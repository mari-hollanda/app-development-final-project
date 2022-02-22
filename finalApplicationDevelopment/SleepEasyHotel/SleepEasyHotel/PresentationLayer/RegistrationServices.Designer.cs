
namespace SleepEasyHotel.PresentationLayer
{
    partial class RegistrationServices
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
            this.tbMenu = new System.Windows.Forms.TabControl();
            this.tbRegistration = new System.Windows.Forms.TabPage();
            this.dtpCheckInDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbRoomAvailable = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.tbBookedRooms = new System.Windows.Forms.TabPage();
            this.rtbBookedTotal = new System.Windows.Forms.RichTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cmbBookedServices = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtTestCheckOut = new System.Windows.Forms.TextBox();
            this.txtBookedEmail = new System.Windows.Forms.TextBox();
            this.txtBookedPhone = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpBookedCheckOutDate = new System.Windows.Forms.DateTimePicker();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.txtBookedName = new System.Windows.Forms.TextBox();
            this.cmbBookedRoom = new System.Windows.Forms.ComboBox();
            this.txtBookedCheckInDate = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbMenu.SuspendLayout();
            this.tbRegistration.SuspendLayout();
            this.tbBookedRooms.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbMenu
            // 
            this.tbMenu.Controls.Add(this.tbRegistration);
            this.tbMenu.Controls.Add(this.tbBookedRooms);
            this.tbMenu.Location = new System.Drawing.Point(8, 8);
            this.tbMenu.Name = "tbMenu";
            this.tbMenu.SelectedIndex = 0;
            this.tbMenu.Size = new System.Drawing.Size(780, 532);
            this.tbMenu.TabIndex = 1;
            // 
            // tbRegistration
            // 
            this.tbRegistration.Controls.Add(this.dtpCheckInDate);
            this.tbRegistration.Controls.Add(this.label11);
            this.tbRegistration.Controls.Add(this.txtEmail);
            this.tbRegistration.Controls.Add(this.txtPhone);
            this.tbRegistration.Controls.Add(this.txtFirstName);
            this.tbRegistration.Controls.Add(this.txtLastName);
            this.tbRegistration.Controls.Add(this.txtStreet);
            this.tbRegistration.Controls.Add(this.txtCity);
            this.tbRegistration.Controls.Add(this.txtState);
            this.tbRegistration.Controls.Add(this.txtZip);
            this.tbRegistration.Controls.Add(this.label9);
            this.tbRegistration.Controls.Add(this.cmbRoomAvailable);
            this.tbRegistration.Controls.Add(this.label8);
            this.tbRegistration.Controls.Add(this.label7);
            this.tbRegistration.Controls.Add(this.label6);
            this.tbRegistration.Controls.Add(this.label5);
            this.tbRegistration.Controls.Add(this.label4);
            this.tbRegistration.Controls.Add(this.label3);
            this.tbRegistration.Controls.Add(this.label2);
            this.tbRegistration.Controls.Add(this.label1);
            this.tbRegistration.Controls.Add(this.btnRegister);
            this.tbRegistration.Location = new System.Drawing.Point(4, 22);
            this.tbRegistration.Name = "tbRegistration";
            this.tbRegistration.Padding = new System.Windows.Forms.Padding(3);
            this.tbRegistration.Size = new System.Drawing.Size(772, 506);
            this.tbRegistration.TabIndex = 0;
            this.tbRegistration.Text = "Registration";
            this.tbRegistration.UseVisualStyleBackColor = true;
            // 
            // dtpCheckInDate
            // 
            this.dtpCheckInDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckInDate.Location = new System.Drawing.Point(204, 308);
            this.dtpCheckInDate.Name = "dtpCheckInDate";
            this.dtpCheckInDate.Size = new System.Drawing.Size(200, 20);
            this.dtpCheckInDate.TabIndex = 10;
            this.dtpCheckInDate.Value = new System.DateTime(2022, 2, 22, 0, 0, 0, 0);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(68, 314);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Check In Date";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(204, 240);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(186, 20);
            this.txtEmail.TabIndex = 8;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(204, 203);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(186, 20);
            this.txtPhone.TabIndex = 7;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(204, 29);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(186, 20);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(204, 56);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(186, 20);
            this.txtLastName.TabIndex = 2;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(204, 87);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(186, 20);
            this.txtStreet.TabIndex = 3;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(204, 113);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(186, 20);
            this.txtCity.TabIndex = 4;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(204, 144);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(186, 20);
            this.txtState.TabIndex = 5;
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(204, 173);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(186, 20);
            this.txtZip.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(68, 278);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Room Available";
            // 
            // cmbRoomAvailable
            // 
            this.cmbRoomAvailable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoomAvailable.FormattingEnabled = true;
            this.cmbRoomAvailable.Location = new System.Drawing.Point(206, 271);
            this.cmbRoomAvailable.Name = "cmbRoomAvailable";
            this.cmbRoomAvailable.Size = new System.Drawing.Size(121, 21);
            this.cmbRoomAvailable.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(68, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Zip";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "State";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ciry";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Street";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(389, 422);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 11;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // tbBookedRooms
            // 
            this.tbBookedRooms.Controls.Add(this.rtbBookedTotal);
            this.tbBookedRooms.Controls.Add(this.label18);
            this.tbBookedRooms.Controls.Add(this.cmbBookedServices);
            this.tbBookedRooms.Controls.Add(this.label17);
            this.tbBookedRooms.Controls.Add(this.txtTestCheckOut);
            this.tbBookedRooms.Controls.Add(this.txtBookedEmail);
            this.tbBookedRooms.Controls.Add(this.txtBookedPhone);
            this.tbBookedRooms.Controls.Add(this.label16);
            this.tbBookedRooms.Controls.Add(this.label15);
            this.tbBookedRooms.Controls.Add(this.label14);
            this.tbBookedRooms.Controls.Add(this.dtpBookedCheckOutDate);
            this.tbBookedRooms.Controls.Add(this.btnCheckOut);
            this.tbBookedRooms.Controls.Add(this.txtBookedName);
            this.tbBookedRooms.Controls.Add(this.cmbBookedRoom);
            this.tbBookedRooms.Controls.Add(this.txtBookedCheckInDate);
            this.tbBookedRooms.Controls.Add(this.label13);
            this.tbBookedRooms.Controls.Add(this.label12);
            this.tbBookedRooms.Controls.Add(this.label10);
            this.tbBookedRooms.Location = new System.Drawing.Point(4, 22);
            this.tbBookedRooms.Name = "tbBookedRooms";
            this.tbBookedRooms.Padding = new System.Windows.Forms.Padding(3);
            this.tbBookedRooms.Size = new System.Drawing.Size(772, 506);
            this.tbBookedRooms.TabIndex = 1;
            this.tbBookedRooms.Text = "Booked Rooms";
            this.tbBookedRooms.UseVisualStyleBackColor = true;
            // 
            // rtbBookedTotal
            // 
            this.rtbBookedTotal.Location = new System.Drawing.Point(111, 351);
            this.rtbBookedTotal.Name = "rtbBookedTotal";
            this.rtbBookedTotal.ReadOnly = true;
            this.rtbBookedTotal.Size = new System.Drawing.Size(277, 137);
            this.rtbBookedTotal.TabIndex = 19;
            this.rtbBookedTotal.Text = "";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(42, 363);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(31, 13);
            this.label18.TabIndex = 18;
            this.label18.Text = "Total";
            // 
            // cmbBookedServices
            // 
            this.cmbBookedServices.FormattingEnabled = true;
            this.cmbBookedServices.Location = new System.Drawing.Point(166, 298);
            this.cmbBookedServices.Name = "cmbBookedServices";
            this.cmbBookedServices.Size = new System.Drawing.Size(206, 21);
            this.cmbBookedServices.TabIndex = 17;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(42, 301);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 13);
            this.label17.TabIndex = 16;
            this.label17.Text = "Services";
            // 
            // txtTestCheckOut
            // 
            this.txtTestCheckOut.Location = new System.Drawing.Point(523, 413);
            this.txtTestCheckOut.Name = "txtTestCheckOut";
            this.txtTestCheckOut.Size = new System.Drawing.Size(100, 20);
            this.txtTestCheckOut.TabIndex = 15;
            // 
            // txtBookedEmail
            // 
            this.txtBookedEmail.Location = new System.Drawing.Point(166, 206);
            this.txtBookedEmail.Name = "txtBookedEmail";
            this.txtBookedEmail.Size = new System.Drawing.Size(206, 20);
            this.txtBookedEmail.TabIndex = 14;
            // 
            // txtBookedPhone
            // 
            this.txtBookedPhone.Location = new System.Drawing.Point(166, 248);
            this.txtBookedPhone.Name = "txtBookedPhone";
            this.txtBookedPhone.Size = new System.Drawing.Size(206, 20);
            this.txtBookedPhone.TabIndex = 13;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(42, 248);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 13);
            this.label16.TabIndex = 12;
            this.label16.Text = "Phone";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(42, 206);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 13);
            this.label15.TabIndex = 11;
            this.label15.Text = "Email";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(457, 168);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "Check Out Date";
            // 
            // dtpBookedCheckOutDate
            // 
            this.dtpBookedCheckOutDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBookedCheckOutDate.Location = new System.Drawing.Point(566, 162);
            this.dtpBookedCheckOutDate.Name = "dtpBookedCheckOutDate";
            this.dtpBookedCheckOutDate.Size = new System.Drawing.Size(200, 20);
            this.dtpBookedCheckOutDate.TabIndex = 9;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(598, 232);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(116, 50);
            this.btnCheckOut.TabIndex = 8;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // txtBookedName
            // 
            this.txtBookedName.Location = new System.Drawing.Point(166, 117);
            this.txtBookedName.Name = "txtBookedName";
            this.txtBookedName.ReadOnly = true;
            this.txtBookedName.Size = new System.Drawing.Size(206, 20);
            this.txtBookedName.TabIndex = 7;
            // 
            // cmbBookedRoom
            // 
            this.cmbBookedRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBookedRoom.FormattingEnabled = true;
            this.cmbBookedRoom.Location = new System.Drawing.Point(166, 55);
            this.cmbBookedRoom.Name = "cmbBookedRoom";
            this.cmbBookedRoom.Size = new System.Drawing.Size(206, 21);
            this.cmbBookedRoom.TabIndex = 6;
            this.cmbBookedRoom.SelectedIndexChanged += new System.EventHandler(this.cmbBookedRoom_SelectedIndexChanged);
            // 
            // txtBookedCheckInDate
            // 
            this.txtBookedCheckInDate.Location = new System.Drawing.Point(166, 162);
            this.txtBookedCheckInDate.Name = "txtBookedCheckInDate";
            this.txtBookedCheckInDate.ReadOnly = true;
            this.txtBookedCheckInDate.Size = new System.Drawing.Size(206, 20);
            this.txtBookedCheckInDate.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(42, 165);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "CheckIn Date";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(42, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Room Number";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(42, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Name";
            // 
            // RegistrationServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 552);
            this.Controls.Add(this.tbMenu);
            this.Name = "RegistrationServices";
            this.Text = "RegistrationServices";
            this.Load += new System.EventHandler(this.RegistrationServices_Load);
            this.tbMenu.ResumeLayout(false);
            this.tbRegistration.ResumeLayout(false);
            this.tbRegistration.PerformLayout();
            this.tbBookedRooms.ResumeLayout(false);
            this.tbBookedRooms.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbMenu;
        private System.Windows.Forms.TabPage tbRegistration;
        private System.Windows.Forms.DateTimePicker dtpCheckInDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbRoomAvailable;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TabPage tbBookedRooms;
        private System.Windows.Forms.ComboBox cmbBookedRoom;
        private System.Windows.Forms.TextBox txtBookedCheckInDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBookedName;
        private System.Windows.Forms.TextBox txtBookedEmail;
        private System.Windows.Forms.TextBox txtBookedPhone;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtpBookedCheckOutDate;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.TextBox txtTestCheckOut;
        private System.Windows.Forms.RichTextBox rtbBookedTotal;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cmbBookedServices;
        private System.Windows.Forms.Label label17;
    }
}