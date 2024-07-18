namespace DVLD.Applications
{
   partial class frmLocalDrivingLicenseApplication
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
         this.tabCtrlApp = new System.Windows.Forms.TabControl();
         this.tabpPersonInfo = new System.Windows.Forms.TabPage();
         this.btnNext = new System.Windows.Forms.Button();
         this.tabpApplicationInfo = new System.Windows.Forms.TabPage();
         this.cmbLicenseClasses = new System.Windows.Forms.ComboBox();
         this.lblCreatedByUser = new System.Windows.Forms.Label();
         this.labl = new System.Windows.Forms.Label();
         this.label6 = new System.Windows.Forms.Label();
         this.label7 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.labApplicationDate = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.lblUserID = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.panel1 = new System.Windows.Forms.Panel();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.lblTitle = new System.Windows.Forms.Label();
         this.btnSave = new System.Windows.Forms.Button();
         this.btnCloseLogin = new System.Windows.Forms.Button();
         this.ctrlPersonInfoWithFilter1 = new DVLD.People.Controls.ctrlPersonInfoWithFilter();
         this.tabCtrlApp.SuspendLayout();
         this.tabpPersonInfo.SuspendLayout();
         this.tabpApplicationInfo.SuspendLayout();
         this.panel1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.SuspendLayout();
         // 
         // tabCtrlApp
         // 
         this.tabCtrlApp.Controls.Add(this.tabpPersonInfo);
         this.tabCtrlApp.Controls.Add(this.tabpApplicationInfo);
         this.tabCtrlApp.Location = new System.Drawing.Point(3, 52);
         this.tabCtrlApp.Name = "tabCtrlApp";
         this.tabCtrlApp.SelectedIndex = 0;
         this.tabCtrlApp.Size = new System.Drawing.Size(958, 525);
         this.tabCtrlApp.TabIndex = 0;
         // 
         // tabpPersonInfo
         // 
         this.tabpPersonInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
         this.tabpPersonInfo.Controls.Add(this.ctrlPersonInfoWithFilter1);
         this.tabpPersonInfo.Controls.Add(this.btnNext);
         this.tabpPersonInfo.Location = new System.Drawing.Point(4, 22);
         this.tabpPersonInfo.Name = "tabpPersonInfo";
         this.tabpPersonInfo.Padding = new System.Windows.Forms.Padding(3);
         this.tabpPersonInfo.Size = new System.Drawing.Size(950, 499);
         this.tabpPersonInfo.TabIndex = 0;
         this.tabpPersonInfo.Text = "Person Info";
         // 
         // btnNext
         // 
         this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(208)))), ((int)(((byte)(214)))));
         this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
         this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnNext.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold);
         this.btnNext.ForeColor = System.Drawing.Color.Black;
         this.btnNext.Location = new System.Drawing.Point(758, 464);
         this.btnNext.Name = "btnNext";
         this.btnNext.Size = new System.Drawing.Size(186, 31);
         this.btnNext.TabIndex = 6;
         this.btnNext.Text = "Next";
         this.btnNext.UseVisualStyleBackColor = false;
         this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
         // 
         // tabpApplicationInfo
         // 
         this.tabpApplicationInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(37)))), ((int)(((byte)(73)))));
         this.tabpApplicationInfo.Controls.Add(this.cmbLicenseClasses);
         this.tabpApplicationInfo.Controls.Add(this.lblCreatedByUser);
         this.tabpApplicationInfo.Controls.Add(this.labl);
         this.tabpApplicationInfo.Controls.Add(this.label6);
         this.tabpApplicationInfo.Controls.Add(this.label7);
         this.tabpApplicationInfo.Controls.Add(this.label5);
         this.tabpApplicationInfo.Controls.Add(this.labApplicationDate);
         this.tabpApplicationInfo.Controls.Add(this.label3);
         this.tabpApplicationInfo.Controls.Add(this.lblUserID);
         this.tabpApplicationInfo.Controls.Add(this.label1);
         this.tabpApplicationInfo.Controls.Add(this.panel1);
         this.tabpApplicationInfo.Location = new System.Drawing.Point(4, 22);
         this.tabpApplicationInfo.Name = "tabpApplicationInfo";
         this.tabpApplicationInfo.Padding = new System.Windows.Forms.Padding(3);
         this.tabpApplicationInfo.Size = new System.Drawing.Size(950, 499);
         this.tabpApplicationInfo.TabIndex = 1;
         this.tabpApplicationInfo.Text = "Application Info";
         // 
         // cmbLicenseClasses
         // 
         this.cmbLicenseClasses.FormattingEnabled = true;
         this.cmbLicenseClasses.Location = new System.Drawing.Point(183, 255);
         this.cmbLicenseClasses.Name = "cmbLicenseClasses";
         this.cmbLicenseClasses.Size = new System.Drawing.Size(177, 21);
         this.cmbLicenseClasses.TabIndex = 40;
         // 
         // lblCreatedByUser
         // 
         this.lblCreatedByUser.AutoSize = true;
         this.lblCreatedByUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(37)))), ((int)(((byte)(73)))));
         this.lblCreatedByUser.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblCreatedByUser.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.lblCreatedByUser.Location = new System.Drawing.Point(188, 361);
         this.lblCreatedByUser.Name = "lblCreatedByUser";
         this.lblCreatedByUser.Size = new System.Drawing.Size(43, 24);
         this.lblCreatedByUser.TabIndex = 39;
         this.lblCreatedByUser.Text = "???";
         // 
         // labl
         // 
         this.labl.AutoSize = true;
         this.labl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(37)))), ((int)(((byte)(73)))));
         this.labl.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.labl.ForeColor = System.Drawing.Color.Gainsboro;
         this.labl.Location = new System.Drawing.Point(24, 361);
         this.labl.Name = "labl";
         this.labl.Size = new System.Drawing.Size(148, 24);
         this.labl.TabIndex = 38;
         this.labl.Text = "CreatedByUser:";
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(37)))), ((int)(((byte)(73)))));
         this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.label6.Location = new System.Drawing.Point(192, 304);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(34, 24);
         this.label6.TabIndex = 37;
         this.label6.Text = "15";
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(37)))), ((int)(((byte)(73)))));
         this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label7.ForeColor = System.Drawing.Color.Gainsboro;
         this.label7.Location = new System.Drawing.Point(24, 304);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(167, 24);
         this.label7.TabIndex = 36;
         this.label7.Text = "Application Fees:";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(37)))), ((int)(((byte)(73)))));
         this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label5.ForeColor = System.Drawing.Color.Gainsboro;
         this.label5.Location = new System.Drawing.Point(24, 251);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(140, 24);
         this.label5.TabIndex = 34;
         this.label5.Text = "License Class:";
         // 
         // labApplicationDate
         // 
         this.labApplicationDate.AutoSize = true;
         this.labApplicationDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(37)))), ((int)(((byte)(73)))));
         this.labApplicationDate.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.labApplicationDate.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.labApplicationDate.Location = new System.Drawing.Point(188, 191);
         this.labApplicationDate.Name = "labApplicationDate";
         this.labApplicationDate.Size = new System.Drawing.Size(43, 24);
         this.labApplicationDate.TabIndex = 33;
         this.labApplicationDate.Text = "???";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(37)))), ((int)(((byte)(73)))));
         this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.ForeColor = System.Drawing.Color.Gainsboro;
         this.label3.Location = new System.Drawing.Point(24, 191);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(160, 24);
         this.label3.TabIndex = 32;
         this.label3.Text = "ApplicationData:";
         // 
         // lblUserID
         // 
         this.lblUserID.AutoSize = true;
         this.lblUserID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(37)))), ((int)(((byte)(73)))));
         this.lblUserID.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblUserID.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.lblUserID.Location = new System.Drawing.Point(188, 127);
         this.lblUserID.Name = "lblUserID";
         this.lblUserID.Size = new System.Drawing.Size(43, 24);
         this.lblUserID.TabIndex = 31;
         this.lblUserID.Text = "???";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(37)))), ((int)(((byte)(73)))));
         this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.ForeColor = System.Drawing.Color.Gainsboro;
         this.label1.Location = new System.Drawing.Point(24, 127);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(159, 24);
         this.label1.TabIndex = 30;
         this.label1.Text = "DL ApplicaionID:";
         // 
         // panel1
         // 
         this.panel1.Controls.Add(this.pictureBox1);
         this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
         this.panel1.Location = new System.Drawing.Point(450, 3);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(497, 493);
         this.panel1.TabIndex = 0;
         // 
         // pictureBox1
         // 
         this.pictureBox1.Image = global::DVLD.Properties.Resources.select;
         this.pictureBox1.Location = new System.Drawing.Point(21, 19);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(457, 451);
         this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.pictureBox1.TabIndex = 0;
         this.pictureBox1.TabStop = false;
         // 
         // lblTitle
         // 
         this.lblTitle.AutoSize = true;
         this.lblTitle.BackColor = System.Drawing.Color.Transparent;
         this.lblTitle.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblTitle.ForeColor = System.Drawing.Color.Gainsboro;
         this.lblTitle.Location = new System.Drawing.Point(246, 29);
         this.lblTitle.Name = "lblTitle";
         this.lblTitle.Size = new System.Drawing.Size(442, 30);
         this.lblTitle.TabIndex = 48;
         this.lblTitle.Text = "New Local Driving License Application";
         // 
         // btnSave
         // 
         this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(154)))), ((int)(((byte)(231)))));
         this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
         this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnSave.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnSave.ForeColor = System.Drawing.Color.White;
         this.btnSave.Location = new System.Drawing.Point(754, 583);
         this.btnSave.Name = "btnSave";
         this.btnSave.Size = new System.Drawing.Size(94, 30);
         this.btnSave.TabIndex = 49;
         this.btnSave.Text = "Save";
         this.btnSave.UseVisualStyleBackColor = false;
         // 
         // btnCloseLogin
         // 
         this.btnCloseLogin.BackColor = System.Drawing.Color.DimGray;
         this.btnCloseLogin.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
         this.btnCloseLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnCloseLogin.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnCloseLogin.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.btnCloseLogin.Location = new System.Drawing.Point(867, 583);
         this.btnCloseLogin.Name = "btnCloseLogin";
         this.btnCloseLogin.Size = new System.Drawing.Size(94, 30);
         this.btnCloseLogin.TabIndex = 50;
         this.btnCloseLogin.Text = "Close";
         this.btnCloseLogin.UseVisualStyleBackColor = false;
         // 
         // ctrlPersonInfoWithFilter1
         // 
         this.ctrlPersonInfoWithFilter1.BackColor = System.Drawing.Color.Gainsboro;
         this.ctrlPersonInfoWithFilter1.Dock = System.Windows.Forms.DockStyle.Top;
         this.ctrlPersonInfoWithFilter1.FilterEnable = true;
         this.ctrlPersonInfoWithFilter1.Location = new System.Drawing.Point(3, 3);
         this.ctrlPersonInfoWithFilter1.Name = "ctrlPersonInfoWithFilter1";
         this.ctrlPersonInfoWithFilter1.ShowAddPerson = true;
         this.ctrlPersonInfoWithFilter1.Size = new System.Drawing.Size(944, 453);
         this.ctrlPersonInfoWithFilter1.TabIndex = 7;
         // 
         // frmLocalDrivingLicenseApplication
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
         this.ClientSize = new System.Drawing.Size(973, 625);
         this.Controls.Add(this.btnSave);
         this.Controls.Add(this.btnCloseLogin);
         this.Controls.Add(this.lblTitle);
         this.Controls.Add(this.tabCtrlApp);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
         this.Name = "frmLocalDrivingLicenseApplication";
         this.Text = "Local Driving License Application";
         this.Load += new System.EventHandler(this.frmLocalDrivingLicenseApplication_Load);
         this.tabCtrlApp.ResumeLayout(false);
         this.tabpPersonInfo.ResumeLayout(false);
         this.tabpApplicationInfo.ResumeLayout(false);
         this.tabpApplicationInfo.PerformLayout();
         this.panel1.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TabControl tabCtrlApp;
      private System.Windows.Forms.TabPage tabpPersonInfo;
      private System.Windows.Forms.TabPage tabpApplicationInfo;
      private System.Windows.Forms.Label lblTitle;
      private System.Windows.Forms.Button btnSave;
      private System.Windows.Forms.Button btnCloseLogin;
      private People.Controls.ctrlPersonInfoWithFilter ctrlPersonInfoWithFilter1;
      private System.Windows.Forms.Button btnNext;
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.Label lblCreatedByUser;
      private System.Windows.Forms.Label labl;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label labApplicationDate;
      private System.Windows.Forms.Label lblUserID;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.ComboBox cmbLicenseClasses;
   }
}