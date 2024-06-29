namespace DVLD.People
{
   partial class frmShowPersonInfo
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
         this.btnCloseLogin = new System.Windows.Forms.Button();
         this.ctrlPersonInfo1 = new DVLD.People.Controls.ctrlPersonInfo();
         this.SuspendLayout();
         // 
         // btnCloseLogin
         // 
         this.btnCloseLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
         this.btnCloseLogin.FlatAppearance.BorderSize = 0;
         this.btnCloseLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnCloseLogin.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnCloseLogin.ForeColor = System.Drawing.Color.Black;
         this.btnCloseLogin.Location = new System.Drawing.Point(835, 383);
         this.btnCloseLogin.Name = "btnCloseLogin";
         this.btnCloseLogin.Size = new System.Drawing.Size(118, 34);
         this.btnCloseLogin.TabIndex = 16;
         this.btnCloseLogin.Text = "Close";
         this.btnCloseLogin.UseVisualStyleBackColor = false;
         this.btnCloseLogin.Click += new System.EventHandler(this.btnCloseLogin_Click);
         // 
         // ctrlPersonInfo1
         // 
         this.ctrlPersonInfo1.BackColor = System.Drawing.Color.Gainsboro;
         this.ctrlPersonInfo1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.ctrlPersonInfo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(154)))), ((int)(((byte)(231)))));
         this.ctrlPersonInfo1.Location = new System.Drawing.Point(0, 0);
         this.ctrlPersonInfo1.Name = "ctrlPersonInfo1";
         this.ctrlPersonInfo1.Size = new System.Drawing.Size(965, 429);
         this.ctrlPersonInfo1.TabIndex = 0;
         // 
         // frmShowPersonInfo
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(965, 429);
         this.Controls.Add(this.btnCloseLogin);
         this.Controls.Add(this.ctrlPersonInfo1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Name = "frmShowPersonInfo";
         this.Text = "frmPersonInfo";
         this.ResumeLayout(false);

      }

      #endregion

      private Controls.ctrlPersonInfo ctrlPersonInfo1;
      private System.Windows.Forms.Button btnCloseLogin;
   }
}