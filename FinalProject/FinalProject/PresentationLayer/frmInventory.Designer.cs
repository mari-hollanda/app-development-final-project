
namespace FinalProject.PresentationLayer
{
    partial class frmInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventory));
            this.tlsMain = new System.Windows.Forms.ToolStrip();
            this.newTlsButton = new System.Windows.Forms.ToolStripButton();
            this.openTlsButton = new System.Windows.Forms.ToolStripButton();
            this.saveTlsButton = new System.Windows.Forms.ToolStripButton();
            this.deleteTlsButton = new System.Windows.Forms.ToolStripButton();
            this.clearTlsButton = new System.Windows.Forms.ToolStripButton();
            this.grp3 = new System.Windows.Forms.GroupBox();
            this.dtpCheckInDate = new System.Windows.Forms.DateTimePicker();
            this.cmb9 = new System.Windows.Forms.ComboBox();
            this.lbl9 = new System.Windows.Forms.Label();
            this.lbl10 = new System.Windows.Forms.Label();
            this.grp2 = new System.Windows.Forms.GroupBox();
            this.lbl5 = new System.Windows.Forms.Label();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.lbl6 = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lbl7 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lbl8 = new System.Windows.Forms.Label();
            this.txtProvince = new System.Windows.Forms.TextBox();
            this.grp1 = new System.Windows.Forms.GroupBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.tlsMain.SuspendLayout();
            this.grp3.SuspendLayout();
            this.grp2.SuspendLayout();
            this.grp1.SuspendLayout();
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
            // grp3
            // 
            this.grp3.Controls.Add(this.dtpCheckInDate);
            this.grp3.Controls.Add(this.cmb9);
            this.grp3.Controls.Add(this.lbl9);
            this.grp3.Controls.Add(this.lbl10);
            this.grp3.Location = new System.Drawing.Point(414, 189);
            this.grp3.Margin = new System.Windows.Forms.Padding(4);
            this.grp3.Name = "grp3";
            this.grp3.Padding = new System.Windows.Forms.Padding(4);
            this.grp3.Size = new System.Drawing.Size(220, 134);
            this.grp3.TabIndex = 66;
            this.grp3.TabStop = false;
            this.grp3.Text = "3";
            // 
            // dtpCheckInDate
            // 
            this.dtpCheckInDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckInDate.Location = new System.Drawing.Point(8, 94);
            this.dtpCheckInDate.Name = "dtpCheckInDate";
            this.dtpCheckInDate.Size = new System.Drawing.Size(175, 20);
            this.dtpCheckInDate.TabIndex = 10;
            // 
            // cmb9
            // 
            this.cmb9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb9.FormattingEnabled = true;
            this.cmb9.Location = new System.Drawing.Point(8, 46);
            this.cmb9.Name = "cmb9";
            this.cmb9.Size = new System.Drawing.Size(175, 21);
            this.cmb9.TabIndex = 9;
            // 
            // lbl9
            // 
            this.lbl9.AutoSize = true;
            this.lbl9.Location = new System.Drawing.Point(8, 28);
            this.lbl9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(13, 13);
            this.lbl9.TabIndex = 32;
            this.lbl9.Text = "9";
            // 
            // lbl10
            // 
            this.lbl10.AutoSize = true;
            this.lbl10.Location = new System.Drawing.Point(8, 74);
            this.lbl10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(19, 13);
            this.lbl10.TabIndex = 34;
            this.lbl10.Text = "10";
            // 
            // grp2
            // 
            this.grp2.Controls.Add(this.lbl5);
            this.grp2.Controls.Add(this.txtZipCode);
            this.grp2.Controls.Add(this.lbl6);
            this.grp2.Controls.Add(this.txtStreet);
            this.grp2.Controls.Add(this.lbl7);
            this.grp2.Controls.Add(this.txtCity);
            this.grp2.Controls.Add(this.lbl8);
            this.grp2.Controls.Add(this.txtProvince);
            this.grp2.Location = new System.Drawing.Point(4, 187);
            this.grp2.Margin = new System.Windows.Forms.Padding(4);
            this.grp2.Name = "grp2";
            this.grp2.Padding = new System.Windows.Forms.Padding(4);
            this.grp2.Size = new System.Drawing.Size(402, 136);
            this.grp2.TabIndex = 65;
            this.grp2.TabStop = false;
            this.grp2.Text = "2";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(8, 28);
            this.lbl5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(13, 13);
            this.lbl5.TabIndex = 32;
            this.lbl5.Text = "5";
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(8, 48);
            this.txtZipCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(175, 20);
            this.txtZipCode.TabIndex = 5;
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Location = new System.Drawing.Point(191, 28);
            this.lbl6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(13, 13);
            this.lbl6.TabIndex = 34;
            this.lbl6.Text = "6";
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
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Location = new System.Drawing.Point(7, 76);
            this.lbl7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(13, 13);
            this.lbl7.TabIndex = 36;
            this.lbl7.Text = "7";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(8, 96);
            this.txtCity.Margin = new System.Windows.Forms.Padding(4);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(175, 20);
            this.txtCity.TabIndex = 7;
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.Location = new System.Drawing.Point(191, 76);
            this.lbl8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(13, 13);
            this.lbl8.TabIndex = 38;
            this.lbl8.Text = "8";
            // 
            // txtProvince
            // 
            this.txtProvince.Location = new System.Drawing.Point(194, 96);
            this.txtProvince.Margin = new System.Windows.Forms.Padding(4);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Size = new System.Drawing.Size(187, 20);
            this.txtProvince.TabIndex = 8;
            // 
            // grp1
            // 
            this.grp1.Controls.Add(this.lbl3);
            this.grp1.Controls.Add(this.txt3);
            this.grp1.Controls.Add(this.txt1);
            this.grp1.Controls.Add(this.lbl4);
            this.grp1.Controls.Add(this.lbl1);
            this.grp1.Controls.Add(this.txt4);
            this.grp1.Controls.Add(this.lbl2);
            this.grp1.Controls.Add(this.txt2);
            this.grp1.Location = new System.Drawing.Point(4, 29);
            this.grp1.Margin = new System.Windows.Forms.Padding(4);
            this.grp1.Name = "grp1";
            this.grp1.Padding = new System.Windows.Forms.Padding(4);
            this.grp1.Size = new System.Drawing.Size(630, 135);
            this.grp1.TabIndex = 64;
            this.grp1.TabStop = false;
            this.grp1.Text = "1";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(11, 79);
            this.lbl3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(13, 13);
            this.lbl3.TabIndex = 45;
            this.lbl3.Text = "3";
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(11, 99);
            this.txt3.Margin = new System.Windows.Forms.Padding(4);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(175, 20);
            this.txt3.TabIndex = 3;
            // 
            // txt1
            // 
            this.txt1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt1.Location = new System.Drawing.Point(11, 46);
            this.txt1.Margin = new System.Windows.Forms.Padding(4);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(212, 20);
            this.txt1.TabIndex = 1;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(191, 79);
            this.lbl4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(13, 13);
            this.lbl4.TabIndex = 46;
            this.lbl4.Text = "4";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(11, 26);
            this.lbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(13, 13);
            this.lbl1.TabIndex = 24;
            this.lbl1.Text = "1";
            // 
            // txt4
            // 
            this.txt4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt4.Location = new System.Drawing.Point(194, 99);
            this.txt4.Margin = new System.Windows.Forms.Padding(4);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(399, 20);
            this.txt4.TabIndex = 4;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(228, 26);
            this.lbl2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(13, 13);
            this.lbl2.TabIndex = 28;
            this.lbl2.Text = "2";
            // 
            // txt2
            // 
            this.txt2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt2.Location = new System.Drawing.Point(231, 46);
            this.txt2.Margin = new System.Windows.Forms.Padding(4);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(362, 20);
            this.txt2.TabIndex = 2;
            // 
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grp3);
            this.Controls.Add(this.grp2);
            this.Controls.Add(this.grp1);
            this.Controls.Add(this.tlsMain);
            this.Name = "frmInventory";
            this.Size = new System.Drawing.Size(674, 352);
            this.tlsMain.ResumeLayout(false);
            this.tlsMain.PerformLayout();
            this.grp3.ResumeLayout(false);
            this.grp3.PerformLayout();
            this.grp2.ResumeLayout(false);
            this.grp2.PerformLayout();
            this.grp1.ResumeLayout(false);
            this.grp1.PerformLayout();
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
        private System.Windows.Forms.GroupBox grp3;
        private System.Windows.Forms.DateTimePicker dtpCheckInDate;
        private System.Windows.Forms.ComboBox cmb9;
        private System.Windows.Forms.Label lbl9;
        private System.Windows.Forms.Label lbl10;
        private System.Windows.Forms.GroupBox grp2;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.TextBox txtProvince;
        private System.Windows.Forms.GroupBox grp1;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txt2;
    }
}
