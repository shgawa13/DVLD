namespace DVLD.Applications.InternationalDrivingApplication
{
   partial class frmShowInternationalLicenseInfo
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
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.btnClose = new System.Windows.Forms.Button();
         this.ctrlInternationalLicenseInfo1 = new DVLD.Applications.InternationalDrivingApplication.controls.ctrlInternationalLicenseInfo();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.SuspendLayout();
         // 
         // lblTitle
         // 
         this.lblTitle.AutoSize = true;
         this.lblTitle.BackColor = System.Drawing.Color.Transparent;
         this.lblTitle.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.lblTitle.Location = new System.Drawing.Point(303, 126);
         this.lblTitle.Name = "lblTitle";
         this.lblTitle.Size = new System.Drawing.Size(378, 30);
         this.lblTitle.TabIndex = 51;
         this.lblTitle.Text = "International Driver License Info";
         // 
         // pictureBox1
         // 
         this.pictureBox1.Image = global::DVLD.Properties.Resources.LicenseView_400;
         this.pictureBox1.Location = new System.Drawing.Point(400, 3);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(184, 120);
         this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.pictureBox1.TabIndex = 50;
         this.pictureBox1.TabStop = false;
         // 
         // btnClose
         // 
         this.btnClose.BackColor = System.Drawing.Color.WhiteSmoke;
         this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.btnClose.FlatAppearance.BorderSize = 0;
         this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnClose.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(36)))));
         this.btnClose.Location = new System.Drawing.Point(857, 488);
         this.btnClose.Name = "btnClose";
         this.btnClose.Size = new System.Drawing.Size(116, 38);
         this.btnClose.TabIndex = 52;
         this.btnClose.Text = "Close";
         this.btnClose.UseVisualStyleBackColor = false;
         // 
         // ctrlInternationalLicenseInfo1
         // 
         this.ctrlInternationalLicenseInfo1.BackColor = System.Drawing.SystemColors.ControlLight;
         this.ctrlInternationalLicenseInfo1.Location = new System.Drawing.Point(12, 166);
         this.ctrlInternationalLicenseInfo1.Name = "ctrlInternationalLicenseInfo1";
         this.ctrlInternationalLicenseInfo1.Size = new System.Drawing.Size(961, 302);
         this.ctrlInternationalLicenseInfo1.TabIndex = 53;
         // 
         // frmShowInternationalLicenseInfo
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
         this.ClientSize = new System.Drawing.Size(982, 538);
         this.Controls.Add(this.ctrlInternationalLicenseInfo1);
         this.Controls.Add(this.btnClose);
         this.Controls.Add(this.lblTitle);
         this.Controls.Add(this.pictureBox1);
         this.Name = "frmShowInternationalLicenseInfo";
         this.Text = "frmShowInternationalLicenseInfo";
         this.Load += new System.EventHandler(this.frmShowInternationalLicenseInfo_Load);
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label lblTitle;
      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.Button btnClose;
      private controls.ctrlInternationalLicenseInfo ctrlInternationalLicenseInfo1;
   }
}