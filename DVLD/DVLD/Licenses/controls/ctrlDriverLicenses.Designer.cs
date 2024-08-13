namespace DVLD.Licenses.controls
{
   partial class ctrlDriverLicenses
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

      #region Component Designer generated code

      /// <summary> 
      /// Required method for Designer support - do not modify 
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.tabControl1 = new System.Windows.Forms.TabControl();
         this.tabpLocal = new System.Windows.Forms.TabPage();
         this.lblLocalLicensesRecords = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.dgvLocalLicensesHistory = new System.Windows.Forms.DataGridView();
         this.tabpInternational = new System.Windows.Forms.TabPage();
         this.dgvInternationalLicensesHistory = new System.Windows.Forms.DataGridView();
         this.lblInternationalLicensesRecords = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.groupBox1.SuspendLayout();
         this.tabControl1.SuspendLayout();
         this.tabpLocal.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dgvLocalLicensesHistory)).BeginInit();
         this.tabpInternational.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicensesHistory)).BeginInit();
         this.SuspendLayout();
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.tabControl1);
         this.groupBox1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.groupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.groupBox1.Location = new System.Drawing.Point(0, 3);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(1046, 198);
         this.groupBox1.TabIndex = 55;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Driver Licenses";
         // 
         // tabControl1
         // 
         this.tabControl1.Controls.Add(this.tabpLocal);
         this.tabControl1.Controls.Add(this.tabpInternational);
         this.tabControl1.Location = new System.Drawing.Point(15, 25);
         this.tabControl1.Name = "tabControl1";
         this.tabControl1.SelectedIndex = 0;
         this.tabControl1.Size = new System.Drawing.Size(1031, 169);
         this.tabControl1.TabIndex = 53;
         // 
         // tabpLocal
         // 
         this.tabpLocal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(34)))), ((int)(((byte)(71)))));
         this.tabpLocal.Controls.Add(this.lblLocalLicensesRecords);
         this.tabpLocal.Controls.Add(this.label1);
         this.tabpLocal.Controls.Add(this.dgvLocalLicensesHistory);
         this.tabpLocal.Location = new System.Drawing.Point(4, 30);
         this.tabpLocal.Name = "tabpLocal";
         this.tabpLocal.Padding = new System.Windows.Forms.Padding(3);
         this.tabpLocal.Size = new System.Drawing.Size(1023, 135);
         this.tabpLocal.TabIndex = 0;
         this.tabpLocal.Text = "Local";
         // 
         // lblLocalLicensesRecords
         // 
         this.lblLocalLicensesRecords.AutoSize = true;
         this.lblLocalLicensesRecords.BackColor = System.Drawing.Color.Transparent;
         this.lblLocalLicensesRecords.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblLocalLicensesRecords.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.lblLocalLicensesRecords.Location = new System.Drawing.Point(97, 111);
         this.lblLocalLicensesRecords.Name = "lblLocalLicensesRecords";
         this.lblLocalLicensesRecords.Size = new System.Drawing.Size(57, 24);
         this.lblLocalLicensesRecords.TabIndex = 55;
         this.lblLocalLicensesRecords.Text = "[???]";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.BackColor = System.Drawing.Color.Transparent;
         this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.label1.Location = new System.Drawing.Point(2, 111);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(97, 24);
         this.label1.TabIndex = 54;
         this.label1.Text = "# Record:";
         // 
         // dgvLocalLicensesHistory
         // 
         this.dgvLocalLicensesHistory.AllowUserToAddRows = false;
         this.dgvLocalLicensesHistory.AllowUserToDeleteRows = false;
         this.dgvLocalLicensesHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
         this.dgvLocalLicensesHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dgvLocalLicensesHistory.Dock = System.Windows.Forms.DockStyle.Top;
         this.dgvLocalLicensesHistory.Location = new System.Drawing.Point(3, 3);
         this.dgvLocalLicensesHistory.Name = "dgvLocalLicensesHistory";
         this.dgvLocalLicensesHistory.ReadOnly = true;
         this.dgvLocalLicensesHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.dgvLocalLicensesHistory.Size = new System.Drawing.Size(1017, 95);
         this.dgvLocalLicensesHistory.TabIndex = 0;
         // 
         // tabpInternational
         // 
         this.tabpInternational.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(34)))), ((int)(((byte)(71)))));
         this.tabpInternational.Controls.Add(this.lblInternationalLicensesRecords);
         this.tabpInternational.Controls.Add(this.label3);
         this.tabpInternational.Controls.Add(this.dgvInternationalLicensesHistory);
         this.tabpInternational.Location = new System.Drawing.Point(4, 30);
         this.tabpInternational.Name = "tabpInternational";
         this.tabpInternational.Padding = new System.Windows.Forms.Padding(3);
         this.tabpInternational.Size = new System.Drawing.Size(1023, 135);
         this.tabpInternational.TabIndex = 1;
         this.tabpInternational.Text = "International";
         // 
         // dgvInternationalLicensesHistory
         // 
         this.dgvInternationalLicensesHistory.AllowUserToAddRows = false;
         this.dgvInternationalLicensesHistory.AllowUserToDeleteRows = false;
         this.dgvInternationalLicensesHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
         this.dgvInternationalLicensesHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dgvInternationalLicensesHistory.Dock = System.Windows.Forms.DockStyle.Top;
         this.dgvInternationalLicensesHistory.Location = new System.Drawing.Point(3, 3);
         this.dgvInternationalLicensesHistory.Name = "dgvInternationalLicensesHistory";
         this.dgvInternationalLicensesHistory.ReadOnly = true;
         this.dgvInternationalLicensesHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.dgvInternationalLicensesHistory.Size = new System.Drawing.Size(1017, 93);
         this.dgvInternationalLicensesHistory.TabIndex = 1;
         // 
         // lblInternationalLicensesRecords
         // 
         this.lblInternationalLicensesRecords.AutoSize = true;
         this.lblInternationalLicensesRecords.BackColor = System.Drawing.Color.Transparent;
         this.lblInternationalLicensesRecords.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblInternationalLicensesRecords.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.lblInternationalLicensesRecords.Location = new System.Drawing.Point(97, 109);
         this.lblInternationalLicensesRecords.Name = "lblInternationalLicensesRecords";
         this.lblInternationalLicensesRecords.Size = new System.Drawing.Size(57, 24);
         this.lblInternationalLicensesRecords.TabIndex = 57;
         this.lblInternationalLicensesRecords.Text = "[???]";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.BackColor = System.Drawing.Color.Transparent;
         this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.label3.Location = new System.Drawing.Point(2, 109);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(97, 24);
         this.label3.TabIndex = 56;
         this.label3.Text = "# Record:";
         // 
         // ctrlDriverLicenses
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(34)))), ((int)(((byte)(71)))));
         this.Controls.Add(this.groupBox1);
         this.Name = "ctrlDriverLicenses";
         this.Size = new System.Drawing.Size(1052, 203);
         this.groupBox1.ResumeLayout(false);
         this.tabControl1.ResumeLayout(false);
         this.tabpLocal.ResumeLayout(false);
         this.tabpLocal.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dgvLocalLicensesHistory)).EndInit();
         this.tabpInternational.ResumeLayout(false);
         this.tabpInternational.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicensesHistory)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.Label lblLocalLicensesRecords;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TabControl tabControl1;
      private System.Windows.Forms.TabPage tabpLocal;
      private System.Windows.Forms.DataGridView dgvLocalLicensesHistory;
      private System.Windows.Forms.TabPage tabpInternational;
      private System.Windows.Forms.DataGridView dgvInternationalLicensesHistory;
      private System.Windows.Forms.Label lblInternationalLicensesRecords;
      private System.Windows.Forms.Label label3;
   }
}
