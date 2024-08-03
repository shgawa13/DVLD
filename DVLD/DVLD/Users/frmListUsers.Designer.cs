namespace DVLD.Users
{
   partial class frmListUsers
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
         this.btnAddUser = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
         this.lblRecordNumber = new System.Windows.Forms.Label();
         this.dgvUsers = new System.Windows.Forms.DataGridView();
         this.ctxMangeUsers = new System.Windows.Forms.ContextMenuStrip(this.components);
         this.tolsShowDetails = new System.Windows.Forms.ToolStripMenuItem();
         this.tolsAddNewUser = new System.Windows.Forms.ToolStripMenuItem();
         this.tolsEdit = new System.Windows.Forms.ToolStripMenuItem();
         this.tolsDelete = new System.Windows.Forms.ToolStripMenuItem();
         this.tolsChangePassword = new System.Windows.Forms.ToolStripMenuItem();
         this.tolsSendEamil = new System.Windows.Forms.ToolStripMenuItem();
         this.tolsPhoneCall = new System.Windows.Forms.ToolStripMenuItem();
         this.label4 = new System.Windows.Forms.Label();
         this.lblRecordsNumber = new System.Windows.Forms.Label();
         this.txtFilterValue = new System.Windows.Forms.TextBox();
         this.cbFilterBy = new System.Windows.Forms.ComboBox();
         this.label2 = new System.Windows.Forms.Label();
         this.cbIsActive = new System.Windows.Forms.ComboBox();
         this.panel1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.flowLayoutPanel1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
         this.ctxMangeUsers.SuspendLayout();
         this.SuspendLayout();
         // 
         // panel1
         // 
         this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
         this.panel1.Controls.Add(this.btnAddUser);
         this.panel1.Controls.Add(this.label1);
         this.panel1.Controls.Add(this.pictureBox1);
         this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
         this.panel1.Location = new System.Drawing.Point(0, 0);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(858, 154);
         this.panel1.TabIndex = 0;
         // 
         // btnAddUser
         // 
         this.btnAddUser.BackColor = System.Drawing.Color.WhiteSmoke;
         this.btnAddUser.FlatAppearance.BorderSize = 0;
         this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnAddUser.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnAddUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(37)))), ((int)(((byte)(73)))));
         this.btnAddUser.Location = new System.Drawing.Point(727, 107);
         this.btnAddUser.Name = "btnAddUser";
         this.btnAddUser.Size = new System.Drawing.Size(118, 34);
         this.btnAddUser.TabIndex = 17;
         this.btnAddUser.Text = "Add User";
         this.btnAddUser.UseVisualStyleBackColor = false;
         this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.label1.Location = new System.Drawing.Point(72, 64);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(139, 26);
         this.label1.TabIndex = 0;
         this.label1.Text = "Mange Users";
         // 
         // pictureBox1
         // 
         this.pictureBox1.Image = global::DVLD.Properties.Resources.list_Users1;
         this.pictureBox1.Location = new System.Drawing.Point(301, 0);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(279, 159);
         this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.pictureBox1.TabIndex = 0;
         this.pictureBox1.TabStop = false;
         // 
         // flowLayoutPanel1
         // 
         this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(33)))), ((int)(((byte)(67)))));
         this.flowLayoutPanel1.Controls.Add(this.lblRecordNumber);
         this.flowLayoutPanel1.Controls.Add(this.dgvUsers);
         this.flowLayoutPanel1.Controls.Add(this.label4);
         this.flowLayoutPanel1.Controls.Add(this.lblRecordsNumber);
         this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 200);
         this.flowLayoutPanel1.Name = "flowLayoutPanel1";
         this.flowLayoutPanel1.Size = new System.Drawing.Size(858, 282);
         this.flowLayoutPanel1.TabIndex = 1;
         // 
         // lblRecordNumber
         // 
         this.lblRecordNumber.AutoSize = true;
         this.lblRecordNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
         this.lblRecordNumber.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.lblRecordNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblRecordNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
         this.lblRecordNumber.Location = new System.Drawing.Point(3, 0);
         this.lblRecordNumber.Name = "lblRecordNumber";
         this.lblRecordNumber.Size = new System.Drawing.Size(0, 20);
         this.lblRecordNumber.TabIndex = 36;
         // 
         // dgvUsers
         // 
         this.dgvUsers.AllowUserToAddRows = false;
         this.dgvUsers.AllowUserToDeleteRows = false;
         this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
         this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dgvUsers.ContextMenuStrip = this.ctxMangeUsers;
         this.dgvUsers.Location = new System.Drawing.Point(3, 23);
         this.dgvUsers.Name = "dgvUsers";
         this.dgvUsers.ReadOnly = true;
         this.dgvUsers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.dgvUsers.Size = new System.Drawing.Size(855, 226);
         this.dgvUsers.TabIndex = 38;
         // 
         // ctxMangeUsers
         // 
         this.ctxMangeUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tolsShowDetails,
            this.tolsAddNewUser,
            this.tolsEdit,
            this.tolsDelete,
            this.tolsChangePassword,
            this.tolsSendEamil,
            this.tolsPhoneCall});
         this.ctxMangeUsers.Name = "ctxMangeUsers";
         this.ctxMangeUsers.Size = new System.Drawing.Size(169, 158);
         this.ctxMangeUsers.Text = "Mange Users";
         // 
         // tolsShowDetails
         // 
         this.tolsShowDetails.Name = "tolsShowDetails";
         this.tolsShowDetails.Size = new System.Drawing.Size(168, 22);
         this.tolsShowDetails.Text = "Show Details";
         this.tolsShowDetails.Click += new System.EventHandler(this.tolsShowDetails_Click);
         // 
         // tolsAddNewUser
         // 
         this.tolsAddNewUser.Name = "tolsAddNewUser";
         this.tolsAddNewUser.Size = new System.Drawing.Size(168, 22);
         this.tolsAddNewUser.Text = "Add New User";
         this.tolsAddNewUser.Click += new System.EventHandler(this.tolsAddNewUser_Click);
         // 
         // tolsEdit
         // 
         this.tolsEdit.Name = "tolsEdit";
         this.tolsEdit.Size = new System.Drawing.Size(168, 22);
         this.tolsEdit.Text = "Edit";
         this.tolsEdit.Click += new System.EventHandler(this.tolsEdit_Click);
         // 
         // tolsDelete
         // 
         this.tolsDelete.Name = "tolsDelete";
         this.tolsDelete.Size = new System.Drawing.Size(168, 22);
         this.tolsDelete.Text = "Delete";
         this.tolsDelete.Click += new System.EventHandler(this.tolsDelete_Click);
         // 
         // tolsChangePassword
         // 
         this.tolsChangePassword.Name = "tolsChangePassword";
         this.tolsChangePassword.Size = new System.Drawing.Size(168, 22);
         this.tolsChangePassword.Text = "Change Password";
         this.tolsChangePassword.Click += new System.EventHandler(this.tolsChangePassword_Click);
         // 
         // tolsSendEamil
         // 
         this.tolsSendEamil.Name = "tolsSendEamil";
         this.tolsSendEamil.Size = new System.Drawing.Size(168, 22);
         this.tolsSendEamil.Text = "Send eamil";
         // 
         // tolsPhoneCall
         // 
         this.tolsPhoneCall.AutoSize = false;
         this.tolsPhoneCall.Name = "tolsPhoneCall";
         this.tolsPhoneCall.Size = new System.Drawing.Size(180, 22);
         this.tolsPhoneCall.Text = "Phone call";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.label4.Location = new System.Drawing.Point(3, 252);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(97, 24);
         this.label4.TabIndex = 57;
         this.label4.Text = "# Record:";
         // 
         // lblRecordsNumber
         // 
         this.lblRecordsNumber.AutoSize = true;
         this.lblRecordsNumber.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblRecordsNumber.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.lblRecordsNumber.Location = new System.Drawing.Point(106, 252);
         this.lblRecordsNumber.Name = "lblRecordsNumber";
         this.lblRecordsNumber.Size = new System.Drawing.Size(43, 24);
         this.lblRecordsNumber.TabIndex = 58;
         this.lblRecordsNumber.Text = "???";
         // 
         // txtFilterValue
         // 
         this.txtFilterValue.Location = new System.Drawing.Point(300, 167);
         this.txtFilterValue.Name = "txtFilterValue";
         this.txtFilterValue.Size = new System.Drawing.Size(170, 20);
         this.txtFilterValue.TabIndex = 23;
         this.txtFilterValue.Visible = false;
         this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
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
         this.cbFilterBy.Location = new System.Drawing.Point(106, 167);
         this.cbFilterBy.Name = "cbFilterBy";
         this.cbFilterBy.Size = new System.Drawing.Size(170, 21);
         this.cbFilterBy.TabIndex = 22;
         this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.label2.Location = new System.Drawing.Point(12, 165);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(75, 24);
         this.label2.TabIndex = 21;
         this.label2.Text = "Find by";
         // 
         // cbIsActive
         // 
         this.cbIsActive.BackColor = System.Drawing.SystemColors.Window;
         this.cbIsActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cbIsActive.ImeMode = System.Windows.Forms.ImeMode.NoControl;
         this.cbIsActive.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
         this.cbIsActive.Location = new System.Drawing.Point(300, 167);
         this.cbIsActive.Name = "cbIsActive";
         this.cbIsActive.Size = new System.Drawing.Size(90, 21);
         this.cbIsActive.TabIndex = 24;
         this.cbIsActive.Visible = false;
         this.cbIsActive.SelectedIndexChanged += new System.EventHandler(this.cbIsActive_SelectedIndexChanged);
         // 
         // frmListUsers
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.AutoSize = true;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(37)))), ((int)(((byte)(73)))));
         this.ClientSize = new System.Drawing.Size(858, 482);
         this.Controls.Add(this.cbIsActive);
         this.Controls.Add(this.txtFilterValue);
         this.Controls.Add(this.cbFilterBy);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.flowLayoutPanel1);
         this.Controls.Add(this.panel1);
         this.Cursor = System.Windows.Forms.Cursors.Default;
         this.ForeColor = System.Drawing.SystemColors.WindowText;
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
         this.Name = "frmListUsers";
         this.Text = "frmListUsers";
         this.Load += new System.EventHandler(this.frmListUsers_Load_1);
         this.panel1.ResumeLayout(false);
         this.panel1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.flowLayoutPanel1.ResumeLayout(false);
         this.flowLayoutPanel1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
         this.ctxMangeUsers.ResumeLayout(false);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Button btnAddUser;
      private System.Windows.Forms.Label lblRecordNumber;
      private System.Windows.Forms.TextBox txtFilterValue;
      private System.Windows.Forms.ComboBox cbFilterBy;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.DataGridView dgvUsers;
      private System.Windows.Forms.ComboBox cbIsActive;
      private System.Windows.Forms.ContextMenuStrip ctxMangeUsers;
      private System.Windows.Forms.ToolStripMenuItem tolsShowDetails;
      private System.Windows.Forms.ToolStripMenuItem tolsAddNewUser;
      private System.Windows.Forms.ToolStripMenuItem tolsEdit;
      private System.Windows.Forms.ToolStripMenuItem tolsDelete;
      private System.Windows.Forms.ToolStripMenuItem tolsChangePassword;
      private System.Windows.Forms.ToolStripMenuItem tolsSendEamil;
      private System.Windows.Forms.ToolStripMenuItem tolsPhoneCall;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label lblRecordsNumber;
   }
}