using System;
using System.IO;
using System.Security.Cryptography;

namespace BroadcasterTest.Cryptography
{
    internal static class RijndaelSample
    {
        private static readonly byte[] Key = { 123, 217, 19, 11, 24, 26, 85, 45, 114, 184, 27, 162, 37, 112, 222, 209, 241, 24, 175, 144, 173, 53, 196, 29, 24, 26, 17, 218, 131, 236, 53, 209 };
        private static readonly byte[] Vector = { 146, 64, 191, 111, 23, 3, 113, 119, 231, 121, 221, 112, 79, 32, 114, 156 };

        public static byte[] Encrypt( byte[] data )
        {
            if ( data == null || data.Length <= 0 )
                throw new ArgumentNullException( "data" );

            byte[] encrypted;

            using ( MemoryStream ms = new MemoryStream() )
            {
                using ( Rijndael alg = Rijndael.Create() )
                {
                    alg.Key = Key;
                    alg.IV = Vector;

                    using ( CryptoStream cs = new CryptoStream( ms, alg.CreateEncryptor(), CryptoStreamMode.Write ) )
                    {
                        cs.Write( data, 0, data.Length );
                    }

                    encrypted = ms.ToArray();
                }
            }

            return encrypted;
        }

        public static byte[] Decrypt( byte[] data )
        {
            if ( data == null || data.Length <= 0 )
                throw new ArgumentNullException( "data" );

            byte[] decrypted;

            using ( MemoryStream ms = new MemoryStream() )
            {
                using ( Rijndael alg = Rijndael.Create() )
                {
                    alg.Key = Key;
                    alg.IV = Vector;

                    using ( CryptoStream cs = new CryptoStream( ms, alg.CreateDecryptor(), CryptoStreamMode.Write ) )
                    {
                        cs.Write( data, 0, data.Length );
                    }

                    decrypted = ms.ToArray();
                }
            }

            return decrypted;
        }
    }
}
