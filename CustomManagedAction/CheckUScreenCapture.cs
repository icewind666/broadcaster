using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Deployment.WindowsInstaller;
using Microsoft.Win32;

namespace CustomManagedAction
{
    /// <summary>
    /// https://wixsharp.codeplex.com/wikipage?title=Deployment%20scenarios#_managed_action
    /// </summary>
    public class CustomActions
    {
        [CustomAction]
        public static ActionResult CheckUScreenCapture( Session session )
        {
            bool isUScreenCaptureExist = false;
            string unrealStreamingFolder = @"UnrealStreaming\UScreenCapture";

            #region CheckRegistry

            string regkey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
            string regkeyWoW64 = @"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall";

            Func<string, bool> checkRegistry = ( regKey ) =>
            {
                using ( RegistryKey key = Registry.LocalMachine.OpenSubKey( regKey ) )
                {
                    if ( key != null )
                        foreach ( string subkeyName in key.GetSubKeyNames() )
                        {
                            using ( RegistryKey subkey = key.OpenSubKey( subkeyName ) )
                            {
                                if ( subkey != null && subkey.GetValueNames().Contains( "DisplayName" ) )
                                {
                                    if ( subkey.GetValue( "DisplayName" ).ToString().Contains( @"UScreenCapture" ) )
                                    {
                                        return true;
                                    }
                                }
                            }
                        }
                }
                return false;
            };

            if ( checkRegistry( regkey ) ) { isUScreenCaptureExist = true; }
            if ( checkRegistry( regkeyWoW64 ) ) { isUScreenCaptureExist = true; }

            #endregion

            #region CheckFileSystem

            //http://stackoverflow.com/questions/1958881/how-can-32-bit-application-find-the-location-of-64-bit-program-files-directory-o

            string programX64 = Environment.GetFolderPath( Environment.SpecialFolder.Windows ).ToLower().Replace( "windows", "Program Files" );
            string dir = Path.Combine( programX64, unrealStreamingFolder );

            if ( Directory.Exists( dir ) )
            {
                isUScreenCaptureExist = true;
            }

            if ( Environment.Is64BitOperatingSystem )
            {
                dir = Path.Combine( Environment.GetFolderPath( Environment.SpecialFolder.ProgramFilesX86 ), unrealStreamingFolder );

                if ( Directory.Exists( dir ) )
                {
                    isUScreenCaptureExist = true;
                }
            }

            #endregion

            if ( !isUScreenCaptureExist )
            {
                if ( DialogResult.Yes == MessageBox.Show(
                        @"Can't find UScreenCapture. For broadcaster correct work, you need it, install now?",
                        @"UScreenCapture install",
                        MessageBoxButtons.YesNo ) )
                {
                    //session["USCREENCAPTURE"] = "yes";

                    byte[] fileBytes;
                    string filePath;
                    if ( Environment.Is64BitOperatingSystem )
                    {
                        fileBytes = Properties.Resources.UScreenCapture__x64_;
                        filePath = Path.GetTempPath() + @"\UScreenCapture_x64.msi";
                    }
                    else
                    {
                        fileBytes = Properties.Resources.UScreenCapture__x86_;
                        filePath = Path.GetTempPath() + @"\UScreenCapture_x86.msi";
                    }

                    try
                    {
                        System.IO.File.WriteAllBytes( filePath, fileBytes );
                        Process.Start( filePath );
                    }
                    catch ( Exception exception )
                    {
                        MessageBox.Show( exception.Message );
                    }
                }
            }

            return ActionResult.Success;
        }
    }
}
