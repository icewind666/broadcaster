using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BroadcasterTest.ModelNS
{
    internal static class VideoBitRate
    {
        //http://www.ezs3.com/public/What_bitrate_should_I_use_when_encoding_my_video_How_do_I_optimize_my_video_for_the_web.cfm
        public static readonly List<string> bits = new List<string>()
        {
            "400K", "700K", "1500K", "2500K", "3000K", "3500K", "4000K"
        };

        /// <summary>
        /// return 3000K.
        /// </summary>
        public static string GetDefaultValue
        {
            get { return "3000K"; }
        }
    }
}
