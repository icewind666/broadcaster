using System;
using System.Windows.Forms;
using BroadcasterTest.Interfaces;

namespace BroadcasterTest
{
    internal sealed class Messager : IMessager
    {
        public void ShowMessage( string message )
        {
            MessageBox.Show( message, @"Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading );
        }

        public void ShowExclamation( string message )
        {
            MessageBox.Show( message, @"Exclamation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading );
        }

        public void ShowError( string message )
        {
            MessageBox.Show( message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading );
        }

        public string ChangeConfigName( string name )
        {
            string configName = String.Empty;

            using ( ChangeConfigNameForm configNameForm = new ChangeConfigNameForm( name ) )
            {
                configNameForm.ShowDialog();
                configName = configNameForm.ConfigName;
            }

            return configName;
        }
    }
}
