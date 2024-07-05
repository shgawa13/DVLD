namespace DVLD.Applications
{
   partial class frmMangeApplicationTypes
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
         this.dgvApplicationTypes = new System.Windows.Forms.DataGridView();
         this.label1 = new System.Windows.Forms.Label();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.label2 = new System.Windows.Forms.Label();
         this.lblApplicationTypesNumber = new System.Windows.Forms.Label();
         this.ctxmEditApplicationType = new System.Windows.Forms.ContextMenuStrip(this.components);
         this.tolsmEdit = new System.Windows.Forms.ToolStripMenuItem();
         ((System.ComponentModel.ISupportInitialize)(this.dgvApplicationTypes)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.ctxmEditApplicationType.SuspendLayout();
         this.SuspendLayout();
         // 
         // dgvApplicationTypes
         // 
         this.dgvApplicationTypes.AllowUserToAddRows = false;
         this.dgvApplicationTypes.AllowUserToDeleteRows = false;
         this.dgvApplicationTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
         this.dgvApplicationTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dgvApplicationTypes.ContextMenuStrip = this.ctxmEditApplicationType;
         this.dgvApplicationTypes.Location = new System.Drawing.Point(0, 195);
         this.dgvApplicationTypes.Name = "dgvApplicationTypes";
         this.dgvApplicationTypes.ReadOnly = true;
         this.dgvApplicationTypes.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
         this.dgvApplicationTypes.Size = new System.Drawing.Size(817, 269);
         this.dgvApplicationTypes.TabIndex = 1;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.label1.Location = new System.Drawing.Point(299, 151);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(218, 32);
         this.label1.TabIndex = 2;
         this.label1.Text = "Application Types";
         // 
         // pictureBox1
         // 
         this.pictureBox1.Image = global::DVLD.Properties.Resources.Application_Types_512;
         this.pictureBox1.Location = new System.Drawing.Point(303, 16);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(210, 123);
         this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.pictureBox1.TabIndex = 3;
         this.pictureBox1.TabStop = false;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.label2.Location = new System.Drawing.Point(8, 474);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(78, 21);
         this.label2.TabIndex = 4;
         this.label2.Text = "Records :";
         // 
         // lblApplicationTypesNumber
         // 
         this.lblApplicationTypesNumber.AutoSize = true;
         this.lblApplicationTypesNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblApplicationTypesNumber.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.lblApplicationTypesNumber.Location = new System.Drawing.Point(91, 474);
         this.lblApplicationTypesNumber.Name = "lblApplicationTypesNumber";
         this.lblApplicationTypesNumber.Size = new System.Drawing.Size(31, 21);
         this.lblApplicationTypesNumber.TabIndex = 5;
         this.lblApplicationTypesNumber.Text = "???";
         // 
         // ctxmEditApplicationType
         // 
         this.ctxmEditApplicationType.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tolsmEdit});
         this.ctxmEditApplicationType.Name = "ctxmEditApplicationType";
         this.ctxmEditApplicationType.Size = new System.Drawing.Size(181, 48);
         this.ctxmEditApplicationType.Text = "Edit Application";
         // 
         // tolsmEdit
         // 
         this.tolsmEdit.Name = "tolsmEdit";
         this.tolsmEdit.Size = new System.Drawing.Size(180, 22);
         this.tolsmEdit.Text = "Edit";
         this.tolsmEdit.Click += new System.EventHandler(this.tolsmEdit_Click);
         // 
         // frmMangeApplicationTypes
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(33)))), ((int)(((byte)(67)))));
         this.ClientSize = new System.Drawing.Size(817, 509);
         this.Controls.Add(this.lblApplicationTypesNumber);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.pictureBox1);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.dgvApplicationTypes);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
         this.Name = "frmMangeApplicationTypes";
         this.Text = "Mange Application Types";
         this.Load += new System.EventHandler(this.frmMangeApplicationTypes_Load);
         ((System.ComponentModel.ISupportInitialize)(this.dgvApplicationTypes)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.ctxmEditApplicationType.ResumeLayout(false);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion
      private System.Windows.Forms.DataGridView dgvApplicationTypes;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label lblApplicationTypesNumber;
      private System.Windows.Forms.ContextMenuStrip ctxmEditApplicationType;
      private System.Windows.Forms.ToolStripMenuItem tolsmEdit;
   }
}