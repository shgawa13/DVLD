namespace DVLD.Users
{
   partial class frmAddUpdateUser
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
         this.tcUserInfo = new System.Windows.Forms.TabControl();
         this.tbpPersonInfo = new System.Windows.Forms.TabPage();
         this.btnNext = new System.Windows.Forms.Button();
         this.ctrlPersonInfoWithFilter1 = new DVLD.People.Controls.ctrlPersonInfoWithFilter();
         this.tbpLoginInfo = new System.Windows.Forms.TabPage();
         this.panel1 = new System.Windows.Forms.Panel();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.checkbIsActive = new System.Windows.Forms.CheckBox();
         this.lblUserID = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.label7 = new System.Windows.Forms.Label();
         this.txtbConfirmPassword = new System.Windows.Forms.TextBox();
         this.txtbPassword = new System.Windows.Forms.TextBox();
         this.txtbUserName = new System.Windows.Forms.TextBox();
         this.lblTitle = new System.Windows.Forms.Label();
         this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
         this.btnCloseLogin = new System.Windows.Forms.Button();
         this.btnSave = new System.Windows.Forms.Button();
         this.tcUserInfo.SuspendLayout();
         this.tbpPersonInfo.SuspendLayout();
         this.tbpLoginInfo.SuspendLayout();
         this.panel1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
         this.SuspendLayout();
         // 
         // tcUserInfo
         // 
         this.tcUserInfo.Controls.Add(this.tbpPersonInfo);
         this.tcUserInfo.Controls.Add(this.tbpLoginInfo);
         this.tcUserInfo.Location = new System.Drawing.Point(-1, 32);
         this.tcUserInfo.Multiline = true;
         this.tcUserInfo.Name = "tcUserInfo";
         this.tcUserInfo.SelectedIndex = 0;
         this.tcUserInfo.Size = new System.Drawing.Size(975, 538);
         this.tcUserInfo.TabIndex = 0;
         // 
         // tbpPersonInfo
         // 
         this.tbpPersonInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
         this.tbpPersonInfo.Controls.Add(this.btnNext);
         this.tbpPersonInfo.Controls.Add(this.ctrlPersonInfoWithFilter1);
         this.tbpPersonInfo.Location = new System.Drawing.Point(4, 22);
         this.tbpPersonInfo.Name = "tbpPersonInfo";
         this.tbpPersonInfo.Padding = new System.Windows.Forms.Padding(3);
         this.tbpPersonInfo.Size = new System.Drawing.Size(967, 512);
         this.tbpPersonInfo.TabIndex = 0;
         this.tbpPersonInfo.Text = "Person Info";
         // 
         // btnNext
         // 
         this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(208)))), ((int)(((byte)(214)))));
         this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
         this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnNext.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold);
         this.btnNext.ForeColor = System.Drawing.Color.Black;
         this.btnNext.Location = new System.Drawing.Point(775, 476);
         this.btnNext.Name = "btnNext";
         this.btnNext.Size = new System.Drawing.Size(186, 31);
         this.btnNext.TabIndex = 1;
         this.btnNext.Text = "Next";
         this.btnNext.UseVisualStyleBackColor = false;
         this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
         // 
         // ctrlPersonInfoWithFilter1
         // 
         this.ctrlPersonInfoWithFilter1.BackColor = System.Drawing.Color.Gainsboro;
         this.ctrlPersonInfoWithFilter1.FilterEnable = true;
         this.ctrlPersonInfoWithFilter1.Location = new System.Drawing.Point(0, 0);
         this.ctrlPersonInfoWithFilter1.Name = "ctrlPersonInfoWithFilter1";
         this.ctrlPersonInfoWithFilter1.ShowAddPerson = true;
         this.ctrlPersonInfoWithFilter1.Size = new System.Drawing.Size(968, 472);
         this.ctrlPersonInfoWithFilter1.TabIndex = 0;
         // 
         // tbpLoginInfo
         // 
         this.tbpLoginInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
         this.tbpLoginInfo.Controls.Add(this.panel1);
         this.tbpLoginInfo.Controls.Add(this.checkbIsActive);
         this.tbpLoginInfo.Controls.Add(this.lblUserID);
         this.tbpLoginInfo.Controls.Add(this.label3);
         this.tbpLoginInfo.Controls.Add(this.label2);
         this.tbpLoginInfo.Controls.Add(this.label1);
         this.tbpLoginInfo.Controls.Add(this.label7);
         this.tbpLoginInfo.Controls.Add(this.txtbConfirmPassword);
         this.tbpLoginInfo.Controls.Add(this.txtbPassword);
         this.tbpLoginInfo.Controls.Add(this.txtbUserName);
         this.tbpLoginInfo.Location = new System.Drawing.Point(4, 22);
         this.tbpLoginInfo.Name = "tbpLoginInfo";
         this.tbpLoginInfo.Padding = new System.Windows.Forms.Padding(3);
         this.tbpLoginInfo.Size = new System.Drawing.Size(967, 512);
         this.tbpLoginInfo.TabIndex = 1;
         this.tbpLoginInfo.Text = "Login Info";
         // 
         // panel1
         // 
         this.panel1.Controls.Add(this.pictureBox1);
         this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
         this.panel1.Location = new System.Drawing.Point(514, 3);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(450, 506);
         this.panel1.TabIndex = 47;
         // 
         // pictureBox1
         // 
         this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
         this.pictureBox1.Image = global::DVLD.Properties.Resources.addUserLogo;
         this.pictureBox1.Location = new System.Drawing.Point(-40, 0);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(490, 506);
         this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.pictureBox1.TabIndex = 0;
         this.pictureBox1.TabStop = false;
         // 
         // checkbIsActive
         // 
         this.checkbIsActive.AutoSize = true;
         this.checkbIsActive.Checked = true;
         this.checkbIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
         this.checkbIsActive.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.checkbIsActive.ForeColor = System.Drawing.Color.White;
         this.checkbIsActive.Location = new System.Drawing.Point(336, 319);
         this.checkbIsActive.Name = "checkbIsActive";
         this.checkbIsActive.Size = new System.Drawing.Size(92, 24);
         this.checkbIsActive.TabIndex = 46;
         this.checkbIsActive.Text = "Is Active";
         this.checkbIsActive.UseVisualStyleBackColor = true;
         // 
         // lblUserID
         // 
         this.lblUserID.AutoSize = true;
         this.lblUserID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
         this.lblUserID.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblUserID.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.lblUserID.Location = new System.Drawing.Point(245, 127);
         this.lblUserID.Name = "lblUserID";
         this.lblUserID.Size = new System.Drawing.Size(37, 21);
         this.lblUserID.TabIndex = 45;
         this.lblUserID.Text = "???";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
         this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
         this.label3.Location = new System.Drawing.Point(78, 279);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(150, 21);
         this.label3.TabIndex = 44;
         this.label3.Text = "Confirm Password";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
         this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
         this.label2.Location = new System.Drawing.Point(144, 228);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(84, 21);
         this.label2.TabIndex = 43;
         this.label2.Text = "Password";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
         this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
         this.label1.Location = new System.Drawing.Point(134, 176);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(94, 21);
         this.label1.TabIndex = 42;
         this.label1.Text = "User Name";
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
         this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
         this.label7.Location = new System.Drawing.Point(168, 127);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(60, 21);
         this.label7.TabIndex = 41;
         this.label7.Text = "UserID";
         // 
         // txtbConfirmPassword
         // 
         this.txtbConfirmPassword.Location = new System.Drawing.Point(249, 281);
         this.txtbConfirmPassword.Name = "txtbConfirmPassword";
         this.txtbConfirmPassword.Size = new System.Drawing.Size(179, 20);
         this.txtbConfirmPassword.TabIndex = 2;
         this.txtbConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtbConfirmPassword_Validating);
         // 
         // txtbPassword
         // 
         this.txtbPassword.Location = new System.Drawing.Point(249, 230);
         this.txtbPassword.Name = "txtbPassword";
         this.txtbPassword.Size = new System.Drawing.Size(179, 20);
         this.txtbPassword.TabIndex = 1;
         this.txtbPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtbPassword_Validating);
         // 
         // txtbUserName
         // 
         this.txtbUserName.Location = new System.Drawing.Point(249, 178);
         this.txtbUserName.Name = "txtbUserName";
         this.txtbUserName.Size = new System.Drawing.Size(179, 20);
         this.txtbUserName.TabIndex = 0;
         this.txtbUserName.Validating += new System.ComponentModel.CancelEventHandler(this.txtbUserName_Validating);
         // 
         // lblTitle
         // 
         this.lblTitle.AutoSize = true;
         this.lblTitle.BackColor = System.Drawing.Color.Transparent;
         this.lblTitle.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblTitle.ForeColor = System.Drawing.Color.Gainsboro;
         this.lblTitle.Location = new System.Drawing.Point(391, 13);
         this.lblTitle.Name = "lblTitle";
         this.lblTitle.Size = new System.Drawing.Size(169, 30);
         this.lblTitle.TabIndex = 47;
         this.lblTitle.Text = "Add New User";
         // 
         // errorProvider1
         // 
         this.errorProvider1.ContainerControl = this;
         // 
         // btnCloseLogin
         // 
         this.btnCloseLogin.BackColor = System.Drawing.Color.DimGray;
         this.btnCloseLogin.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
         this.btnCloseLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnCloseLogin.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnCloseLogin.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.btnCloseLogin.Location = new System.Drawing.Point(874, 588);
         this.btnCloseLogin.Name = "btnCloseLogin";
         this.btnCloseLogin.Size = new System.Drawing.Size(94, 30);
         this.btnCloseLogin.TabIndex = 17;
         this.btnCloseLogin.Text = "Close";
         this.btnCloseLogin.UseVisualStyleBackColor = false;
         this.btnCloseLogin.Click += new System.EventHandler(this.btnCloseLogin_Click);
         // 
         // btnSave
         // 
         this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(154)))), ((int)(((byte)(231)))));
         this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
         this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnSave.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnSave.ForeColor = System.Drawing.Color.White;
         this.btnSave.Location = new System.Drawing.Point(761, 588);
         this.btnSave.Name = "btnSave";
         this.btnSave.Size = new System.Drawing.Size(94, 30);
         this.btnSave.TabIndex = 16;
         this.btnSave.Text = "Save";
         this.btnSave.UseVisualStyleBackColor = false;
         this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
         // 
         // frmAddUpdateUser
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
         this.ClientSize = new System.Drawing.Size(973, 625);
         this.Controls.Add(this.lblTitle);
         this.Controls.Add(this.btnSave);
         this.Controls.Add(this.btnCloseLogin);
         this.Controls.Add(this.tcUserInfo);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
         this.Name = "frmAddUpdateUser";
         this.Text = "frmAddUser";
         this.Load += new System.EventHandler(this.frmAddUser_Load);
         this.tcUserInfo.ResumeLayout(false);
         this.tbpPersonInfo.ResumeLayout(false);
         this.tbpLoginInfo.ResumeLayout(false);
         this.tbpLoginInfo.PerformLayout();
         this.panel1.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TabControl tcUserInfo;
      private System.Windows.Forms.TabPage tbpPersonInfo;
      private System.Windows.Forms.TextBox txtbConfirmPassword;
      private System.Windows.Forms.TextBox txtbPassword;
      private System.Windows.Forms.TextBox txtbUserName;
      private System.Windows.Forms.Label lblUserID;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.CheckBox checkbIsActive;
      private System.Windows.Forms.Label lblTitle;
      private People.Controls.ctrlPersonInfoWithFilter ctrlPersonInfoWithFilter1;
      private System.Windows.Forms.Button btnNext;
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.ErrorProvider errorProvider1;
      private System.Windows.Forms.TabPage tbpLoginInfo;
      private System.Windows.Forms.Button btnSave;
      private System.Windows.Forms.Button btnCloseLogin;
   }
}