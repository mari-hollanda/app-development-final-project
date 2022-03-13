
namespace SleepEasyHotel.PresentationLayer
{
    partial class frmUpdateService
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.grpServices = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblSelectDescription = new System.Windows.Forms.Label();
            this.cmbDescription = new System.Windows.Forms.ComboBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblServiceID = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.grpServices.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(126, 268);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(141, 42);
            this.btnUpdate.TabIndex = 63;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // grpServices
            // 
            this.grpServices.Controls.Add(this.txtDescription);
            this.grpServices.Controls.Add(this.lblSelectDescription);
            this.grpServices.Controls.Add(this.cmbDescription);
            this.grpServices.Controls.Add(this.txtType);
            this.grpServices.Controls.Add(this.lblType);
            this.grpServices.Controls.Add(this.lblDescription);
            this.grpServices.Controls.Add(this.lblPrice);
            this.grpServices.Controls.Add(this.txtPrice);
            this.grpServices.Location = new System.Drawing.Point(95, 68);
            this.grpServices.Margin = new System.Windows.Forms.Padding(4);
            this.grpServices.Name = "grpServices";
            this.grpServices.Padding = new System.Windows.Forms.Padding(4);
            this.grpServices.Size = new System.Drawing.Size(402, 193);
            this.grpServices.TabIndex = 64;
            this.grpServices.TabStop = false;
            this.grpServices.Text = "Services";
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Location = new System.Drawing.Point(123, 70);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(262, 20);
            this.txtDescription.TabIndex = 66;
            // 
            // lblSelectDescription
            // 
            this.lblSelectDescription.AutoSize = true;
            this.lblSelectDescription.Location = new System.Drawing.Point(11, 34);
            this.lblSelectDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectDescription.Name = "lblSelectDescription";
            this.lblSelectDescription.Size = new System.Drawing.Size(93, 13);
            this.lblSelectDescription.TabIndex = 65;
            this.lblSelectDescription.Text = "Select Description";
            // 
            // cmbDescription
            // 
            this.cmbDescription.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDescription.FormattingEnabled = true;
            this.cmbDescription.Location = new System.Drawing.Point(123, 26);
            this.cmbDescription.Name = "cmbDescription";
            this.cmbDescription.Size = new System.Drawing.Size(262, 21);
            this.cmbDescription.TabIndex = 49;
            this.cmbDescription.SelectedIndexChanged += new System.EventHandler(this.cmbDescription_SelectedIndexChanged);
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(123, 145);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(262, 20);
            this.txtType.TabIndex = 3;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(11, 145);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 48;
            this.lblType.Text = "Type";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(8, 77);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 24;
            this.lblDescription.Text = "Description";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(11, 110);
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
            this.txtPrice.Location = new System.Drawing.Point(123, 103);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(262, 20);
            this.txtPrice.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(348, 268);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(132, 42);
            this.btnDelete.TabIndex = 65;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblServiceID
            // 
            this.lblServiceID.AutoSize = true;
            this.lblServiceID.Location = new System.Drawing.Point(504, 158);
            this.lblServiceID.Name = "lblServiceID";
            this.lblServiceID.Size = new System.Drawing.Size(57, 13);
            this.lblServiceID.TabIndex = 64;
            this.lblServiceID.Text = "Service ID";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(392, 41);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(105, 29);
            this.btnRefresh.TabIndex = 66;
            this.btnRefresh.Text = "Refresh Page";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmUpdateService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblServiceID);
            this.Controls.Add(this.grpServices);
            this.Name = "frmUpdateService";
            this.Size = new System.Drawing.Size(592, 344);
            this.Load += new System.EventHandler(this.frmUpdateService_Load);
            this.grpServices.ResumeLayout(false);
            this.grpServices.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox grpServices;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox cmbDescription;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblServiceID;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblSelectDescription;
        private System.Windows.Forms.Button btnRefresh;
    }
}
