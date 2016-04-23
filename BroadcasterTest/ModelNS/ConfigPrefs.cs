namespace BroadcasterTest.ModelNS
{
    internal static class ConfigPrefs
    {
        #region VideoOptions

        internal static class VidoOptions
        {
            internal const string VFRAMES = @"-vframes";
            internal const string R = @"-r";
            internal const string S = @"-s";
            internal const string ASPECT = @"-aspect";
            internal const string VN = @"-vn";
            internal const string VCODEC = @"-vcodec";
            internal const string PASS = @"-pass";
            internal const string PASSLOGFILE = @"-passlogfile";
            internal const string VF = @"-vf";
        }

        #endregion

        #region AdvancedVideoOptions

        internal static class AdvancedVideoOptions
        {
            internal const string PIX_FMT = @"-pix_fmt";
            internal const string SWS_FLAGS = @"-sws_flags";
            internal const string VDT = @"-vdt";
            internal const string RC_OVERRIDE = @"-rc_override";
            internal const string ILME = @"-ilme";
            internal const string PSNR = @"-psnr";
            internal const string VSTATS = @"-vstats";
            internal const string VSTATS_FILE = @"-vstats_file";
            internal const string TOP = @"-top";
            internal const string DC = @"-dc";
            internal const string VTAG = @"-vtag";
            internal const string QPHIST = @"-qphist";
            internal const string VBSF = @"-vbsf";
            internal const string FORCE_KEY_FRAMES = @"-force_key_frames";
            internal const string COPYINKF = @"-copyinkf";
            internal const string HWACCEL = @"-hwaccel";
            internal const string HWACCEL_DEVICE = @"-hwaccel_device";
        }

        #endregion

        #region AudioOptions

        internal static class AudioOptions
        {
            internal const string AFRAMES = @"-aframes";
            internal const string AR = @"-ar";
            internal const string AQ = @"-aq";
            internal const string AC = @"-ac";
            internal const string AN = @"-an";
            internal const string ACODEC = @"-acodec";
            internal const string SAMPLE_FMT = @"-sample_fmt";
            internal const string AF = @"-af";
        }

        #endregion

        #region AdvancedAudioOptions

        internal static class AdvancedAudioOptions
        {
            internal const string ATAG = @"-atag";
            internal const string ABSF = @"-absf";
            internal const string GUESS_LAYOUT_MAX = @"-guess_layout_max";
        }

        #endregion
    }
}
