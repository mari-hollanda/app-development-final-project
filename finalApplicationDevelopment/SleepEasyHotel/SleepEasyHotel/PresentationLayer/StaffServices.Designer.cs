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
            this.tbUpdateStaff = new System.Windows.Forms.TabPage();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTtile = new System.Windows.Forms.TextBox();
            this.cmbPID = new System.Windows.Forms.ComboBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblPID = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbStaff.SuspendLayout();
            this.tbCreateStaff.SuspendLayout();
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
            // tbUpdateStaff
            // 
            this.tbUpdateStaff.Location = new System.Drawing.Point(4, 22);
            this.tbUpdateStaff.Name = "tbUpdateStaff";
            this.tbUpdateStaff.Padding = new System.Windows.Forms.Padding(3);
            this.tbUpdateStaff.Size = new System.Drawing.Size(789, 389);
            this.tbUpdateStaff.TabIndex = 1;
            this.tbUpdateStaff.Text = "Update Staff";
            this.tbUpdateStaff.UseVisualStyleBackColor = true;
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(297, 61);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(160, 20);
            this.txtFname.TabIndex = 0;
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(297, 108);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(160, 20);
            this.txtLname.TabIndex = 1;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(297, 190);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(160, 20);
            this.txtPhoneNumber.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(297, 232);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(160, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // txtTtile
            // 
            this.txtTtile.Location = new System.Drawing.Point(297, 275);
            this.txtTtile.Name = "txtTtile";
            this.txtTtile.Size = new System.Drawing.Size(160, 20);
            this.txtTtile.TabIndex = 4;
            // 
            // cmbPID
            // 
            this.cmbPID.FormattingEnabled = true;
            this.cmbPID.Location = new System.Drawing.Point(297, 151);
            this.cmbPID.Name = "cmbPID";
            this.cmbPID.Size = new System.Drawing.Size(160, 21);
            this.cmbPID.TabIndex = 5;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(253, 327);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(107, 37);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
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
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(91, 108);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(67, 13);
            this.lblLastName.TabIndex = 8;
            this.lblLastName.Text = "Last Name : ";
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
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(92, 190);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(84, 13);
            this.lblPhoneNumber.TabIndex = 10;
            this.lblPhoneNumber.Text = "PhoneNumber : ";
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
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(92, 275);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(36, 13);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Title : ";
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
    }
}