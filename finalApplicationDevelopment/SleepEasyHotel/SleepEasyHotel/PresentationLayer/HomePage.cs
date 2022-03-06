using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SleepEasyHotel.PresentationLayer;
using SleepEasyHotel.PresentationLayer;


namespace SleepEasyHotel.PresentationLayer
{
    public partial class HomePage : Form
    {
        private string username;
        private string PositionID;
       
        public void setInfo(string uName, string pID)
        {
            username = uName;
            PositionID = pID;
        }

        public HomePage()
        {
            InitializeComponent();
        }

       
        private void HomePage_Load(object sender, EventArgs e)
        {
           
            rtbLogin.Text = "Welcome "+ username;
           
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
           
            login.Show();
            this.Close();
        }

       

        private void btnRegistrationService_Click(object sender, EventArgs e)
        {
            RegistrationServices frmRegistration = new RegistrationServices();
            this.Hide();
            frmRegistration.Show();

        }

        private void btnStaffServices_Click(object sender, EventArgs e)
        {
            staffServices staffServices = new staffServices();
            this.Hide();
            staffServices.Show();

        }
    }
}
