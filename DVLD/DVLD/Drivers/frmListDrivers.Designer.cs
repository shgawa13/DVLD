namespace DVLD.Drivers
{
   partial class frmListDrivers
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
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.panel1 = new System.Windows.Forms.Panel();
         this.label1 = new System.Windows.Forms.Label();
         this.dgvDrivers = new System.Windows.Forms.DataGridView();
         this.panel2 = new System.Windows.Forms.Panel();
         this.panel3 = new System.Windows.Forms.Panel();
         this.label2 = new System.Windows.Forms.Label();
         this.lblRecordsCount = new System.Windows.Forms.Label();
         this.txtFilterValue = new System.Windows.Forms.TextBox();
         this.cbFilterBy = new System.Windows.Forms.ComboBox();
         this.label4 = new System.Windows.Forms.Label();
         this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
         this.tlsmShowInfo = new System.Windows.Forms.ToolStripMenuItem();
         this.tlsmshowPersonLicenseHistory = new System.Windows.Forms.ToolStripMenuItem();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.panel1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dgvDrivers)).BeginInit();
         this.panel2.SuspendLayout();
         this.panel3.SuspendLayout();
         this.contextMenuStrip1.SuspendLayout();
         this.SuspendLayout();
         // 
         // pictureBox1
         // 
         this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
         this.pictureBox1.Image = global::DVLD.Properties.Resources.driver;
         this.pictureBox1.Location = new System.Drawing.Point(294, 3);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(217, 154);
         this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.pictureBox1.TabIndex = 0;
         this.pictureBox1.TabStop = false;
         // 
         // panel1
         // 
         this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
         this.panel1.Controls.Add(this.label1);
         this.panel1.Controls.Add(this.pictureBox1);
         this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
         this.panel1.Location = new System.Drawing.Point(0, 0);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(800, 196);
         this.panel1.TabIndex = 1;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.label1.Location = new System.Drawing.Point(361, 160);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(93, 30);
         this.label1.TabIndex = 1;
         this.label1.Text = "Drivers";
         // 
         // dgvDrivers
         // 
         this.dgvDrivers.AllowUserToAddRows = false;
         this.dgvDrivers.AllowUserToDeleteRows = false;
         this.dgvDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dgvDrivers.Location = new System.Drawing.Point(0, 263);
         this.dgvDrivers.Name = "dgvDrivers";
         this.dgvDrivers.ReadOnly = true;
         this.dgvDrivers.Size = new System.Drawing.Size(800, 211);
         this.dgvDrivers.TabIndex = 2;
         // 
         // panel2
         // 
         this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
         this.panel2.Controls.Add(this.lblRecordsCount);
         this.panel2.Controls.Add(this.label2);
         this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.panel2.Location = new System.Drawing.Point(0, 480);
         this.panel2.Name = "panel2";
         this.panel2.Size = new System.Drawing.Size(800, 47);
         this.panel2.TabIndex = 3;
         // 
         // panel3
         // 
         this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(37)))), ((int)(((byte)(73)))));
         this.panel3.Controls.Add(this.txtFilterValue);
         this.panel3.Controls.Add(this.cbFilterBy);
         this.panel3.Controls.Add(this.label4);
         this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
         this.panel3.Location = new System.Drawing.Point(0, 196);
         this.panel3.Name = "panel3";
         this.panel3.Size = new System.Drawing.Size(800, 61);
         this.panel3.TabIndex = 4;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.label2.Location = new System.Drawing.Point(3, 14);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(97, 24);
         this.label2.TabIndex = 2;
         this.label2.Text = "# Record:";
         // 
         // lblRecordsCount
         // 
         this.lblRecordsCount.AutoSize = true;
         this.lblRecordsCount.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblRecordsCount.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.lblRecordsCount.Location = new System.Drawing.Point(97, 14);
         this.lblRecordsCount.Name = "lblRecordsCount";
         this.lblRecordsCount.Size = new System.Drawing.Size(57, 24);
         this.lblRecordsCount.TabIndex = 3;
         this.lblRecordsCount.Text = "[???]";
         // 
         // txtFilterValue
         // 
         this.txtFilterValue.Location = new System.Drawing.Point(295, 23);
         this.txtFilterValue.Name = "txtFilterValue";
         this.txtFilterValue.Size = new System.Drawing.Size(170, 20);
         this.txtFilterValue.TabIndex = 26;
         this.txtFilterValue.Visible = false;
         this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
         this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
         // 
         // cbFilterBy
         // 
         this.cbFilterBy.BackColor = System.Drawing.SystemColors.Window;
         this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cbFilterBy.ImeMode = System.Windows.Forms.ImeMode.NoControl;
         this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "Driver ID",
            "Person ID",
            "National No.",
            "Full Name"});
         this.cbFilterBy.Location = new System.Drawing.Point(101, 23);
         this.cbFilterBy.Name = "cbFilterBy";
         this.cbFilterBy.Size = new System.Drawing.Size(170, 21);
         this.cbFilterBy.TabIndex = 25;
         this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.label4.Location = new System.Drawing.Point(7, 21);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(75, 24);
         this.label4.TabIndex = 24;
         this.label4.Text = "Find by";
         // 
         // contextMenuStrip1
         // 
         this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsmShowInfo,
            this.tlsmshowPersonLicenseHistory});
         this.contextMenuStrip1.Name = "contextMenuStrip1";
         this.contextMenuStrip1.Size = new System.Drawing.Size(187, 70);
         // 
         // tlsmShowInfo
         // 
         this.tlsmShowInfo.Name = "tlsmShowInfo";
         this.tlsmShowInfo.Size = new System.Drawing.Size(186, 22);
         this.tlsmShowInfo.Text = "Show Info";
         this.tlsmShowInfo.Click += new System.EventHandler(this.tlsmShowInfo_Click);
         // 
         // tlsmshowPersonLicenseHistory
         // 
         this.tlsmshowPersonLicenseHistory.Name = "tlsmshowPersonLicenseHistory";
         this.tlsmshowPersonLicenseHistory.Size = new System.Drawing.Size(186, 22);
         this.tlsmshowPersonLicenseHistory.Text = "Show License History";
         this.tlsmshowPersonLicenseHistory.Click += new System.EventHandler(this.tlsmshowPersonLicenseHistory_Click);
         // 
         // frmListDrivers
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.Gainsboro;
         this.ClientSize = new System.Drawing.Size(800, 527);
         this.Controls.Add(this.panel3);
         this.Controls.Add(this.panel2);
         this.Controls.Add(this.dgvDrivers);
         this.Controls.Add(this.panel1);
         this.Name = "frmListDrivers";
         this.Text = "List Drivers";
         this.Load += new System.EventHandler(this.frmListDrivers_Load);
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.panel1.ResumeLayout(false);
         this.panel1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dgvDrivers)).EndInit();
         this.panel2.ResumeLayout(false);
         this.panel2.PerformLayout();
         this.panel3.ResumeLayout(false);
         this.panel3.PerformLayout();
         this.contextMenuStrip1.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.DataGridView dgvDrivers;
      private System.Windows.Forms.Panel panel2;
      private System.Windows.Forms.Panel panel3;
      private System.Windows.Forms.Label lblRecordsCount;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox txtFilterValue;
      private System.Windows.Forms.ComboBox cbFilterBy;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
      private System.Windows.Forms.ToolStripMenuItem tlsmShowInfo;
      private System.Windows.Forms.ToolStripMenuItem tlsmshowPersonLicenseHistory;
   }
}