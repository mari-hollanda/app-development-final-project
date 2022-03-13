
namespace SleepEasyHotel.PresentationLayer
{
    partial class mainFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbcApplication = new System.Windows.Forms.TabControl();
            this.mainStrp = new System.Windows.Forms.MenuStrip();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guestRegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookedRoomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffRegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainStrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcApplication
            // 
            this.tbcApplication.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcApplication.Location = new System.Drawing.Point(0, 24);
            this.tbcApplication.Margin = new System.Windows.Forms.Padding(4);
            this.tbcApplication.Name = "tbcApplication";
            this.tbcApplication.SelectedIndex = 0;
            this.tbcApplication.Size = new System.Drawing.Size(800, 426);
            this.tbcApplication.TabIndex = 4;
            // 
            // mainStrp
            // 
            this.mainStrp.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainStrp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.registrationToolStripMenuItem,
            this.staffToolStripMenuItem,
            this.roomToolStripMenuItem,
            this.servicesToolStripMenuItem});
            this.mainStrp.Location = new System.Drawing.Point(0, 0);
            this.mainStrp.Name = "mainStrp";
            this.mainStrp.Size = new System.Drawing.Size(800, 24);
            this.mainStrp.TabIndex = 3;
            this.mainStrp.Text = "menuStrip1";
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disconnectToolStripMenuItem,
            this.clearTabToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.mainToolStripMenuItem.Text = "Main";
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.disconnectToolStripMenuItem.Text = "LogOut";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // clearTabToolStripMenuItem
            // 
            this.clearTabToolStripMenuItem.Name = "clearTabToolStripMenuItem";
            this.clearTabToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clearTabToolStripMenuItem.Text = "Clear Tab";
            this.clearTabToolStripMenuItem.Click += new System.EventHandler(this.clearTabToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // registrationToolStripMenuItem
            // 
            this.registrationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guestRegistrationToolStripMenuItem,
            this.bookedRoomsToolStripMenuItem});
            this.registrationToolStripMenuItem.Name = "registrationToolStripMenuItem";
            this.registrationToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.registrationToolStripMenuItem.Text = "Registration";
            // 
            // guestRegistrationToolStripMenuItem
            // 
            this.guestRegistrationToolStripMenuItem.Name = "guestRegistrationToolStripMenuItem";
            this.guestRegistrationToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.guestRegistrationToolStripMenuItem.Text = "Guest Registration";
            this.guestRegistrationToolStripMenuItem.Click += new System.EventHandler(this.guestRegistrationToolStripMenuItem_Click);
            // 
            // bookedRoomsToolStripMenuItem
            // 
            this.bookedRoomsToolStripMenuItem.Name = "bookedRoomsToolStripMenuItem";
            this.bookedRoomsToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.bookedRoomsToolStripMenuItem.Text = "Booked Rooms";
            this.bookedRoomsToolStripMenuItem.Click += new System.EventHandler(this.bookedRoomsToolStripMenuItem_Click);
            // 
            // staffToolStripMenuItem
            // 
            this.staffToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.staffRegistrationToolStripMenuItem,
            this.updateStaffToolStripMenuItem});
            this.staffToolStripMenuItem.Name = "staffToolStripMenuItem";
            this.staffToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.staffToolStripMenuItem.Text = "Staff";
            // 
            // staffRegistrationToolStripMenuItem
            // 
            this.staffRegistrationToolStripMenuItem.Name = "staffRegistrationToolStripMenuItem";
            this.staffRegistrationToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.staffRegistrationToolStripMenuItem.Text = "Staff Registration";
            this.staffRegistrationToolStripMenuItem.Click += new System.EventHandler(this.staffRegistrationToolStripMenuItem_Click);
            // 
            // updateStaffToolStripMenuItem
            // 
            this.updateStaffToolStripMenuItem.Name = "updateStaffToolStripMenuItem";
            this.updateStaffToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.updateStaffToolStripMenuItem.Text = "Staff Update";
            this.updateStaffToolStripMenuItem.Click += new System.EventHandler(this.updateStaffToolStripMenuItem_Click);
            // 
            // roomToolStripMenuItem
            // 
            this.roomToolStripMenuItem.Name = "roomToolStripMenuItem";
            this.roomToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.roomToolStripMenuItem.Text = "Room";
            this.roomToolStripMenuItem.Click += new System.EventHandler(this.roomToolStripMenuItem_Click);
            // 
            // servicesToolStripMenuItem
            // 
            this.servicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createServiceToolStripMenuItem,
            this.updateServiceToolStripMenuItem});
            this.servicesToolStripMenuItem.Name = "servicesToolStripMenuItem";
            this.servicesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.servicesToolStripMenuItem.Text = "Services";
            // 
            // createServiceToolStripMenuItem
            // 
            this.createServiceToolStripMenuItem.Name = "createServiceToolStripMenuItem";
            this.createServiceToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.createServiceToolStripMenuItem.Text = "Create Service";
            this.createServiceToolStripMenuItem.Click += new System.EventHandler(this.createServiceToolStripMenuItem_Click);
            // 
            // updateServiceToolStripMenuItem
            // 
            this.updateServiceToolStripMenuItem.Name = "updateServiceToolStripMenuItem";
            this.updateServiceToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.updateServiceToolStripMenuItem.Text = "Update Service";
            this.updateServiceToolStripMenuItem.Click += new System.EventHandler(this.updateServiceToolStripMenuItem_Click);
            // 
            // mainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbcApplication);
            this.Controls.Add(this.mainStrp);
            this.Name = "mainFrm";
            this.Text = "mainFrm";
            this.Load += new System.EventHandler(this.mainFrm_Load);
            this.mainStrp.ResumeLayout(false);
            this.mainStrp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbcApplication;
        private System.Windows.Forms.MenuStrip mainStrp;
        private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guestRegistrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookedRoomsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem servicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffRegistrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createServiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateServiceToolStripMenuItem;
    }
}