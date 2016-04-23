using System;
using System.Collections.Generic;
using BroadcasterTest.Enums;

namespace BroadcasterTest.Interfaces
{
    public interface IMainForm
    {
        event EventHandler OnLoadEventHandler;
        event EventHandler AddNewConfig;
        event EventHandler CloneConfig;
        event EventHandler UpdateConfig;
        event EventHandler RenameConfig;
        event EventHandler RemoveConfig;
        event EventHandler SelectedConfigChanged;
        event EventHandler GetAvailableDevicesEventHandler;
        event EventHandler StartEventHandler;
        event EventHandler StopEventHandler;
        event EventHandler KillFfmpegProcessEventHandler;
        event EventHandler MicrophoneVolumeChangeEventHandler;
        event EventHandler AudioInputChangeEventHandler;
        event EventHandler CaptreWindowEventHander;

        string CurrentConfigName { get; }
        string FfmpegPath { get; set; }
        string FfmpegArgs { get; set; }
        string SaveToFile { get; set; }
        string StreamUrl { get; set; }
        string StreamKey { get; set; }

        #region VideoOptions

        void SetVideoBitrate( IEnumerable<string> videoBitrate );
        string GetVideoBitrate { get; }
        void SelectVideoBitrate( string videoBitrate );

        string VoVframes { get; set; }
        string VoR { get; set; }
        string VoS { get; set; }
        string VoAspect { get; set; }
        string VoVn { get; set; }
        string VoVcodec { get; set; }
        string VoPass { get; set; }
        string VoPasslogfile { get; set; }
        string VoVf { get; set; }

        #endregion

        #region AdvancedVideoOptions

        string AvoPixFmt { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage( "Microsoft.Naming", "CA1726:UsePreferredTerms", MessageId = "Flags" )]
        string AvoSwsFlags { get; set; }
        string AvoVdt { get; set; }
        string AvoRcOverride { get; set; }
        string AvoIlme { get; set; }
        string AvoPsnr { get; set; }
        string AvoVstats { get; set; }
        string AvoVstatsFile { get; set; }
        string AvoTop { get; set; }
        string AvoDc { get; set; }
        string AvoVtag { get; set; }
        string AvoQphist { get; set; }
        string AvoVbsf { get; set; }
        string AvoForceKeyFrames { get; set; }
        string AvoCopyinkf { get; set; }
        string AvoHwaccel { get; set; }
        string AvoHwaccelDevice { get; set; }

        #endregion

        #region AudioOptions

        void SetAudioBitrate( IEnumerable<string> audioBitrate );
        string GetAudioBitrate { get; }
        void SelectAudioBitrate( string audioBitrate );

        string AoAframes { get; set; }
        string AoAr { get; set; }
        string AoAq { get; set; }
        string AoAc { get; set; }
        string AoAn { get; set; }
        string AoAcodec { get; set; }
        string AoSampleFmt { get; set; }
        string AoAf { get; set; }

        #endregion

        #region AdvancedAudioOptions

        string AaoAtag { get; set; }
        string AaoAbsf { get; set; }
        string AaoGuessLayoutMax { get; set; }

        #endregion

        void WriteToMainLog( string logMessage );
        void WriteToFfmpegLog( string logMessage );

        string GetVideoInput { get; }
        string GetAduioInput { get; }
        IntPtr GetWindowTitleIntPtr { get; }
        string GetWindowTitleName { get; }
        int MicrophoneVolume { get; set; }
        WindowCaptureType GetWindowCaptureType { get; }
        void SetVideoInput( Dictionary<string, string> videoInput );
        void SetAudioInput( Dictionary<string, string> audioInput );
        void SetOpenedWindows( Dictionary<IntPtr, string> openedWindows );
        void SetConfigNames( IEnumerable<string> names );

        void StartButtonAvailability( bool enable );
        void StopButtonAvailability( bool enable );
        void KillFfmpegButtonAvailability( bool enable );
    }
}
