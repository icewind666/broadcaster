using System;
using System.Windows.Forms;

namespace BroadcasterTest
{
    public partial class ChangeConfigNameForm : Form
    {
        public string ConfigName { get; private set; }

        public ChangeConfigNameForm( string name )
        {
            InitializeComponent();
            this.ConfigName = name;
            this.tb_configName.Text = name;
        }

        private void btn_cancel_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void btn_Save_Click( object sender, EventArgs e )
        {
            this.ConfigName = this.tb_configName.Text;
            this.Close();
        }
    }
}
