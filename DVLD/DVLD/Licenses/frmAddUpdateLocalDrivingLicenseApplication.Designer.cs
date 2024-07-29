namespace DVLD.Licenses
{
   partial class frmAddUpdateLocalDrivingLicenseApplication
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
         this.lblTitle = new System.Windows.Forms.Label();
         this.tabApplication = new System.Windows.Forms.TabControl();
         this.tabPersonInfo = new System.Windows.Forms.TabPage();
         this.btnNext = new System.Windows.Forms.Button();
         this.ctrlPersonInfoWithFilter1 = new DVLD.People.Controls.ctrlPersonInfoWithFilter();
         this.tabApplicationInfo = new System.Windows.Forms.TabPage();
         this.cbLicenseClasses = new System.Windows.Forms.ComboBox();
         this.lblCreatedByUser = new System.Windows.Forms.Label();
         this.label9 = new System.Windows.Forms.Label();
         this.lblApplicationFees = new System.Windows.Forms.Label();
         this.label7 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.lblApplicationDate = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.lblApplicationID = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.panel1 = new System.Windows.Forms.Panel();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.btnClose = new System.Windows.Forms.Button();
         this.btnSave = new System.Windows.Forms.Button();
         this.tabApplication.SuspendLayout();
         this.tabPersonInfo.SuspendLayout();
         this.tabApplicationInfo.SuspendLayout();
         this.panel1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.SuspendLayout();
         // 
         // lblTitle
         // 
         this.lblTitle.AutoSize = true;
         this.lblTitle.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.lblTitle.Location = new System.Drawing.Point(543, 21);
         this.lblTitle.Name = "lblTitle";
         this.lblTitle.Size = new System.Drawing.Size(176, 25);
         this.lblTitle.TabIndex = 17;
         this.lblTitle.Text = "Mange People";
         // 
         // tabApplication
         // 
         this.tabApplication.Controls.Add(this.tabPersonInfo);
         this.tabApplication.Controls.Add(this.tabApplicationInfo);
         this.tabApplication.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.tabApplication.Location = new System.Drawing.Point(12, 49);
         this.tabApplication.Multiline = true;
         this.tabApplication.Name = "tabApplication";
         this.tabApplication.SelectedIndex = 0;
         this.tabApplication.Size = new System.Drawing.Size(1239, 525);
         this.tabApplication.TabIndex = 18;
         // 
         // tabPersonInfo
         // 
         this.tabPersonInfo.BackColor = System.Drawing.Color.DarkGray;
         this.tabPersonInfo.Controls.Add(this.btnNext);
         this.tabPersonInfo.Controls.Add(this.ctrlPersonInfoWithFilter1);
         this.tabPersonInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
         this.tabPersonInfo.Location = new System.Drawing.Point(4, 23);
         this.tabPersonInfo.Name = "tabPersonInfo";
         this.tabPersonInfo.Padding = new System.Windows.Forms.Padding(3);
         this.tabPersonInfo.Size = new System.Drawing.Size(1231, 498);
         this.tabPersonInfo.TabIndex = 0;
         this.tabPersonInfo.Text = "Person Info";
         // 
         // btnNext
         // 
         this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
         this.btnNext.Enabled = false;
         this.btnNext.FlatAppearance.BorderSize = 0;
         this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnNext.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(36)))));
         this.btnNext.Location = new System.Drawing.Point(1023, 462);
         this.btnNext.Name = "btnNext";
         this.btnNext.Size = new System.Drawing.Size(202, 30);
         this.btnNext.TabIndex = 21;
         this.btnNext.Text = "Next";
         this.btnNext.UseVisualStyleBackColor = false;
         this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
         // 
         // ctrlPersonInfoWithFilter1
         // 
         this.ctrlPersonInfoWithFilter1.BackColor = System.Drawing.Color.Gainsboro;
         this.ctrlPersonInfoWithFilter1.FilterEnable = true;
         this.ctrlPersonInfoWithFilter1.Location = new System.Drawing.Point(-4, 3);
         this.ctrlPersonInfoWithFilter1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
         this.ctrlPersonInfoWithFilter1.Name = "ctrlPersonInfoWithFilter1";
         this.ctrlPersonInfoWithFilter1.ShowAddPerson = true;
         this.ctrlPersonInfoWithFilter1.Size = new System.Drawing.Size(1239, 495);
         this.ctrlPersonInfoWithFilter1.TabIndex = 22;
         this.ctrlPersonInfoWithFilter1.OnPersonSelected += new System.Action<int>(this.ctrlPersonInfoWithFilter1_OnPersonSelected);
         // 
         // tabApplicationInfo
         // 
         this.tabApplicationInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
         this.tabApplicationInfo.Controls.Add(this.cbLicenseClasses);
         this.tabApplicationInfo.Controls.Add(this.lblCreatedByUser);
         this.tabApplicationInfo.Controls.Add(this.label9);
         this.tabApplicationInfo.Controls.Add(this.lblApplicationFees);
         this.tabApplicationInfo.Controls.Add(this.label7);
         this.tabApplicationInfo.Controls.Add(this.label5);
         this.tabApplicationInfo.Controls.Add(this.lblApplicationDate);
         this.tabApplicationInfo.Controls.Add(this.label2);
         this.tabApplicationInfo.Controls.Add(this.lblApplicationID);
         this.tabApplicationInfo.Controls.Add(this.label3);
         this.tabApplicationInfo.Controls.Add(this.panel1);
         this.tabApplicationInfo.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.tabApplicationInfo.Location = new System.Drawing.Point(4, 23);
         this.tabApplicationInfo.Name = "tabApplicationInfo";
         this.tabApplicationInfo.Padding = new System.Windows.Forms.Padding(3);
         this.tabApplicationInfo.Size = new System.Drawing.Size(1231, 498);
         this.tabApplicationInfo.TabIndex = 1;
         this.tabApplicationInfo.Text = "Application Info";
         // 
         // cbLicenseClasses
         // 
         this.cbLicenseClasses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cbLicenseClasses.Font = new System.Drawing.Font("Verdana", 13.25F, System.Drawing.FontStyle.Bold);
         this.cbLicenseClasses.ImeMode = System.Windows.Forms.ImeMode.NoControl;
         this.cbLicenseClasses.Location = new System.Drawing.Point(200, 223);
         this.cbLicenseClasses.Name = "cbLicenseClasses";
         this.cbLicenseClasses.Size = new System.Drawing.Size(359, 30);
         this.cbLicenseClasses.TabIndex = 39;
         // 
         // lblCreatedByUser
         // 
         this.lblCreatedByUser.AutoSize = true;
         this.lblCreatedByUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
         this.lblCreatedByUser.Font = new System.Drawing.Font("Verdana", 13.25F, System.Drawing.FontStyle.Bold);
         this.lblCreatedByUser.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.lblCreatedByUser.Location = new System.Drawing.Point(196, 365);
         this.lblCreatedByUser.Name = "lblCreatedByUser";
         this.lblCreatedByUser.Size = new System.Drawing.Size(43, 22);
         this.lblCreatedByUser.TabIndex = 38;
         this.lblCreatedByUser.Text = "???";
         // 
         // label9
         // 
         this.label9.AutoSize = true;
         this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
         this.label9.Font = new System.Drawing.Font("Verdana", 13.25F, System.Drawing.FontStyle.Bold);
         this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.label9.Location = new System.Drawing.Point(14, 365);
         this.label9.Name = "label9";
         this.label9.Size = new System.Drawing.Size(169, 22);
         this.label9.TabIndex = 37;
         this.label9.Text = "CreatedByUser:";
         // 
         // lblApplicationFees
         // 
         this.lblApplicationFees.AutoSize = true;
         this.lblApplicationFees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
         this.lblApplicationFees.Font = new System.Drawing.Font("Verdana", 13.25F, System.Drawing.FontStyle.Bold);
         this.lblApplicationFees.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.lblApplicationFees.Location = new System.Drawing.Point(198, 295);
         this.lblApplicationFees.Name = "lblApplicationFees";
         this.lblApplicationFees.Size = new System.Drawing.Size(43, 22);
         this.lblApplicationFees.TabIndex = 36;
         this.lblApplicationFees.Text = "???";
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
         this.label7.Font = new System.Drawing.Font("Verdana", 13.25F, System.Drawing.FontStyle.Bold);
         this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.label7.Location = new System.Drawing.Point(14, 295);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(184, 22);
         this.label7.TabIndex = 35;
         this.label7.Text = "Application Fees:";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
         this.label5.Font = new System.Drawing.Font("Verdana", 13.25F, System.Drawing.FontStyle.Bold);
         this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.label5.Location = new System.Drawing.Point(14, 227);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(175, 22);
         this.label5.TabIndex = 33;
         this.label5.Text = "License Classes:";
         // 
         // lblApplicationDate
         // 
         this.lblApplicationDate.AutoSize = true;
         this.lblApplicationDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
         this.lblApplicationDate.Font = new System.Drawing.Font("Verdana", 13.25F, System.Drawing.FontStyle.Bold);
         this.lblApplicationDate.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.lblApplicationDate.Location = new System.Drawing.Point(200, 170);
         this.lblApplicationDate.Name = "lblApplicationDate";
         this.lblApplicationDate.Size = new System.Drawing.Size(43, 22);
         this.lblApplicationDate.TabIndex = 32;
         this.lblApplicationDate.Text = "???";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
         this.label2.Font = new System.Drawing.Font("Verdana", 13.25F, System.Drawing.FontStyle.Bold);
         this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.label2.Location = new System.Drawing.Point(14, 170);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(184, 22);
         this.label2.TabIndex = 31;
         this.label2.Text = "Application Date:";
         // 
         // lblApplicationID
         // 
         this.lblApplicationID.AutoSize = true;
         this.lblApplicationID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
         this.lblApplicationID.Font = new System.Drawing.Font("Verdana", 13.25F, System.Drawing.FontStyle.Bold);
         this.lblApplicationID.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.lblApplicationID.Location = new System.Drawing.Point(126, 109);
         this.lblApplicationID.Name = "lblApplicationID";
         this.lblApplicationID.Size = new System.Drawing.Size(43, 22);
         this.lblApplicationID.TabIndex = 30;
         this.lblApplicationID.Text = "???";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
         this.label3.Font = new System.Drawing.Font("Verdana", 13.25F, System.Drawing.FontStyle.Bold);
         this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.label3.Location = new System.Drawing.Point(14, 109);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(106, 22);
         this.label3.TabIndex = 29;
         this.label3.Text = "L.DLA ID:";
         // 
         // panel1
         // 
         this.panel1.Controls.Add(this.pictureBox1);
         this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
         this.panel1.Location = new System.Drawing.Point(727, 3);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(501, 492);
         this.panel1.TabIndex = 22;
         // 
         // pictureBox1
         // 
         this.pictureBox1.Image = global::DVLD.Properties.Resources.App;
         this.pictureBox1.Location = new System.Drawing.Point(6, 64);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(495, 359);
         this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.pictureBox1.TabIndex = 0;
         this.pictureBox1.TabStop = false;
         // 
         // btnClose
         // 
         this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
         this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.btnClose.FlatAppearance.BorderSize = 0;
         this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnClose.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(36)))));
         this.btnClose.Location = new System.Drawing.Point(1147, 586);
         this.btnClose.Name = "btnClose";
         this.btnClose.Size = new System.Drawing.Size(94, 30);
         this.btnClose.TabIndex = 19;
         this.btnClose.Text = "Close";
         this.btnClose.UseVisualStyleBackColor = false;
         // 
         // btnSave
         // 
         this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
         this.btnSave.FlatAppearance.BorderSize = 0;
         this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnSave.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(36)))));
         this.btnSave.Location = new System.Drawing.Point(1036, 586);
         this.btnSave.Name = "btnSave";
         this.btnSave.Size = new System.Drawing.Size(94, 30);
         this.btnSave.TabIndex = 20;
         this.btnSave.Text = "Save";
         this.btnSave.UseVisualStyleBackColor = false;
         this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
         // 
         // frmAddUpdateLocalDrivingLicenseApplication
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
         this.ClientSize = new System.Drawing.Size(1263, 624);
         this.Controls.Add(this.btnSave);
         this.Controls.Add(this.btnClose);
         this.Controls.Add(this.tabApplication);
         this.Controls.Add(this.lblTitle);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
         this.Name = "frmAddUpdateLocalDrivingLicenseApplication";
         this.Text = "Local Driving License Application";
         this.Load += new System.EventHandler(this.frmAddUpdateLocalDrivingLicenseApplication_Load);
         this.tabApplication.ResumeLayout(false);
         this.tabPersonInfo.ResumeLayout(false);
         this.tabApplicationInfo.ResumeLayout(false);
         this.tabApplicationInfo.PerformLayout();
         this.panel1.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label lblTitle;
      private System.Windows.Forms.TabControl tabApplication;
      private System.Windows.Forms.TabPage tabPersonInfo;
      private System.Windows.Forms.TabPage tabApplicationInfo;
      private System.Windows.Forms.Button btnNext;
      private System.Windows.Forms.Button btnClose;
      private System.Windows.Forms.Button btnSave;
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.Label lblCreatedByUser;
      private System.Windows.Forms.Label label9;
      private System.Windows.Forms.Label lblApplicationFees;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label lblApplicationDate;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label lblApplicationID;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.ComboBox cbLicenseClasses;
      private People.Controls.ctrlPersonInfoWithFilter ctrlPersonInfoWithFilter1;
   }
}