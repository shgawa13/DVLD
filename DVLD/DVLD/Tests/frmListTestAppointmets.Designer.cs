namespace DVLD.Applications.LocalDrivingLicenseApplication
{
   partial class frmListTestAppointmets
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
         this.label1 = new System.Windows.Forms.Label();
         this.dataGridView1 = new System.Windows.Forms.DataGridView();
         this.lblLDVLAppNumber = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.btnSave = new System.Windows.Forms.Button();
         this.ctrlDrivingLicenseApplicationInfo1 = new DVLD.Applications.LocalDrivingLicenseApplication.controls.ctrlDrivingLicenseApplicationInfo();
         this.btnAddAppointment = new System.Windows.Forms.Button();
         this.picboxLocalDrivingLicense = new System.Windows.Forms.PictureBox();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.picboxLocalDrivingLicense)).BeginInit();
         this.SuspendLayout();
         // 
         // lblTitle
         // 
         this.lblTitle.AutoSize = true;
         this.lblTitle.BackColor = System.Drawing.Color.Transparent;
         this.lblTitle.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.lblTitle.Location = new System.Drawing.Point(291, 65);
         this.lblTitle.Name = "lblTitle";
         this.lblTitle.Size = new System.Drawing.Size(320, 24);
         this.lblTitle.TabIndex = 50;
         this.lblTitle.Text = "Local Driving License Applications";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.BackColor = System.Drawing.Color.Transparent;
         this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold);
         this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.label1.Location = new System.Drawing.Point(5, 473);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(142, 24);
         this.label1.TabIndex = 53;
         this.label1.Text = "Appointments:";
         // 
         // dataGridView1
         // 
         this.dataGridView1.AllowUserToAddRows = false;
         this.dataGridView1.AllowUserToDeleteRows = false;
         this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dataGridView1.Location = new System.Drawing.Point(4, 510);
         this.dataGridView1.Name = "dataGridView1";
         this.dataGridView1.ReadOnly = true;
         this.dataGridView1.Size = new System.Drawing.Size(894, 107);
         this.dataGridView1.TabIndex = 54;
         // 
         // lblLDVLAppNumber
         // 
         this.lblLDVLAppNumber.AutoSize = true;
         this.lblLDVLAppNumber.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblLDVLAppNumber.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.lblLDVLAppNumber.Location = new System.Drawing.Point(104, 627);
         this.lblLDVLAppNumber.Name = "lblLDVLAppNumber";
         this.lblLDVLAppNumber.Size = new System.Drawing.Size(43, 24);
         this.lblLDVLAppNumber.TabIndex = 58;
         this.lblLDVLAppNumber.Text = "???";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.label2.Location = new System.Drawing.Point(6, 627);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(97, 24);
         this.label2.TabIndex = 57;
         this.label2.Text = "# Record:";
         // 
         // btnSave
         // 
         this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
         this.btnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.btnSave.FlatAppearance.BorderSize = 0;
         this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnSave.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(36)))));
         this.btnSave.Location = new System.Drawing.Point(790, 622);
         this.btnSave.Name = "btnSave";
         this.btnSave.Size = new System.Drawing.Size(105, 35);
         this.btnSave.TabIndex = 59;
         this.btnSave.Text = "Close";
         this.btnSave.UseVisualStyleBackColor = false;
         this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
         // 
         // ctrlDrivingLicenseApplicationInfo1
         // 
         this.ctrlDrivingLicenseApplicationInfo1.BackColor = System.Drawing.Color.Gainsboro;
         this.ctrlDrivingLicenseApplicationInfo1.Location = new System.Drawing.Point(4, 107);
         this.ctrlDrivingLicenseApplicationInfo1.Name = "ctrlDrivingLicenseApplicationInfo1";
         this.ctrlDrivingLicenseApplicationInfo1.Size = new System.Drawing.Size(894, 354);
         this.ctrlDrivingLicenseApplicationInfo1.TabIndex = 55;
         // 
         // btnAddAppointment
         // 
         this.btnAddAppointment.AutoSize = true;
         this.btnAddAppointment.BackColor = System.Drawing.Color.Transparent;
         this.btnAddAppointment.BackgroundImage = global::DVLD.Properties.Resources.AddAppointment_32;
         this.btnAddAppointment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
         this.btnAddAppointment.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
         this.btnAddAppointment.FlatAppearance.BorderSize = 0;
         this.btnAddAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnAddAppointment.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnAddAppointment.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.btnAddAppointment.Location = new System.Drawing.Point(825, 467);
         this.btnAddAppointment.Name = "btnAddAppointment";
         this.btnAddAppointment.Size = new System.Drawing.Size(65, 39);
         this.btnAddAppointment.TabIndex = 60;
         this.btnAddAppointment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
         this.btnAddAppointment.UseVisualStyleBackColor = false;
         // 
         // picboxLocalDrivingLicense
         // 
         this.picboxLocalDrivingLicense.Image = global::DVLD.Properties.Resources.Vision_512;
         this.picboxLocalDrivingLicense.Location = new System.Drawing.Point(359, 8);
         this.picboxLocalDrivingLicense.Name = "picboxLocalDrivingLicense";
         this.picboxLocalDrivingLicense.Size = new System.Drawing.Size(185, 54);
         this.picboxLocalDrivingLicense.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.picboxLocalDrivingLicense.TabIndex = 51;
         this.picboxLocalDrivingLicense.TabStop = false;
         // 
         // frmLocalDrivingLicenseApplicationInfo
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
         this.ClientSize = new System.Drawing.Size(902, 661);
         this.Controls.Add(this.btnAddAppointment);
         this.Controls.Add(this.btnSave);
         this.Controls.Add(this.lblLDVLAppNumber);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.ctrlDrivingLicenseApplicationInfo1);
         this.Controls.Add(this.dataGridView1);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.picboxLocalDrivingLicense);
         this.Controls.Add(this.lblTitle);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
         this.Name = "frmLocalDrivingLicenseApplicationInfo";
         this.Text = "frmLocalDrivingLicenseApplicationInfo";
         this.Load += new System.EventHandler(this.frmLocalDrivingLicenseApplicationInfo_Load);
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.picboxLocalDrivingLicense)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion
      private System.Windows.Forms.PictureBox picboxLocalDrivingLicense;
      private System.Windows.Forms.Label lblTitle;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.DataGridView dataGridView1;
      private controls.ctrlDrivingLicenseApplicationInfo ctrlDrivingLicenseApplicationInfo1;
      private System.Windows.Forms.Label lblLDVLAppNumber;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Button btnSave;
      private System.Windows.Forms.Button btnAddAppointment;
   }
}