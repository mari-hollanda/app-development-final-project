
namespace FinalProject.PresentationLayer
{
    partial class frmRooms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRooms));
            this.grpBooking = new System.Windows.Forms.GroupBox();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.grpRooms = new System.Windows.Forms.GroupBox();
            this.cmbRoomID = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblStaff = new System.Windows.Forms.Label();
            this.lblRoomID = new System.Windows.Forms.Label();
            this.txtStaff = new System.Windows.Forms.TextBox();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.txtRoomType = new System.Windows.Forms.TextBox();
            this.tlsMain = new System.Windows.Forms.ToolStrip();
            this.newTlsButton = new System.Windows.Forms.ToolStripButton();
            this.openTlsButton = new System.Windows.Forms.ToolStripButton();
            this.saveTlsButton = new System.Windows.Forms.ToolStripButton();
            this.deleteTlsButton = new System.Windows.Forms.ToolStripButton();
            this.clearTlsButton = new System.Windows.Forms.ToolStripButton();
            this.grpBooking.SuspendLayout();
            this.grpRooms.SuspendLayout();
            this.tlsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBooking
            // 
            this.grpBooking.Controls.Add(this.dtpCheckOut);
            this.grpBooking.Controls.Add(this.dtpCheckIn);
            this.grpBooking.Controls.Add(this.lblCheckIn);
            this.grpBooking.Controls.Add(this.lblCheckOut);
            this.grpBooking.Location = new System.Drawing.Point(4, 202);
            this.grpBooking.Margin = new System.Windows.Forms.Padding(4);
            this.grpBooking.Name = "grpBooking";
            this.grpBooking.Padding = new System.Windows.Forms.Padding(4);
            this.grpBooking.Size = new System.Drawing.Size(381, 136);
            this.grpBooking.TabIndex = 63;
            this.grpBooking.TabStop = false;
            this.grpBooking.Text = "Booking";
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.Location = new System.Drawing.Point(11, 92);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(310, 20);
            this.dtpCheckOut.TabIndex = 6;
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.Location = new System.Drawing.Point(11, 44);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(310, 20);
            this.dtpCheckIn.TabIndex = 5;
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Location = new System.Drawing.Point(8, 28);
            this.lblCheckIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(50, 13);
            this.lblCheckIn.TabIndex = 32;
            this.lblCheckIn.Text = "Check In";
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.Location = new System.Drawing.Point(7, 76);
            this.lblCheckOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(58, 13);
            this.lblCheckOut.TabIndex = 36;
            this.lblCheckOut.Text = "Check Out";
            // 
            // grpRooms
            // 
            this.grpRooms.Controls.Add(this.cmbRoomID);
            this.grpRooms.Controls.Add(this.lblStatus);
            this.grpRooms.Controls.Add(this.txtStatus);
            this.grpRooms.Controls.Add(this.lblStaff);
            this.grpRooms.Controls.Add(this.lblRoomID);
            this.grpRooms.Controls.Add(this.txtStaff);
            this.grpRooms.Controls.Add(this.lblRoomType);
            this.grpRooms.Controls.Add(this.txtRoomType);
            this.grpRooms.Location = new System.Drawing.Point(4, 44);
            this.grpRooms.Margin = new System.Windows.Forms.Padding(4);
            this.grpRooms.Name = "grpRooms";
            this.grpRooms.Padding = new System.Windows.Forms.Padding(4);
            this.grpRooms.Size = new System.Drawing.Size(381, 135);
            this.grpRooms.TabIndex = 61;
            this.grpRooms.TabStop = false;
            this.grpRooms.Text = "Room";
            // 
            // cmbRoomID
            // 
            this.cmbRoomID.FormattingEnabled = true;
            this.cmbRoomID.Location = new System.Drawing.Point(11, 45);
            this.cmbRoomID.Name = "cmbRoomID";
            this.cmbRoomID.Size = new System.Drawing.Size(95, 21);
            this.cmbRoomID.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(11, 79);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(68, 13);
            this.lblStatus.TabIndex = 45;
            this.lblStatus.Text = "Room Status";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(11, 99);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(4);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(172, 20);
            this.txtStatus.TabIndex = 3;
            // 
            // lblStaff
            // 
            this.lblStaff.AutoSize = true;
            this.lblStaff.Location = new System.Drawing.Point(191, 79);
            this.lblStaff.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(43, 13);
            this.lblStaff.TabIndex = 46;
            this.lblStaff.Text = "Staff ID";
            // 
            // lblRoomID
            // 
            this.lblRoomID.AutoSize = true;
            this.lblRoomID.Location = new System.Drawing.Point(11, 26);
            this.lblRoomID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomID.Name = "lblRoomID";
            this.lblRoomID.Size = new System.Drawing.Size(75, 13);
            this.lblRoomID.TabIndex = 24;
            this.lblRoomID.Text = "Room Number";
            // 
            // txtStaff
            // 
            this.txtStaff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStaff.Location = new System.Drawing.Point(194, 99);
            this.txtStaff.Margin = new System.Windows.Forms.Padding(4);
            this.txtStaff.Name = "txtStaff";
            this.txtStaff.Size = new System.Drawing.Size(127, 20);
            this.txtStaff.TabIndex = 4;
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Location = new System.Drawing.Point(129, 26);
            this.lblRoomType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(62, 13);
            this.lblRoomType.TabIndex = 28;
            this.lblRoomType.Text = "Room Type";
            // 
            // txtRoomType
            // 
            this.txtRoomType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRoomType.Location = new System.Drawing.Point(132, 46);
            this.txtRoomType.Margin = new System.Windows.Forms.Padding(4);
            this.txtRoomType.Name = "txtRoomType";
            this.txtRoomType.Size = new System.Drawing.Size(136, 20);
            this.txtRoomType.TabIndex = 2;
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
            this.tlsMain.Size = new System.Drawing.Size(459, 25);
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
            // frmRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpBooking);
            this.Controls.Add(this.grpRooms);
            this.Controls.Add(this.tlsMain);
            this.Name = "frmRooms";
            this.Size = new System.Drawing.Size(459, 352);
            this.grpBooking.ResumeLayout(false);
            this.grpBooking.PerformLayout();
            this.grpRooms.ResumeLayout(false);
            this.grpRooms.PerformLayout();
            this.tlsMain.ResumeLayout(false);
            this.tlsMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpBooking;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.GroupBox grpRooms;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lblStaff;
        private System.Windows.Forms.Label lblRoomID;
        private System.Windows.Forms.TextBox txtStaff;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.TextBox txtRoomType;
        private System.Windows.Forms.ToolStrip tlsMain;
        private System.Windows.Forms.ToolStripButton newTlsButton;
        private System.Windows.Forms.ToolStripButton openTlsButton;
        private System.Windows.Forms.ToolStripButton saveTlsButton;
        private System.Windows.Forms.ToolStripButton deleteTlsButton;
        private System.Windows.Forms.ToolStripButton clearTlsButton;
        private System.Windows.Forms.ComboBox cmbRoomID;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
    }
}
