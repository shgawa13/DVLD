namespace DVLD.Applications
{
   partial class frmEditApplicationType
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
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.lblApplicationID = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.txtbTitle = new System.Windows.Forms.TextBox();
         this.txtbFees = new System.Windows.Forms.TextBox();
         this.btnSave = new System.Windows.Forms.Button();
         this.btnCancel = new System.Windows.Forms.Button();
         this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
         ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.BackColor = System.Drawing.Color.Gainsboro;
         this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.ForeColor = System.Drawing.Color.Red;
         this.label1.Location = new System.Drawing.Point(134, 37);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(256, 30);
         this.label1.TabIndex = 0;
         this.label1.Text = "Update Application Type";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(62, 97);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(29, 20);
         this.label2.TabIndex = 1;
         this.label2.Text = "ID:";
         // 
         // lblApplicationID
         // 
         this.lblApplicationID.AutoSize = true;
         this.lblApplicationID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblApplicationID.Location = new System.Drawing.Point(108, 97);
         this.lblApplicationID.Name = "lblApplicationID";
         this.lblApplicationID.Size = new System.Drawing.Size(30, 20);
         this.lblApplicationID.TabIndex = 2;
         this.lblApplicationID.Text = "???";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label4.Location = new System.Drawing.Point(51, 158);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(40, 20);
         this.label4.TabIndex = 3;
         this.label4.Text = "Title";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label5.Location = new System.Drawing.Point(51, 211);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(40, 20);
         this.label5.TabIndex = 4;
         this.label5.Text = "Fees";
         // 
         // txtbTitle
         // 
         this.txtbTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtbTitle.Location = new System.Drawing.Point(112, 158);
         this.txtbTitle.Name = "txtbTitle";
         this.txtbTitle.Size = new System.Drawing.Size(372, 27);
         this.txtbTitle.TabIndex = 5;
         this.txtbTitle.Validating += new System.ComponentModel.CancelEventHandler(this.txtbTitle_Validating);
         // 
         // txtbFees
         // 
         this.txtbFees.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtbFees.Location = new System.Drawing.Point(112, 211);
         this.txtbFees.Name = "txtbFees";
         this.txtbFees.Size = new System.Drawing.Size(372, 27);
         this.txtbFees.TabIndex = 6;
         this.txtbFees.Validating += new System.ComponentModel.CancelEventHandler(this.txtbFees_Validating);
         // 
         // btnSave
         // 
         this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
         this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnSave.ForeColor = System.Drawing.Color.RoyalBlue;
         this.btnSave.Location = new System.Drawing.Point(278, 260);
         this.btnSave.Name = "btnSave";
         this.btnSave.Size = new System.Drawing.Size(91, 33);
         this.btnSave.TabIndex = 7;
         this.btnSave.Text = "Save";
         this.btnSave.UseVisualStyleBackColor = true;
         this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
         // 
         // btnCancel
         // 
         this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnCancel.Location = new System.Drawing.Point(393, 260);
         this.btnCancel.Name = "btnCancel";
         this.btnCancel.Size = new System.Drawing.Size(91, 33);
         this.btnCancel.TabIndex = 8;
         this.btnCancel.Text = "Cancel";
         this.btnCancel.UseVisualStyleBackColor = true;
         // 
         // errorProvider1
         // 
         this.errorProvider1.ContainerControl = this;
         // 
         // frmEditApplicationType
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.Gainsboro;
         this.ClientSize = new System.Drawing.Size(512, 305);
         this.Controls.Add(this.btnCancel);
         this.Controls.Add(this.btnSave);
         this.Controls.Add(this.txtbFees);
         this.Controls.Add(this.txtbTitle);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.lblApplicationID);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
         this.Name = "frmEditApplicationType";
         this.Text = "Update Application Type";
         this.Load += new System.EventHandler(this.frmEditApplicationType_Load);
         ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label lblApplicationID;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.TextBox txtbTitle;
      private System.Windows.Forms.TextBox txtbFees;
      private System.Windows.Forms.Button btnSave;
      private System.Windows.Forms.Button btnCancel;
      private System.Windows.Forms.ErrorProvider errorProvider1;
   }
}