namespace DVLD.Applications.LocalDrivingLicenseApplication
{
   partial class frmLocalDrivingLicenseApplicationInfo
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
         this.SuspendLayout();
         // 
         // ctrlDrivingLicenseApplicationInfo1
         // 
         this.ctrlDrivingLicenseApplicationInfo1.BackColor = System.Drawing.Color.Gainsboro;
         this.ctrlDrivingLicenseApplicationInfo1.Location = new System.Drawing.Point(-1, 1);
         this.ctrlDrivingLicenseApplicationInfo1.Name = "ctrlDrivingLicenseApplicationInfo1";
         this.ctrlDrivingLicenseApplicationInfo1.Size = new System.Drawing.Size(894, 354);
         this.ctrlDrivingLicenseApplicationInfo1.TabIndex = 0;
         // 
         // frmLocalDrivingLicenseApplicationInfo
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(892, 354);
         this.Controls.Add(this.ctrlDrivingLicenseApplicationInfo1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
         this.Name = "frmLocalDrivingLicenseApplicationInfo";
         this.Text = "frmLocalDrivingLicenseApplicationInfo";
         this.Load += new System.EventHandler(this.frmLocalDrivingLicenseApplicationInfo_Load);
         this.ResumeLayout(false);

      }

      #endregion

      private controls.ctrlDrivingLicenseApplicationInfo ctrlDrivingLicenseApplicationInfo1;
   }
}