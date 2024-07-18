namespace DVLD.Licenses
{
   partial class frmListDrivingLicenseApplication
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
         this.panel1 = new System.Windows.Forms.Panel();
         this.txtFilterValue = new System.Windows.Forms.TextBox();
         this.cbFilterBy = new System.Windows.Forms.ComboBox();
         this.label2 = new System.Windows.Forms.Label();
         this.lblTitle = new System.Windows.Forms.Label();
         this.dgvDrivingLincesApplications = new System.Windows.Forms.DataGridView();
         this.bntAddNewApplication = new System.Windows.Forms.Button();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.panel1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dgvDrivingLincesApplications)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.SuspendLayout();
         // 
         // panel1
         // 
         this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
         this.panel1.Controls.Add(this.txtFilterValue);
         this.panel1.Controls.Add(this.cbFilterBy);
         this.panel1.Controls.Add(this.label2);
         this.panel1.Controls.Add(this.bntAddNewApplication);
         this.panel1.Controls.Add(this.pictureBox1);
         this.panel1.Controls.Add(this.lblTitle);
         this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
         this.panel1.Location = new System.Drawing.Point(0, 0);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(950, 211);
         this.panel1.TabIndex = 0;
         // 
         // txtFilterValue
         // 
         this.txtFilterValue.Location = new System.Drawing.Point(294, 178);
         this.txtFilterValue.Name = "txtFilterValue";
         this.txtFilterValue.Size = new System.Drawing.Size(170, 20);
         this.txtFilterValue.TabIndex = 53;
         this.txtFilterValue.Visible = false;
         // 
         // cbFilterBy
         // 
         this.cbFilterBy.BackColor = System.Drawing.SystemColors.Window;
         this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cbFilterBy.ImeMode = System.Windows.Forms.ImeMode.NoControl;
         this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "User ID",
            "User Name",
            "Person ID",
            "Full Name",
            "Is Active"});
         this.cbFilterBy.Location = new System.Drawing.Point(100, 178);
         this.cbFilterBy.Name = "cbFilterBy";
         this.cbFilterBy.Size = new System.Drawing.Size(170, 21);
         this.cbFilterBy.TabIndex = 52;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.label2.Location = new System.Drawing.Point(18, 176);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(75, 24);
         this.label2.TabIndex = 51;
         this.label2.Text = "Find by";
         // 
         // lblTitle
         // 
         this.lblTitle.AutoSize = true;
         this.lblTitle.BackColor = System.Drawing.Color.Transparent;
         this.lblTitle.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.lblTitle.Location = new System.Drawing.Point(256, 124);
         this.lblTitle.Name = "lblTitle";
         this.lblTitle.Size = new System.Drawing.Size(447, 34);
         this.lblTitle.TabIndex = 48;
         this.lblTitle.Text = "Local Driving License Applications";
         // 
         // dgvDrivingLincesApplications
         // 
         this.dgvDrivingLincesApplications.AllowUserToAddRows = false;
         this.dgvDrivingLincesApplications.AllowUserToDeleteRows = false;
         this.dgvDrivingLincesApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dgvDrivingLincesApplications.Dock = System.Windows.Forms.DockStyle.Fill;
         this.dgvDrivingLincesApplications.Location = new System.Drawing.Point(0, 211);
         this.dgvDrivingLincesApplications.Name = "dgvDrivingLincesApplications";
         this.dgvDrivingLincesApplications.ReadOnly = true;
         this.dgvDrivingLincesApplications.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.dgvDrivingLincesApplications.Size = new System.Drawing.Size(950, 247);
         this.dgvDrivingLincesApplications.TabIndex = 1;
         // 
         // bntAddNewApplication
         // 
         this.bntAddNewApplication.BackColor = System.Drawing.Color.Transparent;
         this.bntAddNewApplication.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
         this.bntAddNewApplication.FlatAppearance.BorderSize = 0;
         this.bntAddNewApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.bntAddNewApplication.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold);
         this.bntAddNewApplication.ForeColor = System.Drawing.Color.Black;
         this.bntAddNewApplication.Image = global::DVLD.Properties.Resources.New_Application_64;
         this.bntAddNewApplication.Location = new System.Drawing.Point(852, 133);
         this.bntAddNewApplication.Name = "bntAddNewApplication";
         this.bntAddNewApplication.Size = new System.Drawing.Size(86, 69);
         this.bntAddNewApplication.TabIndex = 50;
         this.bntAddNewApplication.UseVisualStyleBackColor = false;
         // 
         // pictureBox1
         // 
         this.pictureBox1.Image = global::DVLD.Properties.Resources.Application_Types_5121;
         this.pictureBox1.Location = new System.Drawing.Point(366, 6);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(227, 115);
         this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.pictureBox1.TabIndex = 49;
         this.pictureBox1.TabStop = false;
         // 
         // frmListDrivingLicenseApplication
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(33)))), ((int)(((byte)(67)))));
         this.ClientSize = new System.Drawing.Size(950, 458);
         this.Controls.Add(this.dgvDrivingLincesApplications);
         this.Controls.Add(this.panel1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
         this.Name = "frmListDrivingLicenseApplication";
         this.Text = "frmListDrivingLicenseApplication";
         this.Load += new System.EventHandler(this.frmListDrivingLicenseApplication_Load);
         this.panel1.ResumeLayout(false);
         this.panel1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dgvDrivingLincesApplications)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.Label lblTitle;
      private System.Windows.Forms.DataGridView dgvDrivingLincesApplications;
      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.Button bntAddNewApplication;
      private System.Windows.Forms.TextBox txtFilterValue;
      private System.Windows.Forms.ComboBox cbFilterBy;
      private System.Windows.Forms.Label label2;
   }
}