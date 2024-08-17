namespace DVLD.Users.Controls
{
   partial class ctrlChangePassword
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
         this.components = new System.ComponentModel.Container();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.txtbConfirmPassword = new System.Windows.Forms.TextBox();
         this.txtbNewPassword = new System.Windows.Forms.TextBox();
         this.txtbCurrentPassword = new System.Windows.Forms.TextBox();
         this.label3 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
         this.ctrlUserInfo1 = new DVLD.Users.Controls.ctrlUserInfo();
         this.groupBox1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
         this.SuspendLayout();
         // 
         // groupBox1
         // 
         this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
         this.groupBox1.Controls.Add(this.pictureBox1);
         this.groupBox1.Controls.Add(this.txtbConfirmPassword);
         this.groupBox1.Controls.Add(this.txtbNewPassword);
         this.groupBox1.Controls.Add(this.txtbCurrentPassword);
         this.groupBox1.Controls.Add(this.label3);
         this.groupBox1.Controls.Add(this.label1);
         this.groupBox1.Controls.Add(this.label2);
         this.groupBox1.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.groupBox1.ForeColor = System.Drawing.Color.RoyalBlue;
         this.groupBox1.Location = new System.Drawing.Point(0, 360);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(987, 176);
         this.groupBox1.TabIndex = 1;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Change Password";
         // 
         // pictureBox1
         // 
         this.pictureBox1.Image = global::DVLD.Properties.Resources.password;
         this.pictureBox1.Location = new System.Drawing.Point(608, 15);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(205, 151);
         this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.pictureBox1.TabIndex = 30;
         this.pictureBox1.TabStop = false;
         // 
         // txtbConfirmPassword
         // 
         this.txtbConfirmPassword.Location = new System.Drawing.Point(181, 126);
         this.txtbConfirmPassword.Name = "txtbConfirmPassword";
         this.txtbConfirmPassword.PasswordChar = '*';
         this.txtbConfirmPassword.Size = new System.Drawing.Size(181, 25);
         this.txtbConfirmPassword.TabIndex = 29;
         this.txtbConfirmPassword.UseSystemPasswordChar = true;
         this.txtbConfirmPassword.Visible = false;
         this.txtbConfirmPassword.TextChanged += new System.EventHandler(this.txtbConfirmPassword_TextChanged);
         // 
         // txtbNewPassword
         // 
         this.txtbNewPassword.Location = new System.Drawing.Point(181, 78);
         this.txtbNewPassword.Name = "txtbNewPassword";
         this.txtbNewPassword.PasswordChar = '*';
         this.txtbNewPassword.Size = new System.Drawing.Size(181, 25);
         this.txtbNewPassword.TabIndex = 27;
         this.txtbNewPassword.UseSystemPasswordChar = true;
         this.txtbNewPassword.Visible = false;
         // 
         // txtbCurrentPassword
         // 
         this.txtbCurrentPassword.Location = new System.Drawing.Point(181, 30);
         this.txtbCurrentPassword.Name = "txtbCurrentPassword";
         this.txtbCurrentPassword.PasswordChar = '*';
         this.txtbCurrentPassword.Size = new System.Drawing.Size(181, 25);
         this.txtbCurrentPassword.TabIndex = 25;
         this.txtbCurrentPassword.UseSystemPasswordChar = true;
         this.txtbCurrentPassword.Visible = false;
         this.txtbCurrentPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtbCurrentPassword_Validating);
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.label3.Location = new System.Drawing.Point(20, 126);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(150, 21);
         this.label3.TabIndex = 28;
         this.label3.Text = "Confirm Password";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.label1.Location = new System.Drawing.Point(20, 78);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(121, 21);
         this.label1.TabIndex = 26;
         this.label1.Text = "New Password";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.label2.Location = new System.Drawing.Point(20, 30);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(146, 21);
         this.label2.TabIndex = 24;
         this.label2.Text = "Current Password";
         // 
         // errorProvider1
         // 
         this.errorProvider1.ContainerControl = this;
         // 
         // ctrlUserInfo1
         // 
         this.ctrlUserInfo1.BackColor = System.Drawing.Color.Gainsboro;
         this.ctrlUserInfo1.Dock = System.Windows.Forms.DockStyle.Top;
         this.ctrlUserInfo1.Location = new System.Drawing.Point(0, 0);
         this.ctrlUserInfo1.Name = "ctrlUserInfo1";
         this.ctrlUserInfo1.Size = new System.Drawing.Size(949, 472);
         this.ctrlUserInfo1.TabIndex = 0;
         // 
         // ctrlChangePassword
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.groupBox1);
         this.Controls.Add(this.ctrlUserInfo1);
         this.Name = "ctrlChangePassword";
         this.Size = new System.Drawing.Size(949, 533);
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private ctrlUserInfo ctrlUserInfo1;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.TextBox txtbCurrentPassword;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox txtbNewPassword;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox txtbConfirmPassword;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.ErrorProvider errorProvider1;
      private System.Windows.Forms.PictureBox pictureBox1;
   }
}
