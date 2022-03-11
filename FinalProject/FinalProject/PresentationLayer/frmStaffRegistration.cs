using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.PresentationLayer
{
    public partial class frmStaffRegistration : UserControl
    {
        public frmStaffRegistration()
        {
            InitializeComponent();
            ClearForm();
        }

        private void newTlsButton_Click(object sender, EventArgs e)
        {

        }

        private void openTlsButton_Click(object sender, EventArgs e)
        {

        }

        private void saveTlsButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteTlsButton_Click(object sender, EventArgs e)
        {

        }

        private void clearTlsButton_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtPosition.Text = "";
            txtTitle.Text = "";
        }
    }
}
