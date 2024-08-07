namespace DVLD.Tests
{
   partial class frmTakeTest
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
         this.ctrlSecheduledTest1 = new DVLD.Tests.controls.ctrlSecheduledTest();
         this.btnSave = new System.Windows.Forms.Button();
         this.btnCancel = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.lblUserMessage = new System.Windows.Forms.Label();
         this.rbPass = new System.Windows.Forms.RadioButton();
         this.rbFail = new System.Windows.Forms.RadioButton();
         this.txtNotes = new System.Windows.Forms.TextBox();
         this.radioButton2 = new System.Windows.Forms.RadioButton();
         this.SuspendLayout();
         // 
         // ctrlSecheduledTest1
         // 
         this.ctrlSecheduledTest1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
         this.ctrlSecheduledTest1.Location = new System.Drawing.Point(-2, 0);
         this.ctrlSecheduledTest1.Name = "ctrlSecheduledTest1";
         this.ctrlSecheduledTest1.Size = new System.Drawing.Size(448, 458);
         this.ctrlSecheduledTest1.TabIndex = 0;
         // 
         // btnSave
         // 
         this.btnSave.BackColor = System.Drawing.Color.WhiteSmoke;
         this.btnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
         this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnSave.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(36)))));
         this.btnSave.Location = new System.Drawing.Point(250, 583);
         this.btnSave.Name = "btnSave";
         this.btnSave.Size = new System.Drawing.Size(95, 38);
         this.btnSave.TabIndex = 61;
         this.btnSave.Text = "Save";
         this.btnSave.UseVisualStyleBackColor = false;
         this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
         // 
         // btnCancel
         // 
         this.btnCancel.BackColor = System.Drawing.Color.WhiteSmoke;
         this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
         this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnCancel.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(36)))));
         this.btnCancel.Location = new System.Drawing.Point(351, 583);
         this.btnCancel.Name = "btnCancel";
         this.btnCancel.Size = new System.Drawing.Size(95, 38);
         this.btnCancel.TabIndex = 62;
         this.btnCancel.Text = "Close";
         this.btnCancel.UseVisualStyleBackColor = false;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold);
         this.label1.Location = new System.Drawing.Point(6, 465);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(64, 21);
         this.label1.TabIndex = 63;
         this.label1.Text = "Result:";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold);
         this.label2.Location = new System.Drawing.Point(9, 494);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(58, 21);
         this.label2.TabIndex = 64;
         this.label2.Text = "Notes:";
         // 
         // lblUserMessage
         // 
         this.lblUserMessage.AutoSize = true;
         this.lblUserMessage.BackColor = System.Drawing.Color.Transparent;
         this.lblUserMessage.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblUserMessage.ForeColor = System.Drawing.Color.Crimson;
         this.lblUserMessage.Location = new System.Drawing.Point(209, 464);
         this.lblUserMessage.Name = "lblUserMessage";
         this.lblUserMessage.Size = new System.Drawing.Size(193, 20);
         this.lblUserMessage.TabIndex = 65;
         this.lblUserMessage.Text = "Can\'t Change this Result";
         // 
         // rbPass
         // 
         this.rbPass.AutoSize = true;
         this.rbPass.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.rbPass.Location = new System.Drawing.Point(77, 463);
         this.rbPass.Name = "rbPass";
         this.rbPass.Size = new System.Drawing.Size(62, 24);
         this.rbPass.TabIndex = 66;
         this.rbPass.TabStop = true;
         this.rbPass.Text = "Pass";
         this.rbPass.UseVisualStyleBackColor = true;
         // 
         // rbFail
         // 
         this.rbFail.AutoSize = true;
         this.rbFail.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.rbFail.Location = new System.Drawing.Point(145, 462);
         this.rbFail.Name = "rbFail";
         this.rbFail.Size = new System.Drawing.Size(55, 24);
         this.rbFail.TabIndex = 67;
         this.rbFail.TabStop = true;
         this.rbFail.Text = "Fail";
         this.rbFail.UseVisualStyleBackColor = true;
         // 
         // txtNotes
         // 
         this.txtNotes.Location = new System.Drawing.Point(78, 497);
         this.txtNotes.Multiline = true;
         this.txtNotes.Name = "txtNotes";
         this.txtNotes.Size = new System.Drawing.Size(353, 76);
         this.txtNotes.TabIndex = 68;
         // 
         // radioButton2
         // 
         this.radioButton2.AutoSize = true;
         this.radioButton2.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.radioButton2.Location = new System.Drawing.Point(145, 462);
         this.radioButton2.Name = "radioButton2";
         this.radioButton2.Size = new System.Drawing.Size(55, 24);
         this.radioButton2.TabIndex = 67;
         this.radioButton2.TabStop = true;
         this.radioButton2.Text = "Fail";
         this.radioButton2.UseVisualStyleBackColor = true;
         // 
         // frmTakeTest
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.Gainsboro;
         this.ClientSize = new System.Drawing.Size(446, 625);
         this.Controls.Add(this.txtNotes);
         this.Controls.Add(this.rbFail);
         this.Controls.Add(this.rbPass);
         this.Controls.Add(this.lblUserMessage);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.btnCancel);
         this.Controls.Add(this.btnSave);
         this.Controls.Add(this.ctrlSecheduledTest1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
         this.Name = "frmTakeTest";
         this.Text = "Take Test";
         this.Load += new System.EventHandler(this.frmTakeTest_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private controls.ctrlSecheduledTest ctrlSecheduledTest1;
      private System.Windows.Forms.Button btnSave;
      private System.Windows.Forms.Button btnCancel;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label lblUserMessage;
      private System.Windows.Forms.RadioButton rbPass;
      private System.Windows.Forms.RadioButton rbFail;
      private System.Windows.Forms.TextBox txtNotes;
      private System.Windows.Forms.RadioButton radioButton2;
   }
}