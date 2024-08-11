namespace DVLD.Licenses.Local_License.controls
{
   partial class ctrlDriverLicenseInfoWithFilter
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
         this.gbFilters = new System.Windows.Forms.GroupBox();
         this.btnFind = new System.Windows.Forms.Button();
         this.label2 = new System.Windows.Forms.Label();
         this.txtLicenseID = new System.Windows.Forms.TextBox();
         this.ctrlDriverLicenseInfo1 = new DVLD.Licenses.Local_License.controls.ctrlDriverLicenseInfo();
         this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
         this.gbFilters.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
         this.SuspendLayout();
         // 
         // gbFilters
         // 
         this.gbFilters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(37)))), ((int)(((byte)(73)))));
         this.gbFilters.Controls.Add(this.btnFind);
         this.gbFilters.Controls.Add(this.label2);
         this.gbFilters.Controls.Add(this.txtLicenseID);
         this.gbFilters.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.gbFilters.ForeColor = System.Drawing.Color.Gainsboro;
         this.gbFilters.Location = new System.Drawing.Point(0, 0);
         this.gbFilters.Name = "gbFilters";
         this.gbFilters.Size = new System.Drawing.Size(517, 70);
         this.gbFilters.TabIndex = 4;
         this.gbFilters.TabStop = false;
         this.gbFilters.Text = "Filter";
         // 
         // btnFind
         // 
         this.btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(33)))), ((int)(((byte)(67)))));
         this.btnFind.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
         this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnFind.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnFind.ForeColor = System.Drawing.Color.White;
         this.btnFind.Location = new System.Drawing.Point(362, 25);
         this.btnFind.Name = "btnFind";
         this.btnFind.Size = new System.Drawing.Size(94, 30);
         this.btnFind.TabIndex = 27;
         this.btnFind.Text = "Find";
         this.btnFind.UseVisualStyleBackColor = false;
         this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.label2.Location = new System.Drawing.Point(17, 29);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(132, 23);
         this.label2.TabIndex = 24;
         this.label2.Text = "License ID:";
         // 
         // txtLicenseID
         // 
         this.txtLicenseID.Location = new System.Drawing.Point(155, 27);
         this.txtLicenseID.Name = "txtLicenseID";
         this.txtLicenseID.Size = new System.Drawing.Size(188, 26);
         this.txtLicenseID.TabIndex = 26;
         this.txtLicenseID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
         // 
         // ctrlDriverLicenseInfo1
         // 
         this.ctrlDriverLicenseInfo1.BackColor = System.Drawing.SystemColors.ControlLight;
         this.ctrlDriverLicenseInfo1.Location = new System.Drawing.Point(0, 73);
         this.ctrlDriverLicenseInfo1.Name = "ctrlDriverLicenseInfo1";
         this.ctrlDriverLicenseInfo1.Size = new System.Drawing.Size(880, 390);
         this.ctrlDriverLicenseInfo1.TabIndex = 5;
         // 
         // errorProvider1
         // 
         this.errorProvider1.ContainerControl = this;
         // 
         // ctrlDriverLicenseInfoWithFilter
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(37)))), ((int)(((byte)(73)))));
         this.Controls.Add(this.ctrlDriverLicenseInfo1);
         this.Controls.Add(this.gbFilters);
         this.Name = "ctrlDriverLicenseInfoWithFilter";
         this.Size = new System.Drawing.Size(882, 464);
         this.gbFilters.ResumeLayout(false);
         this.gbFilters.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.GroupBox gbFilters;
      private System.Windows.Forms.Button btnFind;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox txtLicenseID;
      private ctrlDriverLicenseInfo ctrlDriverLicenseInfo1;
      private System.Windows.Forms.ErrorProvider errorProvider1;
   }
}
