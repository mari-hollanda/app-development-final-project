using System;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class frmLogin : Form
    {

        public string login;
        public string password;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            login = txtLogin.Text;
            password = txtPassword.Text;

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
