
namespace FinalProject
{
    partial class frmGuestRegistration
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGuestRegistration));
            this.tlsMain = new System.Windows.Forms.ToolStrip();
            this.newTlsButton = new System.Windows.Forms.ToolStripButton();
            this.openTlsButton = new System.Windows.Forms.ToolStripButton();
            this.saveTlsButton = new System.Windows.Forms.ToolStripButton();
            this.deleteTlsButton = new System.Windows.Forms.ToolStripButton();
            this.clearTlsButton = new System.Windows.Forms.ToolStripButton();
            this.grpAddress = new System.Windows.Forms.GroupBox();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblProvince = new System.Windows.Forms.Label();
            this.txtProvince = new System.Windows.Forms.TextBox();
            this.grpPersonalData = new System.Windows.Forms.GroupBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.grpBooking = new System.Windows.Forms.GroupBox();
            this.dtpCheckInDate = new System.Windows.Forms.DateTimePicker();
            this.cmbRoomAvailable = new System.Windows.Forms.ComboBox();
            this.lblRoomAvailable = new System.Windows.Forms.Label();
            this.lblCheckInDate = new System.Windows.Forms.Label();
            this.tlsMain.SuspendLayout();
            this.grpAddress.SuspendLayout();
            this.grpPersonalData.SuspendLayout();
            this.grpBooking.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlsMain
            // 
            this.tlsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTlsButton,
            this.openTlsButton,
            this.saveTlsButton,
            this.deleteTlsButton,
            this.clearTlsButton});
            this.tlsMain.Location = new System.Drawing.Point(0, 0);
            this.tlsMain.Name = "tlsMain";
            this.tlsMain.Size = new System.Drawing.Size(674, 25);
            this.tlsMain.TabIndex = 0;
            // 
            // newTlsButton
            // 
            this.newTlsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newTlsButton.Image = ((System.Drawing.Image)(resources.GetObject("newTlsButton.Image")));
            this.newTlsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newTlsButton.Name = "newTlsButton";
            this.newTlsButton.Size = new System.Drawing.Size(23, 22);
            this.newTlsButton.Text = "New";
            this.newTlsButton.Click += new System.EventHandler(this.newTlsButton_Click);
            // 
            // openTlsButton
            // 
            this.openTlsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openTlsButton.Image = ((System.Drawing.Image)(resources.GetObject("openTlsButton.Image")));
            this.openTlsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openTlsButton.Name = "openTlsButton";
            this.openTlsButton.Size = new System.Drawing.Size(23, 22);
            this.openTlsButton.Text = "Open";
            this.openTlsButton.Click += new System.EventHandler(this.openTlsButton_Click);
            // 
            // saveTlsButton
            // 
            this.saveTlsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveTlsButton.Image = ((System.Drawing.Image)(resources.GetObject("saveTlsButton.Image")));
            this.saveTlsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveTlsButton.Name = "saveTlsButton";
            this.saveTlsButton.Size = new System.Drawing.Size(23, 22);
            this.saveTlsButton.Text = "Save";
            this.saveTlsButton.Click += new System.EventHandler(this.saveTlsButton_Click);
            // 
            // deleteTlsButton
            // 
            this.deleteTlsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteTlsButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteTlsButton.Image")));
            this.deleteTlsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteTlsButton.Name = "deleteTlsButton";
            this.deleteTlsButton.Size = new System.Drawing.Size(23, 22);
            this.deleteTlsButton.Text = "Delete";
            this.deleteTlsButton.Click += new System.EventHandler(this.deleteTlsButton_Click);
            // 
            // clearTlsButton
            // 
            this.clearTlsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clearTlsButton.Image = ((System.Drawing.Image)(resources.GetObject("clearTlsButton.Image")));
            this.clearTlsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clearTlsButton.Name = "clearTlsButton";
            this.clearTlsButton.Size = new System.Drawing.Size(23, 22);
            this.clearTlsButton.Text = "Clear";
            this.clearTlsButton.Click += new System.EventHandler(this.clearTlsButton_Click);
            // 
            // grpAddress
            // 
            this.grpAddress.Controls.Add(this.lblZipCode);
            this.grpAddress.Controls.Add(this.txtZipCode);
            this.grpAddress.Controls.Add(this.lblStreet);
            this.grpAddress.Controls.Add(this.txtStreet);
            this.grpAddress.Controls.Add(this.lblCity);
            this.grpAddress.Controls.Add(this.txtCity);
            this.grpAddress.Controls.Add(this.lblProvince);
            this.grpAddress.Controls.Add(this.txtProvince);
            this.grpAddress.Location = new System.Drawing.Point(4, 187);
            this.grpAddress.Margin = new System.Windows.Forms.Padding(4);
            this.grpAddress.Name = "grpAddress";
            this.grpAddress.Padding = new System.Windows.Forms.Padding(4);
            this.grpAddress.Size = new System.Drawing.Size(402, 136);
            this.grpAddress.TabIndex = 59;
            this.grpAddress.TabStop = false;
            this.grpAddress.Text = "Address";
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Location = new System.Drawing.Point(8, 28);
            this.lblZipCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(50, 13);
            this.lblZipCode.TabIndex = 32;
            this.lblZipCode.Text = "Zip Code";
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(8, 48);
            this.txtZipCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(175, 20);
            this.txtZipCode.TabIndex = 5;
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(191, 28);
            this.lblStreet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(35, 13);
            this.lblStreet.TabIndex = 34;
            this.lblStreet.Text = "Street";
            // 
            // txtStreet
            // 
            this.txtStreet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStreet.Location = new System.Drawing.Point(192, 48);
            this.txtStreet.Margin = new System.Windows.Forms.Padding(4);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(189, 20);
            this.txtStreet.TabIndex = 6;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(7, 76);
            this.lblCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 36;
            this.lblCity.Text = "City";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(8, 96);
            this.txtCity.Margin = new System.Windows.Forms.Padding(4);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(175, 20);
            this.txtCity.TabIndex = 7;
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Location = new System.Drawing.Point(191, 76);
            this.lblProvince.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(49, 13);
            this.lblProvince.TabIndex = 38;
            this.lblProvince.Text = "Province";
            // 
            // txtProvince
            // 
            this.txtProvince.Location = new System.Drawing.Point(194, 96);
            this.txtProvince.Margin = new System.Windows.Forms.Padding(4);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Size = new System.Drawing.Size(187, 20);
            this.txtProvince.TabIndex = 8;
            // 
            // grpPersonalData
            // 
            this.grpPersonalData.Controls.Add(this.lblPhone);
            this.grpPersonalData.Controls.Add(this.txtPhone);
            this.grpPersonalData.Controls.Add(this.txtFirstName);
            this.grpPersonalData.Controls.Add(this.lblEmail);
            this.grpPersonalData.Controls.Add(this.lblFirstName);
            this.grpPersonalData.Controls.Add(this.txtEmail);
            this.grpPersonalData.Controls.Add(this.lblLastName);
            this.grpPersonalData.Controls.Add(this.txtLastName);
            this.grpPersonalData.Location = new System.Drawing.Point(4, 29);
            this.grpPersonalData.Margin = new System.Windows.Forms.Padding(4);
            this.grpPersonalData.Name = "grpPersonalData";
            this.grpPersonalData.Padding = new System.Windows.Forms.Padding(4);
            this.grpPersonalData.Size = new System.Drawing.Size(630, 135);
            this.grpPersonalData.TabIndex = 2;
            this.grpPersonalData.TabStop = false;
            this.grpPersonalData.Text = "Personal Data";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(11, 79);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(38, 13);
            this.lblPhone.TabIndex = 45;
            this.lblPhone.Text = "Phone";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(11, 99);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(175, 20);
            this.txtPhone.TabIndex = 3;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFirstName.Location = new System.Drawing.Point(11, 46);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(212, 20);
            this.txtFirstName.TabIndex = 1;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(191, 79);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 46;
            this.lblEmail.Text = "Email";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(11, 26);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 24;
            this.lblFirstName.Text = "First Name";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Location = new System.Drawing.Point(194, 99);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(399, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(228, 26);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 28;
            this.lblLastName.Text = "Last Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLastName.Location = new System.Drawing.Point(231, 46);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(362, 20);
            this.txtLastName.TabIndex = 2;
            // 
            // grpBooking
            // 
            this.grpBooking.Controls.Add(this.dtpCheckInDate);
            this.grpBooking.Controls.Add(this.cmbRoomAvailable);
            this.grpBooking.Controls.Add(this.lblRoomAvailable);
            this.grpBooking.Controls.Add(this.lblCheckInDate);
            this.grpBooking.Location = new System.Drawing.Point(414, 189);
            this.grpBooking.Margin = new System.Windows.Forms.Padding(4);
            this.grpBooking.Name = "grpBooking";
            this.grpBooking.Padding = new System.Windows.Forms.Padding(4);
            this.grpBooking.Size = new System.Drawing.Size(220, 134);
            this.grpBooking.TabIndex = 60;
            this.grpBooking.TabStop = false;
            this.grpBooking.Text = "Booking";
            // 
            // dtpCheckInDate
            // 
            this.dtpCheckInDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckInDate.Location = new System.Drawing.Point(8, 94);
            this.dtpCheckInDate.Name = "dtpCheckInDate";
            this.dtpCheckInDate.Size = new System.Drawing.Size(175, 20);
            this.dtpCheckInDate.TabIndex = 10;
            // 
            // cmbRoomAvailable
            // 
            this.cmbRoomAvailable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoomAvailable.FormattingEnabled = true;
            this.cmbRoomAvailable.Location = new System.Drawing.Point(8, 46);
            this.cmbRoomAvailable.Name = "cmbRoomAvailable";
            this.cmbRoomAvailable.Size = new System.Drawing.Size(175, 21);
            this.cmbRoomAvailable.TabIndex = 9;
            // 
            // lblRoomAvailable
            // 
            this.lblRoomAvailable.AutoSize = true;
            this.lblRoomAvailable.Location = new System.Drawing.Point(8, 28);
            this.lblRoomAvailable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomAvailable.Name = "lblRoomAvailable";
            this.lblRoomAvailable.Size = new System.Drawing.Size(81, 13);
            this.lblRoomAvailable.TabIndex = 32;
            this.lblRoomAvailable.Text = "Room Available";
            // 
            // lblCheckInDate
            // 
            this.lblCheckInDate.AutoSize = true;
            this.lblCheckInDate.Location = new System.Drawing.Point(8, 74);
            this.lblCheckInDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCheckInDate.Name = "lblCheckInDate";
            this.lblCheckInDate.Size = new System.Drawing.Size(76, 13);
            this.lblCheckInDate.TabIndex = 34;
            this.lblCheckInDate.Text = "Check-In Date";
            // 
            // frmGuestRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpBooking);
            this.Controls.Add(this.grpAddress);
            this.Controls.Add(this.grpPersonalData);
            this.Controls.Add(this.tlsMain);
            this.Name = "frmGuestRegistration";
            this.Size = new System.Drawing.Size(674, 352);
            this.tlsMain.ResumeLayout(false);
            this.tlsMain.PerformLayout();
            this.grpAddress.ResumeLayout(false);
            this.grpAddress.PerformLayout();
            this.grpPersonalData.ResumeLayout(false);
            this.grpPersonalData.PerformLayout();
            this.grpBooking.ResumeLayout(false);
            this.grpBooking.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tlsMain;
        private System.Windows.Forms.ToolStripButton newTlsButton;
        private System.Windows.Forms.ToolStripButton openTlsButton;
        private System.Windows.Forms.ToolStripButton saveTlsButton;
        private System.Windows.Forms.ToolStripButton deleteTlsButton;
        private System.Windows.Forms.ToolStripButton clearTlsButton;
        private System.Windows.Forms.GroupBox grpAddress;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.GroupBox grpPersonalData;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.GroupBox grpBooking;
        private System.Windows.Forms.Label lblRoomAvailable;
        private System.Windows.Forms.Label lblCheckInDate;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cmbRoomAvailable;
        private System.Windows.Forms.DateTimePicker dtpCheckInDate;
        private System.Windows.Forms.TextBox txtProvince;
    }
}
