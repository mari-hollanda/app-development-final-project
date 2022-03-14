
namespace SleepEasyHotel.PresentationLayer
{
    partial class frmUpdateRooms
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
            this.grpBooking = new System.Windows.Forms.GroupBox();
            this.dtpCheckInDate = new System.Windows.Forms.DateTimePicker();
            this.dtpCheckOutDate = new System.Windows.Forms.DateTimePicker();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.grpRooms = new System.Windows.Forms.GroupBox();
            this.cmbRoomStatus = new System.Windows.Forms.ComboBox();
            this.cmbRoomType = new System.Windows.Forms.ComboBox();
            this.cmbRoomID = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblStaff = new System.Windows.Forms.Label();
            this.lblRoomID = new System.Windows.Forms.Label();
            this.txtStaff = new System.Windows.Forms.TextBox();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblRoom = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.grpBooking.SuspendLayout();
            this.grpRooms.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBooking
            // 
            this.grpBooking.Controls.Add(this.dtpCheckInDate);
            this.grpBooking.Controls.Add(this.dtpCheckOutDate);
            this.grpBooking.Controls.Add(this.lblCheckIn);
            this.grpBooking.Controls.Add(this.lblCheckOut);
            this.grpBooking.Location = new System.Drawing.Point(50, 179);
            this.grpBooking.Margin = new System.Windows.Forms.Padding(4);
            this.grpBooking.Name = "grpBooking";
            this.grpBooking.Padding = new System.Windows.Forms.Padding(4);
            this.grpBooking.Size = new System.Drawing.Size(381, 133);
            this.grpBooking.TabIndex = 65;
            this.grpBooking.TabStop = false;
            this.grpBooking.Text = "Booking";
            // 
            // dtpCheckInDate
            // 
            this.dtpCheckInDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckInDate.Location = new System.Drawing.Point(78, 28);
            this.dtpCheckInDate.Name = "dtpCheckInDate";
            this.dtpCheckInDate.Size = new System.Drawing.Size(175, 20);
            this.dtpCheckInDate.TabIndex = 38;
            // 
            // dtpCheckOutDate
            // 
            this.dtpCheckOutDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckOutDate.Location = new System.Drawing.Point(78, 76);
            this.dtpCheckOutDate.Name = "dtpCheckOutDate";
            this.dtpCheckOutDate.Size = new System.Drawing.Size(175, 20);
            this.dtpCheckOutDate.TabIndex = 37;
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
            this.grpRooms.Controls.Add(this.cmbRoomStatus);
            this.grpRooms.Controls.Add(this.cmbRoomType);
            this.grpRooms.Controls.Add(this.cmbRoomID);
            this.grpRooms.Controls.Add(this.lblStatus);
            this.grpRooms.Controls.Add(this.lblStaff);
            this.grpRooms.Controls.Add(this.lblRoomID);
            this.grpRooms.Controls.Add(this.txtStaff);
            this.grpRooms.Controls.Add(this.lblRoomType);
            this.grpRooms.Location = new System.Drawing.Point(50, 21);
            this.grpRooms.Margin = new System.Windows.Forms.Padding(4);
            this.grpRooms.Name = "grpRooms";
            this.grpRooms.Padding = new System.Windows.Forms.Padding(4);
            this.grpRooms.Size = new System.Drawing.Size(381, 135);
            this.grpRooms.TabIndex = 64;
            this.grpRooms.TabStop = false;
            this.grpRooms.Text = "Room";
            // 
            // cmbRoomStatus
            // 
            this.cmbRoomStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoomStatus.FormattingEnabled = true;
            this.cmbRoomStatus.Items.AddRange(new object[] {
            "Empty",
            "Occupied"});
            this.cmbRoomStatus.Location = new System.Drawing.Point(11, 98);
            this.cmbRoomStatus.Name = "cmbRoomStatus";
            this.cmbRoomStatus.Size = new System.Drawing.Size(148, 21);
            this.cmbRoomStatus.TabIndex = 48;
            // 
            // cmbRoomType
            // 
            this.cmbRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoomType.FormattingEnabled = true;
            this.cmbRoomType.Items.AddRange(new object[] {
            "K",
            "Q",
            "D"});
            this.cmbRoomType.Location = new System.Drawing.Point(132, 45);
            this.cmbRoomType.Name = "cmbRoomType";
            this.cmbRoomType.Size = new System.Drawing.Size(148, 21);
            this.cmbRoomType.TabIndex = 47;
            // 
            // cmbRoomID
            // 
            this.cmbRoomID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoomID.FormattingEnabled = true;
            this.cmbRoomID.Location = new System.Drawing.Point(11, 45);
            this.cmbRoomID.Name = "cmbRoomID";
            this.cmbRoomID.Size = new System.Drawing.Size(95, 21);
            this.cmbRoomID.TabIndex = 1;
            this.cmbRoomID.SelectedIndexChanged += new System.EventHandler(this.cmbRoomID_SelectedIndexChanged);
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
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(209, 331);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 66;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Location = new System.Drawing.Point(206, 162);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(49, 13);
            this.lblRoom.TabIndex = 49;
            this.lblRoom.Text = "Room ID";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(356, 331);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 39;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(59, 331);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(77, 23);
            this.btnRefresh.TabIndex = 67;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmUpdateRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblRoom);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.grpBooking);
            this.Controls.Add(this.grpRooms);
            this.Name = "frmUpdateRooms";
            this.Size = new System.Drawing.Size(467, 377);
            this.Load += new System.EventHandler(this.frmUpdateRooms_Load);
            this.grpBooking.ResumeLayout(false);
            this.grpBooking.PerformLayout();
            this.grpRooms.ResumeLayout(false);
            this.grpRooms.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBooking;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.GroupBox grpRooms;
        private System.Windows.Forms.ComboBox cmbRoomID;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblStaff;
        private System.Windows.Forms.Label lblRoomID;
        private System.Windows.Forms.TextBox txtStaff;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DateTimePicker dtpCheckInDate;
        private System.Windows.Forms.DateTimePicker dtpCheckOutDate;
        private System.Windows.Forms.ComboBox cmbRoomStatus;
        private System.Windows.Forms.ComboBox cmbRoomType;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
    }
}
