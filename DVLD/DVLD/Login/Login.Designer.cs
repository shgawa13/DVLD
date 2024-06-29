namespace DVLD
{
    partial class frmLogin
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
         this.panel2 = new System.Windows.Forms.Panel();
         this.panel3 = new System.Windows.Forms.Panel();
         this.label1 = new System.Windows.Forms.Label();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.listBox1 = new System.Windows.Forms.ListBox();
         this.Login = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.txtboxUserName = new System.Windows.Forms.TextBox();
         this.txtboxPassword = new System.Windows.Forms.TextBox();
         this.label3 = new System.Windows.Forms.Label();
         this.btnLogin = new System.Windows.Forms.Button();
         this.cboxRemember = new System.Windows.Forms.CheckBox();
         this.btnCloseLogin = new System.Windows.Forms.Button();
         this.panel1.SuspendLayout();
         this.panel2.SuspendLayout();
         this.panel3.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.SuspendLayout();
         // 
         // panel1
         // 
         this.panel1.Controls.Add(this.panel2);
         this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
         this.panel1.Location = new System.Drawing.Point(0, 0);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(397, 498);
         this.panel1.TabIndex = 0;
         // 
         // panel2
         // 
         this.panel2.Controls.Add(this.panel3);
         this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
         this.panel2.Location = new System.Drawing.Point(0, 0);
         this.panel2.Name = "panel2";
         this.panel2.Size = new System.Drawing.Size(397, 498);
         this.panel2.TabIndex = 1;
         // 
         // panel3
         // 
         this.panel3.BackColor = System.Drawing.Color.Black;
         this.panel3.Controls.Add(this.label1);
         this.panel3.Controls.Add(this.pictureBox1);
         this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
         this.panel3.Location = new System.Drawing.Point(0, 0);
         this.panel3.Name = "panel3";
         this.panel3.Size = new System.Drawing.Size(397, 498);
         this.panel3.TabIndex = 1;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.BackColor = System.Drawing.Color.Transparent;
         this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.label1.Location = new System.Drawing.Point(97, 43);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(207, 148);
         this.label1.TabIndex = 1;
         this.label1.Text = "DVLD \r\nMange Users\r\nLicenses\r\nTests";
         this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // pictureBox1
         // 
         this.pictureBox1.Image = global::DVLD.Properties.Resources.preview_bg;
         this.pictureBox1.Location = new System.Drawing.Point(3, 235);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(391, 258);
         this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.pictureBox1.TabIndex = 0;
         this.pictureBox1.TabStop = false;
         // 
         // listBox1
         // 
         this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(33)))), ((int)(((byte)(67)))));
         this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.listBox1.FormattingEnabled = true;
         this.listBox1.ItemHeight = 18;
         this.listBox1.Location = new System.Drawing.Point(397, 0);
         this.listBox1.Name = "listBox1";
         this.listBox1.Size = new System.Drawing.Size(484, 498);
         this.listBox1.TabIndex = 1;
         // 
         // Login
         // 
         this.Login.AutoSize = true;
         this.Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(33)))), ((int)(((byte)(67)))));
         this.Login.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Login.ForeColor = System.Drawing.Color.Gainsboro;
         this.Login.Location = new System.Drawing.Point(598, 94);
         this.Login.Name = "Login";
         this.Login.Size = new System.Drawing.Size(86, 29);
         this.Login.TabIndex = 2;
         this.Login.Text = "Login";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(33)))), ((int)(((byte)(67)))));
         this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.ForeColor = System.Drawing.Color.Gainsboro;
         this.label2.Location = new System.Drawing.Point(419, 195);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(94, 21);
         this.label2.TabIndex = 3;
         this.label2.Text = "UserName";
         // 
         // txtboxUserName
         // 
         this.txtboxUserName.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold);
         this.txtboxUserName.Location = new System.Drawing.Point(520, 192);
         this.txtboxUserName.Name = "txtboxUserName";
         this.txtboxUserName.Size = new System.Drawing.Size(259, 26);
         this.txtboxUserName.TabIndex = 0;
         // 
         // txtboxPassword
         // 
         this.txtboxPassword.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold);
         this.txtboxPassword.Location = new System.Drawing.Point(520, 249);
         this.txtboxPassword.Name = "txtboxPassword";
         this.txtboxPassword.PasswordChar = '*';
         this.txtboxPassword.Size = new System.Drawing.Size(259, 26);
         this.txtboxPassword.TabIndex = 1;
         this.txtboxPassword.UseSystemPasswordChar = true;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(33)))), ((int)(((byte)(67)))));
         this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.ForeColor = System.Drawing.Color.Gainsboro;
         this.label3.Location = new System.Drawing.Point(422, 252);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(89, 21);
         this.label3.TabIndex = 6;
         this.label3.Text = "Password";
         // 
         // btnLogin
         // 
         this.btnLogin.BackColor = System.Drawing.Color.Silver;
         this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
         this.btnLogin.FlatAppearance.BorderSize = 0;
         this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnLogin.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(36)))));
         this.btnLogin.Location = new System.Drawing.Point(520, 340);
         this.btnLogin.Name = "btnLogin";
         this.btnLogin.Size = new System.Drawing.Size(259, 53);
         this.btnLogin.TabIndex = 3;
         this.btnLogin.Text = "Login";
         this.btnLogin.UseVisualStyleBackColor = false;
         this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
         // 
         // cboxRemember
         // 
         this.cboxRemember.AutoSize = true;
         this.cboxRemember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(33)))), ((int)(((byte)(67)))));
         this.cboxRemember.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.cboxRemember.ForeColor = System.Drawing.Color.LightGray;
         this.cboxRemember.Location = new System.Drawing.Point(648, 292);
         this.cboxRemember.Name = "cboxRemember";
         this.cboxRemember.Size = new System.Drawing.Size(142, 25);
         this.cboxRemember.TabIndex = 2;
         this.cboxRemember.Text = "Remember me";
         this.cboxRemember.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         this.cboxRemember.UseVisualStyleBackColor = false;
         // 
         // btnCloseLogin
         // 
         this.btnCloseLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(33)))), ((int)(((byte)(67)))));
         this.btnCloseLogin.FlatAppearance.BorderSize = 0;
         this.btnCloseLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnCloseLogin.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnCloseLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(83)))), ((int)(((byte)(100)))));
         this.btnCloseLogin.Location = new System.Drawing.Point(840, 0);
         this.btnCloseLogin.Name = "btnCloseLogin";
         this.btnCloseLogin.Size = new System.Drawing.Size(41, 30);
         this.btnCloseLogin.TabIndex = 11;
         this.btnCloseLogin.Text = "X";
         this.btnCloseLogin.UseVisualStyleBackColor = false;
         this.btnCloseLogin.Click += new System.EventHandler(this.btnCloseLogin_Click);
         // 
         // frmLogin
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.Black;
         this.ClientSize = new System.Drawing.Size(881, 498);
         this.ControlBox = false;
         this.Controls.Add(this.btnCloseLogin);
         this.Controls.Add(this.cboxRemember);
         this.Controls.Add(this.btnLogin);
         this.Controls.Add(this.txtboxPassword);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.txtboxUserName);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.Login);
         this.Controls.Add(this.listBox1);
         this.Controls.Add(this.panel1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Name = "frmLogin";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Login";
         this.panel1.ResumeLayout(false);
         this.panel2.ResumeLayout(false);
         this.panel3.ResumeLayout(false);
         this.panel3.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

        }

      #endregion

      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.Panel panel2;
      private System.Windows.Forms.Panel panel3;
      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.ListBox listBox1;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label Login;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox txtboxUserName;
      private System.Windows.Forms.TextBox txtboxPassword;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Button btnLogin;
      private System.Windows.Forms.CheckBox cboxRemember;
      private System.Windows.Forms.Button btnCloseLogin;
   }
}

