﻿namespace DVLD.Tests
{
   partial class frmScheduleTest
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
         this.ctrlSecheduleTest1 = new DVLD.Tests.controls.ctrlSecheduleTest();
         this.SuspendLayout();
         // 
         // ctrlSecheduleTest1
         // 
         this.ctrlSecheduleTest1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
         this.ctrlSecheduleTest1.Location = new System.Drawing.Point(1, -1);
         this.ctrlSecheduleTest1.Name = "ctrlSecheduleTest1";
         this.ctrlSecheduleTest1.Size = new System.Drawing.Size(454, 551);
         this.ctrlSecheduleTest1.TabIndex = 0;
         this.ctrlSecheduleTest1.TestTypeID = Business.clsTestType.enTypeTest.WrittenTest;
         // 
         // frmScheduleTest
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.Gainsboro;
         this.ClientSize = new System.Drawing.Size(455, 550);
         this.Controls.Add(this.ctrlSecheduleTest1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
         this.Name = "frmScheduleTest";
         this.Text = "Schedule Test";
         this.Load += new System.EventHandler(this.frmScheduleTest_Load);
         this.ResumeLayout(false);

      }

      #endregion

      private controls.ctrlSecheduleTest ctrlSecheduleTest1;
   }
}