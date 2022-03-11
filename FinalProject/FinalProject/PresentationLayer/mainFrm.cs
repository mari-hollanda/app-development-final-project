using FinalProject.PresentationLayer;
using System;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class mainFrm : Form
    {

        int GuestRegistration = 0;
        int BookedRooms = 0;
        int StaffRegistration = 0;
        int Rooms = 0;
        int Services = 0;
        int Inventory = 0;

        public mainFrm()
        {
            InitializeComponent();
            clearTabToolStripMenuItem.Enabled = false;
            connectToolStripMenuItem.Enabled = true;
            disconnectToolStripMenuItem.Enabled = false;
            guestRegistrationToolStripMenuItem.Enabled = false;
            bookedRoomsToolStripMenuItem.Enabled = false;
            staffToolStripMenuItem.Enabled = false;
            roomToolStripMenuItem.Enabled = false;
            servicesToolStripMenuItem.Enabled = false;
            inventoryToolStripMenuItem.Enabled = false;
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin F = new frmLogin();
            F.ShowDialog();

            if (F.DialogResult == DialogResult.OK)
            {

                string login = F.login;
                string password = F.password;

                if (Util.adminValidation(password) == true)
                {

                    clearTabToolStripMenuItem.Enabled = true;
                    connectToolStripMenuItem.Enabled = false;
                    disconnectToolStripMenuItem.Enabled = true;
                    guestRegistrationToolStripMenuItem.Enabled = true;
                    bookedRoomsToolStripMenuItem.Enabled = true;
                    staffToolStripMenuItem.Enabled = true;
                    roomToolStripMenuItem.Enabled = true;
                    servicesToolStripMenuItem.Enabled = true;
                    inventoryToolStripMenuItem.Enabled = true;

                    MessageBox.Show("Welcome " + login + "!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Invalid password.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMessage Db = new frmMessage("Would you like to disconnect?");
            Db.ShowDialog();
            if (Db.DialogResult == DialogResult.Yes)
            {
                for (int i = tbcApplication.TabPages.Count - 1; i >= 0; i += -1)
                {
                    clearTab(tbcApplication.TabPages[i]);
                }

                clearTabToolStripMenuItem.Enabled = false;
                connectToolStripMenuItem.Enabled = true;
                disconnectToolStripMenuItem.Enabled = false;
                guestRegistrationToolStripMenuItem.Enabled = false;
                bookedRoomsToolStripMenuItem.Enabled = false;
                staffToolStripMenuItem.Enabled = false;
                roomToolStripMenuItem.Enabled = false;
                servicesToolStripMenuItem.Enabled = false;
                inventoryToolStripMenuItem.Enabled = false;
            }
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
            tbcApplication.TabPages.Remove(TB);
        }

        private void clearTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(tbcApplication.SelectedTab == null))
            {
                clearTab(tbcApplication.SelectedTab);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void roomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Rooms == 0)
            {
                Rooms += 1;
                frmRooms U = new frmRooms();
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

        private void servicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Services == 0)
            {
                Services += 1;
                frmServices U = new frmServices();
                U.Dock = DockStyle.Fill;
                TabPage TB = new TabPage();
                TB.Name = "Services";
                TB.Text = "Services";
                TB.Controls.Add(U);
                tbcApplication.TabPages.Add(TB);
            }
            else
            {
                MessageBox.Show("Tab already opened.", "SleepEasy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Inventory == 0)
            {
                Inventory += 1;
                frmInventory U = new frmInventory();
                U.Dock = DockStyle.Fill;
                TabPage TB = new TabPage();
                TB.Name = "Inventory";
                TB.Text = "Inventory";
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
