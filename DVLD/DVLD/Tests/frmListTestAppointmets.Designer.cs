namespace DVLD.Applications.LocalDrivingLicenseApplication
{
   partial class frmListTestAppointments
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
         this.lblTitle = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.dgvTestAppointments = new System.Windows.Forms.DataGridView();
         this.ctmsAppointmentMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
         this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.takeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.lblRecordsCount = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.btnSave = new System.Windows.Forms.Button();
         this.btnAddAppointment = new System.Windows.Forms.Button();
         this.pbTestTypeImage = new System.Windows.Forms.PictureBox();
         this.ctrlDrivingLicenseApplicationInfo1 = new DVLD.Applications.LocalDrivingLicenseApplication.controls.ctrlDrivingLicenseApplicationInfo();
         ((System.ComponentModel.ISupportInitialize)(this.dgvTestAppointments)).BeginInit();
         this.ctmsAppointmentMenu.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pbTestTypeImage)).BeginInit();
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
         // dgvTestAppointments
         // 
         this.dgvTestAppointments.AllowUserToAddRows = false;
         this.dgvTestAppointments.AllowUserToDeleteRows = false;
         this.dgvTestAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
         this.dgvTestAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dgvTestAppointments.ContextMenuStrip = this.ctmsAppointmentMenu;
         this.dgvTestAppointments.Location = new System.Drawing.Point(4, 510);
         this.dgvTestAppointments.Name = "dgvTestAppointments";
         this.dgvTestAppointments.ReadOnly = true;
         this.dgvTestAppointments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.dgvTestAppointments.Size = new System.Drawing.Size(894, 107);
         this.dgvTestAppointments.TabIndex = 54;
         // 
         // ctmsAppointmentMenu
         // 
         this.ctmsAppointmentMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.takeTestToolStripMenuItem});
         this.ctmsAppointmentMenu.Name = "ctmsAppointmentMenu";
         this.ctmsAppointmentMenu.Size = new System.Drawing.Size(181, 70);
         this.ctmsAppointmentMenu.Text = "Appointment Menu";
         // 
         // editToolStripMenuItem
         // 
         this.editToolStripMenuItem.Name = "editToolStripMenuItem";
         this.editToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
         this.editToolStripMenuItem.Text = "Edit";
         this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
         // 
         // takeTestToolStripMenuItem
         // 
         this.takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
         this.takeTestToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
         this.takeTestToolStripMenuItem.Text = "Take Test";
         this.takeTestToolStripMenuItem.Click += new System.EventHandler(this.takeTestToolStripMenuItem_Click);
         // 
         // lblRecordsCount
         // 
         this.lblRecordsCount.AutoSize = true;
         this.lblRecordsCount.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblRecordsCount.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.lblRecordsCount.Location = new System.Drawing.Point(104, 627);
         this.lblRecordsCount.Name = "lblRecordsCount";
         this.lblRecordsCount.Size = new System.Drawing.Size(43, 24);
         this.lblRecordsCount.TabIndex = 58;
         this.lblRecordsCount.Text = "???";
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
         this.btnAddAppointment.Click += new System.EventHandler(this.btnAddAppointment_Click);
         // 
         // pbTestTypeImage
         // 
         this.pbTestTypeImage.Image = global::DVLD.Properties.Resources.Vision_512;
         this.pbTestTypeImage.Location = new System.Drawing.Point(359, 8);
         this.pbTestTypeImage.Name = "pbTestTypeImage";
         this.pbTestTypeImage.Size = new System.Drawing.Size(185, 54);
         this.pbTestTypeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.pbTestTypeImage.TabIndex = 51;
         this.pbTestTypeImage.TabStop = false;
         // 
         // ctrlDrivingLicenseApplicationInfo1
         // 
         this.ctrlDrivingLicenseApplicationInfo1.BackColor = System.Drawing.Color.Gainsboro;
         this.ctrlDrivingLicenseApplicationInfo1.Location = new System.Drawing.Point(4, 107);
         this.ctrlDrivingLicenseApplicationInfo1.Name = "ctrlDrivingLicenseApplicationInfo1";
         this.ctrlDrivingLicenseApplicationInfo1.Size = new System.Drawing.Size(894, 354);
         this.ctrlDrivingLicenseApplicationInfo1.TabIndex = 55;
         // 
         // frmListTestAppointments
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
         this.ClientSize = new System.Drawing.Size(902, 661);
         this.Controls.Add(this.btnAddAppointment);
         this.Controls.Add(this.btnSave);
         this.Controls.Add(this.lblRecordsCount);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.ctrlDrivingLicenseApplicationInfo1);
         this.Controls.Add(this.dgvTestAppointments);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.pbTestTypeImage);
         this.Controls.Add(this.lblTitle);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
         this.Name = "frmListTestAppointments";
         this.Text = "List Test Appointments";
         this.Load += new System.EventHandler(this.frmListTestAppointments_Load);
         ((System.ComponentModel.ISupportInitialize)(this.dgvTestAppointments)).EndInit();
         this.ctmsAppointmentMenu.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.pbTestTypeImage)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion
      private System.Windows.Forms.PictureBox pbTestTypeImage;
      private System.Windows.Forms.Label lblTitle;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.DataGridView dgvTestAppointments;
      private controls.ctrlDrivingLicenseApplicationInfo ctrlDrivingLicenseApplicationInfo1;
      private System.Windows.Forms.Label lblRecordsCount;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Button btnSave;
      private System.Windows.Forms.Button btnAddAppointment;
      private System.Windows.Forms.ContextMenuStrip ctmsAppointmentMenu;
      private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem takeTestToolStripMenuItem;
   }
}