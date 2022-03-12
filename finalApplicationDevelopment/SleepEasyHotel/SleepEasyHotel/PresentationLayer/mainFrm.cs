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
using SleepEasyHotel.BusinessObjects;

namespace SleepEasyHotel.PresentationLayer
{
    public partial class mainFrm : Form
    {
        int GuestRegistration = 0;
        int BookedRooms = 0;
        int StaffRegistration = 0;
        int StaffUpdate = 0;
        int Rooms = 0;
        int Services = 0;
        int Inventory = 0;


        string username;
        string PositionID;
        public void setInfo(string uName, string pID)
        {
            username = uName;
            PositionID = pID;
        }
        public mainFrm()
        {
            InitializeComponent();
        }

        void clearTab(TabPage TB)
        {
            if (TB.Name == "Guest Registration")
            {
                GuestRegistration = 0;
            }
            if (TB.Name == "Booked Rooms")
            {
                BookedRooms = 0;
            }
            if (TB.Name == "Staff Registration")
            {
                StaffRegistration = 0;
            }
            if (TB.Name == "Rooms")
            {
                Rooms = 0;
            }
            if (TB.Name == "Services")
            {
                Services = 0;
            }
            if (TB.Name == "Inventory")
            {
                Inventory = 0;
            }
            if (TB.Name == "Staff Update")
            {
                StaffUpdate = 0;
            }
            tbcApplication.TabPages.Remove(TB);
        }

      


        private void mainFrm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome "+username);
            if (PositionID == "1")
            {

                clearTabToolStripMenuItem.Enabled = true;
                registrationToolStripMenuItem.Enabled = true;
                disconnectToolStripMenuItem.Enabled = true;
                guestRegistrationToolStripMenuItem.Enabled = true;
                bookedRoomsToolStripMenuItem.Enabled = true;
                staffToolStripMenuItem.Enabled = true;
                roomToolStripMenuItem.Enabled = true;
                servicesToolStripMenuItem.Enabled = true;
                inventoryToolStripMenuItem.Enabled = true;
            }
            else if (PositionID == "2")
            {
                clearTabToolStripMenuItem.Enabled = false;
                registrationToolStripMenuItem.Enabled = true;
                disconnectToolStripMenuItem.Enabled = false;
                guestRegistrationToolStripMenuItem.Enabled = false;
                bookedRoomsToolStripMenuItem.Enabled = false;
                staffToolStripMenuItem.Enabled = false;
                roomToolStripMenuItem.Enabled = false;
                servicesToolStripMenuItem.Enabled = false;
                inventoryToolStripMenuItem.Enabled = false;
            }
            else {
                clearTabToolStripMenuItem.Enabled = false;
                registrationToolStripMenuItem.Enabled = false;
                disconnectToolStripMenuItem.Enabled = false;
                guestRegistrationToolStripMenuItem.Enabled = false;
                bookedRoomsToolStripMenuItem.Enabled = false;
                staffToolStripMenuItem.Enabled = false;
                roomToolStripMenuItem.Enabled = false;
                servicesToolStripMenuItem.Enabled = false;
                inventoryToolStripMenuItem.Enabled = false;
            }
        }

        private void guestRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GuestRegistration == 0)
            {
                GuestRegistration += 1;
                frmGuestRegistration U = new frmGuestRegistration();
                U.Dock = DockStyle.Fill;
                TabPage TB = new TabPage();
                TB.Name = "Guest Registration";
                TB.Text = "Guest Registration";
                TB.Controls.Add(U);
                tbcApplication.TabPages.Add(TB);
            }
            else
            {
                MessageBox.Show("Tab already opened.", "SleepEasy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bookedRoomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BookedRooms == 0)
            {
                BookedRooms += 1;
                frmBookedRooms U = new frmBookedRooms();
                U.Dock = DockStyle.Fill;
                TabPage TB = new TabPage();
                TB.Name = "Booked Rooms";
                TB.Text = "Booked Rooms";
                TB.Controls.Add(U);
                tbcApplication.TabPages.Add(TB);
            }
            else
            {
                MessageBox.Show("Tab already opened.", "SleepEasy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void clearTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(tbcApplication.SelectedTab == null))
            {
                clearTab(tbcApplication.SelectedTab);
            }
        }

       

        private void staffRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (StaffRegistration == 0)
            {
                StaffRegistration += 1;
                frmStaffRegistration U = new frmStaffRegistration();
                U.Dock = DockStyle.Fill;
                TabPage TB = new TabPage();
                TB.Name = "Staff Registration";
                TB.Text = "Staff Registration";
                TB.Controls.Add(U);
                tbcApplication.TabPages.Add(TB);
            }
            else
            {
                MessageBox.Show("Tab already opened.", "SleepEasy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void updateStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (StaffUpdate == 0)
            {
                StaffUpdate += 1;
                frmStaffUpdate U = new frmStaffUpdate();
                U.Dock = DockStyle.Fill;
                TabPage TB = new TabPage();
                TB.Name = "Staff Update";
                TB.Text = "Staff Update";
                TB.Controls.Add(U);
                tbcApplication.TabPages.Add(TB);
            }
            else
            {
                MessageBox.Show("Tab already opened.", "SleepEasy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbcApplication_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void roomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (StaffUpdate == 0)
            {
                StaffUpdate += 1;
                frmUpdateRooms U = new frmUpdateRooms();
                U.Dock = DockStyle.Fill;
                TabPage TB = new TabPage();
                TB.Name = "Rooms";
                TB.Text = "Rooms";
                TB.Controls.Add(U);
                tbcApplication.TabPages.Add(TB);
            }
            else
            {
                MessageBox.Show("Tab already opened.", "SleepEasy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
