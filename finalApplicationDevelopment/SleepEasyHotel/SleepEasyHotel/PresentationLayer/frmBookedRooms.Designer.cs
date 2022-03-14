
namespace SleepEasyHotel.PresentationLayer
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
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.grpTotal = new System.Windows.Forms.GroupBox();
            this.btnService = new System.Windows.Forms.Button();
            this.lblServices = new System.Windows.Forms.Label();
            this.cmbServices = new System.Windows.Forms.ComboBox();
            this.rtbTotal = new System.Windows.Forms.RichTextBox();
            this.grpServices = new System.Windows.Forms.GroupBox();
            this.dtpCheckOutDate = new System.Windows.Forms.DateTimePicker();
            this.txtCheckInDate = new System.Windows.Forms.TextBox();
            this.lblCheckOutDate = new System.Windows.Forms.Label();
            this.lblCheckInDate = new System.Windows.Forms.Label();
            this.grpPersonalData = new System.Windows.Forms.GroupBox();
            this.lblGuestID = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.cmbRoomNumber = new System.Windows.Forms.ComboBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.grpTotal.SuspendLayout();
            this.grpServices.SuspendLayout();
            this.grpPersonalData.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnCheckOut.Location = new System.Drawing.Point(41, 343);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(175, 36);
            this.btnCheckOut.TabIndex = 64;
            this.btnCheckOut.Text = "Check-Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // grpTotal
            // 
            this.grpTotal.Controls.Add(this.btnService);
            this.grpTotal.Controls.Add(this.lblServices);
            this.grpTotal.Controls.Add(this.cmbServices);
            this.grpTotal.Location = new System.Drawing.Point(30, 186);
            this.grpTotal.Margin = new System.Windows.Forms.Padding(4);
            this.grpTotal.Name = "grpTotal";
            this.grpTotal.Padding = new System.Windows.Forms.Padding(4);
            this.grpTotal.Size = new System.Drawing.Size(268, 134);
            this.grpTotal.TabIndex = 67;
            this.grpTotal.TabStop = false;
            this.grpTotal.Text = "Total";
            // 
            // btnService
            // 
            this.btnService.Location = new System.Drawing.Point(86, 78);
            this.btnService.Name = "btnService";
            this.btnService.Size = new System.Drawing.Size(75, 23);
            this.btnService.TabIndex = 33;
            this.btnService.Text = "Add Service";
            this.btnService.UseVisualStyleBackColor = true;
            this.btnService.Click += new System.EventHandler(this.btnService_Click);
            // 
            // lblServices
            // 
            this.lblServices.AutoSize = true;
            this.lblServices.Location = new System.Drawing.Point(23, 39);
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
            this.cmbServices.Location = new System.Drawing.Point(95, 31);
            this.cmbServices.Name = "cmbServices";
            this.cmbServices.Size = new System.Drawing.Size(143, 21);
            this.cmbServices.TabIndex = 6;
            // 
            // rtbTotal
            // 
            this.rtbTotal.Location = new System.Drawing.Point(571, 53);
            this.rtbTotal.Name = "rtbTotal";
            this.rtbTotal.Size = new System.Drawing.Size(186, 267);
            this.rtbTotal.TabIndex = 5;
            this.rtbTotal.Text = "";
            // 
            // grpServices
            // 
            this.grpServices.Controls.Add(this.dtpCheckOutDate);
            this.grpServices.Controls.Add(this.txtCheckInDate);
            this.grpServices.Controls.Add(this.lblCheckOutDate);
            this.grpServices.Controls.Add(this.lblCheckInDate);
            this.grpServices.Location = new System.Drawing.Point(306, 186);
            this.grpServices.Margin = new System.Windows.Forms.Padding(4);
            this.grpServices.Name = "grpServices";
            this.grpServices.Padding = new System.Windows.Forms.Padding(4);
            this.grpServices.Size = new System.Drawing.Size(258, 136);
            this.grpServices.TabIndex = 66;
            this.grpServices.TabStop = false;
            this.grpServices.Text = "Services";
            // 
            // dtpCheckOutDate
            // 
            this.dtpCheckOutDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckOutDate.Location = new System.Drawing.Point(11, 99);
            this.dtpCheckOutDate.Name = "dtpCheckOutDate";
            this.dtpCheckOutDate.Size = new System.Drawing.Size(175, 20);
            this.dtpCheckOutDate.TabIndex = 8;
            this.dtpCheckOutDate.ValueChanged += new System.EventHandler(this.dtpCheckOutDate_ValueChanged);
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
            // grpPersonalData
            // 
            this.grpPersonalData.Controls.Add(this.lblGuestID);
            this.grpPersonalData.Controls.Add(this.txtLastName);
            this.grpPersonalData.Controls.Add(this.lblLastName);
            this.grpPersonalData.Controls.Add(this.cmbRoomNumber);
            this.grpPersonalData.Controls.Add(this.lblPhone);
            this.grpPersonalData.Controls.Add(this.txtPhone);
            this.grpPersonalData.Controls.Add(this.lblEmail);
            this.grpPersonalData.Controls.Add(this.lblRoomNumber);
            this.grpPersonalData.Controls.Add(this.txtEmail);
            this.grpPersonalData.Controls.Add(this.lblName);
            this.grpPersonalData.Controls.Add(this.txtFirstName);
            this.grpPersonalData.Location = new System.Drawing.Point(30, 43);
            this.grpPersonalData.Margin = new System.Windows.Forms.Padding(4);
            this.grpPersonalData.Name = "grpPersonalData";
            this.grpPersonalData.Padding = new System.Windows.Forms.Padding(4);
            this.grpPersonalData.Size = new System.Drawing.Size(534, 135);
            this.grpPersonalData.TabIndex = 65;
            this.grpPersonalData.TabStop = false;
            this.grpPersonalData.Text = "Personal Data";
            // 
            // lblGuestID
            // 
            this.lblGuestID.AutoSize = true;
            this.lblGuestID.Location = new System.Drawing.Point(450, 99);
            this.lblGuestID.Name = "lblGuestID";
            this.lblGuestID.Size = new System.Drawing.Size(46, 13);
            this.lblGuestID.TabIndex = 49;
            this.lblGuestID.Text = "GuestID";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(352, 47);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(160, 20);
            this.txtLastName.TabIndex = 48;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(349, 26);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 47;
            this.lblLastName.Text = "Last Name";
            // 
            // cmbRoomNumber
            // 
            this.cmbRoomNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoomNumber.FormattingEnabled = true;
            this.cmbRoomNumber.Location = new System.Drawing.Point(11, 46);
            this.cmbRoomNumber.Name = "cmbRoomNumber";
            this.cmbRoomNumber.Size = new System.Drawing.Size(175, 21);
            this.cmbRoomNumber.TabIndex = 1;
            this.cmbRoomNumber.SelectedIndexChanged += new System.EventHandler(this.cmbRoomNumber_SelectedIndexChanged);
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
            this.txtEmail.Size = new System.Drawing.Size(234, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(191, 26);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(57, 13);
            this.lblName.TabIndex = 28;
            this.lblName.Text = "First Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFirstName.Location = new System.Drawing.Point(194, 46);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(128, 20);
            this.txtFirstName.TabIndex = 2;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(235, 343);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(163, 36);
            this.btnUpdate.TabIndex = 34;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(602, 326);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(125, 29);
            this.btnClear.TabIndex = 68;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(437, 347);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(105, 29);
            this.btnRefresh.TabIndex = 69;
            this.btnRefresh.Text = "Refresh Page";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmBookedRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.rtbTotal);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.grpTotal);
            this.Controls.Add(this.grpServices);
            this.Controls.Add(this.grpPersonalData);
            this.Name = "frmBookedRooms";
            this.Size = new System.Drawing.Size(775, 443);
            this.Load += new System.EventHandler(this.frmBookedRooms_Load);
            this.grpTotal.ResumeLayout(false);
            this.grpTotal.PerformLayout();
            this.grpServices.ResumeLayout(false);
            this.grpServices.PerformLayout();
            this.grpPersonalData.ResumeLayout(false);
            this.grpPersonalData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.GroupBox grpTotal;
        private System.Windows.Forms.RichTextBox rtbTotal;
        private System.Windows.Forms.Label lblServices;
        private System.Windows.Forms.ComboBox cmbServices;
        private System.Windows.Forms.GroupBox grpServices;
        private System.Windows.Forms.DateTimePicker dtpCheckOutDate;
        private System.Windows.Forms.TextBox txtCheckInDate;
        private System.Windows.Forms.Label lblCheckOutDate;
        private System.Windows.Forms.Label lblCheckInDate;
        private System.Windows.Forms.GroupBox grpPersonalData;
        private System.Windows.Forms.ComboBox cmbRoomNumber;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Button btnService;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblGuestID;
        private System.Windows.Forms.Button btnRefresh;
    }
}
