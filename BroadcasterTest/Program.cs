using System;
using System.Windows.Forms;
using BroadcasterTest.ModelNS;

[assembly: CLSCompliant( true )]
namespace BroadcasterTest
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault( false );

            MainForm mainForm = new MainForm();
            Messager messager = new Messager();
            Model model = new Model();

            new Presetner( mainForm, messager, model );
            Application.Run( mainForm );
            Application.ApplicationExit += delegate { mainForm.Dispose(); model.Dispose(); };
        }
    }
}
