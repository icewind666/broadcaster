using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using BroadcasterTest.Enums;
using BroadcasterTest.Interfaces;
using BroadcasterTest.ModelNS;

namespace BroadcasterTest
{
    internal sealed class Presetner
    {
        private readonly IMainForm _window;
        private readonly IMessager _messager;
        private readonly Model _model;

        private static Dictionary<string, Config> CONFIGS = new Dictionary<string, Config>();

        public Presetner( IMainForm window, IMessager messager, Model model )
        {
            if ( window == null )
            {
                throw new ArgumentNullException( "window" );
            }

            if ( messager == null )
            {
                throw new ArgumentNullException( "messager" );
            }

            if ( model == null )
            {
                throw new ArgumentNullException( "model" );
            }

            this._window = window;
            this._messager = messager;
            this._model = model;

            this._window.GetAvailableDevicesEventHandler += WindowGetAvailableDevicesEventHandler;
            this._window.KillFfmpegProcessEventHandler += WindowKillFfmpegProcessEventHandler;

            this._window.AddNewConfig += WindowAddNewConfig;
            this._window.CloneConfig += WindowCloneConfig;
            this._window.UpdateConfig += WindowUpdateConfig;
            this._window.RenameConfig += WindowRenameConfig;
            this._window.RemoveConfig += WindowRemoveConfig;
            this._window.SelectedConfigChanged += WindowSelectedConfigChanged;

            this._window.StartEventHandler += WindowStartEventHandler;
            this._window.StopEventHandler += WindowStopEventHandler;
            this._window.MicrophoneVolumeChangeEventHandler += WindowMicrophoneVolumeChangeEventHandler;
            this._window.AudioInputChangeEventHandler += WindowAudioInputChangeEventHandler;
            this._window.CaptreWindowEventHander += CaptreWindowCaptreWindowEventHander;
            this._window.OnLoadEventHandler += WindowOnLoadEventHandler;

            this._model.WriteToWindowLogEvent += ModelWriteToWindowLogEvent;
            this._model.ShowErrorMessageEvent += ModelShowErrorMessageEvent;
        }

        #region Model

        private void ModelShowErrorMessageEvent( object sender, ModelEventArgs e )
        {
            this._messager.ShowError( e.Message );
        }

        private void ModelWriteToWindowLogEvent( object sender, ModelEventArgs e )
        {
            switch ( e.LogType )
            {
                case LogType.MainWindowLog:
                    this.WriteToLog( e.Message );
                    break;
                case LogType.FfmepgLog:
                    this.WiteToFfmepegLog( e.Message );
                    break;
            }
        }

        #endregion

        #region IMainForm

        private void WindowOnLoadEventHandler( object sender, EventArgs e )
        {
            this._window.SetAudioBitrate( Model.GetAudioBitrates );
            this._window.SelectAudioBitrate( AudioBitRate.GetDefaultValue );

            this._window.SetVideoBitrate( Model.GetVideoBitrates );
            this._window.SelectVideoBitrate( VideoBitRate.GetDefaultValue );

            CONFIGS = this._model.LoadConfig();

            if ( CONFIGS.Count >= 1 )
            {
                this._window.SetConfigNames( CONFIGS.Keys );

                string configName = this._window.CurrentConfigName;
                Config config = CONFIGS[ configName ];
                this.SetConfigToWindow( config );
            }
        }

        private void WindowStartEventHandler( object sender, EventArgs e )
        {
            Config config = this.GetConfigFromWindow();

            if ( !string.IsNullOrEmpty( this._window.SaveToFile ) && !string.IsNullOrEmpty( this._window.StreamUrl ) )
            {
                this._messager.ShowExclamation( "В случае заполнения двух целей одновременно будет выбран вариант вещания на URL" );

                this.ExecuteActionWithCatch( () =>
                 {
                     this._model.RecordingToWeb( config );
                 } );
            }
            else if ( !string.IsNullOrEmpty( this._window.SaveToFile ) )
            {
                this.ExecuteActionWithCatch( () =>
                 {
                     this._model.RecordingToFile( config );
                 } );
            }
            else if ( !string.IsNullOrEmpty( this._window.StreamUrl ) )
            {
                this.ExecuteActionWithCatch( () =>
                 {
                     this._model.RecordingToWeb( config );
                 } );
            }
            else
            {
                this._messager.ShowError( "Не выбрана цель вещания - укажите файл или url!" );
                return;
            }

            this._window.StartButtonAvailability( false );
            this._window.StopButtonAvailability( true );
            this._window.KillFfmpegButtonAvailability( true );
        }

        private void WindowStopEventHandler( object sender, EventArgs e )
        {
            this._model.KillFfmpegProcess( @"q", "Sent Q key to stop ffmpeg" );
            this._window.StartButtonAvailability( true );
            this._window.StopButtonAvailability( false );
            this._window.KillFfmpegButtonAvailability( false );
        }

        private void WindowKillFfmpegProcessEventHandler( object sender, EventArgs e )
        {
            //todo: Эти комманды не правильно работают, процесс не завершается.
            this._model.KillFfmpegProcess( @"^c", "Sending KILL to ffmpeg - video will be corrupted" );

            this._window.StartButtonAvailability( true );
            this._window.StopButtonAvailability( false );
            this._window.KillFfmpegButtonAvailability( false );
        }

        private void WindowRemoveConfig( object sender, EventArgs e )
        {
            string configName = this._window.CurrentConfigName;
            if ( configName == null )
            {
                return;
            }

            if ( CONFIGS.Keys.Contains( configName ) )
            {
                CONFIGS.Remove( configName );
                this._window.SetConfigNames( CONFIGS.Keys );
            }

            if ( CONFIGS.Keys.Count == 0 )
            {
                this.SetConfigToWindow( new Config() );
            }
        }

        private void WindowRenameConfig( object sender, EventArgs e )
        {
            string configName = this._window.CurrentConfigName;
            if ( configName == null )
            {
                return;
            }

            string configNewName = this._messager.ChangeConfigName( configName ).Trim();
            if ( string.IsNullOrWhiteSpace( configNewName ) || configName.Equals( configNewName, StringComparison.OrdinalIgnoreCase ) )
            {
                return;
            }

            Config config = this.GetConfigFromWindow();
            CONFIGS.Remove( configName );
            CONFIGS.Add( configNewName, config );

            this._window.SetConfigNames( CONFIGS.Keys );
        }

        private void WindowUpdateConfig( object sender, EventArgs e )
        {
            string configName = this._window.CurrentConfigName;
            if ( configName != null )
            {
                Config config = this.GetConfigFromWindow();
                CONFIGS[ configName ] = config;
            }

            this.ExecuteActionWithCatch( () =>
            {
                this._model.SaveConfig( CONFIGS );
            } );
        }

        private void WindowCloneConfig( object sender, EventArgs e )
        {
            string configName = this._window.CurrentConfigName;
            if ( configName == null )
            {
                return;
            }

            Config config = this.GetConfigFromWindow();

            string configNewName = String.Concat( configName, new Random().Next( 1, 100 ).ToString( CultureInfo.CurrentCulture ) );

            if ( !CONFIGS.ContainsKey( configNewName ) )
            {
                CONFIGS.Add( configNewName, config );
                this._window.SetConfigNames( CONFIGS.Keys );
            }
        }

        private void WindowAddNewConfig( object sender, EventArgs e )
        {
            Random rnd = new Random();
            string configName = String.Concat( @"NewConfig", rnd.Next( 1, 1000 ).ToString( CultureInfo.CurrentCulture ) );

            if ( !CONFIGS.ContainsKey( configName ) )
            {
                CONFIGS.Add( configName, new Config() );
                this._window.SetConfigNames( CONFIGS.Keys );
            }
        }

        private void WindowSelectedConfigChanged( object sender, EventArgs e )
        {
            string configName = this._window.CurrentConfigName;
            if ( configName == null )
            {
                return;
            }

            if ( CONFIGS.ContainsKey( configName ) )
            {
                Config config = CONFIGS[ configName ];
                this.SetConfigToWindow( config );
            }
        }

        private void WindowGetAvailableDevicesEventHandler( object sender, EventArgs e )
        {
            this.ExecuteActionWithCatch( () =>
             {
                 this._model.InitializeAvailableDevices( this._window.FfmpegPath );

                 if ( this._model.GetVideoInput == null )
                 {
                     return;
                 }

                 this._window.SetVideoInput( this._model.GetVideoInput );
                 this._window.SetAudioInput( this._model.GetAudioInput );

                 if ( this._model.GetVideoInput.Count > 0 )
                 {
                     this._window.StartButtonAvailability( true );
                 }
             } );
        }

        private void WindowMicrophoneVolumeChangeEventHandler( object sender, EventArgs e )
        {
            Model.SetMicriphoneVolume( this._window.MicrophoneVolume );
        }

        private void WindowAudioInputChangeEventHandler( object sender, EventArgs e )
        {
            //Config config = this.GetConfigFromWindow();
            string audioInput = this._window.GetAduioInput;

            if ( string.IsNullOrEmpty( audioInput ) )
            {
                return;
            }

            this.ExecuteActionWithCatch( () =>
             {
                 Model.ChangeUnsignedMixerControl( audioInput );
                 this._window.MicrophoneVolume = Model.GetCurrentMicrophoneVolume();
             } );
        }

        private void CaptreWindowCaptreWindowEventHander( object sender, EventArgs e )
        {
            this.ExecuteActionWithCatch( () =>
             {
                 Dictionary<IntPtr, string> temp = new Dictionary<IntPtr, string>()
                 {
                    { IntPtr.Zero, "      ---   NONE   ---      " }
                 };
                 foreach ( var item in Model.GetAvailableWindowsToCapture() )
                 {
                     temp.Add( item.Key, item.Value );
                 }
                 this._window.SetOpenedWindows( temp );
             } );
        }

        #endregion

        private Config GetConfigFromWindow()
        {
            Config config = new Config
            {
                FfmpegPath = this._window.FfmpegPath,
                FfmpegArgs = this._window.FfmpegArgs,
                SaveToFile = this._window.SaveToFile,
                StreamUrl = this._window.StreamUrl,
                StreamKey = this._window.StreamKey,

                VideoBitrate = this._window.GetVideoBitrate,
                VideoOptionVFrames = this._window.VoVframes,
                VideoOptionR = this._window.VoR,
                VideoOptionS = this._window.VoS,
                VideoOptionAspect = this._window.VoAspect,
                VideoOptionVn = this._window.VoVn,
                VideoOptionVCodec = this._window.VoVcodec,
                VideoOptionPass = this._window.VoPass,
                VideoOptionPasslogfile = this._window.VoPasslogfile,
                VideoOptionVf = this._window.VoVf,

                AVideoOptionPixFmt = this._window.AvoPixFmt,
                AVideoOptionSwsFlags = this._window.AvoSwsFlags,
                AVideoOptionVdt = this._window.AvoVdt,
                AVideoOptionRcOverride = this._window.AvoRcOverride,
                AVideoOptionIlme = this._window.AvoIlme,
                AVideoOptionPsnr = this._window.AvoPsnr,
                AVideoOptionVstats = this._window.AvoVstats,
                AVideoOptionVstatsFile = this._window.AvoVstatsFile,
                AVideoOptionTop = this._window.AvoTop,
                AVideoOptionDc = this._window.AvoDc,
                AVideoOptionVtag = this._window.AvoVtag,
                AVideoOptionQphist = this._window.AvoQphist,
                AVideoOptionVbsf = this._window.AvoVbsf,
                AVideoOptionForceKeyFrames = this._window.AvoForceKeyFrames,
                AVideoOptionCopyinkf = this._window.AvoCopyinkf,
                AVideoOptionHwaccel = this._window.AvoHwaccel,
                AVideoOptionHwaccelDevice = this._window.AvoHwaccelDevice,

                AudioBitrate = this._window.GetAudioBitrate,
                AudioOptionAframes = this._window.AoAframes,
                AudioOptionAr = this._window.AoAr,
                AudioOptionAq = this._window.AoAq,
                AudioOptionAc = this._window.AoAc,
                AudioOptionAn = this._window.AoAn,
                AudioOptionAcodec = this._window.AoAcodec,
                AudioOptionSampleFmt = this._window.AoSampleFmt,
                AudioOptionAf = this._window.AoAf,

                AAudioOptionAtag = this._window.AaoAtag,
                AAudioOptionAbsf = this._window.AaoAbsf,
                AAudioOptionGuessLayoutMax = this._window.AaoGuessLayoutMax,

                VideoInput = this._window.GetVideoInput,
                AudioInput = this._window.GetAduioInput,
                WindowTitleIntPtr = this._window.GetWindowTitleIntPtr,
                WindowTitleName = this._window.GetWindowTitleName,
                WindowCaptureType = this._window.GetWindowCaptureType
            };

            return config;
        }

        private void SetConfigToWindow( Config config )
        {
            if ( config == null )
            {
                return;
            }

            Func<string, string> getStringArg = ( arg ) =>
            {
                return ( !string.IsNullOrWhiteSpace( arg ) ) ? arg : string.Empty;
            };

            this._window.FfmpegPath = getStringArg( config.FfmpegPath );
            this._window.FfmpegArgs = getStringArg( config.FfmpegArgs );
            this._window.SaveToFile = getStringArg( config.SaveToFile );
            this._window.StreamUrl = getStringArg( config.StreamUrl );
            this._window.StreamKey = getStringArg( config.StreamKey );

            #region VideoOptions
            this._window.SelectVideoBitrate( getStringArg( config.VideoBitrate ) );
            this._window.VoVframes = getStringArg( config.VideoOptionVFrames );
            this._window.VoR = getStringArg( config.VideoOptionR );
            this._window.VoS = getStringArg( config.VideoOptionS );
            this._window.VoAspect = getStringArg( config.VideoOptionAspect );
            this._window.VoVn = getStringArg( config.VideoOptionVn );
            this._window.VoVcodec = getStringArg( config.VideoOptionVCodec );
            this._window.VoPass = getStringArg( config.VideoOptionPass );
            this._window.VoPasslogfile = getStringArg( config.VideoOptionPasslogfile );
            this._window.VoVf = getStringArg( config.VideoOptionVf );
            #endregion

            #region AdvancedVideoOptions
            this._window.AvoPixFmt = getStringArg( config.AVideoOptionPixFmt );
            this._window.AvoSwsFlags = getStringArg( config.AVideoOptionSwsFlags );
            this._window.AvoVdt = getStringArg( config.AVideoOptionVdt );
            this._window.AvoRcOverride = getStringArg( config.AVideoOptionRcOverride );
            this._window.AvoIlme = getStringArg( config.AVideoOptionIlme );
            this._window.AvoPsnr = getStringArg( config.AVideoOptionPsnr );
            this._window.AvoVstats = getStringArg( config.AVideoOptionVstats );
            this._window.AvoVstatsFile = getStringArg( config.AVideoOptionVstatsFile );
            this._window.AvoTop = getStringArg( config.AVideoOptionTop );
            this._window.AvoDc = getStringArg( config.AVideoOptionDc );
            this._window.AvoVtag = getStringArg( config.AVideoOptionVtag );
            this._window.AvoQphist = getStringArg( config.AVideoOptionQphist );
            this._window.AvoVbsf = getStringArg( config.AVideoOptionVbsf );
            this._window.AvoForceKeyFrames = getStringArg( config.AVideoOptionForceKeyFrames );
            this._window.AvoCopyinkf = getStringArg( config.AVideoOptionCopyinkf );
            this._window.AvoHwaccel = getStringArg( config.AVideoOptionHwaccel );
            this._window.AvoHwaccelDevice = getStringArg( config.AVideoOptionHwaccelDevice );
            #endregion

            #region AudioOptions
            this._window.SelectAudioBitrate( getStringArg( config.AudioBitrate ) );
            this._window.AoAframes = getStringArg( config.AudioOptionAframes );
            this._window.AoAr = getStringArg( config.AudioOptionAr );
            this._window.AoAq = getStringArg( config.AudioOptionAq );
            this._window.AoAc = getStringArg( config.AudioOptionAc );
            this._window.AoAn = getStringArg( config.AudioOptionAn );
            this._window.AoAcodec = getStringArg( config.AudioOptionAcodec );
            this._window.AoSampleFmt = getStringArg( config.AudioOptionSampleFmt );
            this._window.AoAf = getStringArg( config.AudioOptionAf );
            #endregion

            #region AdvancedAudioOptions
            this._window.AaoAtag = getStringArg( config.AAudioOptionAtag );
            this._window.AaoAbsf = getStringArg( config.AAudioOptionAbsf );
            this._window.AaoGuessLayoutMax = getStringArg( config.AAudioOptionGuessLayoutMax );
            #endregion
        }

        private void WriteToLog( string message )
        {
            this._window.WriteToMainLog( message );
        }

        private void WiteToFfmepegLog( string message )
        {
            this._window.WriteToFfmpegLog( message );
        }

        [SuppressMessage( "Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes" )]
        private void ExecuteActionWithCatch( Action action )
        {
            try
            {
                action.Invoke();
            }
            catch ( Exception exception )
            {
                this._messager.ShowError( exception.Message );
            }
        }
    }
}
