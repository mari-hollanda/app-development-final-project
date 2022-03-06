
namespace SleepEasyHotel.PresentationLayer
{
    partial class HomePage
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
            this.btnRegistrationService = new System.Windows.Forms.Button();
            this.btnRoomService = new System.Windows.Forms.Button();
            this.btnServices = new System.Windows.Forms.Button();
            this.btnStaffServices = new System.Windows.Forms.Button();
            this.rtbLogin = new System.Windows.Forms.RichTextBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegistrationService
            // 
            this.btnRegistrationService.Location = new System.Drawing.Point(30, 114);
            this.btnRegistrationService.Name = "btnRegistrationService";
            this.btnRegistrationService.Size = new System.Drawing.Size(176, 51);
            this.btnRegistrationService.TabIndex = 1;
            this.btnRegistrationService.Text = "Registration Service";
            this.btnRegistrationService.UseVisualStyleBackColor = true;
            this.btnRegistrationService.Click += new System.EventHandler(this.btnRegistrationService_Click);
            // 
            // btnRoomService
            // 
            this.btnRoomService.Location = new System.Drawing.Point(266, 115);
            this.btnRoomService.Name = "btnRoomService";
            this.btnRoomService.Size = new System.Drawing.Size(176, 50);
            this.btnRoomService.TabIndex = 3;
            this.btnRoomService.Text = "Room Service";
            this.btnRoomService.UseVisualStyleBackColor = true;
            // 
            // btnServices
            // 
            this.btnServices.Location = new System.Drawing.Point(266, 216);
            this.btnServices.Name = "btnServices";
            this.btnServices.Size = new System.Drawing.Size(176, 49);
            this.btnServices.TabIndex = 5;
            this.btnServices.Text = "Services";
            this.btnServices.UseVisualStyleBackColor = true;
            // 
            // btnStaffServices
            // 
            this.btnStaffServices.Location = new System.Drawing.Point(30, 216);
            this.btnStaffServices.Name = "btnStaffServices";
            this.btnStaffServices.Size = new System.Drawing.Size(176, 48);
            this.btnStaffServices.TabIndex = 7;
            this.btnStaffServices.Text = "Staff Services";
            this.btnStaffServices.UseVisualStyleBackColor = true;
            this.btnStaffServices.Click += new System.EventHandler(this.btnStaffServices_Click);
            // 
            // rtbLogin
            // 
            this.rtbLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbLogin.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbLogin.Location = new System.Drawing.Point(625, 3);
            this.rtbLogin.Name = "rtbLogin";
            this.rtbLogin.ReadOnly = true;
            this.rtbLogin.Size = new System.Drawing.Size(197, 60);
            this.rtbLogin.TabIndex = 8;
            this.rtbLogin.Text = "";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(113, 347);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(216, 57);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 464);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.rtbLogin);
            this.Controls.Add(this.btnStaffServices);
            this.Controls.Add(this.btnServices);
            this.Controls.Add(this.btnRoomService);
            this.Controls.Add(this.btnRegistrationService);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrationService;
        private System.Windows.Forms.Button btnRoomService;
        private System.Windows.Forms.Button btnServices;
        private System.Windows.Forms.Button btnStaffServices;
        private System.Windows.Forms.RichTextBox rtbLogin;
        private System.Windows.Forms.Button btnLogout;
    }
}