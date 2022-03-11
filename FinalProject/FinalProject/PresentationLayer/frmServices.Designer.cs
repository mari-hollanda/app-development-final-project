
namespace FinalProject.PresentationLayer
{
    partial class frmServices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServices));
            this.grpServices = new System.Windows.Forms.GroupBox();
            this.cmbDescription = new System.Windows.Forms.ComboBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.tlsMain = new System.Windows.Forms.ToolStrip();
            this.newTlsButton = new System.Windows.Forms.ToolStripButton();
            this.openTlsButton = new System.Windows.Forms.ToolStripButton();
            this.saveTlsButton = new System.Windows.Forms.ToolStripButton();
            this.deleteTlsButton = new System.Windows.Forms.ToolStripButton();
            this.clearTlsButton = new System.Windows.Forms.ToolStripButton();
            this.grpServices.SuspendLayout();
            this.tlsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpServices
            // 
            this.grpServices.Controls.Add(this.cmbDescription);
            this.grpServices.Controls.Add(this.lblDescription);
            this.grpServices.Controls.Add(this.lblPrice);
            this.grpServices.Controls.Add(this.txtPrice);
            this.grpServices.Location = new System.Drawing.Point(4, 44);
            this.grpServices.Margin = new System.Windows.Forms.Padding(4);
            this.grpServices.Name = "grpServices";
            this.grpServices.Padding = new System.Windows.Forms.Padding(4);
            this.grpServices.Size = new System.Drawing.Size(402, 101);
            this.grpServices.TabIndex = 61;
            this.grpServices.TabStop = false;
            this.grpServices.Text = "Services";
            // 
            // cmbDescription
            // 
            this.cmbDescription.FormattingEnabled = true;
            this.cmbDescription.Location = new System.Drawing.Point(11, 46);
            this.cmbDescription.Name = "cmbDescription";
            this.cmbDescription.Size = new System.Drawing.Size(175, 21);
            this.cmbDescription.TabIndex = 47;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(11, 26);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 24;
            this.lblDescription.Text = "Description";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(191, 26);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 28;
            this.lblPrice.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrice.Location = new System.Drawing.Point(194, 43);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(171, 20);
            this.txtPrice.TabIndex = 2;
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
            this.tlsMain.Size = new System.Drawing.Size(440, 25);
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
            // frmServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpServices);
            this.Controls.Add(this.tlsMain);
            this.Name = "frmServices";
            this.Size = new System.Drawing.Size(440, 164);
            this.grpServices.ResumeLayout(false);
            this.grpServices.PerformLayout();
            this.tlsMain.ResumeLayout(false);
            this.tlsMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpServices;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ToolStrip tlsMain;
        private System.Windows.Forms.ToolStripButton newTlsButton;
        private System.Windows.Forms.ToolStripButton openTlsButton;
        private System.Windows.Forms.ToolStripButton saveTlsButton;
        private System.Windows.Forms.ToolStripButton deleteTlsButton;
        private System.Windows.Forms.ToolStripButton clearTlsButton;
        private System.Windows.Forms.ComboBox cmbDescription;
    }
}
