﻿namespace DVLD.Users
{
   partial class frmUserInfo
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
         this.ctrlUserInfo1 = new DVLD.Users.Controls.ctrlUserInfo();
         this.SuspendLayout();
         // 
         // ctrlUserInfo1
         // 
         this.ctrlUserInfo1.BackColor = System.Drawing.Color.Gainsboro;
         this.ctrlUserInfo1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.ctrlUserInfo1.Location = new System.Drawing.Point(0, 0);
         this.ctrlUserInfo1.Name = "ctrlUserInfo1";
         this.ctrlUserInfo1.Size = new System.Drawing.Size(977, 461);
         this.ctrlUserInfo1.TabIndex = 0;
         // 
         // frmUserInfo
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(977, 461);
         this.Controls.Add(this.ctrlUserInfo1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
         this.Name = "frmUserInfo";
         this.Text = "frmUserInfo";
         this.Load += new System.EventHandler(this.frmUserInfo_Load);
         this.ResumeLayout(false);

      }

      #endregion

      private Controls.ctrlUserInfo ctrlUserInfo1;
   }
}