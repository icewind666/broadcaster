using System;
using System.IO;

namespace BroadcasterTest.ModelNS
{
    internal static class Logger
    {
        private const string LOG_FILE_NAME = @"events.log";
        private static readonly string LOG_FULL_FILE_NAME = Path.Combine( Model.SETTINGS_PATH, LOG_FILE_NAME );

        public static void WriteToLog( string message )
        {
            if ( !Directory.Exists( Model.SETTINGS_PATH ) )
            {
                Directory.CreateDirectory( Model.SETTINGS_PATH );
            }

            using ( StreamWriter sr = new StreamWriter( LOG_FULL_FILE_NAME, true ) )
            {
                //todo: Файл лога может стать большим, удалять?
                sr.WriteLine( "{0} | {1}", DateTime.Now.ToUniversalTime(), message );
            }
        }
    }
}
