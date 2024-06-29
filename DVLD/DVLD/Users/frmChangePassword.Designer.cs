namespace DVLD.Users
{
   partial class frmChangePassword
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
         this.btnSavePassword = new System.Windows.Forms.Button();
         this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
         this.ctrlChangePassword1 = new DVLD.Users.Controls.ctrlChangePassword();
         ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
         this.SuspendLayout();
         // 
         // btnSavePassword
         // 
         this.btnSavePassword.BackColor = System.Drawing.Color.WhiteSmoke;
         this.btnSavePassword.FlatAppearance.BorderSize = 0;
         this.btnSavePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnSavePassword.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnSavePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(37)))), ((int)(((byte)(73)))));
         this.btnSavePassword.Location = new System.Drawing.Point(441, 547);
         this.btnSavePassword.Name = "btnSavePassword";
         this.btnSavePassword.Size = new System.Drawing.Size(118, 34);
         this.btnSavePassword.TabIndex = 33;
         this.btnSavePassword.Text = "Save";
         this.btnSavePassword.UseVisualStyleBackColor = false;
         this.btnSavePassword.Click += new System.EventHandler(this.btnSavePassword_Click);
         // 
         // errorProvider1
         // 
         this.errorProvider1.ContainerControl = this;
         // 
         // ctrlChangePassword1
         // 
         this.ctrlChangePassword1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.ctrlChangePassword1.Location = new System.Drawing.Point(0, 0);
         this.ctrlChangePassword1.Name = "ctrlChangePassword1";
         this.ctrlChangePassword1.Size = new System.Drawing.Size(984, 652);
         this.ctrlChangePassword1.TabIndex = 0;
         // 
         // frmChangePassword
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(984, 652);
         this.Controls.Add(this.btnSavePassword);
         this.Controls.Add(this.ctrlChangePassword1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
         this.Name = "frmChangePassword";
         this.Text = "frmChangePassword";
         this.Load += new System.EventHandler(this.frmChangePassword_Load);
         ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private Controls.ctrlChangePassword ctrlChangePassword1;
      private System.Windows.Forms.Button btnSavePassword;
      private System.Windows.Forms.ErrorProvider errorProvider1;
   }
}