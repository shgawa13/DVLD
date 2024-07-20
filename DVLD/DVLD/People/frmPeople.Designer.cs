namespace DVLD.People
{
   partial class frmPeople
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
         this.btnCloseLogin = new System.Windows.Forms.Button();
         this.panel1 = new System.Windows.Forms.Panel();
         this.btnAddPreson = new System.Windows.Forms.Button();
         this.txtFilterValue = new System.Windows.Forms.TextBox();
         this.cbFilter = new System.Windows.Forms.ComboBox();
         this.label2 = new System.Windows.Forms.Label();
         this.panel2 = new System.Windows.Forms.Panel();
         this.lblRecordsNum = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.dgvPeople = new System.Windows.Forms.DataGridView();
         this.cmstMangePeople = new System.Windows.Forms.ContextMenuStrip(this.components);
         this.tolstmShowDetils = new System.Windows.Forms.ToolStripMenuItem();
         this.tolstmSendEmail = new System.Windows.Forms.ToolStripMenuItem();
         this.tolstmEdit = new System.Windows.Forms.ToolStripMenuItem();
         this.tolstmDelete = new System.Windows.Forms.ToolStripMenuItem();
         this.label1 = new System.Windows.Forms.Label();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.panel1.SuspendLayout();
         this.panel2.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).BeginInit();
         this.cmstMangePeople.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.SuspendLayout();
         // 
         // btnCloseLogin
         // 
         this.btnCloseLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
         this.btnCloseLogin.FlatAppearance.BorderSize = 0;
         this.btnCloseLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnCloseLogin.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnCloseLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(36)))));
         this.btnCloseLogin.Location = new System.Drawing.Point(1024, 9);
         this.btnCloseLogin.Name = "btnCloseLogin";
         this.btnCloseLogin.Size = new System.Drawing.Size(94, 30);
         this.btnCloseLogin.TabIndex = 13;
         this.btnCloseLogin.Text = "Close";
         this.btnCloseLogin.UseVisualStyleBackColor = false;
         this.btnCloseLogin.Click += new System.EventHandler(this.btnCloseLogin_Click);
         // 
         // panel1
         // 
         this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(37)))), ((int)(((byte)(73)))));
         this.panel1.Controls.Add(this.btnAddPreson);
         this.panel1.Controls.Add(this.txtFilterValue);
         this.panel1.Controls.Add(this.cbFilter);
         this.panel1.Controls.Add(this.label2);
         this.panel1.Location = new System.Drawing.Point(0, 151);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(1125, 67);
         this.panel1.TabIndex = 14;
         // 
         // btnAddPreson
         // 
         this.btnAddPreson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
         this.btnAddPreson.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
         this.btnAddPreson.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
         this.btnAddPreson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(36)))));
         this.btnAddPreson.Location = new System.Drawing.Point(1010, 6);
         this.btnAddPreson.Name = "btnAddPreson";
         this.btnAddPreson.Size = new System.Drawing.Size(108, 54);
         this.btnAddPreson.TabIndex = 21;
         this.btnAddPreson.Text = "Add New\r\nPerson";
         this.btnAddPreson.UseVisualStyleBackColor = false;
         this.btnAddPreson.Click += new System.EventHandler(this.btnAddPreson_Click);
         // 
         // txtFilterValue
         // 
         this.txtFilterValue.Location = new System.Drawing.Point(297, 24);
         this.txtFilterValue.Name = "txtFilterValue";
         this.txtFilterValue.Size = new System.Drawing.Size(170, 20);
         this.txtFilterValue.TabIndex = 20;
         this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
         // 
         // cbFilter
         // 
         this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cbFilter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
         this.cbFilter.Items.AddRange(new object[] {
            "None",
            "Person ID",
            "National Number",
            "First Name",
            "Second Name",
            "Third Name",
            "Last Name",
            "Nationlity",
            "Gendor",
            "Phone Number",
            "Email"});
         this.cbFilter.Location = new System.Drawing.Point(103, 24);
         this.cbFilter.Name = "cbFilter";
         this.cbFilter.Size = new System.Drawing.Size(170, 21);
         this.cbFilter.TabIndex = 19;
         this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
         this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.label2.Location = new System.Drawing.Point(21, 25);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(67, 18);
         this.label2.TabIndex = 18;
         this.label2.Text = "Find by";
         // 
         // panel2
         // 
         this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(37)))), ((int)(((byte)(73)))));
         this.panel2.Controls.Add(this.lblRecordsNum);
         this.panel2.Controls.Add(this.label3);
         this.panel2.Controls.Add(this.btnCloseLogin);
         this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.panel2.Location = new System.Drawing.Point(0, 503);
         this.panel2.Name = "panel2";
         this.panel2.Size = new System.Drawing.Size(1127, 51);
         this.panel2.TabIndex = 22;
         // 
         // lblRecordsNum
         // 
         this.lblRecordsNum.AutoSize = true;
         this.lblRecordsNum.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
         this.lblRecordsNum.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.lblRecordsNum.Location = new System.Drawing.Point(102, 20);
         this.lblRecordsNum.Name = "lblRecordsNum";
         this.lblRecordsNum.Size = new System.Drawing.Size(0, 18);
         this.lblRecordsNum.TabIndex = 19;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
         this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.label3.Location = new System.Drawing.Point(14, 19);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(89, 18);
         this.label3.TabIndex = 18;
         this.label3.Text = "# Record:";
         // 
         // dgvPeople
         // 
         this.dgvPeople.AllowUserToAddRows = false;
         this.dgvPeople.AllowUserToDeleteRows = false;
         this.dgvPeople.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
         this.dgvPeople.BackgroundColor = System.Drawing.Color.DarkGray;
         this.dgvPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dgvPeople.ContextMenuStrip = this.cmstMangePeople;
         this.dgvPeople.Location = new System.Drawing.Point(-3, 218);
         this.dgvPeople.Name = "dgvPeople";
         this.dgvPeople.ReadOnly = true;
         this.dgvPeople.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.dgvPeople.Size = new System.Drawing.Size(1128, 288);
         this.dgvPeople.TabIndex = 15;
         // 
         // cmstMangePeople
         // 
         this.cmstMangePeople.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tolstmShowDetils,
            this.tolstmSendEmail,
            this.tolstmEdit,
            this.tolstmDelete});
         this.cmstMangePeople.Name = "contextMenuStrip1";
         this.cmstMangePeople.Size = new System.Drawing.Size(136, 92);
         this.cmstMangePeople.Text = "Mange People";
         // 
         // tolstmShowDetils
         // 
         this.tolstmShowDetils.Name = "tolstmShowDetils";
         this.tolstmShowDetils.Size = new System.Drawing.Size(135, 22);
         this.tolstmShowDetils.Text = "Show Detils";
         this.tolstmShowDetils.Click += new System.EventHandler(this.tolstmShowDetils_Click);
         // 
         // tolstmSendEmail
         // 
         this.tolstmSendEmail.Name = "tolstmSendEmail";
         this.tolstmSendEmail.Size = new System.Drawing.Size(135, 22);
         this.tolstmSendEmail.Text = "Send Email";
         // 
         // tolstmEdit
         // 
         this.tolstmEdit.Name = "tolstmEdit";
         this.tolstmEdit.Size = new System.Drawing.Size(135, 22);
         this.tolstmEdit.Text = "Edit";
         this.tolstmEdit.Click += new System.EventHandler(this.tolstmEdit_Click);
         // 
         // tolstmDelete
         // 
         this.tolstmDelete.Name = "tolstmDelete";
         this.tolstmDelete.Size = new System.Drawing.Size(135, 22);
         this.tolstmDelete.Text = "Delete";
         this.tolstmDelete.Click += new System.EventHandler(this.tolstmDelete_Click);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Bold);
         this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
         this.label1.Location = new System.Drawing.Point(68, 63);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(151, 22);
         this.label1.TabIndex = 16;
         this.label1.Text = "Mange People";
         // 
         // pictureBox1
         // 
         this.pictureBox1.Image = global::DVLD.Properties.Resources.stand_out_1oag_bg;
         this.pictureBox1.Location = new System.Drawing.Point(366, 4);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(393, 140);
         this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.pictureBox1.TabIndex = 17;
         this.pictureBox1.TabStop = false;
         // 
         // frmPeople
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.AutoSize = true;
         this.BackColor = System.Drawing.Color.DarkGray;
         this.ClientSize = new System.Drawing.Size(1127, 554);
         this.Controls.Add(this.panel2);
         this.Controls.Add(this.panel1);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.pictureBox1);
         this.Controls.Add(this.dgvPeople);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Name = "frmPeople";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Mange People";
         this.Load += new System.EventHandler(this.frmPeople_Load);
         this.panel1.ResumeLayout(false);
         this.panel1.PerformLayout();
         this.panel2.ResumeLayout(false);
         this.panel2.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).EndInit();
         this.cmstMangePeople.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button btnCloseLogin;
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.DataGridView dgvPeople;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.ComboBox cbFilter;
      private System.Windows.Forms.Button btnAddPreson;
      private System.Windows.Forms.TextBox txtFilterValue;
      private System.Windows.Forms.Panel panel2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label lblRecordsNum;
      private System.Windows.Forms.ContextMenuStrip cmstMangePeople;
      private System.Windows.Forms.ToolStripMenuItem tolstmShowDetils;
      private System.Windows.Forms.ToolStripMenuItem tolstmSendEmail;
      private System.Windows.Forms.ToolStripMenuItem tolstmEdit;
      private System.Windows.Forms.ToolStripMenuItem tolstmDelete;
   }
}