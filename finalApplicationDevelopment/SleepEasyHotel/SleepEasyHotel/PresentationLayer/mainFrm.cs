using System;
using System.Windows.Forms;

/*
 * Main Form
 * @since 20220220
 * Form that contains the main parts of the application
 */
namespace SleepEasyHotel.PresentationLayer
{
    public partial class mainFrm : Form
    {
        int GuestRegistration = 0;
        int BookedRooms = 0;
        int StaffRegistration = 0;
        int StaffUpdate = 0;
        int Rooms = 0;
        int createServices = 0;
        int updateServices = 0;
        int loginCreate = 0;

        string username;
        string PositionID;

        //Set Information method
        public void setInfo(string uName, string pID)
        {
            username = uName;
            PositionID = pID;
        }

        public mainFrm()
        {
            InitializeComponent();
        }

        //Remove from Tab
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
            if (TB.Name == "Create service")
            {
                createServices = 0;
            }
            if (TB.Name == "Update service")
            {
                updateServices = 0;
            }
            if (TB.Name == "Staff Update")
            {
                StaffUpdate = 0;
            }
            if (TB.Name == "Create Login")
            {
                loginCreate = 0;
            }
            tbcApplication.TabPages.Remove(TB);
        }

        //Load the Form
        private void mainFrm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome "+ username);
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
            }
            else if (PositionID == "2")
            {
                clearTabToolStripMenuItem.Enabled = true;
                registrationToolStripMenuItem.Enabled = true;
                disconnectToolStripMenuItem.Enabled = true;
                guestRegistrationToolStripMenuItem.Enabled = true;
                bookedRoomsToolStripMenuItem.Enabled = true;
                staffToolStripMenuItem.Enabled = false;
                roomToolStripMenuItem.Enabled = false;
                servicesToolStripMenuItem.Enabled = false;
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
            }
        }

        //Open Guest Registration ToolStripMenuItem
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

        //Open Booked Rooms ToolStripMenuItem
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

        //Clear Tab Method
        private void clearTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(tbcApplication.SelectedTab == null))
            {
                clearTab(tbcApplication.SelectedTab);
            }
        }

        //Open Staff Registration ToolStripMenuItem
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

        //Open Update Staff ToolStripMenuItem
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

        //Open Rooms ToolStripMenuItem
        private void roomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Rooms == 0)
            {
                Rooms += 1;
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

        //Open Create Service ToolStripMenuItem
        private void createServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (createServices == 0)
            {
                createServices += 1;
                frmCreateService U = new frmCreateService();
                U.Dock = DockStyle.Fill;
                TabPage TB = new TabPage();
                TB.Name = "Create service";
                TB.Text = "Create service";
                TB.Controls.Add(U);
                tbcApplication.TabPages.Add(TB);
            }
            else
            {
                MessageBox.Show("Tab already opened.", "SleepEasy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Open Update Service ToolStripMenuItem
        private void updateServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (updateServices == 0)
            {
                updateServices += 1;
                frmUpdateService U = new frmUpdateService();
                U.Dock = DockStyle.Fill;
                TabPage TB = new TabPage();
                TB.Name = "Update service";
                TB.Text = "Update service";
                TB.Controls.Add(U);
                tbcApplication.TabPages.Add(TB);
            }
            else
            {
                MessageBox.Show("Tab already opened.", "SleepEasy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Logout Button
        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        //Exit Button
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to close the application?", "Closing event!", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
