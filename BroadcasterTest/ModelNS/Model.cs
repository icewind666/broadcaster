using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Management;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using BroadcasterTest.Enums;

// ReSharper disable ArrangeThisQualifier

namespace BroadcasterTest.ModelNS
{
    internal sealed class Model : IDisposable
    {
        //что бы работал захват видео нужно установить фильтр UScreenCapture
        //http://nerdlogger.com/2011/11/03/stream-your-windows-desktop-using-ffmpeg/

        /// <summary>
        /// Print message to log of LogType.
        /// </summary>
        public event EventHandler<ModelEventArgs> WriteToWindowLogEvent;

        /// <summary>
        /// Show message window to user.
        /// </summary>
        public event EventHandler<ModelEventArgs> ShowErrorMessageEvent;

        //rtmp://w1.hypercube24.ru/live/

        public static readonly string SETTINGS_PATH =
            Path.Combine(
                Environment.GetFolderPath( Environment.SpecialFolder.LocalApplicationData ),
                @"Pentestit\BroadcasterTest"
            );
        public Dictionary<string, string> GetVideoInput { get; private set; }
        public Dictionary<string, string> GetAudioInput { get; private set; }

        private Process _process;
        private Task _task;

        public void StartRecording( Config config, bool broadcast )
        {
            if ( !this.CheckFfmpegFileExists( config.FfmpegPath ) )
            {
                return;
            }

            string ffmpegString = this.GetRecordingProcessArg( config, broadcast );

            if ( ffmpegString == null )
            {
                return;
            }

            this.SendToWindowLogAndWriteToLogFile( string.Format( CultureInfo.InvariantCulture, "FFMPEG_COMMAND: {0}", ffmpegString ), LogType.MainWindowLog );

            this.StratRecordingProcess( ffmpegString );
        }

        public void RecordingToFile( Config config )
        {
            if ( string.IsNullOrWhiteSpace( config.SaveToFile ) )
            {
                throw new ArgumentException( @"In the recording mode to the file you want to specify the file name!" );
            }

            this.ExecuteActionWithCatch( () =>
             {
                 if ( File.Exists( config.SaveToFile ) )
                 {
                     File.Delete( config.SaveToFile );
                 }

                 this.StartRecording( config, false );
             }, string.Format( CultureInfo.InvariantCulture, "Existed file was deleted: {0}", config.SaveToFile ),
                string.Format( CultureInfo.InvariantCulture, "ERROR: cant remove file: {0}.", config.SaveToFile ) );
        }

        public void RecordingToWeb( Config config )
        {
            this.ExecuteActionWithCatch( () =>
             {
                 this.StartRecording( config, true );
             } );
        }

        public void InitializeAvailableDevices( string ffmpegPath )
        {
            if ( !this.CheckFfmpegFileExists( ffmpegPath ) )
            {
                return;
            }

            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                WindowStyle = ProcessWindowStyle.Hidden,
                FileName = @"cmd.exe",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                RedirectStandardInput = true,
                Arguments = string.Format( CultureInfo.InvariantCulture, "/U /C {0} -list_devices true -f dshow -i dummy", ffmpegPath )
            };

            this.SendToWindowLogAndWriteToLogFile( "Getting DirectShow devices list...", LogType.MainWindowLog );

            string processOutputText;

            using ( Process process = new Process() )
            {
                process.StartInfo = startInfo;
                process.Start();
                processOutputText = process.StandardOutput.ReadToEnd() + process.StandardError.ReadToEnd();
            }

            if ( string.IsNullOrWhiteSpace( processOutputText ) )
            {
                this.ShowUserErrorMessage( @"Cannot get available devices.", LogType.MainWindowLog );
                return;
            }

            Encoding wind1252 = Encoding.UTF8;
            Encoding utf8 = Encoding.GetEncoding( 1251 );
            byte[] wind1252Bytes = wind1252.GetBytes( processOutputText );
            byte[] utf8Bytes = Encoding.Convert( wind1252, utf8, wind1252Bytes );
            string utf8String = Encoding.UTF8.GetString( utf8Bytes );

            processOutputText = utf8String;
            int index = processOutputText.IndexOf( "DirectShow video devices", 0, StringComparison.OrdinalIgnoreCase );
            int indexAudio = processOutputText.IndexOf( "DirectShow audio devices", 0, StringComparison.OrdinalIgnoreCase );
            int videoPartLength = indexAudio - index;

            string cutted = processOutputText.Substring( index, videoPartLength );

            string cuttedAudio = processOutputText.Substring( indexAudio );
            string pattern = "\"(.*)\"";

            var dict = new Dictionary<string, string>();
            var dictAudio = new Dictionary<string, string>();

            foreach ( Match match in Regex.Matches( cutted, pattern, RegexOptions.IgnoreCase ) )
            {
                if ( !match.Groups[ 1 ].Value.StartsWith( @"@", StringComparison.Ordinal ) )
                    dict.Add( match.Groups[ 1 ].Value, match.Groups[ 1 ].Value );
            }

            if ( dict.Count > 0 )
            {
                this.GetVideoInput = dict;
            }

            foreach ( Match match in Regex.Matches( cuttedAudio, pattern, RegexOptions.IgnoreCase ) )
            {
                if ( !match.Groups[ 1 ].Value.StartsWith( @"@", StringComparison.Ordinal ) )
                    dictAudio.Add( match.Groups[ 1 ].Value, match.Groups[ 1 ].Value );
            }

            if ( dictAudio.Count > 0 )
            {
                this.GetAudioInput = dictAudio;
            }
        }

        [SuppressMessage( "Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes" )]
        public void KillFfmpegProcess( string commandParameter, string messageToUser )
        {
            if ( this._process == null )
            {
                return;
            }

            try
            {
                this._process.StandardInput.WriteLine( commandParameter );
                this._process.StandardInput.Close();
                this.KillProcessAndChildren( this._process.Id );
                this._process = null;
            }
            catch ( Exception e )
            {
                string message = ( messageToUser == null ) ? e.Message : e.Message + Environment.NewLine + messageToUser;
                this.SendToWindowLog( message, LogType.MainWindowLog );
            }
        }

        public static Dictionary<IntPtr, string> GetAvailableWindowsToCapture()
        {
            return NativeMethods.GetOpenWindows;
        }

        public static List<string> GetAudioBitrates
        {
            get { return AudioBitRate.bits; }
        }

        public static List<string> GetVideoBitrates
        {
            get { return VideoBitRate.bits; }
        }

        #region Config
        public Dictionary<string, Config> LoadConfig()
        {
            return this.ExecuteFunctionWithCatch<Dictionary<string, Config>>( () => ConfigSaver.LoadConfig() );
        }

        public void SaveConfig( Dictionary<string, Config> config )
        {
            this.ExecuteActionWithCatch( () =>
             {
                 ConfigSaver.SaveConfig( config );
             } );
        }
        #endregion

        #region Microphone
        public static void SetMicriphoneVolume( int volume )
        {
            Microphone.SetMicrophoneVolume( volume );
        }

        public static void ChangeUnsignedMixerControl( string devName )
        {
            Microphone.SetVolumeControlByName( devName );
        }

        public static int GetCurrentMicrophoneVolume()
        {
            return Microphone.GetMicrophoneVolume;
        }
        #endregion

        #region Logger

        [SuppressMessage( "Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes" )]
        private void WriteToLogFile( string message )
        {
            try
            {
                Logger.WriteToLog( message );
            }
            catch ( UnauthorizedAccessException e )
            {
                this.SendToWindowLog( e.Message, LogType.MainWindowLog );
                this.KillFfmpegProcess( @"^c", null );
            }
            catch ( Exception e )
            {
                this.ShowUserErrorMessage( e.Message, LogType.MainWindowLog );
                this.KillFfmpegProcess( @"^c", null );
            }
        }

        #endregion

        private string GetRecordingProcessArg( Config config, bool broadcast )
        {
            string fileNameToWrite = " -f flv ";

            if ( broadcast )
            {
                fileNameToWrite += string.Format( CultureInfo.InvariantCulture, "{0}/{1}", config.StreamUrl, config.StreamKey.Replace( "|", "%7C" ) );
            }
            else
            {
                fileNameToWrite += config.SaveToFile;
            }

            string inputDeviceStr = ( string.IsNullOrEmpty( config.VideoInput ) ? string.Empty : "video=\"" + config.VideoInput + "\"" );
            inputDeviceStr += ( string.IsNullOrEmpty( config.AudioInput ) ? string.Empty : ":audio=\"" + config.AudioInput + "\"" );

            if ( string.IsNullOrEmpty( inputDeviceStr ) )
            {
                this.ShowUserErrorMessage( "ERROR: No devices selected!", LogType.MainWindowLog );
                return null;
            }

            if ( config.WindowTitleIntPtr != IntPtr.Zero && !string.IsNullOrEmpty( config.WindowTitleName ) )
            {
                inputDeviceStr = GetWindowCaptureArg( inputDeviceStr, config );
            }

            string audioArg = ( string.IsNullOrEmpty( config.AudioInput )
                ? string.Empty
                : string.Format( CultureInfo.InvariantCulture, " -b:a {0}", config.AudioBitrate ) );

            string additionalArgs = GetAdditionalArgs( config );

            return string.Format( CultureInfo.InvariantCulture, "{0} {1} -i {2} -q 1 -c:a libvo_aacenc -b:v {3}{4}{5}{6}", config.FfmpegPath, config.FfmpegArgs, inputDeviceStr, config.VideoBitrate, audioArg, additionalArgs, fileNameToWrite );
        }

        private static string GetAdditionalArgs( Config config )
        {
            StringBuilder additionalArgs = new StringBuilder( 700 );
            Action<string, string> addToAdArgs = new Action<string, string>( ( arg, pref ) =>
            {
                if ( !string.IsNullOrWhiteSpace( arg ) )
                {
                    additionalArgs.AppendFormat( " {0} {1}", pref, arg );
                }
            } );

            addToAdArgs( config.VideoOptionVFrames, ConfigPrefs.VidoOptions.VFRAMES );
            addToAdArgs( config.VideoOptionR, ConfigPrefs.VidoOptions.R );
            addToAdArgs( config.VideoOptionS, ConfigPrefs.VidoOptions.S );
            addToAdArgs( config.VideoOptionAspect, ConfigPrefs.VidoOptions.ASPECT );
            addToAdArgs( config.VideoOptionVn, ConfigPrefs.VidoOptions.VN );
            addToAdArgs( config.VideoOptionVCodec, ConfigPrefs.VidoOptions.VCODEC );
            addToAdArgs( config.VideoOptionPass, ConfigPrefs.VidoOptions.PASS );
            addToAdArgs( config.VideoOptionPasslogfile, ConfigPrefs.VidoOptions.PASSLOGFILE );
            addToAdArgs( config.VideoOptionVf, ConfigPrefs.VidoOptions.VF );

            addToAdArgs( config.AVideoOptionPixFmt, ConfigPrefs.AdvancedVideoOptions.PIX_FMT );
            addToAdArgs( config.AVideoOptionSwsFlags, ConfigPrefs.AdvancedVideoOptions.SWS_FLAGS );
            addToAdArgs( config.AVideoOptionVdt, ConfigPrefs.AdvancedVideoOptions.VDT );
            addToAdArgs( config.AVideoOptionRcOverride, ConfigPrefs.AdvancedVideoOptions.RC_OVERRIDE );
            addToAdArgs( config.AVideoOptionIlme, ConfigPrefs.AdvancedVideoOptions.ILME );
            addToAdArgs( config.AVideoOptionPsnr, ConfigPrefs.AdvancedVideoOptions.PSNR );
            addToAdArgs( config.AVideoOptionVstats, ConfigPrefs.AdvancedVideoOptions.VSTATS );
            addToAdArgs( config.AVideoOptionVstatsFile, ConfigPrefs.AdvancedVideoOptions.VSTATS );
            addToAdArgs( config.AVideoOptionTop, ConfigPrefs.AdvancedVideoOptions.TOP );
            addToAdArgs( config.AVideoOptionDc, ConfigPrefs.AdvancedVideoOptions.DC );
            addToAdArgs( config.AVideoOptionVtag, ConfigPrefs.AdvancedVideoOptions.VTAG );
            addToAdArgs( config.AVideoOptionQphist, ConfigPrefs.AdvancedVideoOptions.QPHIST );
            addToAdArgs( config.AVideoOptionVbsf, ConfigPrefs.AdvancedVideoOptions.VBSF );
            addToAdArgs( config.AVideoOptionForceKeyFrames, ConfigPrefs.AdvancedVideoOptions.FORCE_KEY_FRAMES );
            addToAdArgs( config.AVideoOptionCopyinkf, ConfigPrefs.AdvancedVideoOptions.COPYINKF );
            addToAdArgs( config.AVideoOptionHwaccel, ConfigPrefs.AdvancedVideoOptions.HWACCEL );
            addToAdArgs( config.AVideoOptionHwaccelDevice, ConfigPrefs.AdvancedVideoOptions.HWACCEL_DEVICE );

            addToAdArgs( config.AudioOptionAframes, ConfigPrefs.AudioOptions.AFRAMES );
            addToAdArgs( config.AudioOptionAr, ConfigPrefs.AudioOptions.AR );
            addToAdArgs( config.AudioOptionAq, ConfigPrefs.AudioOptions.AQ );
            addToAdArgs( config.AudioOptionAc, ConfigPrefs.AudioOptions.AC );
            addToAdArgs( config.AudioOptionAn, ConfigPrefs.AudioOptions.AN );
            addToAdArgs( config.AudioOptionAcodec, ConfigPrefs.AudioOptions.ACODEC );
            addToAdArgs( config.AudioOptionSampleFmt, ConfigPrefs.AudioOptions.SAMPLE_FMT );
            addToAdArgs( config.AudioOptionAf, ConfigPrefs.AudioOptions.AF );

            addToAdArgs( config.AAudioOptionAtag, ConfigPrefs.AdvancedAudioOptions.ATAG );
            addToAdArgs( config.AAudioOptionAbsf, ConfigPrefs.AdvancedAudioOptions.ABSF );
            addToAdArgs( config.AAudioOptionGuessLayoutMax, ConfigPrefs.AdvancedAudioOptions.GUESS_LAYOUT_MAX );

            return additionalArgs.ToString();
        }

        private void StratRecordingProcess( string ffmpegString )
        {
            if ( this._process != null )
            {
                this._process.Dispose();
            }

            this._process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                WindowStyle = ProcessWindowStyle.Hidden,
                FileName = @"cmd.exe",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                RedirectStandardInput = true,
                StandardOutputEncoding = Encoding.UTF8,
                Arguments = "/U /C " + ffmpegString,
                CreateNoWindow = true
            };
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            this._process.StartInfo = startInfo;

            this._process.OutputDataReceived += new DataReceivedEventHandler( ProcessProcOutputDataReceived );
            this._process.ErrorDataReceived += new DataReceivedEventHandler( ProcessProcOutputDataReceived );

            this._task = new Task( () =>
             {
                 this._process.Start();
                 this._process.BeginOutputReadLine();
                 this._process.BeginErrorReadLine();
                 this._process.WaitForExit();
             } );
            this._task.Start();
        }

        private void ProcessProcOutputDataReceived( object sender, DataReceivedEventArgs e )
        {
            if ( !string.IsNullOrEmpty( e.Data ) )
            {
                this.SendToWindowLogAndWriteToLogFile( string.Format( CultureInfo.InvariantCulture, "{0}\n", e.Data.Trim() ), LogType.FfmepgLog, "[***FFMPEG OUTPUT ***]" );
            }
        }

        private bool CheckFfmpegFileExists( string filePath )
        {
            if ( !File.Exists( filePath ) )
            {
                this.ShowUserErrorMessage( "Can't find ffmpeg.exe file!\nCheck 'ffmpeg.exe path' parameter", LogType.MainWindowLog );
                return false;
            }
            return true;
        }

        private static string GetWindowCaptureArg( string videoDeviceStr, Config config )
        {
            //http://ffmpeg.org/ffmpeg-all.html ПОЛНЫЙ МАНУАЛ ffmpeg -f gdigrab -framerate 6 -i title=Calculator out.mpg
            //http://stackoverflow.com/questions/6766333/capture-windows-screen-with-ffmpeg
            //Возможна запись по координатам окна -vf crop w:h:x:y
            /*
            So, if you wanted to capture a window that was 450px by 300px & the upper left-hand corner was 
            located at position 101,115 you would use the filter like this: -vf crop=”450:300:101,115″
            http://stackoverflow.com/questions/5878963/getting-active-window-coordinates-and-height-width-in-c-sharp
            http://improve.dk/getting-window-location-and-size/
            */

            switch ( config.WindowCaptureType )
            {
                case WindowCaptureType.VfCrop:
                    if ( config.WindowTitleIntPtr != IntPtr.Zero )
                    {
                        Rectangle rect = NativeMethods.TryGetWindowRectagle( config.WindowTitleIntPtr );

                        if ( rect.X < 0 ) { rect.X = -rect.X; }
                        if ( rect.Y < 0 ) { rect.Y = -rect.Y; }

                        //todo: Размер иногда больше влево.
                        rect.Width = rect.Width - rect.X;
                        rect.Height = rect.Height - rect.Y;

                        videoDeviceStr = string.Concat( videoDeviceStr,
                            string.Format( CultureInfo.InvariantCulture, " -vf crop=\"{0}:{1}:{2}:{3}\" ",
                            rect.Width, rect.Height, rect.Left, rect.Top ) );
                    }
                    break;

                case WindowCaptureType.Title:
                    // Удаляем video="":, т.к. задается -i title="".
                    videoDeviceStr = videoDeviceStr.Substring( videoDeviceStr.IndexOf( ':' ) + 1 );
                    videoDeviceStr = string.Concat( videoDeviceStr, string.Format( CultureInfo.InvariantCulture, " -f gdigrab -i title=\"{0}\"", config.WindowTitleName ) );
                    break;
            }

            return videoDeviceStr;
        }

        private void SendToWindowLogAndWriteToLogFile( string message, LogType logType, string preMessage = null )
        {
            this.SendToWindowLog( message, logType );

            if ( preMessage == null )
            {
                this.WriteToLogFile( message );
            }
            else
            {
                this.WriteToLogFile( string.Format( CultureInfo.InvariantCulture, "{0} {1}", preMessage, message ) );
            }
        }

        [SuppressMessage( "Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes" )]
        private void ExecuteActionWithCatch( Action action, string message = null, string errorMessage = null )
        {
            try
            {
                action.Invoke();

                if ( message != null )
                {
                    this.SendToWindowLogAndWriteToLogFile( message, LogType.MainWindowLog );
                }
            }
            catch ( ObjectDisposedException )
            {

            }
            catch ( Exception exception )
            {
                this.SendToWindowLogAndWriteToLogFile( string.Format( CultureInfo.InvariantCulture, "{0}, Exception: {1}", errorMessage, exception.Message ), LogType.MainWindowLog );
            }
        }

        [SuppressMessage( "Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes" )]
        private T ExecuteFunctionWithCatch<T>( Func<T> func, string message = null, string errorMessage = null )
            where T : new()
        {
            try
            {
                if ( message != null )
                {
                    this.SendToWindowLogAndWriteToLogFile( message, LogType.MainWindowLog );
                }

                return func.Invoke();
            }
            catch ( Exception exception )
            {
                this.SendToWindowLogAndWriteToLogFile( string.Format( CultureInfo.InvariantCulture, "{0}, Exception: {1}", errorMessage, exception.Message ), LogType.MainWindowLog );
            }

            return new T();
        }

        private void ShowUserErrorMessage( string message, LogType logType )
        {
            if ( this.ShowErrorMessageEvent != null )
            {
                this.ShowErrorMessageEvent( this, new ModelEventArgs( message, logType ) );
            }
        }

        private void SendToWindowLog( string message, LogType logType )
        {
            if ( this.WriteToWindowLogEvent != null )
            {
                this.WriteToWindowLogEvent( this, new ModelEventArgs( message, logType ) );
            }
        }

        /// <summary>
        /// Kill a process, and all of its children, grandchildren, etc.
        /// </summary>
        /// <param name="pid">Process ID.</param>
        private void KillProcessAndChildren( int pid )
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher
              ( "Select * From Win32_Process Where ParentProcessID=" + pid );
            ManagementObjectCollection moc = searcher.Get();
            searcher.Dispose();
            foreach ( ManagementObject mo in moc )
            {
                KillProcessAndChildren( Convert.ToInt32( mo[ "ProcessID" ], CultureInfo.InvariantCulture ) );
            }
            try
            {
                Process proc = Process.GetProcessById( pid );

                if ( proc.ProcessName.Equals( "cmd", StringComparison.OrdinalIgnoreCase ) ||
                    proc.ProcessName.Equals( "conhost", StringComparison.OrdinalIgnoreCase ) ||
                    proc.ProcessName.Equals( "ffmpeg", StringComparison.OrdinalIgnoreCase ) )
                {
                    proc.Kill();
                }
            }
            catch ( ArgumentException )
            {
                // Process already exited.
            }
            catch ( Win32Exception )
            {
                // ignored
            }
        }

        public void Dispose()
        {
            if ( this._process != null )
            {
                this._process.Dispose();
            }
            if ( this._task != null )
            {
                this._task.Dispose();
            }
        }
    }
}
