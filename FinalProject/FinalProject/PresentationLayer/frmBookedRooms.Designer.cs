
namespace FinalProject
{
    partial class frmBookedRooms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookedRooms));
            this.tlsMain = new System.Windows.Forms.ToolStrip();
            this.newTlsButton = new System.Windows.Forms.ToolStripButton();
            this.openTlsButton = new System.Windows.Forms.ToolStripButton();
            this.saveTlsButton = new System.Windows.Forms.ToolStripButton();
            this.deleteTlsButton = new System.Windows.Forms.ToolStripButton();
            this.clearTlsButton = new System.Windows.Forms.ToolStripButton();
            this.grpTotal = new System.Windows.Forms.GroupBox();
            this.rtbTotal = new System.Windows.Forms.RichTextBox();
            this.lblServices = new System.Windows.Forms.Label();
            this.cmbServices = new System.Windows.Forms.ComboBox();
            this.txtCheckInDate = new System.Windows.Forms.TextBox();
            this.dtpCheckOutDate = new System.Windows.Forms.DateTimePicker();
            this.lblCheckOutDate = new System.Windows.Forms.Label();
            this.lblCheckInDate = new System.Windows.Forms.Label();
            this.grpServices = new System.Windows.Forms.GroupBox();
            this.grpPersonalData = new System.Windows.Forms.GroupBox();
            this.cmbRoomNumber = new System.Windows.Forms.ComboBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.tlsMain.SuspendLayout();
            this.grpTotal.SuspendLayout();
            this.grpServices.SuspendLayout();
            this.grpPersonalData.SuspendLayout();
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
            this.tlsMain.Size = new System.Drawing.Size(568, 25);
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
            // grpTotal
            // 
            this.grpTotal.Controls.Add(this.rtbTotal);
            this.grpTotal.Controls.Add(this.lblServices);
            this.grpTotal.Controls.Add(this.cmbServices);
            this.grpTotal.Location = new System.Drawing.Point(4, 172);
            this.grpTotal.Margin = new System.Windows.Forms.Padding(4);
            this.grpTotal.Name = "grpTotal";
            this.grpTotal.Padding = new System.Windows.Forms.Padding(4);
            this.grpTotal.Size = new System.Drawing.Size(268, 134);
            this.grpTotal.TabIndex = 63;
            this.grpTotal.TabStop = false;
            this.grpTotal.Text = "Total";
            // 
            // rtbTotal
            // 
            this.rtbTotal.Location = new System.Drawing.Point(8, 21);
            this.rtbTotal.Name = "rtbTotal";
            this.rtbTotal.Size = new System.Drawing.Size(253, 47);
            this.rtbTotal.TabIndex = 5;
            this.rtbTotal.Text = "";
            // 
            // lblServices
            // 
            this.lblServices.AutoSize = true;
            this.lblServices.Location = new System.Drawing.Point(11, 79);
            this.lblServices.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServices.Name = "lblServices";
            this.lblServices.Size = new System.Drawing.Size(48, 13);
            this.lblServices.TabIndex = 32;
            this.lblServices.Text = "Services";
            // 
            // cmbServices
            // 
            this.cmbServices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServices.FormattingEnabled = true;
            this.cmbServices.Location = new System.Drawing.Point(11, 98);
            this.cmbServices.Name = "cmbServices";
            this.cmbServices.Size = new System.Drawing.Size(143, 21);
            this.cmbServices.TabIndex = 6;
            // 
            // txtCheckInDate
            // 
            this.txtCheckInDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCheckInDate.Location = new System.Drawing.Point(11, 48);
            this.txtCheckInDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtCheckInDate.Name = "txtCheckInDate";
            this.txtCheckInDate.Size = new System.Drawing.Size(175, 20);
            this.txtCheckInDate.TabIndex = 7;
            // 
            // dtpCheckOutDate
            // 
            this.dtpCheckOutDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckOutDate.Location = new System.Drawing.Point(11, 99);
            this.dtpCheckOutDate.Name = "dtpCheckOutDate";
            this.dtpCheckOutDate.Size = new System.Drawing.Size(175, 20);
            this.dtpCheckOutDate.TabIndex = 8;
            // 
            // lblCheckOutDate
            // 
            this.lblCheckOutDate.AutoSize = true;
            this.lblCheckOutDate.Location = new System.Drawing.Point(8, 83);
            this.lblCheckOutDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCheckOutDate.Name = "lblCheckOutDate";
            this.lblCheckOutDate.Size = new System.Drawing.Size(84, 13);
            this.lblCheckOutDate.TabIndex = 34;
            this.lblCheckOutDate.Text = "Check-Out Date";
            // 
            // lblCheckInDate
            // 
            this.lblCheckInDate.AutoSize = true;
            this.lblCheckInDate.Location = new System.Drawing.Point(8, 31);
            this.lblCheckInDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCheckInDate.Name = "lblCheckInDate";
            this.lblCheckInDate.Size = new System.Drawing.Size(76, 13);
            this.lblCheckInDate.TabIndex = 32;
            this.lblCheckInDate.Text = "Check-In Date";
            // 
            // grpServices
            // 
            this.grpServices.Controls.Add(this.dtpCheckOutDate);
            this.grpServices.Controls.Add(this.txtCheckInDate);
            this.grpServices.Controls.Add(this.lblCheckOutDate);
            this.grpServices.Controls.Add(this.lblCheckInDate);
            this.grpServices.Location = new System.Drawing.Point(280, 172);
            this.grpServices.Margin = new System.Windows.Forms.Padding(4);
            this.grpServices.Name = "grpServices";
            this.grpServices.Padding = new System.Windows.Forms.Padding(4);
            this.grpServices.Size = new System.Drawing.Size(258, 136);
            this.grpServices.TabIndex = 62;
            this.grpServices.TabStop = false;
            this.grpServices.Text = "Services";
            // 
            // grpPersonalData
            // 
            this.grpPersonalData.Controls.Add(this.cmbRoomNumber);
            this.grpPersonalData.Controls.Add(this.lblPhone);
            this.grpPersonalData.Controls.Add(this.txtPhone);
            this.grpPersonalData.Controls.Add(this.lblEmail);
            this.grpPersonalData.Controls.Add(this.lblRoomNumber);
            this.grpPersonalData.Controls.Add(this.txtEmail);
            this.grpPersonalData.Controls.Add(this.lblName);
            this.grpPersonalData.Controls.Add(this.txtName);
            this.grpPersonalData.Location = new System.Drawing.Point(4, 29);
            this.grpPersonalData.Margin = new System.Windows.Forms.Padding(4);
            this.grpPersonalData.Name = "grpPersonalData";
            this.grpPersonalData.Padding = new System.Windows.Forms.Padding(4);
            this.grpPersonalData.Size = new System.Drawing.Size(534, 135);
            this.grpPersonalData.TabIndex = 61;
            this.grpPersonalData.TabStop = false;
            this.grpPersonalData.Text = "Personal Data";
            // 
            // cmbRoomNumber
            // 
            this.cmbRoomNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoomNumber.FormattingEnabled = true;
            this.cmbRoomNumber.Location = new System.Drawing.Point(11, 46);
            this.cmbRoomNumber.Name = "cmbRoomNumber";
            this.cmbRoomNumber.Size = new System.Drawing.Size(175, 21);
            this.cmbRoomNumber.TabIndex = 1;
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
            // lblRoomNumber
            // 
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.Location = new System.Drawing.Point(11, 26);
            this.lblRoomNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(75, 13);
            this.lblRoomNumber.TabIndex = 24;
            this.lblRoomNumber.Text = "Room Number";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Location = new System.Drawing.Point(194, 99);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(318, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(191, 26);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 28;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(194, 46);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(318, 20);
            this.txtName.TabIndex = 2;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.Location = new System.Drawing.Point(189, 327);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(175, 36);
            this.btnCheckOut.TabIndex = 9;
            this.btnCheckOut.Text = "Check-Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // frmBookedRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.grpTotal);
            this.Controls.Add(this.grpServices);
            this.Controls.Add(this.grpPersonalData);
            this.Controls.Add(this.tlsMain);
            this.Name = "frmBookedRooms";
            this.Size = new System.Drawing.Size(568, 387);
            this.tlsMain.ResumeLayout(false);
            this.tlsMain.PerformLayout();
            this.grpTotal.ResumeLayout(false);
            this.grpTotal.PerformLayout();
            this.grpServices.ResumeLayout(false);
            this.grpServices.PerformLayout();
            this.grpPersonalData.ResumeLayout(false);
            this.grpPersonalData.PerformLayout();
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
        private System.Windows.Forms.GroupBox grpTotal;
        private System.Windows.Forms.DateTimePicker dtpCheckOutDate;
        private System.Windows.Forms.Label lblCheckInDate;
        private System.Windows.Forms.Label lblCheckOutDate;
        private System.Windows.Forms.GroupBox grpServices;
        private System.Windows.Forms.Label lblServices;
        private System.Windows.Forms.GroupBox grpPersonalData;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbRoomNumber;
        private System.Windows.Forms.TextBox txtCheckInDate;
        private System.Windows.Forms.ComboBox cmbServices;
        private System.Windows.Forms.RichTextBox rtbTotal;
        private System.Windows.Forms.Button btnCheckOut;
    }
}
