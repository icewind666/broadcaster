using System;
using System.IO;
using WixSharp;
using File = WixSharp.File;

namespace BuildMSI
{
    class Setup
    {
        //https://wixsharp.codeplex.com/
        //http://www.infoq.com/articles/WixSharp
        //http://www.codeproject.com/Articles/31407/Wix-WixSharp-managed-interface-for-WiX

        private static readonly string COMPANY_FOLDER_PATH = @"\Pentestit\BroadcasterTest";
        private static readonly string OUTPUT_FILE_NAME = @"BroadcasterSetup";

        static void Main( string[] args )
        {
            Console.WriteLine( @"Press Enter to start building..." );
            Console.ReadLine();

            Compiler.WixLocation = @"..\..\WixSharp\Wix_bin\bin\";
            Compiler.WixSdkLocation = @"..\..\WixSharp\Wix_bin\SDK\";
            Compiler.ClientAssembly = @"..\..\WixSharp\";

            Project project = new Project(
                "Broadcaster",
                new Dir(
                        // Стандартный путь для установки
                        "%ProgramFiles%" + COMPANY_FOLDER_PATH,

                        new File( @"..\..\..\BroadcasterTest\bin\Debug\BroadcasterTest.exe",
                            new FileShortcut( "MyApp", @"%Desktop%" ) ),
                        // Иконка удаления программы которая будет находится в папке самой программы.
                        new ExeFileShortcut( "Uninstall Broadcaster", "[System64Folder]msiexec.exe", "/x [ProductCode]" ),

                        new File( @"..\..\..\BroadcasterTest\bin\Debug\NAudio.dll" ),
                        new File( @"..\..\..\BroadcasterTest\bin\Debug\NAudio.WindowsMediaFormat.dll" )
                        ),

                new Dir(
                        // Путь для сохранения настроек приложения, не перемещаемый профиль.
                        "%LocalAppData%" + COMPANY_FOLDER_PATH,
                        // Копируем пустые файлы, что бы они удалялись вместе с приложением.
                        new File( @"..\..\events.log" ),
                        new File( @"..\..\config.bin" )
                    ),

                //new Property("USCREENCAPTURE", "no"),

                //System.Reflection.Assembly.GetExecutingAssembly().Location (if class in local project)
                new ManagedAction( @"CheckUScreenCapture", @"..\..\..\CustomManagedAction\bin\Debug\CustomManagedAction.dll", Return.ignore, When.Before, Step.LaunchConditions, Condition.Always, Sequence.InstallUISequence ) )
            {
                LicenceFile = @"..\..\License.rtf",
                UI = WUI.WixUI_InstallDir,
                SourceBaseDir = Environment.CurrentDirectory,
                OutFileName = OUTPUT_FILE_NAME,
                BannerImage = @"..\..\PENTESTIT_banner.bmp"
            };

            //Compiler.PreserveTempFiles = true;
            Compiler.BuildMsi( project );

            Console.WriteLine( @"Start msi (y,n)?" );
            ConsoleKeyInfo consoleKey = Console.ReadKey();
            if ( consoleKey.Key == ConsoleKey.Y )
            {
                System.Diagnostics.Process.Start( Environment.CurrentDirectory + @"\" + OUTPUT_FILE_NAME + ".msi" );
            }
            Console.ReadLine();
        }
    }
}
