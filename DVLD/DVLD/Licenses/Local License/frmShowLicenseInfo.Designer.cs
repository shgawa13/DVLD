namespace DVLD.Licenses.Local_License
{
   partial class frmShowLicenseInfo
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
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.lblTitle = new System.Windows.Forms.Label();
         this.btnClose = new System.Windows.Forms.Button();
         this.ctrlDriverLicenseInfo1 = new DVLD.Licenses.Local_License.controls.ctrlDriverLicenseInfo();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.SuspendLayout();
         // 
         // pictureBox1
         // 
         this.pictureBox1.Image = global::DVLD.Properties.Resources.LicenseView_400;
         this.pictureBox1.Location = new System.Drawing.Point(349, 12);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(184, 99);
         this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.pictureBox1.TabIndex = 0;
         this.pictureBox1.TabStop = false;
         // 
         // lblTitle
         // 
         this.lblTitle.AutoSize = true;
         this.lblTitle.BackColor = System.Drawing.Color.Transparent;
         this.lblTitle.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.lblTitle.Location = new System.Drawing.Point(331, 115);
         this.lblTitle.Name = "lblTitle";
         this.lblTitle.Size = new System.Drawing.Size(225, 30);
         this.lblTitle.TabIndex = 49;
         this.lblTitle.Text = "Driver License Info";
         // 
         // btnClose
         // 
         this.btnClose.BackColor = System.Drawing.Color.WhiteSmoke;
         this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.btnClose.FlatAppearance.BorderSize = 0;
         this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnClose.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(36)))));
         this.btnClose.Location = new System.Drawing.Point(757, 547);
         this.btnClose.Name = "btnClose";
         this.btnClose.Size = new System.Drawing.Size(116, 38);
         this.btnClose.TabIndex = 51;
         this.btnClose.Text = "Close";
         this.btnClose.UseVisualStyleBackColor = false;
         // 
         // ctrlDriverLicenseInfo1
         // 
         this.ctrlDriverLicenseInfo1.BackColor = System.Drawing.SystemColors.ControlLight;
         this.ctrlDriverLicenseInfo1.Location = new System.Drawing.Point(3, 153);
         this.ctrlDriverLicenseInfo1.Name = "ctrlDriverLicenseInfo1";
         this.ctrlDriverLicenseInfo1.Size = new System.Drawing.Size(880, 388);
         this.ctrlDriverLicenseInfo1.TabIndex = 50;
         // 
         // frmShowLicenseInfo
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
         this.ClientSize = new System.Drawing.Size(885, 591);
         this.Controls.Add(this.btnClose);
         this.Controls.Add(this.ctrlDriverLicenseInfo1);
         this.Controls.Add(this.lblTitle);
         this.Controls.Add(this.pictureBox1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
         this.Name = "frmShowLicenseInfo";
         this.Text = "Show License Info";
         this.Load += new System.EventHandler(this.frmShowLicenseInfo_Load);
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.Label lblTitle;
      private controls.ctrlDriverLicenseInfo ctrlDriverLicenseInfo1;
      private System.Windows.Forms.Button btnClose;
   }
}