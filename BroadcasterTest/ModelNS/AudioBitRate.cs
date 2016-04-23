using System.Collections.Generic;

namespace BroadcasterTest.ModelNS
{
    internal static class AudioBitRate
    {
        public static readonly List<string> bits = new List<string>()
        {
            "32K", "40K", "48K", "56K", "64K", "80K", "96K", "128K", "192K", "256K", "320K"
        };

        /// <summary>
        /// return 128K.
        /// </summary>
        public static string GetDefaultValue
        {
            get { return "128K"; }
        }
    }
}
