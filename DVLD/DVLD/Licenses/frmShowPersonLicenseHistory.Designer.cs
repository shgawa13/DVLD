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
         this.tabControl1 = new System.Windows.Forms.TabControl();
         this.tabpLocal = new System.Windows.Forms.TabPage();
         this.tabpInternational = new System.Windows.Forms.TabPage();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.dgvLocalLicenses = new System.Windows.Forms.DataGridView();
         this.dgvInternationalLicenses = new System.Windows.Forms.DataGridView();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.ctrlPersonInfoWithFilter1 = new DVLD.People.Controls.ctrlPersonInfoWithFilter();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.tabControl1.SuspendLayout();
         this.tabpLocal.SuspendLayout();
         this.tabpInternational.SuspendLayout();
         this.groupBox1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dgvLocalLicenses)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicenses)).BeginInit();
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
         this.pictureBox1.Location = new System.Drawing.Point(13, 189);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(175, 145);
         this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.pictureBox1.TabIndex = 52;
         this.pictureBox1.TabStop = false;
         // 
         // tabControl1
         // 
         this.tabControl1.Controls.Add(this.tabpLocal);
         this.tabControl1.Controls.Add(this.tabpInternational);
         this.tabControl1.Location = new System.Drawing.Point(15, 25);
         this.tabControl1.Name = "tabControl1";
         this.tabControl1.SelectedIndex = 0;
         this.tabControl1.Size = new System.Drawing.Size(1031, 136);
         this.tabControl1.TabIndex = 53;
         // 
         // tabpLocal
         // 
         this.tabpLocal.Controls.Add(this.dgvLocalLicenses);
         this.tabpLocal.Location = new System.Drawing.Point(4, 30);
         this.tabpLocal.Name = "tabpLocal";
         this.tabpLocal.Padding = new System.Windows.Forms.Padding(3);
         this.tabpLocal.Size = new System.Drawing.Size(1023, 102);
         this.tabpLocal.TabIndex = 0;
         this.tabpLocal.Text = "Local";
         this.tabpLocal.UseVisualStyleBackColor = true;
         // 
         // tabpInternational
         // 
         this.tabpInternational.Controls.Add(this.dgvInternationalLicenses);
         this.tabpInternational.Location = new System.Drawing.Point(4, 30);
         this.tabpInternational.Name = "tabpInternational";
         this.tabpInternational.Padding = new System.Windows.Forms.Padding(3);
         this.tabpInternational.Size = new System.Drawing.Size(1023, 102);
         this.tabpInternational.TabIndex = 1;
         this.tabpInternational.Text = "International";
         this.tabpInternational.UseVisualStyleBackColor = true;
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.label2);
         this.groupBox1.Controls.Add(this.label1);
         this.groupBox1.Controls.Add(this.tabControl1);
         this.groupBox1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.groupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.groupBox1.Location = new System.Drawing.Point(24, 496);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(1046, 194);
         this.groupBox1.TabIndex = 54;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Driver Licenses";
         // 
         // dgvLocalLicenses
         // 
         this.dgvLocalLicenses.AllowUserToAddRows = false;
         this.dgvLocalLicenses.AllowUserToDeleteRows = false;
         this.dgvLocalLicenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
         this.dgvLocalLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dgvLocalLicenses.Dock = System.Windows.Forms.DockStyle.Top;
         this.dgvLocalLicenses.Location = new System.Drawing.Point(3, 3);
         this.dgvLocalLicenses.Name = "dgvLocalLicenses";
         this.dgvLocalLicenses.ReadOnly = true;
         this.dgvLocalLicenses.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.dgvLocalLicenses.Size = new System.Drawing.Size(1017, 93);
         this.dgvLocalLicenses.TabIndex = 0;
         // 
         // dgvInternationalLicenses
         // 
         this.dgvInternationalLicenses.AllowUserToAddRows = false;
         this.dgvInternationalLicenses.AllowUserToDeleteRows = false;
         this.dgvInternationalLicenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
         this.dgvInternationalLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dgvInternationalLicenses.Dock = System.Windows.Forms.DockStyle.Top;
         this.dgvInternationalLicenses.Location = new System.Drawing.Point(3, 3);
         this.dgvInternationalLicenses.Name = "dgvInternationalLicenses";
         this.dgvInternationalLicenses.ReadOnly = true;
         this.dgvInternationalLicenses.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.dgvInternationalLicenses.Size = new System.Drawing.Size(1017, 93);
         this.dgvInternationalLicenses.TabIndex = 1;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.BackColor = System.Drawing.Color.Transparent;
         this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.label1.Location = new System.Drawing.Point(10, 165);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(97, 24);
         this.label1.TabIndex = 54;
         this.label1.Text = "# Record:";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.BackColor = System.Drawing.Color.Transparent;
         this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.label2.Location = new System.Drawing.Point(103, 165);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(57, 24);
         this.label2.TabIndex = 55;
         this.label2.Text = "[???]";
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
         // 
         // frmShowPersonLicenseHistory
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(34)))), ((int)(((byte)(71)))));
         this.ClientSize = new System.Drawing.Size(1161, 696);
         this.Controls.Add(this.ctrlPersonInfoWithFilter1);
         this.Controls.Add(this.pictureBox1);
         this.Controls.Add(this.lblTitle);
         this.Controls.Add(this.groupBox1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
         this.Name = "frmShowPersonLicenseHistory";
         this.Text = "Show PersonLicense History";
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.tabControl1.ResumeLayout(false);
         this.tabpLocal.ResumeLayout(false);
         this.tabpInternational.ResumeLayout(false);
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dgvLocalLicenses)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicenses)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label lblTitle;
      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.TabControl tabControl1;
      private System.Windows.Forms.TabPage tabpLocal;
      private System.Windows.Forms.TabPage tabpInternational;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.DataGridView dgvLocalLicenses;
      private System.Windows.Forms.DataGridView dgvInternationalLicenses;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private People.Controls.ctrlPersonInfoWithFilter ctrlPersonInfoWithFilter1;
   }
}