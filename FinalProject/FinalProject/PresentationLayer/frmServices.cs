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
    public partial class frmServices : UserControl
    {
        public frmServices()
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
            txtPrice.Text = "";
            cmbDescription.SelectedIndex = -1;
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
