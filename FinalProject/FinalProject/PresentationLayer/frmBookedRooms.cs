using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class frmBookedRooms : UserControl
    {
        public frmBookedRooms()
        {
            InitializeComponent();
            ClearForm();
        }

        private void ClearForm()
        {
            txtName.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtCheckInDate.Text = "";
            rtbTotal.Text = "";
            cmbRoomNumber.SelectedIndex = - 1;
            cmbServices.SelectedIndex = -1;
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

        private void btnCheckOut_Click(object sender, EventArgs e)
        {

        }
    }
}
