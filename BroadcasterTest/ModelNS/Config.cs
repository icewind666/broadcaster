using System;
using BroadcasterTest.Enums;

namespace BroadcasterTest.ModelNS
{
    [Serializable]
    public class Config
    {
        public string FfmpegPath { get; set; }
        public string FfmpegArgs { get; set; }
        public string SaveToFile { get; set; }
        public string StreamUrl { get; set; }
        public string StreamKey { get; set; }

        #region VideoOptions
        public string VideoBitrate { get; set; }
        public string VideoOptionVFrames { get; set; }
        public string VideoOptionR { get; set; }
        public string VideoOptionS { get; set; }
        public string VideoOptionAspect { get; set; }
        public string VideoOptionVn { get; set; }
        public string VideoOptionVCodec { get; set; }
        public string VideoOptionPass { get; set; }
        public string VideoOptionPasslogfile { get; set; }
        public string VideoOptionVf { get; set; }
        #endregion

        #region AdvancedVideoOptions
        public string AVideoOptionPixFmt { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage( "Microsoft.Naming", "CA1726:UsePreferredTerms", MessageId = "Flags" )]
        public string AVideoOptionSwsFlags { get; set; }
        public string AVideoOptionVdt { get; set; }
        public string AVideoOptionRcOverride { get; set; }
        public string AVideoOptionIlme { get; set; }
        public string AVideoOptionPsnr { get; set; }
        public string AVideoOptionVstats { get; set; }
        public string AVideoOptionVstatsFile { get; set; }
        public string AVideoOptionTop { get; set; }
        public string AVideoOptionDc { get; set; }
        public string AVideoOptionVtag { get; set; }
        public string AVideoOptionQphist { get; set; }
        public string AVideoOptionVbsf { get; set; }
        public string AVideoOptionForceKeyFrames { get; set; }
        public string AVideoOptionCopyinkf { get; set; }
        public string AVideoOptionHwaccel { get; set; }
        public string AVideoOptionHwaccelDevice { get; set; }
        #endregion

        #region AudioOptions
        public string AudioBitrate { get; set; }
        public string AudioOptionAframes { get; set; }
        public string AudioOptionAr { get; set; }
        public string AudioOptionAq { get; set; }
        public string AudioOptionAc { get; set; }
        public string AudioOptionAn { get; set; }
        public string AudioOptionAcodec { get; set; }
        public string AudioOptionSampleFmt { get; set; }
        public string AudioOptionAf { get; set; }
        #endregion

        #region AdvancedAudioOptions
        public string AAudioOptionAtag { get; set; }
        public string AAudioOptionAbsf { get; set; }
        public string AAudioOptionGuessLayoutMax { get; set; }
        #endregion

        public string VideoInput { get; set; }
        public string AudioInput { get; set; }
        public IntPtr WindowTitleIntPtr { get; set; }
        public string WindowTitleName { get; set; }
        public WindowCaptureType WindowCaptureType { get; set; }
    }
}
