namespace DVLD.People
{
   partial class frmMain
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
         this.panel1 = new System.Windows.Forms.Panel();
         this.btnCloseLogin = new System.Windows.Forms.Button();
         this.menuStrip1 = new System.Windows.Forms.MenuStrip();
         this.tolStripApplication = new System.Windows.Forms.ToolStripMenuItem();
         this.drivingLicensesServicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.mangeApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.detianLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.mangeApplicationTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.mangeTestTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.tolStripPeople = new System.Windows.Forms.ToolStripMenuItem();
         this.tolStripDrivers = new System.Windows.Forms.ToolStripMenuItem();
         this.tolStripUsers = new System.Windows.Forms.ToolStripMenuItem();
         this.tolStripAccountSettings = new System.Windows.Forms.ToolStripMenuItem();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.panel1.SuspendLayout();
         this.menuStrip1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.SuspendLayout();
         // 
         // panel1
         // 
         this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(33)))), ((int)(((byte)(67)))));
         this.panel1.Controls.Add(this.pictureBox1);
         this.panel1.Controls.Add(this.btnCloseLogin);
         this.panel1.Controls.Add(this.menuStrip1);
         this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.panel1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
         this.panel1.Location = new System.Drawing.Point(0, 0);
         this.panel1.Name = "panel1";
         this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
         this.panel1.Size = new System.Drawing.Size(1255, 516);
         this.panel1.TabIndex = 0;
         // 
         // btnCloseLogin
         // 
         this.btnCloseLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(33)))), ((int)(((byte)(67)))));
         this.btnCloseLogin.FlatAppearance.BorderSize = 0;
         this.btnCloseLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnCloseLogin.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnCloseLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(83)))), ((int)(((byte)(100)))));
         this.btnCloseLogin.Location = new System.Drawing.Point(1214, 0);
         this.btnCloseLogin.Name = "btnCloseLogin";
         this.btnCloseLogin.Size = new System.Drawing.Size(41, 30);
         this.btnCloseLogin.TabIndex = 12;
         this.btnCloseLogin.Text = "X";
         this.btnCloseLogin.UseVisualStyleBackColor = false;
         this.btnCloseLogin.Click += new System.EventHandler(this.btnCloseLogin_Click);
         // 
         // menuStrip1
         // 
         this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(36)))));
         this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
         this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tolStripApplication,
            this.tolStripPeople,
            this.tolStripDrivers,
            this.tolStripUsers,
            this.tolStripAccountSettings});
         this.menuStrip1.Location = new System.Drawing.Point(0, 0);
         this.menuStrip1.Name = "menuStrip1";
         this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 110, 5, 5);
         this.menuStrip1.Size = new System.Drawing.Size(161, 516);
         this.menuStrip1.Stretch = false;
         this.menuStrip1.TabIndex = 0;
         this.menuStrip1.Text = "menuStrip1";
         // 
         // tolStripApplication
         // 
         this.tolStripApplication.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drivingLicensesServicesToolStripMenuItem,
            this.mangeApplicationsToolStripMenuItem,
            this.detianLicensesToolStripMenuItem,
            this.mangeApplicationTypesToolStripMenuItem,
            this.mangeTestTypesToolStripMenuItem});
         this.tolStripApplication.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
         this.tolStripApplication.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.tolStripApplication.Margin = new System.Windows.Forms.Padding(0, 30, 0, 30);
         this.tolStripApplication.Name = "tolStripApplication";
         this.tolStripApplication.Padding = new System.Windows.Forms.Padding(0);
         this.tolStripApplication.Size = new System.Drawing.Size(140, 21);
         this.tolStripApplication.Text = "Application";
         // 
         // drivingLicensesServicesToolStripMenuItem
         // 
         this.drivingLicensesServicesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(36)))));
         this.drivingLicensesServicesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
         this.drivingLicensesServicesToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
         this.drivingLicensesServicesToolStripMenuItem.Name = "drivingLicensesServicesToolStripMenuItem";
         this.drivingLicensesServicesToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
         this.drivingLicensesServicesToolStripMenuItem.Text = "Driving Licenses Services";
         // 
         // mangeApplicationsToolStripMenuItem
         // 
         this.mangeApplicationsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(36)))));
         this.mangeApplicationsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
         this.mangeApplicationsToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
         this.mangeApplicationsToolStripMenuItem.Name = "mangeApplicationsToolStripMenuItem";
         this.mangeApplicationsToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
         this.mangeApplicationsToolStripMenuItem.Text = "Mange Applications";
         // 
         // detianLicensesToolStripMenuItem
         // 
         this.detianLicensesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(36)))));
         this.detianLicensesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
         this.detianLicensesToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
         this.detianLicensesToolStripMenuItem.Name = "detianLicensesToolStripMenuItem";
         this.detianLicensesToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
         this.detianLicensesToolStripMenuItem.Text = "Detian Licenses";
         // 
         // mangeApplicationTypesToolStripMenuItem
         // 
         this.mangeApplicationTypesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(36)))));
         this.mangeApplicationTypesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.mangeApplicationTypesToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
         this.mangeApplicationTypesToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this.mangeApplicationTypesToolStripMenuItem.Name = "mangeApplicationTypesToolStripMenuItem";
         this.mangeApplicationTypesToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
         this.mangeApplicationTypesToolStripMenuItem.Text = "Mange Application Types";
         this.mangeApplicationTypesToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
         this.mangeApplicationTypesToolStripMenuItem.Click += new System.EventHandler(this.mangeApplicationTypesToolStripMenuItem_Click);
         // 
         // mangeTestTypesToolStripMenuItem
         // 
         this.mangeTestTypesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(36)))));
         this.mangeTestTypesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
         this.mangeTestTypesToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
         this.mangeTestTypesToolStripMenuItem.Name = "mangeTestTypesToolStripMenuItem";
         this.mangeTestTypesToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
         this.mangeTestTypesToolStripMenuItem.Text = "Mange Test Types";
         this.mangeTestTypesToolStripMenuItem.Click += new System.EventHandler(this.mangeTestTypesToolStripMenuItem_Click);
         // 
         // tolStripPeople
         // 
         this.tolStripPeople.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
         this.tolStripPeople.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.tolStripPeople.Margin = new System.Windows.Forms.Padding(0, 30, 0, 30);
         this.tolStripPeople.Name = "tolStripPeople";
         this.tolStripPeople.Size = new System.Drawing.Size(140, 21);
         this.tolStripPeople.Text = "People";
         this.tolStripPeople.Click += new System.EventHandler(this.tolStripPeople_Click);
         // 
         // tolStripDrivers
         // 
         this.tolStripDrivers.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
         this.tolStripDrivers.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.tolStripDrivers.Margin = new System.Windows.Forms.Padding(0, 30, 0, 30);
         this.tolStripDrivers.Name = "tolStripDrivers";
         this.tolStripDrivers.Size = new System.Drawing.Size(140, 21);
         this.tolStripDrivers.Text = "Drivers";
         // 
         // tolStripUsers
         // 
         this.tolStripUsers.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
         this.tolStripUsers.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.tolStripUsers.Margin = new System.Windows.Forms.Padding(0, 30, 0, 30);
         this.tolStripUsers.Name = "tolStripUsers";
         this.tolStripUsers.Size = new System.Drawing.Size(140, 21);
         this.tolStripUsers.Text = "Users";
         this.tolStripUsers.Click += new System.EventHandler(this.tolStripUsers_Click);
         // 
         // tolStripAccountSettings
         // 
         this.tolStripAccountSettings.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
         this.tolStripAccountSettings.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.tolStripAccountSettings.Margin = new System.Windows.Forms.Padding(0, 30, 0, 30);
         this.tolStripAccountSettings.Name = "tolStripAccountSettings";
         this.tolStripAccountSettings.Size = new System.Drawing.Size(140, 21);
         this.tolStripAccountSettings.Text = "Account Settings";
         // 
         // pictureBox1
         // 
         this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(36)))));
         this.pictureBox1.Image = global::DVLD.Properties.Resources.gzexperts_logo;
         this.pictureBox1.Location = new System.Drawing.Point(12, 12);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(125, 97);
         this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.pictureBox1.TabIndex = 13;
         this.pictureBox1.TabStop = false;
         // 
         // frmMain
         // 
         this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1255, 516);
         this.Controls.Add(this.panel1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Name = "frmMain";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Dashboard";
         this.panel1.ResumeLayout(false);
         this.panel1.PerformLayout();
         this.menuStrip1.ResumeLayout(false);
         this.menuStrip1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.MenuStrip menuStrip1;
      private System.Windows.Forms.ToolStripMenuItem tolStripApplication;
      private System.Windows.Forms.ToolStripMenuItem tolStripPeople;
      private System.Windows.Forms.ToolStripMenuItem tolStripDrivers;
      private System.Windows.Forms.ToolStripMenuItem tolStripUsers;
      private System.Windows.Forms.Button btnCloseLogin;
      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.ToolStripMenuItem tolStripAccountSettings;
      private System.Windows.Forms.ToolStripMenuItem drivingLicensesServicesToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem mangeApplicationsToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem mangeApplicationTypesToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem mangeTestTypesToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem detianLicensesToolStripMenuItem;
   }
}