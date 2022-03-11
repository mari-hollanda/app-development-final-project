using System;
using System.Windows.Forms;

namespace FinalProject.PresentationLayer
{
    public partial class frmRooms : UserControl
    {
        public frmRooms()
        {
            InitializeComponent();
            ClearForm();
        }

        private void clearTlsButton_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtRoomType.Text = "";
            txtStaff.Text = "";
            txtStatus.Text = "";
            cmbRoomID.SelectedIndex = -1;
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
    }
}
