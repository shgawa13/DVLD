namespace DVLD.Licenses
{
   partial class frmShowPersonLicenseHistory
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
         this.ctrlDriverLicenses1 = new DVLD.Licenses.controls.ctrlDriverLicenses();
         this.ctrlPersonInfoWithFilter1 = new DVLD.People.Controls.ctrlPersonInfoWithFilter();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.SuspendLayout();
         // 
         // lblTitle
         // 
         this.lblTitle.AutoSize = true;
         this.lblTitle.BackColor = System.Drawing.Color.Transparent;
         this.lblTitle.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.lblTitle.Location = new System.Drawing.Point(493, 7);
         this.lblTitle.Name = "lblTitle";
         this.lblTitle.Size = new System.Drawing.Size(185, 30);
         this.lblTitle.TabIndex = 50;
         this.lblTitle.Text = "License History";
         // 
         // pictureBox1
         // 
         this.pictureBox1.Image = global::DVLD.Properties.Resources.PersonLicenseHistory_512;
         this.pictureBox1.Location = new System.Drawing.Point(1, 189);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(187, 145);
         this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.pictureBox1.TabIndex = 52;
         this.pictureBox1.TabStop = false;
         // 
         // ctrlDriverLicenses1
         // 
         this.ctrlDriverLicenses1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(34)))), ((int)(((byte)(71)))));
         this.ctrlDriverLicenses1.Location = new System.Drawing.Point(12, 509);
         this.ctrlDriverLicenses1.Name = "ctrlDriverLicenses1";
         this.ctrlDriverLicenses1.Size = new System.Drawing.Size(1052, 203);
         this.ctrlDriverLicenses1.TabIndex = 56;
         // 
         // ctrlPersonInfoWithFilter1
         // 
         this.ctrlPersonInfoWithFilter1.BackColor = System.Drawing.Color.Gainsboro;
         this.ctrlPersonInfoWithFilter1.FilterEnable = true;
         this.ctrlPersonInfoWithFilter1.Location = new System.Drawing.Point(194, 40);
         this.ctrlPersonInfoWithFilter1.Name = "ctrlPersonInfoWithFilter1";
         this.ctrlPersonInfoWithFilter1.ShowAddPerson = true;
         this.ctrlPersonInfoWithFilter1.Size = new System.Drawing.Size(968, 463);
         this.ctrlPersonInfoWithFilter1.TabIndex = 55;
         this.ctrlPersonInfoWithFilter1.OnPersonSelected += new System.Action<int>(this.ctrlPersonInfoWithFilter1_OnPersonSelected);
         // 
         // frmShowPersonLicenseHistory
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(34)))), ((int)(((byte)(71)))));
         this.ClientSize = new System.Drawing.Size(1161, 707);
         this.Controls.Add(this.ctrlDriverLicenses1);
         this.Controls.Add(this.ctrlPersonInfoWithFilter1);
         this.Controls.Add(this.pictureBox1);
         this.Controls.Add(this.lblTitle);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
         this.Name = "frmShowPersonLicenseHistory";
         this.Text = "Show Person License History";
         this.Load += new System.EventHandler(this.frmShowPersonLicenseHistory_Load);
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label lblTitle;
      private System.Windows.Forms.PictureBox pictureBox1;
      private People.Controls.ctrlPersonInfoWithFilter ctrlPersonInfoWithFilter1;
      private controls.ctrlDriverLicenses ctrlDriverLicenses1;
   }
}