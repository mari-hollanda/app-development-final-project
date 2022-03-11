using System;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class frmGuestRegistration : UserControl
    {
        public frmGuestRegistration()
        {
            InitializeComponent();
            ClearForm();
        }

        private void ClearForm()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtZipCode.Text = "";
            txtStreet.Text = "";
            txtCity.Text = "";
            txtProvince.Text = "";
            cmbRoomAvailable.SelectedIndex = -1;
        }

        private void newTlsButton_Click(object sender, EventArgs e)
        {
            // Code to Create new guest
        }

        private void openTlsButton_Click(object sender, EventArgs e)
        {
            // Code to open a guest
        }

        private void saveTlsButton_Click(object sender, EventArgs e)
        {
            // Code to save a guest
        }

        private void deleteTlsButton_Click(object sender, EventArgs e)
        {
            // Code to delete a guest
        }

        private void clearTlsButton_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
