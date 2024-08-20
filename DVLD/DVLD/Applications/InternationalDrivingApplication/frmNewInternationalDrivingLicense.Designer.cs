namespace DVLD.Applications.InternationalDrivingApplication
{
   partial class frmNewInternationalDrivingLicense
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
         this.ctrlDriverLicenseInfoWithFilter1 = new DVLD.Licenses.Local_License.controls.ctrlDriverLicenseInfoWithFilter();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.lblCreatedBy = new System.Windows.Forms.Label();
         this.label9 = new System.Windows.Forms.Label();
         this.lblExpirationDate = new System.Windows.Forms.Label();
         this.label11 = new System.Windows.Forms.Label();
         this.lblLocalLicenseID = new System.Windows.Forms.Label();
         this.label13 = new System.Windows.Forms.Label();
         this.lblInternationalLicenseID = new System.Windows.Forms.Label();
         this.label15 = new System.Windows.Forms.Label();
         this.lblFees = new System.Windows.Forms.Label();
         this.label7 = new System.Windows.Forms.Label();
         this.lblIssueDate = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.lblApplicationDate = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.lblApplicationID = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.linkShowLicenseInfo = new System.Windows.Forms.LinkLabel();
         this.linkShowLicenseHistory = new System.Windows.Forms.LinkLabel();
         this.btnClose = new System.Windows.Forms.Button();
         this.btnIssueLicense = new System.Windows.Forms.Button();
         this.groupBox1.SuspendLayout();
         this.SuspendLayout();
         // 
         // ctrlDriverLicenseInfoWithFilter1
         // 
         this.ctrlDriverLicenseInfoWithFilter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(37)))), ((int)(((byte)(73)))));
         this.ctrlDriverLicenseInfoWithFilter1.FilterEnabled = true;
         this.ctrlDriverLicenseInfoWithFilter1.Location = new System.Drawing.Point(-2, 0);
         this.ctrlDriverLicenseInfoWithFilter1.Name = "ctrlDriverLicenseInfoWithFilter1";
         this.ctrlDriverLicenseInfoWithFilter1.Size = new System.Drawing.Size(882, 464);
         this.ctrlDriverLicenseInfoWithFilter1.TabIndex = 0;
         this.ctrlDriverLicenseInfoWithFilter1.OnLicenseSelected += new System.Action<int>(this.ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected);
         // 
         // groupBox1
         // 
         this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
         this.groupBox1.Controls.Add(this.lblCreatedBy);
         this.groupBox1.Controls.Add(this.label9);
         this.groupBox1.Controls.Add(this.lblExpirationDate);
         this.groupBox1.Controls.Add(this.label11);
         this.groupBox1.Controls.Add(this.lblLocalLicenseID);
         this.groupBox1.Controls.Add(this.label13);
         this.groupBox1.Controls.Add(this.lblInternationalLicenseID);
         this.groupBox1.Controls.Add(this.label15);
         this.groupBox1.Controls.Add(this.lblFees);
         this.groupBox1.Controls.Add(this.label7);
         this.groupBox1.Controls.Add(this.lblIssueDate);
         this.groupBox1.Controls.Add(this.label5);
         this.groupBox1.Controls.Add(this.lblApplicationDate);
         this.groupBox1.Controls.Add(this.label3);
         this.groupBox1.Controls.Add(this.lblApplicationID);
         this.groupBox1.Controls.Add(this.label1);
         this.groupBox1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold);
         this.groupBox1.ForeColor = System.Drawing.Color.Crimson;
         this.groupBox1.Location = new System.Drawing.Point(-2, 464);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(882, 159);
         this.groupBox1.TabIndex = 1;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "International License Info";
         // 
         // lblCreatedBy
         // 
         this.lblCreatedBy.AutoSize = true;
         this.lblCreatedBy.BackColor = System.Drawing.Color.Gainsboro;
         this.lblCreatedBy.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblCreatedBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
         this.lblCreatedBy.Location = new System.Drawing.Point(601, 122);
         this.lblCreatedBy.Name = "lblCreatedBy";
         this.lblCreatedBy.Size = new System.Drawing.Size(49, 21);
         this.lblCreatedBy.TabIndex = 121;
         this.lblCreatedBy.Text = "[???]";
         // 
         // label9
         // 
         this.label9.AutoSize = true;
         this.label9.BackColor = System.Drawing.Color.Gainsboro;
         this.label9.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
         this.label9.Location = new System.Drawing.Point(435, 122);
         this.label9.Name = "label9";
         this.label9.Size = new System.Drawing.Size(98, 21);
         this.label9.TabIndex = 120;
         this.label9.Text = "Created by:";
         // 
         // lblExpirationDate
         // 
         this.lblExpirationDate.AutoSize = true;
         this.lblExpirationDate.BackColor = System.Drawing.Color.Gainsboro;
         this.lblExpirationDate.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblExpirationDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
         this.lblExpirationDate.Location = new System.Drawing.Point(601, 93);
         this.lblExpirationDate.Name = "lblExpirationDate";
         this.lblExpirationDate.Size = new System.Drawing.Size(49, 21);
         this.lblExpirationDate.TabIndex = 119;
         this.lblExpirationDate.Text = "[???]";
         // 
         // label11
         // 
         this.label11.AutoSize = true;
         this.label11.BackColor = System.Drawing.Color.Gainsboro;
         this.label11.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
         this.label11.Location = new System.Drawing.Point(435, 93);
         this.label11.Name = "label11";
         this.label11.Size = new System.Drawing.Size(135, 21);
         this.label11.TabIndex = 118;
         this.label11.Text = "Expiration Date:";
         // 
         // lblLocalLicenseID
         // 
         this.lblLocalLicenseID.AutoSize = true;
         this.lblLocalLicenseID.BackColor = System.Drawing.Color.Gainsboro;
         this.lblLocalLicenseID.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblLocalLicenseID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
         this.lblLocalLicenseID.Location = new System.Drawing.Point(601, 57);
         this.lblLocalLicenseID.Name = "lblLocalLicenseID";
         this.lblLocalLicenseID.Size = new System.Drawing.Size(49, 21);
         this.lblLocalLicenseID.TabIndex = 117;
         this.lblLocalLicenseID.Text = "[???]";
         // 
         // label13
         // 
         this.label13.AutoSize = true;
         this.label13.BackColor = System.Drawing.Color.Gainsboro;
         this.label13.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
         this.label13.Location = new System.Drawing.Point(435, 57);
         this.label13.Name = "label13";
         this.label13.Size = new System.Drawing.Size(140, 21);
         this.label13.TabIndex = 116;
         this.label13.Text = "Local License ID:";
         // 
         // lblInternationalLicenseID
         // 
         this.lblInternationalLicenseID.AutoSize = true;
         this.lblInternationalLicenseID.BackColor = System.Drawing.Color.Gainsboro;
         this.lblInternationalLicenseID.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblInternationalLicenseID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
         this.lblInternationalLicenseID.Location = new System.Drawing.Point(601, 26);
         this.lblInternationalLicenseID.Name = "lblInternationalLicenseID";
         this.lblInternationalLicenseID.Size = new System.Drawing.Size(49, 21);
         this.lblInternationalLicenseID.TabIndex = 115;
         this.lblInternationalLicenseID.Text = "[???]";
         // 
         // label15
         // 
         this.label15.AutoSize = true;
         this.label15.BackColor = System.Drawing.Color.Gainsboro;
         this.label15.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
         this.label15.Location = new System.Drawing.Point(435, 26);
         this.label15.Name = "label15";
         this.label15.Size = new System.Drawing.Size(118, 21);
         this.label15.TabIndex = 114;
         this.label15.Text = "I.L License ID:";
         // 
         // lblFees
         // 
         this.lblFees.AutoSize = true;
         this.lblFees.BackColor = System.Drawing.Color.Gainsboro;
         this.lblFees.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblFees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
         this.lblFees.Location = new System.Drawing.Point(241, 122);
         this.lblFees.Name = "lblFees";
         this.lblFees.Size = new System.Drawing.Size(49, 21);
         this.lblFees.TabIndex = 113;
         this.lblFees.Text = "[???]";
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.BackColor = System.Drawing.Color.Gainsboro;
         this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
         this.label7.Location = new System.Drawing.Point(69, 122);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(50, 21);
         this.label7.TabIndex = 112;
         this.label7.Text = "Fees:";
         // 
         // lblIssueDate
         // 
         this.lblIssueDate.AutoSize = true;
         this.lblIssueDate.BackColor = System.Drawing.Color.Gainsboro;
         this.lblIssueDate.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblIssueDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
         this.lblIssueDate.Location = new System.Drawing.Point(241, 93);
         this.lblIssueDate.Name = "lblIssueDate";
         this.lblIssueDate.Size = new System.Drawing.Size(49, 21);
         this.lblIssueDate.TabIndex = 111;
         this.lblIssueDate.Text = "[???]";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.BackColor = System.Drawing.Color.Gainsboro;
         this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
         this.label5.Location = new System.Drawing.Point(69, 93);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(96, 21);
         this.label5.TabIndex = 110;
         this.label5.Text = "Issue Date:";
         // 
         // lblApplicationDate
         // 
         this.lblApplicationDate.AutoSize = true;
         this.lblApplicationDate.BackColor = System.Drawing.Color.Gainsboro;
         this.lblApplicationDate.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblApplicationDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
         this.lblApplicationDate.Location = new System.Drawing.Point(241, 57);
         this.lblApplicationDate.Name = "lblApplicationDate";
         this.lblApplicationDate.Size = new System.Drawing.Size(49, 21);
         this.lblApplicationDate.TabIndex = 109;
         this.lblApplicationDate.Text = "[???]";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.BackColor = System.Drawing.Color.Gainsboro;
         this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
         this.label3.Location = new System.Drawing.Point(69, 57);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(145, 21);
         this.label3.TabIndex = 108;
         this.label3.Text = "Application Date:";
         // 
         // lblApplicationID
         // 
         this.lblApplicationID.AutoSize = true;
         this.lblApplicationID.BackColor = System.Drawing.Color.Gainsboro;
         this.lblApplicationID.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblApplicationID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
         this.lblApplicationID.Location = new System.Drawing.Point(241, 26);
         this.lblApplicationID.Name = "lblApplicationID";
         this.lblApplicationID.Size = new System.Drawing.Size(49, 21);
         this.lblApplicationID.TabIndex = 107;
         this.lblApplicationID.Text = "[???]";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.BackColor = System.Drawing.Color.Gainsboro;
         this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
         this.label1.Location = new System.Drawing.Point(69, 26);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(149, 21);
         this.label1.TabIndex = 106;
         this.label1.Text = "I.L Application ID:";
         // 
         // linkShowLicenseInfo
         // 
         this.linkShowLicenseInfo.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
         this.linkShowLicenseInfo.AutoSize = true;
         this.linkShowLicenseInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(37)))), ((int)(((byte)(73)))));
         this.linkShowLicenseInfo.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.linkShowLicenseInfo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
         this.linkShowLicenseInfo.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
         this.linkShowLicenseInfo.LinkColor = System.Drawing.Color.RoyalBlue;
         this.linkShowLicenseInfo.Location = new System.Drawing.Point(198, 637);
         this.linkShowLicenseInfo.Name = "linkShowLicenseInfo";
         this.linkShowLicenseInfo.Size = new System.Drawing.Size(181, 21);
         this.linkShowLicenseInfo.TabIndex = 63;
         this.linkShowLicenseInfo.TabStop = true;
         this.linkShowLicenseInfo.Text = "Show New LicenseInfo";
         this.linkShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkShowLicenseInfo_LinkClicked);
         // 
         // linkShowLicenseHistory
         // 
         this.linkShowLicenseHistory.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
         this.linkShowLicenseHistory.AutoSize = true;
         this.linkShowLicenseHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(37)))), ((int)(((byte)(73)))));
         this.linkShowLicenseHistory.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.linkShowLicenseHistory.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
         this.linkShowLicenseHistory.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
         this.linkShowLicenseHistory.LinkColor = System.Drawing.Color.RoyalBlue;
         this.linkShowLicenseHistory.Location = new System.Drawing.Point(8, 637);
         this.linkShowLicenseHistory.Name = "linkShowLicenseHistory";
         this.linkShowLicenseHistory.Size = new System.Drawing.Size(172, 21);
         this.linkShowLicenseHistory.TabIndex = 62;
         this.linkShowLicenseHistory.TabStop = true;
         this.linkShowLicenseHistory.Text = "Show License History";
         this.linkShowLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkShowLicenseHistory_LinkClicked);
         // 
         // btnClose
         // 
         this.btnClose.BackColor = System.Drawing.Color.DimGray;
         this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnClose.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnClose.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.btnClose.Location = new System.Drawing.Point(626, 629);
         this.btnClose.Name = "btnClose";
         this.btnClose.Size = new System.Drawing.Size(86, 37);
         this.btnClose.TabIndex = 61;
         this.btnClose.Text = "Close";
         this.btnClose.UseVisualStyleBackColor = false;
         // 
         // btnIssueLicense
         // 
         this.btnIssueLicense.BackColor = System.Drawing.Color.Azure;
         this.btnIssueLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnIssueLicense.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnIssueLicense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
         this.btnIssueLicense.Location = new System.Drawing.Point(733, 629);
         this.btnIssueLicense.Name = "btnIssueLicense";
         this.btnIssueLicense.Size = new System.Drawing.Size(138, 37);
         this.btnIssueLicense.TabIndex = 60;
         this.btnIssueLicense.Text = "Issue";
         this.btnIssueLicense.UseVisualStyleBackColor = false;
         this.btnIssueLicense.Click += new System.EventHandler(this.btnIssueLicense_Click);
         // 
         // frmNewInternationalDrivingLicense
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(37)))), ((int)(((byte)(73)))));
         this.ClientSize = new System.Drawing.Size(879, 671);
         this.Controls.Add(this.linkShowLicenseInfo);
         this.Controls.Add(this.linkShowLicenseHistory);
         this.Controls.Add(this.btnClose);
         this.Controls.Add(this.btnIssueLicense);
         this.Controls.Add(this.groupBox1);
         this.Controls.Add(this.ctrlDriverLicenseInfoWithFilter1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
         this.Name = "frmNewInternationalDrivingLicense";
         this.Text = "New International Driving License";
         this.Activated += new System.EventHandler(this.frmNewInternationalDrivingLicense_Activated);
         this.Load += new System.EventHandler(this.frmNewInternationalDrivingLicense_Load);
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private Licenses.Local_License.controls.ctrlDriverLicenseInfoWithFilter ctrlDriverLicenseInfoWithFilter1;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.Label lblCreatedBy;
      private System.Windows.Forms.Label label9;
      private System.Windows.Forms.Label lblExpirationDate;
      private System.Windows.Forms.Label label11;
      private System.Windows.Forms.Label lblLocalLicenseID;
      private System.Windows.Forms.Label label13;
      private System.Windows.Forms.Label lblInternationalLicenseID;
      private System.Windows.Forms.Label label15;
      private System.Windows.Forms.Label lblFees;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.Label lblIssueDate;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label lblApplicationDate;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label lblApplicationID;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.LinkLabel linkShowLicenseInfo;
      private System.Windows.Forms.LinkLabel linkShowLicenseHistory;
      private System.Windows.Forms.Button btnClose;
      private System.Windows.Forms.Button btnIssueLicense;
   }
}