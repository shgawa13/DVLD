namespace DVLD.Licenses.Detain_License
{
   partial class frmDetainLicenseApplication
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
         this.ctrlDriverLicenseInfoWithFilter1 = new DVLD.Licenses.Local_License.controls.ctrlDriverLicenseInfoWithFilter();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.txtFineFees = new System.Windows.Forms.TextBox();
         this.lblCreatedBy = new System.Windows.Forms.Label();
         this.label9 = new System.Windows.Forms.Label();
         this.lblLicenseID = new System.Windows.Forms.Label();
         this.label7 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.lblDetainDate = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.lblDetainID = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.linkShowLicenseInfo = new System.Windows.Forms.LinkLabel();
         this.linkLicenseHistory = new System.Windows.Forms.LinkLabel();
         this.btnClose = new System.Windows.Forms.Button();
         this.btnDetain = new System.Windows.Forms.Button();
         this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
         this.groupBox1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
         this.SuspendLayout();
         // 
         // ctrlDriverLicenseInfoWithFilter1
         // 
         this.ctrlDriverLicenseInfoWithFilter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(37)))), ((int)(((byte)(73)))));
         this.ctrlDriverLicenseInfoWithFilter1.FilterEnabled = true;
         this.ctrlDriverLicenseInfoWithFilter1.Location = new System.Drawing.Point(1, -1);
         this.ctrlDriverLicenseInfoWithFilter1.Name = "ctrlDriverLicenseInfoWithFilter1";
         this.ctrlDriverLicenseInfoWithFilter1.Size = new System.Drawing.Size(882, 455);
         this.ctrlDriverLicenseInfoWithFilter1.TabIndex = 0;
         this.ctrlDriverLicenseInfoWithFilter1.OnLicenseSelected += new System.Action<int>(this.ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected);
         // 
         // groupBox1
         // 
         this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
         this.groupBox1.Controls.Add(this.txtFineFees);
         this.groupBox1.Controls.Add(this.lblCreatedBy);
         this.groupBox1.Controls.Add(this.label9);
         this.groupBox1.Controls.Add(this.lblLicenseID);
         this.groupBox1.Controls.Add(this.label7);
         this.groupBox1.Controls.Add(this.label5);
         this.groupBox1.Controls.Add(this.lblDetainDate);
         this.groupBox1.Controls.Add(this.label3);
         this.groupBox1.Controls.Add(this.lblDetainID);
         this.groupBox1.Controls.Add(this.label1);
         this.groupBox1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.groupBox1.ForeColor = System.Drawing.Color.Crimson;
         this.groupBox1.Location = new System.Drawing.Point(1, 452);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(882, 133);
         this.groupBox1.TabIndex = 1;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Detain Info";
         // 
         // txtFineFees
         // 
         this.txtFineFees.Location = new System.Drawing.Point(143, 79);
         this.txtFineFees.Name = "txtFineFees";
         this.txtFineFees.Size = new System.Drawing.Size(92, 26);
         this.txtFineFees.TabIndex = 98;
         this.txtFineFees.Validating += new System.ComponentModel.CancelEventHandler(this.txtFineFees_Validating);
         // 
         // lblCreatedBy
         // 
         this.lblCreatedBy.AutoSize = true;
         this.lblCreatedBy.BackColor = System.Drawing.Color.Gainsboro;
         this.lblCreatedBy.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblCreatedBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
         this.lblCreatedBy.Location = new System.Drawing.Point(496, 52);
         this.lblCreatedBy.Name = "lblCreatedBy";
         this.lblCreatedBy.Size = new System.Drawing.Size(49, 21);
         this.lblCreatedBy.TabIndex = 97;
         this.lblCreatedBy.Text = "[???]";
         // 
         // label9
         // 
         this.label9.AutoSize = true;
         this.label9.BackColor = System.Drawing.Color.Gainsboro;
         this.label9.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
         this.label9.Location = new System.Drawing.Point(347, 52);
         this.label9.Name = "label9";
         this.label9.Size = new System.Drawing.Size(99, 21);
         this.label9.TabIndex = 96;
         this.label9.Text = "Created By:";
         // 
         // lblLicenseID
         // 
         this.lblLicenseID.AutoSize = true;
         this.lblLicenseID.BackColor = System.Drawing.Color.Gainsboro;
         this.lblLicenseID.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblLicenseID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
         this.lblLicenseID.Location = new System.Drawing.Point(496, 22);
         this.lblLicenseID.Name = "lblLicenseID";
         this.lblLicenseID.Size = new System.Drawing.Size(49, 21);
         this.lblLicenseID.TabIndex = 95;
         this.lblLicenseID.Text = "[???]";
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.BackColor = System.Drawing.Color.Gainsboro;
         this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
         this.label7.Location = new System.Drawing.Point(347, 22);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(94, 21);
         this.label7.TabIndex = 94;
         this.label7.Text = "License ID:";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.BackColor = System.Drawing.Color.Gainsboro;
         this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
         this.label5.Location = new System.Drawing.Point(35, 82);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(88, 21);
         this.label5.TabIndex = 92;
         this.label5.Text = "Fine Fees:";
         // 
         // lblDetainDate
         // 
         this.lblDetainDate.AutoSize = true;
         this.lblDetainDate.BackColor = System.Drawing.Color.Gainsboro;
         this.lblDetainDate.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblDetainDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
         this.lblDetainDate.Location = new System.Drawing.Point(143, 52);
         this.lblDetainDate.Name = "lblDetainDate";
         this.lblDetainDate.Size = new System.Drawing.Size(49, 21);
         this.lblDetainDate.TabIndex = 91;
         this.lblDetainDate.Text = "[???]";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.BackColor = System.Drawing.Color.Gainsboro;
         this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
         this.label3.Location = new System.Drawing.Point(35, 52);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(107, 21);
         this.label3.TabIndex = 90;
         this.label3.Text = "Detain Date:";
         // 
         // lblDetainID
         // 
         this.lblDetainID.AutoSize = true;
         this.lblDetainID.BackColor = System.Drawing.Color.Gainsboro;
         this.lblDetainID.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblDetainID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
         this.lblDetainID.Location = new System.Drawing.Point(143, 22);
         this.lblDetainID.Name = "lblDetainID";
         this.lblDetainID.Size = new System.Drawing.Size(49, 21);
         this.lblDetainID.TabIndex = 89;
         this.lblDetainID.Text = "[???]";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.BackColor = System.Drawing.Color.Gainsboro;
         this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
         this.label1.Location = new System.Drawing.Point(35, 22);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(87, 21);
         this.label1.TabIndex = 88;
         this.label1.Text = "Detain ID:";
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
         this.linkShowLicenseInfo.Location = new System.Drawing.Point(201, 603);
         this.linkShowLicenseInfo.Name = "linkShowLicenseInfo";
         this.linkShowLicenseInfo.Size = new System.Drawing.Size(181, 21);
         this.linkShowLicenseInfo.TabIndex = 55;
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
         this.linkLicenseHistory.Location = new System.Drawing.Point(11, 603);
         this.linkLicenseHistory.Name = "linkLicenseHistory";
         this.linkLicenseHistory.Size = new System.Drawing.Size(172, 21);
         this.linkLicenseHistory.TabIndex = 54;
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
         this.btnClose.Location = new System.Drawing.Point(629, 595);
         this.btnClose.Name = "btnClose";
         this.btnClose.Size = new System.Drawing.Size(86, 37);
         this.btnClose.TabIndex = 53;
         this.btnClose.Text = "Close";
         this.btnClose.UseVisualStyleBackColor = false;
         // 
         // btnDetain
         // 
         this.btnDetain.BackColor = System.Drawing.Color.Azure;
         this.btnDetain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnDetain.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnDetain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
         this.btnDetain.Location = new System.Drawing.Point(736, 595);
         this.btnDetain.Name = "btnDetain";
         this.btnDetain.Size = new System.Drawing.Size(138, 37);
         this.btnDetain.TabIndex = 52;
         this.btnDetain.Text = "Detain";
         this.btnDetain.UseVisualStyleBackColor = false;
         this.btnDetain.Click += new System.EventHandler(this.btnDetain_Click);
         // 
         // errorProvider1
         // 
         this.errorProvider1.ContainerControl = this;
         // 
         // frmDetainLicenseApplication
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(37)))), ((int)(((byte)(73)))));
         this.ClientSize = new System.Drawing.Size(881, 642);
         this.Controls.Add(this.linkShowLicenseInfo);
         this.Controls.Add(this.linkLicenseHistory);
         this.Controls.Add(this.btnClose);
         this.Controls.Add(this.btnDetain);
         this.Controls.Add(this.groupBox1);
         this.Controls.Add(this.ctrlDriverLicenseInfoWithFilter1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
         this.Name = "frmDetainLicenseApplication";
         this.Text = "Detain License Application";
         this.Load += new System.EventHandler(this.frmDetainLicenseApplication_Load);
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private Local_License.controls.ctrlDriverLicenseInfoWithFilter ctrlDriverLicenseInfoWithFilter1;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.Label lblCreatedBy;
      private System.Windows.Forms.Label label9;
      private System.Windows.Forms.Label lblLicenseID;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label lblDetainDate;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label lblDetainID;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox txtFineFees;
      private System.Windows.Forms.LinkLabel linkShowLicenseInfo;
      private System.Windows.Forms.LinkLabel linkLicenseHistory;
      private System.Windows.Forms.Button btnClose;
      private System.Windows.Forms.Button btnDetain;
      private System.Windows.Forms.ErrorProvider errorProvider1;
   }
}