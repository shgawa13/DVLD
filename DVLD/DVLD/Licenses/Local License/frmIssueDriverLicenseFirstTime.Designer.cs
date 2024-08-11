namespace DVLD.Licenses.Local_License
{
   partial class frmIssueDriverLicenseFirstTime
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
         this.ctrlDrivingLicenseApplicationInfo1 = new DVLD.Applications.LocalDrivingLicenseApplication.controls.ctrlDrivingLicenseApplicationInfo();
         this.txtNotes = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.btnClose = new System.Windows.Forms.Button();
         this.btnIssue = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // ctrlDrivingLicenseApplicationInfo1
         // 
         this.ctrlDrivingLicenseApplicationInfo1.BackColor = System.Drawing.Color.Gainsboro;
         this.ctrlDrivingLicenseApplicationInfo1.Location = new System.Drawing.Point(0, 0);
         this.ctrlDrivingLicenseApplicationInfo1.Name = "ctrlDrivingLicenseApplicationInfo1";
         this.ctrlDrivingLicenseApplicationInfo1.Size = new System.Drawing.Size(894, 354);
         this.ctrlDrivingLicenseApplicationInfo1.TabIndex = 0;
         // 
         // txtNotes
         // 
         this.txtNotes.Location = new System.Drawing.Point(63, 370);
         this.txtNotes.Multiline = true;
         this.txtNotes.Name = "txtNotes";
         this.txtNotes.Size = new System.Drawing.Size(824, 83);
         this.txtNotes.TabIndex = 1;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(36)))));
         this.label1.Location = new System.Drawing.Point(10, 370);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(56, 18);
         this.label1.TabIndex = 2;
         this.label1.Text = "Note:";
         // 
         // btnClose
         // 
         this.btnClose.BackColor = System.Drawing.Color.WhiteSmoke;
         this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.btnClose.FlatAppearance.BorderSize = 0;
         this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnClose.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(36)))));
         this.btnClose.Location = new System.Drawing.Point(682, 469);
         this.btnClose.Name = "btnClose";
         this.btnClose.Size = new System.Drawing.Size(94, 38);
         this.btnClose.TabIndex = 16;
         this.btnClose.Text = "Close";
         this.btnClose.UseVisualStyleBackColor = false;
         // 
         // btnIssue
         // 
         this.btnIssue.BackColor = System.Drawing.Color.WhiteSmoke;
         this.btnIssue.FlatAppearance.BorderSize = 0;
         this.btnIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnIssue.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnIssue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(36)))));
         this.btnIssue.Location = new System.Drawing.Point(793, 469);
         this.btnIssue.Name = "btnIssue";
         this.btnIssue.Size = new System.Drawing.Size(94, 38);
         this.btnIssue.TabIndex = 17;
         this.btnIssue.Text = "Issue";
         this.btnIssue.UseVisualStyleBackColor = false;
         this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
         // 
         // frmIssueDriverLicenseFirstTime
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.DarkGray;
         this.ClientSize = new System.Drawing.Size(893, 513);
         this.Controls.Add(this.txtNotes);
         this.Controls.Add(this.btnIssue);
         this.Controls.Add(this.btnClose);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.ctrlDrivingLicenseApplicationInfo1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
         this.Name = "frmIssueDriverLicenseFirstTime";
         this.Text = "Issue Driver License First Time";
         this.Load += new System.EventHandler(this.frmIssueDriverLicenseFirstTime_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private Applications.LocalDrivingLicenseApplication.controls.ctrlDrivingLicenseApplicationInfo ctrlDrivingLicenseApplicationInfo1;
      private System.Windows.Forms.TextBox txtNotes;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Button btnClose;
      private System.Windows.Forms.Button btnIssue;
   }
}