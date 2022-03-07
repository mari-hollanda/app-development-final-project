namespace SleepEasyHotel.PresentationLayer
{
    partial class staffServices
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
            this.tbStaff = new System.Windows.Forms.TabControl();
            this.tbCreateStaff = new System.Windows.Forms.TabPage();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblPID = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.cmbPID = new System.Windows.Forms.ComboBox();
            this.txtTtile = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.tbUpdateStaff = new System.Windows.Forms.TabPage();
            this.lblStaffIDtoUpdate = new System.Windows.Forms.Label();
            this.lblStaffIDUpdateSelect = new System.Windows.Forms.Label();
            this.lblSelectionUpdate = new System.Windows.Forms.Label();
            this.txtUpdateFirstName = new System.Windows.Forms.TextBox();
            this.lblUpdateTitle = new System.Windows.Forms.Label();
            this.lblUpdateEmail = new System.Windows.Forms.Label();
            this.lblUpdatePhoneNumber = new System.Windows.Forms.Label();
            this.lblUpdatePID = new System.Windows.Forms.Label();
            this.lblUpdateLname = new System.Windows.Forms.Label();
            this.lblUpdateFname = new System.Windows.Forms.Label();
            this.btnUpdateStaff = new System.Windows.Forms.Button();
            this.txtUpdateTitle = new System.Windows.Forms.TextBox();
            this.txtUpdateEmail = new System.Windows.Forms.TextBox();
            this.cmbUpdatePID = new System.Windows.Forms.ComboBox();
            this.txtUpdatePhoneNumber = new System.Windows.Forms.TextBox();
            this.txtUpdateLname = new System.Windows.Forms.TextBox();
            this.cmbUpdateFname = new System.Windows.Forms.ComboBox();
            this.tbStaff.SuspendLayout();
            this.tbCreateStaff.SuspendLayout();
            this.tbUpdateStaff.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbStaff
            // 
            this.tbStaff.Controls.Add(this.tbCreateStaff);
            this.tbStaff.Controls.Add(this.tbUpdateStaff);
            this.tbStaff.Location = new System.Drawing.Point(2, 32);
            this.tbStaff.Name = "tbStaff";
            this.tbStaff.SelectedIndex = 0;
            this.tbStaff.Size = new System.Drawing.Size(797, 415);
            this.tbStaff.TabIndex = 0;
            // 
            // tbCreateStaff
            // 
            this.tbCreateStaff.Controls.Add(this.lblTitle);
            this.tbCreateStaff.Controls.Add(this.lblEmail);
            this.tbCreateStaff.Controls.Add(this.lblPhoneNumber);
            this.tbCreateStaff.Controls.Add(this.lblPID);
            this.tbCreateStaff.Controls.Add(this.lblLastName);
            this.tbCreateStaff.Controls.Add(this.lblFirstName);
            this.tbCreateStaff.Controls.Add(this.btnRegister);
            this.tbCreateStaff.Controls.Add(this.cmbPID);
            this.tbCreateStaff.Controls.Add(this.txtTtile);
            this.tbCreateStaff.Controls.Add(this.txtEmail);
            this.tbCreateStaff.Controls.Add(this.txtPhoneNumber);
            this.tbCreateStaff.Controls.Add(this.txtLname);
            this.tbCreateStaff.Controls.Add(this.txtFname);
            this.tbCreateStaff.Location = new System.Drawing.Point(4, 22);
            this.tbCreateStaff.Name = "tbCreateStaff";
            this.tbCreateStaff.Padding = new System.Windows.Forms.Padding(3);
            this.tbCreateStaff.Size = new System.Drawing.Size(789, 389);
            this.tbCreateStaff.TabIndex = 0;
            this.tbCreateStaff.Text = "Add Staff";
            this.tbCreateStaff.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(92, 275);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(36, 13);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Title : ";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(91, 232);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 13);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "Email : ";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(92, 190);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(84, 13);
            this.lblPhoneNumber.TabIndex = 10;
            this.lblPhoneNumber.Text = "PhoneNumber : ";
            // 
            // lblPID
            // 
            this.lblPID.AutoSize = true;
            this.lblPID.Location = new System.Drawing.Point(92, 151);
            this.lblPID.Name = "lblPID";
            this.lblPID.Size = new System.Drawing.Size(55, 13);
            this.lblPID.TabIndex = 9;
            this.lblPID.Text = "PositionID";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(91, 108);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(67, 13);
            this.lblLastName.TabIndex = 8;
            this.lblLastName.Text = "Last Name : ";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(92, 61);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(66, 13);
            this.lblFirstName.TabIndex = 7;
            this.lblFirstName.Text = "First Name : ";
            this.lblFirstName.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(253, 327);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(107, 37);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // cmbPID
            // 
            this.cmbPID.FormattingEnabled = true;
            this.cmbPID.Location = new System.Drawing.Point(297, 151);
            this.cmbPID.Name = "cmbPID";
            this.cmbPID.Size = new System.Drawing.Size(160, 21);
            this.cmbPID.TabIndex = 5;
            // 
            // txtTtile
            // 
            this.txtTtile.Location = new System.Drawing.Point(297, 275);
            this.txtTtile.Name = "txtTtile";
            this.txtTtile.Size = new System.Drawing.Size(160, 20);
            this.txtTtile.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(297, 232);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(160, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(297, 190);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(160, 20);
            this.txtPhoneNumber.TabIndex = 2;
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(297, 108);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(160, 20);
            this.txtLname.TabIndex = 1;
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(297, 61);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(160, 20);
            this.txtFname.TabIndex = 0;
            // 
            // tbUpdateStaff
            // 
            this.tbUpdateStaff.Controls.Add(this.lblStaffIDtoUpdate);
            this.tbUpdateStaff.Controls.Add(this.lblStaffIDUpdateSelect);
            this.tbUpdateStaff.Controls.Add(this.lblSelectionUpdate);
            this.tbUpdateStaff.Controls.Add(this.txtUpdateFirstName);
            this.tbUpdateStaff.Controls.Add(this.lblUpdateTitle);
            this.tbUpdateStaff.Controls.Add(this.lblUpdateEmail);
            this.tbUpdateStaff.Controls.Add(this.lblUpdatePhoneNumber);
            this.tbUpdateStaff.Controls.Add(this.lblUpdatePID);
            this.tbUpdateStaff.Controls.Add(this.lblUpdateLname);
            this.tbUpdateStaff.Controls.Add(this.lblUpdateFname);
            this.tbUpdateStaff.Controls.Add(this.btnUpdateStaff);
            this.tbUpdateStaff.Controls.Add(this.txtUpdateTitle);
            this.tbUpdateStaff.Controls.Add(this.txtUpdateEmail);
            this.tbUpdateStaff.Controls.Add(this.cmbUpdatePID);
            this.tbUpdateStaff.Controls.Add(this.txtUpdatePhoneNumber);
            this.tbUpdateStaff.Controls.Add(this.txtUpdateLname);
            this.tbUpdateStaff.Controls.Add(this.cmbUpdateFname);
            this.tbUpdateStaff.Location = new System.Drawing.Point(4, 22);
            this.tbUpdateStaff.Name = "tbUpdateStaff";
            this.tbUpdateStaff.Padding = new System.Windows.Forms.Padding(3);
            this.tbUpdateStaff.Size = new System.Drawing.Size(789, 389);
            this.tbUpdateStaff.TabIndex = 1;
            this.tbUpdateStaff.Text = "Update Staff";
            this.tbUpdateStaff.UseVisualStyleBackColor = true;
            // 
            // lblStaffIDtoUpdate
            // 
            this.lblStaffIDtoUpdate.AutoSize = true;
            this.lblStaffIDtoUpdate.Location = new System.Drawing.Point(488, 46);
            this.lblStaffIDtoUpdate.Name = "lblStaffIDtoUpdate";
            this.lblStaffIDtoUpdate.Size = new System.Drawing.Size(0, 13);
            this.lblStaffIDtoUpdate.TabIndex = 16;
            // 
            // lblStaffIDUpdateSelect
            // 
            this.lblStaffIDUpdateSelect.AutoSize = true;
            this.lblStaffIDUpdateSelect.Location = new System.Drawing.Point(430, 46);
            this.lblStaffIDUpdateSelect.Name = "lblStaffIDUpdateSelect";
            this.lblStaffIDUpdateSelect.Size = new System.Drawing.Size(52, 13);
            this.lblStaffIDUpdateSelect.TabIndex = 15;
            this.lblStaffIDUpdateSelect.Text = "Staff ID : ";
            // 
            // lblSelectionUpdate
            // 
            this.lblSelectionUpdate.AutoSize = true;
            this.lblSelectionUpdate.Location = new System.Drawing.Point(83, 46);
            this.lblSelectionUpdate.Name = "lblSelectionUpdate";
            this.lblSelectionUpdate.Size = new System.Drawing.Size(46, 13);
            this.lblSelectionUpdate.TabIndex = 14;
            this.lblSelectionUpdate.Text = "Select : ";
            // 
            // txtUpdateFirstName
            // 
            this.txtUpdateFirstName.Location = new System.Drawing.Point(270, 88);
            this.txtUpdateFirstName.Name = "txtUpdateFirstName";
            this.txtUpdateFirstName.Size = new System.Drawing.Size(134, 20);
            this.txtUpdateFirstName.TabIndex = 13;
            // 
            // lblUpdateTitle
            // 
            this.lblUpdateTitle.AutoSize = true;
            this.lblUpdateTitle.Location = new System.Drawing.Point(87, 293);
            this.lblUpdateTitle.Name = "lblUpdateTitle";
            this.lblUpdateTitle.Size = new System.Drawing.Size(36, 13);
            this.lblUpdateTitle.TabIndex = 12;
            this.lblUpdateTitle.Text = "Title : ";
            // 
            // lblUpdateEmail
            // 
            this.lblUpdateEmail.AutoSize = true;
            this.lblUpdateEmail.Location = new System.Drawing.Point(87, 245);
            this.lblUpdateEmail.Name = "lblUpdateEmail";
            this.lblUpdateEmail.Size = new System.Drawing.Size(41, 13);
            this.lblUpdateEmail.TabIndex = 11;
            this.lblUpdateEmail.Text = "Email : ";
            // 
            // lblUpdatePhoneNumber
            // 
            this.lblUpdatePhoneNumber.AutoSize = true;
            this.lblUpdatePhoneNumber.Location = new System.Drawing.Point(87, 208);
            this.lblUpdatePhoneNumber.Name = "lblUpdatePhoneNumber";
            this.lblUpdatePhoneNumber.Size = new System.Drawing.Size(87, 13);
            this.lblUpdatePhoneNumber.TabIndex = 10;
            this.lblUpdatePhoneNumber.Text = "Phone Number : ";
            // 
            // lblUpdatePID
            // 
            this.lblUpdatePID.AutoSize = true;
            this.lblUpdatePID.Location = new System.Drawing.Point(83, 166);
            this.lblUpdatePID.Name = "lblUpdatePID";
            this.lblUpdatePID.Size = new System.Drawing.Size(67, 13);
            this.lblUpdatePID.TabIndex = 9;
            this.lblUpdatePID.Text = "Position ID : ";
            // 
            // lblUpdateLname
            // 
            this.lblUpdateLname.AutoSize = true;
            this.lblUpdateLname.Location = new System.Drawing.Point(83, 126);
            this.lblUpdateLname.Name = "lblUpdateLname";
            this.lblUpdateLname.Size = new System.Drawing.Size(67, 13);
            this.lblUpdateLname.TabIndex = 8;
            this.lblUpdateLname.Text = "Last Name : ";
            // 
            // lblUpdateFname
            // 
            this.lblUpdateFname.AutoSize = true;
            this.lblUpdateFname.Location = new System.Drawing.Point(83, 88);
            this.lblUpdateFname.Name = "lblUpdateFname";
            this.lblUpdateFname.Size = new System.Drawing.Size(66, 13);
            this.lblUpdateFname.TabIndex = 7;
            this.lblUpdateFname.Text = "First Name : ";
            // 
            // btnUpdateStaff
            // 
            this.btnUpdateStaff.Location = new System.Drawing.Point(224, 341);
            this.btnUpdateStaff.Name = "btnUpdateStaff";
            this.btnUpdateStaff.Size = new System.Drawing.Size(98, 29);
            this.btnUpdateStaff.TabIndex = 6;
            this.btnUpdateStaff.Text = "Update";
            this.btnUpdateStaff.UseVisualStyleBackColor = true;
            this.btnUpdateStaff.Click += new System.EventHandler(this.btnUpdateStaff_Click);
            // 
            // txtUpdateTitle
            // 
            this.txtUpdateTitle.Location = new System.Drawing.Point(270, 293);
            this.txtUpdateTitle.Name = "txtUpdateTitle";
            this.txtUpdateTitle.Size = new System.Drawing.Size(134, 20);
            this.txtUpdateTitle.TabIndex = 5;
            // 
            // txtUpdateEmail
            // 
            this.txtUpdateEmail.Location = new System.Drawing.Point(270, 245);
            this.txtUpdateEmail.Name = "txtUpdateEmail";
            this.txtUpdateEmail.Size = new System.Drawing.Size(134, 20);
            this.txtUpdateEmail.TabIndex = 4;
            // 
            // cmbUpdatePID
            // 
            this.cmbUpdatePID.FormattingEnabled = true;
            this.cmbUpdatePID.Location = new System.Drawing.Point(270, 163);
            this.cmbUpdatePID.Name = "cmbUpdatePID";
            this.cmbUpdatePID.Size = new System.Drawing.Size(134, 21);
            this.cmbUpdatePID.TabIndex = 3;
            // 
            // txtUpdatePhoneNumber
            // 
            this.txtUpdatePhoneNumber.Location = new System.Drawing.Point(270, 208);
            this.txtUpdatePhoneNumber.Name = "txtUpdatePhoneNumber";
            this.txtUpdatePhoneNumber.Size = new System.Drawing.Size(134, 20);
            this.txtUpdatePhoneNumber.TabIndex = 2;
            // 
            // txtUpdateLname
            // 
            this.txtUpdateLname.Location = new System.Drawing.Point(270, 126);
            this.txtUpdateLname.Name = "txtUpdateLname";
            this.txtUpdateLname.Size = new System.Drawing.Size(134, 20);
            this.txtUpdateLname.TabIndex = 1;
            // 
            // cmbUpdateFname
            // 
            this.cmbUpdateFname.FormattingEnabled = true;
            this.cmbUpdateFname.Location = new System.Drawing.Point(270, 43);
            this.cmbUpdateFname.Name = "cmbUpdateFname";
            this.cmbUpdateFname.Size = new System.Drawing.Size(134, 21);
            this.cmbUpdateFname.TabIndex = 0;
            this.cmbUpdateFname.SelectedIndexChanged += new System.EventHandler(this.cmbUpdateFname_SelectedIndexChanged);
            // 
            // staffServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbStaff);
            this.Name = "staffServices";
            this.Text = "StaffServices";
            this.tbStaff.ResumeLayout(false);
            this.tbCreateStaff.ResumeLayout(false);
            this.tbCreateStaff.PerformLayout();
            this.tbUpdateStaff.ResumeLayout(false);
            this.tbUpdateStaff.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbStaff;
        private System.Windows.Forms.TabPage tbCreateStaff;
        private System.Windows.Forms.TabPage tbUpdateStaff;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ComboBox cmbPID;
        private System.Windows.Forms.TextBox txtTtile;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblPID;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblUpdateTitle;
        private System.Windows.Forms.Label lblUpdateEmail;
        private System.Windows.Forms.Label lblUpdatePhoneNumber;
        private System.Windows.Forms.Label lblUpdatePID;
        private System.Windows.Forms.Label lblUpdateLname;
        private System.Windows.Forms.Label lblUpdateFname;
        private System.Windows.Forms.Button btnUpdateStaff;
        private System.Windows.Forms.TextBox txtUpdateTitle;
        private System.Windows.Forms.TextBox txtUpdateEmail;
        private System.Windows.Forms.ComboBox cmbUpdatePID;
        private System.Windows.Forms.TextBox txtUpdatePhoneNumber;
        private System.Windows.Forms.TextBox txtUpdateLname;
        private System.Windows.Forms.ComboBox cmbUpdateFname;
        private System.Windows.Forms.Label lblSelectionUpdate;
        private System.Windows.Forms.TextBox txtUpdateFirstName;
        private System.Windows.Forms.Label lblStaffIDtoUpdate;
        private System.Windows.Forms.Label lblStaffIDUpdateSelect;
    }
}