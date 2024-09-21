using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestingApp
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent(); 
            loginControl.ConnectionString = Properties.Settings.Default.connectionString;
            loginControl.LoginChangedListener += LoginControl_LoginChangedListener;
        }

        private void LoginControl_LoginChangedListener(object sender, EventArgs e)
        {
            if (loginControl.StateLogin)
            {
                Properties.Settings.Default.emailLogin = loginControl.EmailLogin;
                FormMain formMain = new FormMain();
                formMain.Show();
            }
        }
    }
}
