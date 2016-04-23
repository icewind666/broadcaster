using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using BroadcasterTest.Cryptography;

namespace BroadcasterTest.ModelNS
{
    internal static class ConfigSaver
    {
        private const string CONFIG_FILE_NAME = @"config.bin";
        private static readonly string CONFIG_FULL_FILE_NAME;
        private static readonly BinaryFormatter BIN_FORMATTER = new BinaryFormatter();

        [System.Diagnostics.CodeAnalysis.SuppressMessage( "Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline" )]
        static ConfigSaver()
        {
            CONFIG_FULL_FILE_NAME = Path.Combine( Model.SETTINGS_PATH, CONFIG_FILE_NAME );
        }

        public static Dictionary<string, Config> LoadConfig()
        {
            if ( !File.Exists( CONFIG_FULL_FILE_NAME ) )
            {
                return new Dictionary<string, Config>();
            }

            Dictionary<string, Config> configs;

            try
            {
                byte[] data = File.ReadAllBytes( CONFIG_FULL_FILE_NAME );
                using ( MemoryStream ms = new MemoryStream( RijndaelSample.Decrypt( data ) ) )
                {
                    configs = ( Dictionary<string, Config> ) BIN_FORMATTER.Deserialize( ms );
                }
            }
            catch ( Exception e )
            {
                throw new FileLoadException( @"Can't read config file", e );
            }

            return configs;
        }

        public static void SaveConfig( Dictionary<string, Config> configs )
        {
            if ( configs == null )
            {
                throw new ArgumentNullException( "configs" );
            }

            if ( !Directory.Exists( Model.SETTINGS_PATH ) )
            {
                Directory.CreateDirectory( Model.SETTINGS_PATH );
            }

            using ( MemoryStream ms = new MemoryStream() )
            {
                BIN_FORMATTER.Serialize( ms, configs );
                byte[] data = RijndaelSample.Encrypt( ms.ToArray() );

                File.WriteAllBytes( CONFIG_FULL_FILE_NAME, data );
            }
        }
    }
}
