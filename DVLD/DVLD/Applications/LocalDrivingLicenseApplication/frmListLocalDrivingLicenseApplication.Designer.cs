namespace DVLD.Licenses
{
   partial class frmListLocalDrivingLicenseApplication
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
         this.components = new System.ComponentModel.Container();
         this.panel1 = new System.Windows.Forms.Panel();
         this.cbStatus = new System.Windows.Forms.ComboBox();
         this.txtFilterValue = new System.Windows.Forms.TextBox();
         this.cbFilterBy = new System.Windows.Forms.ComboBox();
         this.label2 = new System.Windows.Forms.Label();
         this.bntAddNewApplication = new System.Windows.Forms.Button();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.lblTitle = new System.Windows.Forms.Label();
         this.dgvDrivingLincesApplications = new System.Windows.Forms.DataGridView();
         this.ctmsApplication = new System.Windows.Forms.ContextMenuStrip(this.components);
         this.tlsmShowApplicationDetails = new System.Windows.Forms.ToolStripMenuItem();
         this.tlsmEditApplication = new System.Windows.Forms.ToolStripMenuItem();
         this.tlsmCancelApplication = new System.Windows.Forms.ToolStripMenuItem();
         this.tlsmDeleteApplication = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
         this.tlsmSecheduleTest = new System.Windows.Forms.ToolStripMenuItem();
         this.vistionTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.writtenTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.streetTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
         this.tlsmShowPersonLicenseHistory = new System.Windows.Forms.ToolStripMenuItem();
         this.label1 = new System.Windows.Forms.Label();
         this.lblLDVLAppNumber = new System.Windows.Forms.Label();
         this.panel1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.dgvDrivingLincesApplications)).BeginInit();
         this.ctmsApplication.SuspendLayout();
         this.SuspendLayout();
         // 
         // panel1
         // 
         this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
         this.panel1.Controls.Add(this.cbStatus);
         this.panel1.Controls.Add(this.txtFilterValue);
         this.panel1.Controls.Add(this.cbFilterBy);
         this.panel1.Controls.Add(this.label2);
         this.panel1.Controls.Add(this.bntAddNewApplication);
         this.panel1.Controls.Add(this.pictureBox1);
         this.panel1.Controls.Add(this.lblTitle);
         this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
         this.panel1.Location = new System.Drawing.Point(0, 0);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(946, 211);
         this.panel1.TabIndex = 0;
         // 
         // cbStatus
         // 
         this.cbStatus.BackColor = System.Drawing.SystemColors.Window;
         this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cbStatus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
         this.cbStatus.Items.AddRange(new object[] {
            "All",
            "New",
            "Completed ",
            "Cancelled"});
         this.cbStatus.Location = new System.Drawing.Point(294, 178);
         this.cbStatus.Name = "cbStatus";
         this.cbStatus.Size = new System.Drawing.Size(90, 21);
         this.cbStatus.TabIndex = 54;
         this.cbStatus.Visible = false;
         // 
         // txtFilterValue
         // 
         this.txtFilterValue.Location = new System.Drawing.Point(294, 178);
         this.txtFilterValue.Name = "txtFilterValue";
         this.txtFilterValue.Size = new System.Drawing.Size(170, 20);
         this.txtFilterValue.TabIndex = 53;
         this.txtFilterValue.Visible = false;
         this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
         this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
         // 
         // cbFilterBy
         // 
         this.cbFilterBy.BackColor = System.Drawing.SystemColors.Window;
         this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cbFilterBy.ImeMode = System.Windows.Forms.ImeMode.NoControl;
         this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "L.DLA ID",
            "National No",
            "Full Name",
            "Status"});
         this.cbFilterBy.Location = new System.Drawing.Point(100, 178);
         this.cbFilterBy.Name = "cbFilterBy";
         this.cbFilterBy.Size = new System.Drawing.Size(170, 21);
         this.cbFilterBy.TabIndex = 52;
         this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.label2.Location = new System.Drawing.Point(18, 176);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(75, 24);
         this.label2.TabIndex = 51;
         this.label2.Text = "Find by";
         // 
         // bntAddNewApplication
         // 
         this.bntAddNewApplication.BackColor = System.Drawing.Color.Transparent;
         this.bntAddNewApplication.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
         this.bntAddNewApplication.FlatAppearance.BorderSize = 0;
         this.bntAddNewApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.bntAddNewApplication.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold);
         this.bntAddNewApplication.ForeColor = System.Drawing.Color.Black;
         this.bntAddNewApplication.Image = global::DVLD.Properties.Resources.New_Application_64;
         this.bntAddNewApplication.Location = new System.Drawing.Point(852, 133);
         this.bntAddNewApplication.Name = "bntAddNewApplication";
         this.bntAddNewApplication.Size = new System.Drawing.Size(86, 69);
         this.bntAddNewApplication.TabIndex = 50;
         this.bntAddNewApplication.UseVisualStyleBackColor = false;
         this.bntAddNewApplication.Click += new System.EventHandler(this.bntAddNewApplication_Click);
         // 
         // pictureBox1
         // 
         this.pictureBox1.Image = global::DVLD.Properties.Resources.Application_Types_5121;
         this.pictureBox1.Location = new System.Drawing.Point(366, 6);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(227, 115);
         this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.pictureBox1.TabIndex = 49;
         this.pictureBox1.TabStop = false;
         // 
         // lblTitle
         // 
         this.lblTitle.AutoSize = true;
         this.lblTitle.BackColor = System.Drawing.Color.Transparent;
         this.lblTitle.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.lblTitle.Location = new System.Drawing.Point(256, 124);
         this.lblTitle.Name = "lblTitle";
         this.lblTitle.Size = new System.Drawing.Size(447, 34);
         this.lblTitle.TabIndex = 48;
         this.lblTitle.Text = "Local Driving License Applications";
         // 
         // dgvDrivingLincesApplications
         // 
         this.dgvDrivingLincesApplications.AllowUserToAddRows = false;
         this.dgvDrivingLincesApplications.AllowUserToDeleteRows = false;
         this.dgvDrivingLincesApplications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
         this.dgvDrivingLincesApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dgvDrivingLincesApplications.ContextMenuStrip = this.ctmsApplication;
         this.dgvDrivingLincesApplications.Location = new System.Drawing.Point(0, 217);
         this.dgvDrivingLincesApplications.Name = "dgvDrivingLincesApplications";
         this.dgvDrivingLincesApplications.ReadOnly = true;
         this.dgvDrivingLincesApplications.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.dgvDrivingLincesApplications.Size = new System.Drawing.Size(946, 250);
         this.dgvDrivingLincesApplications.TabIndex = 1;
         // 
         // ctmsApplication
         // 
         this.ctmsApplication.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsmShowApplicationDetails,
            this.tlsmEditApplication,
            this.tlsmCancelApplication,
            this.tlsmDeleteApplication,
            this.toolStripMenuItem2,
            this.tlsmSecheduleTest,
            this.toolStripMenuItem1,
            this.tlsmShowPersonLicenseHistory});
         this.ctmsApplication.Name = "ctmsApplication";
         this.ctmsApplication.Size = new System.Drawing.Size(226, 170);
         // 
         // tlsmShowApplicationDetails
         // 
         this.tlsmShowApplicationDetails.Name = "tlsmShowApplicationDetails";
         this.tlsmShowApplicationDetails.Size = new System.Drawing.Size(225, 22);
         this.tlsmShowApplicationDetails.Text = "Show Application Details";
         this.tlsmShowApplicationDetails.Click += new System.EventHandler(this.tlsmShowApplicationDetails_Click);
         // 
         // tlsmEditApplication
         // 
         this.tlsmEditApplication.Image = global::DVLD.Properties.Resources.edit_32;
         this.tlsmEditApplication.Name = "tlsmEditApplication";
         this.tlsmEditApplication.Size = new System.Drawing.Size(225, 22);
         this.tlsmEditApplication.Text = "Edit Application";
         // 
         // tlsmCancelApplication
         // 
         this.tlsmCancelApplication.Image = global::DVLD.Properties.Resources.cross_32;
         this.tlsmCancelApplication.Name = "tlsmCancelApplication";
         this.tlsmCancelApplication.Size = new System.Drawing.Size(225, 22);
         this.tlsmCancelApplication.Text = "Cancel Application";
         this.tlsmCancelApplication.Click += new System.EventHandler(this.tlsmCancelApplication_Click);
         // 
         // tlsmDeleteApplication
         // 
         this.tlsmDeleteApplication.Image = global::DVLD.Properties.Resources.Delete_32_2;
         this.tlsmDeleteApplication.Name = "tlsmDeleteApplication";
         this.tlsmDeleteApplication.Size = new System.Drawing.Size(225, 22);
         this.tlsmDeleteApplication.Text = "Delete Application";
         // 
         // toolStripMenuItem2
         // 
         this.toolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
         this.toolStripMenuItem2.Name = "toolStripMenuItem2";
         this.toolStripMenuItem2.Size = new System.Drawing.Size(222, 6);
         // 
         // tlsmSecheduleTest
         // 
         this.tlsmSecheduleTest.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vistionTestToolStripMenuItem,
            this.writtenTestToolStripMenuItem,
            this.streetTestToolStripMenuItem});
         this.tlsmSecheduleTest.Name = "tlsmSecheduleTest";
         this.tlsmSecheduleTest.Size = new System.Drawing.Size(225, 22);
         this.tlsmSecheduleTest.Text = "Sechedule Test";
         // 
         // vistionTestToolStripMenuItem
         // 
         this.vistionTestToolStripMenuItem.Name = "vistionTestToolStripMenuItem";
         this.vistionTestToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
         this.vistionTestToolStripMenuItem.Text = "Vistion Test";
         this.vistionTestToolStripMenuItem.Click += new System.EventHandler(this.vistionTestToolStripMenuItem_Click);
         // 
         // writtenTestToolStripMenuItem
         // 
         this.writtenTestToolStripMenuItem.Name = "writtenTestToolStripMenuItem";
         this.writtenTestToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
         this.writtenTestToolStripMenuItem.Text = "Written Test";
         this.writtenTestToolStripMenuItem.Click += new System.EventHandler(this.writtenTestToolStripMenuItem_Click);
         // 
         // streetTestToolStripMenuItem
         // 
         this.streetTestToolStripMenuItem.Name = "streetTestToolStripMenuItem";
         this.streetTestToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
         this.streetTestToolStripMenuItem.Text = "Street Test";
         // 
         // toolStripMenuItem1
         // 
         this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
         this.toolStripMenuItem1.Name = "toolStripMenuItem1";
         this.toolStripMenuItem1.Size = new System.Drawing.Size(222, 6);
         // 
         // tlsmShowPersonLicenseHistory
         // 
         this.tlsmShowPersonLicenseHistory.Name = "tlsmShowPersonLicenseHistory";
         this.tlsmShowPersonLicenseHistory.Size = new System.Drawing.Size(225, 22);
         this.tlsmShowPersonLicenseHistory.Text = "Show Person License History";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.label1.Location = new System.Drawing.Point(18, 473);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(97, 24);
         this.label1.TabIndex = 55;
         this.label1.Text = "# Record:";
         // 
         // lblLDVLAppNumber
         // 
         this.lblLDVLAppNumber.AutoSize = true;
         this.lblLDVLAppNumber.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblLDVLAppNumber.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.lblLDVLAppNumber.Location = new System.Drawing.Point(116, 473);
         this.lblLDVLAppNumber.Name = "lblLDVLAppNumber";
         this.lblLDVLAppNumber.Size = new System.Drawing.Size(43, 24);
         this.lblLDVLAppNumber.TabIndex = 56;
         this.lblLDVLAppNumber.Text = "???";
         // 
         // frmListLocalDrivingLicenseApplication
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
         this.ClientSize = new System.Drawing.Size(946, 503);
         this.Controls.Add(this.lblLDVLAppNumber);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.dgvDrivingLincesApplications);
         this.Controls.Add(this.panel1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
         this.Name = "frmListLocalDrivingLicenseApplication";
         this.Text = "List Driving License Application";
         this.Load += new System.EventHandler(this.frmListDrivingLicenseApplication_Load);
         this.panel1.ResumeLayout(false);
         this.panel1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.dgvDrivingLincesApplications)).EndInit();
         this.ctmsApplication.ResumeLayout(false);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.Label lblTitle;
      private System.Windows.Forms.DataGridView dgvDrivingLincesApplications;
      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.Button bntAddNewApplication;
      private System.Windows.Forms.TextBox txtFilterValue;
      private System.Windows.Forms.ComboBox cbFilterBy;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.ComboBox cbStatus;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label lblLDVLAppNumber;
      private System.Windows.Forms.ContextMenuStrip ctmsApplication;
      private System.Windows.Forms.ToolStripMenuItem tlsmShowApplicationDetails;
      private System.Windows.Forms.ToolStripMenuItem tlsmEditApplication;
      private System.Windows.Forms.ToolStripMenuItem tlsmCancelApplication;
      private System.Windows.Forms.ToolStripMenuItem tlsmDeleteApplication;
      private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
      private System.Windows.Forms.ToolStripMenuItem tlsmSecheduleTest;
      private System.Windows.Forms.ToolStripMenuItem vistionTestToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem writtenTestToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem streetTestToolStripMenuItem;
      private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
      private System.Windows.Forms.ToolStripMenuItem tlsmShowPersonLicenseHistory;
   }
}