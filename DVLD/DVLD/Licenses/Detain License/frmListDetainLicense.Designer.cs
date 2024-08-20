namespace DVLD.Licenses.Detain_License
{
   partial class frmListDetainedLicense
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
         this.panel1 = new System.Windows.Forms.Panel();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.lblTitle = new System.Windows.Forms.Label();
         this.panel2 = new System.Windows.Forms.Panel();
         this.btnDetain = new System.Windows.Forms.Button();
         this.btnRelease = new System.Windows.Forms.Button();
         this.cbIsReleased = new System.Windows.Forms.ComboBox();
         this.txtFilterValue = new System.Windows.Forms.TextBox();
         this.cbFilterBy = new System.Windows.Forms.ComboBox();
         this.label2 = new System.Windows.Forms.Label();
         this.dgvDetainedLicenses = new System.Windows.Forms.DataGridView();
         this.label1 = new System.Windows.Forms.Label();
         this.lblTotalRecords = new System.Windows.Forms.Label();
         this.cmsApplications = new System.Windows.Forms.ContextMenuStrip(this.components);
         this.tlsmShowPersonDetails = new System.Windows.Forms.ToolStripMenuItem();
         this.tlsmShowLicenseDetails = new System.Windows.Forms.ToolStripMenuItem();
         this.tlsmShowLicenseHistory = new System.Windows.Forms.ToolStripMenuItem();
         this.tlsmReleaseDetainedLicesne = new System.Windows.Forms.ToolStripMenuItem();
         this.panel1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.panel2.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dgvDetainedLicenses)).BeginInit();
         this.cmsApplications.SuspendLayout();
         this.SuspendLayout();
         // 
         // panel1
         // 
         this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
         this.panel1.Controls.Add(this.pictureBox1);
         this.panel1.Controls.Add(this.lblTitle);
         this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
         this.panel1.Location = new System.Drawing.Point(0, 0);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(927, 182);
         this.panel1.TabIndex = 0;
         // 
         // pictureBox1
         // 
         this.pictureBox1.Image = global::DVLD.Properties.Resources.suspended_license;
         this.pictureBox1.Location = new System.Drawing.Point(343, 4);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(247, 136);
         this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.pictureBox1.TabIndex = 50;
         this.pictureBox1.TabStop = false;
         // 
         // lblTitle
         // 
         this.lblTitle.AutoSize = true;
         this.lblTitle.BackColor = System.Drawing.Color.Transparent;
         this.lblTitle.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.lblTitle.Location = new System.Drawing.Point(315, 143);
         this.lblTitle.Name = "lblTitle";
         this.lblTitle.Size = new System.Drawing.Size(299, 34);
         this.lblTitle.TabIndex = 49;
         this.lblTitle.Text = "List Detained Licenses";
         // 
         // panel2
         // 
         this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(37)))), ((int)(((byte)(73)))));
         this.panel2.Controls.Add(this.btnDetain);
         this.panel2.Controls.Add(this.btnRelease);
         this.panel2.Controls.Add(this.cbIsReleased);
         this.panel2.Controls.Add(this.txtFilterValue);
         this.panel2.Controls.Add(this.cbFilterBy);
         this.panel2.Controls.Add(this.label2);
         this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
         this.panel2.Location = new System.Drawing.Point(0, 182);
         this.panel2.Name = "panel2";
         this.panel2.Size = new System.Drawing.Size(927, 51);
         this.panel2.TabIndex = 1;
         // 
         // btnDetain
         // 
         this.btnDetain.BackColor = System.Drawing.Color.IndianRed;
         this.btnDetain.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.btnDetain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnDetain.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnDetain.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.btnDetain.Location = new System.Drawing.Point(812, 7);
         this.btnDetain.Name = "btnDetain";
         this.btnDetain.Size = new System.Drawing.Size(108, 37);
         this.btnDetain.TabIndex = 59;
         this.btnDetain.Text = "Detain";
         this.btnDetain.UseVisualStyleBackColor = false;
         // 
         // btnRelease
         // 
         this.btnRelease.BackColor = System.Drawing.Color.Azure;
         this.btnRelease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnRelease.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnRelease.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
         this.btnRelease.Location = new System.Drawing.Point(686, 7);
         this.btnRelease.Name = "btnRelease";
         this.btnRelease.Size = new System.Drawing.Size(108, 37);
         this.btnRelease.TabIndex = 58;
         this.btnRelease.Text = "Release";
         this.btnRelease.UseVisualStyleBackColor = false;
         // 
         // cbIsReleased
         // 
         this.cbIsReleased.BackColor = System.Drawing.SystemColors.Window;
         this.cbIsReleased.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cbIsReleased.ImeMode = System.Windows.Forms.ImeMode.NoControl;
         this.cbIsReleased.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
         this.cbIsReleased.Location = new System.Drawing.Point(308, 15);
         this.cbIsReleased.Name = "cbIsReleased";
         this.cbIsReleased.Size = new System.Drawing.Size(90, 21);
         this.cbIsReleased.TabIndex = 28;
         this.cbIsReleased.Visible = false;
         this.cbIsReleased.SelectedIndexChanged += new System.EventHandler(this.cbIsReleased_SelectedIndexChanged);
         // 
         // txtFilterValue
         // 
         this.txtFilterValue.Location = new System.Drawing.Point(308, 15);
         this.txtFilterValue.Name = "txtFilterValue";
         this.txtFilterValue.Size = new System.Drawing.Size(170, 20);
         this.txtFilterValue.TabIndex = 27;
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
            "Detain ID",
            "Is Released",
            "National No",
            "Full Name",
            "Release Application ID"});
         this.cbFilterBy.Location = new System.Drawing.Point(114, 15);
         this.cbFilterBy.Name = "cbFilterBy";
         this.cbFilterBy.Size = new System.Drawing.Size(170, 21);
         this.cbFilterBy.TabIndex = 26;
         this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.label2.Location = new System.Drawing.Point(20, 13);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(75, 24);
         this.label2.TabIndex = 25;
         this.label2.Text = "Find by";
         // 
         // dgvDetainedLicenses
         // 
         this.dgvDetainedLicenses.AllowUserToAddRows = false;
         this.dgvDetainedLicenses.AllowUserToDeleteRows = false;
         this.dgvDetainedLicenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
         this.dgvDetainedLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dgvDetainedLicenses.Location = new System.Drawing.Point(0, 237);
         this.dgvDetainedLicenses.Name = "dgvDetainedLicenses";
         this.dgvDetainedLicenses.ReadOnly = true;
         this.dgvDetainedLicenses.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.dgvDetainedLicenses.Size = new System.Drawing.Size(927, 241);
         this.dgvDetainedLicenses.TabIndex = 2;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.label1.Location = new System.Drawing.Point(12, 488);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(97, 24);
         this.label1.TabIndex = 26;
         this.label1.Text = "# Record:";
         // 
         // lblTotalRecords
         // 
         this.lblTotalRecords.AutoSize = true;
         this.lblTotalRecords.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblTotalRecords.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.lblTotalRecords.Location = new System.Drawing.Point(109, 488);
         this.lblTotalRecords.Name = "lblTotalRecords";
         this.lblTotalRecords.Size = new System.Drawing.Size(57, 24);
         this.lblTotalRecords.TabIndex = 29;
         this.lblTotalRecords.Text = "[???]";
         // 
         // cmsApplications
         // 
         this.cmsApplications.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsmShowPersonDetails,
            this.tlsmShowLicenseDetails,
            this.tlsmShowLicenseHistory,
            this.tlsmReleaseDetainedLicesne});
         this.cmsApplications.Name = "contextMenuStrip1";
         this.cmsApplications.Size = new System.Drawing.Size(206, 92);
         // 
         // tlsmShowPersonDetails
         // 
         this.tlsmShowPersonDetails.Name = "tlsmShowPersonDetails";
         this.tlsmShowPersonDetails.Size = new System.Drawing.Size(205, 22);
         this.tlsmShowPersonDetails.Text = "Show Person Details";
         this.tlsmShowPersonDetails.Click += new System.EventHandler(this.tlsmShowPersonDetails_Click);
         // 
         // tlsmShowLicenseDetails
         // 
         this.tlsmShowLicenseDetails.Name = "tlsmShowLicenseDetails";
         this.tlsmShowLicenseDetails.Size = new System.Drawing.Size(205, 22);
         this.tlsmShowLicenseDetails.Text = "Show License Details";
         this.tlsmShowLicenseDetails.Click += new System.EventHandler(this.tlsmShowLicenseDetails_Click);
         // 
         // tlsmShowLicenseHistory
         // 
         this.tlsmShowLicenseHistory.Name = "tlsmShowLicenseHistory";
         this.tlsmShowLicenseHistory.Size = new System.Drawing.Size(205, 22);
         this.tlsmShowLicenseHistory.Text = "Show License History";
         this.tlsmShowLicenseHistory.Click += new System.EventHandler(this.tlsmShowLicenseHistory_Click);
         // 
         // tlsmReleaseDetainedLicesne
         // 
         this.tlsmReleaseDetainedLicesne.Name = "tlsmReleaseDetainedLicesne";
         this.tlsmReleaseDetainedLicesne.Size = new System.Drawing.Size(205, 22);
         this.tlsmReleaseDetainedLicesne.Text = "Release Detained License";
         this.tlsmReleaseDetainedLicesne.Click += new System.EventHandler(this.tlsmReleaseDetainedLicesne_Click);
         // 
         // frmListDetainedLicense
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
         this.ClientSize = new System.Drawing.Size(927, 521);
         this.Controls.Add(this.lblTotalRecords);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.dgvDetainedLicenses);
         this.Controls.Add(this.panel2);
         this.Controls.Add(this.panel1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
         this.Name = "frmListDetainedLicense";
         this.Text = "List Detained License";
         this.Load += new System.EventHandler(this.frmListDetainedLicense_Load);
         this.panel1.ResumeLayout(false);
         this.panel1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.panel2.ResumeLayout(false);
         this.panel2.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dgvDetainedLicenses)).EndInit();
         this.cmsApplications.ResumeLayout(false);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.Label lblTitle;
      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.Panel panel2;
      private System.Windows.Forms.ComboBox cbIsReleased;
      private System.Windows.Forms.TextBox txtFilterValue;
      private System.Windows.Forms.ComboBox cbFilterBy;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.DataGridView dgvDetainedLicenses;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label lblTotalRecords;
      private System.Windows.Forms.Button btnDetain;
      private System.Windows.Forms.Button btnRelease;
      private System.Windows.Forms.ContextMenuStrip cmsApplications;
      private System.Windows.Forms.ToolStripMenuItem tlsmShowPersonDetails;
      private System.Windows.Forms.ToolStripMenuItem tlsmShowLicenseDetails;
      private System.Windows.Forms.ToolStripMenuItem tlsmShowLicenseHistory;
      private System.Windows.Forms.ToolStripMenuItem tlsmReleaseDetainedLicesne;
   }
}