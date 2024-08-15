namespace DVLD.Applications.ReplaceLostOrDamagedLicense
{
   partial class frmReplaceLostOrDamagedLicenseApplication
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
         this.rbLostLicense = new System.Windows.Forms.RadioButton();
         this.rbDamagedLicense = new System.Windows.Forms.RadioButton();
         this.gbReplacementFor = new System.Windows.Forms.GroupBox();
         this.lblCreatedBy = new System.Windows.Forms.Label();
         this.lblOldLicenseID = new System.Windows.Forms.Label();
         this.lblReplacedLicenseID = new System.Windows.Forms.Label();
         this.lblApplicationFees = new System.Windows.Forms.Label();
         this.lblApplicationDate = new System.Windows.Forms.Label();
         this.label8 = new System.Windows.Forms.Label();
         this.label10 = new System.Windows.Forms.Label();
         this.label12 = new System.Windows.Forms.Label();
         this.label6 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.lblAppID = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.linkShowLicenseInfo = new System.Windows.Forms.LinkLabel();
         this.linkLicenseHistory = new System.Windows.Forms.LinkLabel();
         this.btnClose = new System.Windows.Forms.Button();
         this.btnIssueReplacement = new System.Windows.Forms.Button();
         this.lblTitle = new System.Windows.Forms.Label();
         this.groupBox1.SuspendLayout();
         this.gbReplacementFor.SuspendLayout();
         this.SuspendLayout();
         // 
         // ctrlDriverLicenseInfoWithFilter1
         // 
         this.ctrlDriverLicenseInfoWithFilter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(37)))), ((int)(((byte)(73)))));
         this.ctrlDriverLicenseInfoWithFilter1.FilterEnabled = true;
         this.ctrlDriverLicenseInfoWithFilter1.Location = new System.Drawing.Point(0, 34);
         this.ctrlDriverLicenseInfoWithFilter1.Name = "ctrlDriverLicenseInfoWithFilter1";
         this.ctrlDriverLicenseInfoWithFilter1.Size = new System.Drawing.Size(882, 440);
         this.ctrlDriverLicenseInfoWithFilter1.TabIndex = 0;
         this.ctrlDriverLicenseInfoWithFilter1.OnLicenseSelected += new System.Action<int>(this.ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected);
         // 
         // groupBox1
         // 
         this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(93)))), ((int)(((byte)(100)))));
         this.groupBox1.Controls.Add(this.rbLostLicense);
         this.groupBox1.Controls.Add(this.rbDamagedLicense);
         this.groupBox1.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.groupBox1.ForeColor = System.Drawing.Color.AliceBlue;
         this.groupBox1.Location = new System.Drawing.Point(552, 44);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(318, 64);
         this.groupBox1.TabIndex = 1;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Replace For ";
         // 
         // rbLostLicense
         // 
         this.rbLostLicense.AutoSize = true;
         this.rbLostLicense.ForeColor = System.Drawing.Color.AliceBlue;
         this.rbLostLicense.Location = new System.Drawing.Point(182, 17);
         this.rbLostLicense.Name = "rbLostLicense";
         this.rbLostLicense.Size = new System.Drawing.Size(83, 44);
         this.rbLostLicense.TabIndex = 1;
         this.rbLostLicense.Text = "Lost \r\nLicense";
         this.rbLostLicense.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         this.rbLostLicense.UseVisualStyleBackColor = true;
         this.rbLostLicense.CheckedChanged += new System.EventHandler(this.rbLostLicense_CheckedChanged);
         // 
         // rbDamagedLicense
         // 
         this.rbDamagedLicense.AutoSize = true;
         this.rbDamagedLicense.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.rbDamagedLicense.ForeColor = System.Drawing.Color.AliceBlue;
         this.rbDamagedLicense.Location = new System.Drawing.Point(15, 19);
         this.rbDamagedLicense.Name = "rbDamagedLicense";
         this.rbDamagedLicense.Size = new System.Drawing.Size(109, 40);
         this.rbDamagedLicense.TabIndex = 0;
         this.rbDamagedLicense.Text = "Damaged \r\nLicense";
         this.rbDamagedLicense.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         this.rbDamagedLicense.UseVisualStyleBackColor = true;
         this.rbDamagedLicense.CheckedChanged += new System.EventHandler(this.rbDamagedLicense_CheckedChanged);
         // 
         // gbReplacementFor
         // 
         this.gbReplacementFor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(37)))), ((int)(((byte)(73)))));
         this.gbReplacementFor.Controls.Add(this.lblCreatedBy);
         this.gbReplacementFor.Controls.Add(this.lblOldLicenseID);
         this.gbReplacementFor.Controls.Add(this.lblReplacedLicenseID);
         this.gbReplacementFor.Controls.Add(this.lblApplicationFees);
         this.gbReplacementFor.Controls.Add(this.lblApplicationDate);
         this.gbReplacementFor.Controls.Add(this.label8);
         this.gbReplacementFor.Controls.Add(this.label10);
         this.gbReplacementFor.Controls.Add(this.label12);
         this.gbReplacementFor.Controls.Add(this.label6);
         this.gbReplacementFor.Controls.Add(this.label3);
         this.gbReplacementFor.Controls.Add(this.lblAppID);
         this.gbReplacementFor.Controls.Add(this.label1);
         this.gbReplacementFor.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.gbReplacementFor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(83)))), ((int)(((byte)(100)))));
         this.gbReplacementFor.Location = new System.Drawing.Point(0, 476);
         this.gbReplacementFor.Name = "gbReplacementFor";
         this.gbReplacementFor.Size = new System.Drawing.Size(882, 135);
         this.gbReplacementFor.TabIndex = 2;
         this.gbReplacementFor.TabStop = false;
         this.gbReplacementFor.Text = "Application Info for License Replacement";
         // 
         // lblCreatedBy
         // 
         this.lblCreatedBy.AutoSize = true;
         this.lblCreatedBy.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.lblCreatedBy.Location = new System.Drawing.Point(639, 94);
         this.lblCreatedBy.Name = "lblCreatedBy";
         this.lblCreatedBy.Size = new System.Drawing.Size(49, 21);
         this.lblCreatedBy.TabIndex = 15;
         this.lblCreatedBy.Text = "[???]";
         // 
         // lblOldLicenseID
         // 
         this.lblOldLicenseID.AutoSize = true;
         this.lblOldLicenseID.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.lblOldLicenseID.Location = new System.Drawing.Point(639, 64);
         this.lblOldLicenseID.Name = "lblOldLicenseID";
         this.lblOldLicenseID.Size = new System.Drawing.Size(49, 21);
         this.lblOldLicenseID.TabIndex = 14;
         this.lblOldLicenseID.Text = "[???]";
         // 
         // lblReplacedLicenseID
         // 
         this.lblReplacedLicenseID.AutoSize = true;
         this.lblReplacedLicenseID.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.lblReplacedLicenseID.Location = new System.Drawing.Point(639, 33);
         this.lblReplacedLicenseID.Name = "lblReplacedLicenseID";
         this.lblReplacedLicenseID.Size = new System.Drawing.Size(49, 21);
         this.lblReplacedLicenseID.TabIndex = 13;
         this.lblReplacedLicenseID.Text = "[???]";
         // 
         // lblApplicationFees
         // 
         this.lblApplicationFees.AutoSize = true;
         this.lblApplicationFees.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.lblApplicationFees.Location = new System.Drawing.Point(197, 94);
         this.lblApplicationFees.Name = "lblApplicationFees";
         this.lblApplicationFees.Size = new System.Drawing.Size(49, 21);
         this.lblApplicationFees.TabIndex = 12;
         this.lblApplicationFees.Text = "[???]";
         // 
         // lblApplicationDate
         // 
         this.lblApplicationDate.AutoSize = true;
         this.lblApplicationDate.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.lblApplicationDate.Location = new System.Drawing.Point(197, 64);
         this.lblApplicationDate.Name = "lblApplicationDate";
         this.lblApplicationDate.Size = new System.Drawing.Size(49, 21);
         this.lblApplicationDate.TabIndex = 11;
         this.lblApplicationDate.Text = "[???]";
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.label8.Location = new System.Drawing.Point(437, 94);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(99, 21);
         this.label8.TabIndex = 10;
         this.label8.Text = "Created By:";
         // 
         // label10
         // 
         this.label10.AutoSize = true;
         this.label10.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.label10.Location = new System.Drawing.Point(437, 64);
         this.label10.Name = "label10";
         this.label10.Size = new System.Drawing.Size(125, 21);
         this.label10.TabIndex = 8;
         this.label10.Text = "Old License ID:";
         // 
         // label12
         // 
         this.label12.AutoSize = true;
         this.label12.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.label12.Location = new System.Drawing.Point(437, 33);
         this.label12.Name = "label12";
         this.label12.Size = new System.Drawing.Size(171, 21);
         this.label12.TabIndex = 6;
         this.label12.Text = "Replaced License ID:";
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.label6.Location = new System.Drawing.Point(27, 94);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(144, 21);
         this.label6.TabIndex = 4;
         this.label6.Text = "Application Fees:";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.label3.Location = new System.Drawing.Point(26, 64);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(145, 21);
         this.label3.TabIndex = 2;
         this.label3.Text = "Application Date:";
         // 
         // lblAppID
         // 
         this.lblAppID.AutoSize = true;
         this.lblAppID.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.lblAppID.Location = new System.Drawing.Point(197, 33);
         this.lblAppID.Name = "lblAppID";
         this.lblAppID.Size = new System.Drawing.Size(49, 21);
         this.lblAppID.TabIndex = 1;
         this.lblAppID.Text = "[???]";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.label1.Location = new System.Drawing.Point(16, 33);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(155, 21);
         this.label1.TabIndex = 0;
         this.label1.Text = "R.L.Application ID:";
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
         this.linkShowLicenseInfo.Location = new System.Drawing.Point(197, 625);
         this.linkShowLicenseInfo.Name = "linkShowLicenseInfo";
         this.linkShowLicenseInfo.Size = new System.Drawing.Size(181, 21);
         this.linkShowLicenseInfo.TabIndex = 51;
         this.linkShowLicenseInfo.TabStop = true;
         this.linkShowLicenseInfo.Text = "Show New LicenseInfo";
         this.linkShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkShowLicenseInfo_LinkClicked);
         // 
         // linkLicenseHistory
         // 
         this.linkLicenseHistory.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
         this.linkLicenseHistory.AutoSize = true;
         this.linkLicenseHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(37)))), ((int)(((byte)(73)))));
         this.linkLicenseHistory.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.linkLicenseHistory.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
         this.linkLicenseHistory.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
         this.linkLicenseHistory.LinkColor = System.Drawing.Color.RoyalBlue;
         this.linkLicenseHistory.Location = new System.Drawing.Point(7, 625);
         this.linkLicenseHistory.Name = "linkLicenseHistory";
         this.linkLicenseHistory.Size = new System.Drawing.Size(172, 21);
         this.linkLicenseHistory.TabIndex = 50;
         this.linkLicenseHistory.TabStop = true;
         this.linkLicenseHistory.Text = "Show License History";
         this.linkLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLicenseHistory_LinkClicked);
         // 
         // btnClose
         // 
         this.btnClose.BackColor = System.Drawing.Color.DimGray;
         this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnClose.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnClose.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.btnClose.Location = new System.Drawing.Point(595, 617);
         this.btnClose.Name = "btnClose";
         this.btnClose.Size = new System.Drawing.Size(86, 37);
         this.btnClose.TabIndex = 49;
         this.btnClose.Text = "Close";
         this.btnClose.UseVisualStyleBackColor = false;
         // 
         // btnIssueReplacement
         // 
         this.btnIssueReplacement.BackColor = System.Drawing.Color.Azure;
         this.btnIssueReplacement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnIssueReplacement.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnIssueReplacement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
         this.btnIssueReplacement.Location = new System.Drawing.Point(690, 617);
         this.btnIssueReplacement.Name = "btnIssueReplacement";
         this.btnIssueReplacement.Size = new System.Drawing.Size(180, 37);
         this.btnIssueReplacement.TabIndex = 48;
         this.btnIssueReplacement.Text = "Issue Replacement";
         this.btnIssueReplacement.UseVisualStyleBackColor = false;
         // 
         // lblTitle
         // 
         this.lblTitle.AutoSize = true;
         this.lblTitle.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.lblTitle.Location = new System.Drawing.Point(336, 9);
         this.lblTitle.Name = "lblTitle";
         this.lblTitle.Size = new System.Drawing.Size(55, 26);
         this.lblTitle.TabIndex = 52;
         this.lblTitle.Text = "Title";
         // 
         // frmReplaceLostOrDamagedLicenseApplication
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(37)))), ((int)(((byte)(73)))));
         this.ClientSize = new System.Drawing.Size(882, 661);
         this.Controls.Add(this.lblTitle);
         this.Controls.Add(this.linkShowLicenseInfo);
         this.Controls.Add(this.linkLicenseHistory);
         this.Controls.Add(this.btnClose);
         this.Controls.Add(this.btnIssueReplacement);
         this.Controls.Add(this.gbReplacementFor);
         this.Controls.Add(this.groupBox1);
         this.Controls.Add(this.ctrlDriverLicenseInfoWithFilter1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
         this.Name = "frmReplaceLostOrDamagedLicenseApplication";
         this.Text = "Replace Lost Or Damaged License Application";
         this.Load += new System.EventHandler(this.frmReplaceLostOrDamagedLicenseApplication_Load);
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         this.gbReplacementFor.ResumeLayout(false);
         this.gbReplacementFor.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private Licenses.Local_License.controls.ctrlDriverLicenseInfoWithFilter ctrlDriverLicenseInfoWithFilter1;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.RadioButton rbLostLicense;
      private System.Windows.Forms.RadioButton rbDamagedLicense;
      private System.Windows.Forms.GroupBox gbReplacementFor;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label8;
      private System.Windows.Forms.Label label10;
      private System.Windows.Forms.Label label12;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label lblAppID;
      private System.Windows.Forms.Label lblCreatedBy;
      private System.Windows.Forms.Label lblOldLicenseID;
      private System.Windows.Forms.Label lblReplacedLicenseID;
      private System.Windows.Forms.Label lblApplicationFees;
      private System.Windows.Forms.Label lblApplicationDate;
      private System.Windows.Forms.LinkLabel linkShowLicenseInfo;
      private System.Windows.Forms.LinkLabel linkLicenseHistory;
      private System.Windows.Forms.Button btnClose;
      private System.Windows.Forms.Button btnIssueReplacement;
      private System.Windows.Forms.Label lblTitle;
   }
}