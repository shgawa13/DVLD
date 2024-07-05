namespace DVLD.Tests
{
   partial class frmMangeTestType
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
         this.dgvTestType = new System.Windows.Forms.DataGridView();
         this.ctxmsTestTypes = new System.Windows.Forms.ContextMenuStrip(this.components);
         this.tolsmEdit = new System.Windows.Forms.ToolStripMenuItem();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.lblTestTypeNumber = new System.Windows.Forms.Label();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         ((System.ComponentModel.ISupportInitialize)(this.dgvTestType)).BeginInit();
         this.ctxmsTestTypes.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.SuspendLayout();
         // 
         // dgvTestType
         // 
         this.dgvTestType.AllowUserToAddRows = false;
         this.dgvTestType.AllowUserToDeleteRows = false;
         this.dgvTestType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
         this.dgvTestType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dgvTestType.ContextMenuStrip = this.ctxmsTestTypes;
         this.dgvTestType.Location = new System.Drawing.Point(0, 196);
         this.dgvTestType.Name = "dgvTestType";
         this.dgvTestType.ReadOnly = true;
         this.dgvTestType.Size = new System.Drawing.Size(799, 205);
         this.dgvTestType.TabIndex = 0;
         // 
         // ctxmsTestTypes
         // 
         this.ctxmsTestTypes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tolsmEdit});
         this.ctxmsTestTypes.Name = "ctxmsTestTypes";
         this.ctxmsTestTypes.Size = new System.Drawing.Size(181, 48);
         this.ctxmsTestTypes.Text = "Mange TestTypes";
         // 
         // tolsmEdit
         // 
         this.tolsmEdit.Name = "tolsmEdit";
         this.tolsmEdit.Size = new System.Drawing.Size(180, 22);
         this.tolsmEdit.Text = "Edit Test";
         this.tolsmEdit.Click += new System.EventHandler(this.tolsmEdit_Click);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.label1.Location = new System.Drawing.Point(296, 144);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(206, 32);
         this.label1.TabIndex = 1;
         this.label1.Text = "Mange Test Type";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.label2.Location = new System.Drawing.Point(7, 416);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(87, 21);
         this.label2.TabIndex = 3;
         this.label2.Text = "# Records:";
         // 
         // lblTestTypeNumber
         // 
         this.lblTestTypeNumber.AutoSize = true;
         this.lblTestTypeNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblTestTypeNumber.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.lblTestTypeNumber.Location = new System.Drawing.Point(93, 416);
         this.lblTestTypeNumber.Name = "lblTestTypeNumber";
         this.lblTestTypeNumber.Size = new System.Drawing.Size(31, 21);
         this.lblTestTypeNumber.TabIndex = 4;
         this.lblTestTypeNumber.Text = "???";
         // 
         // pictureBox1
         // 
         this.pictureBox1.Image = global::DVLD.Properties.Resources.TestType_512;
         this.pictureBox1.Location = new System.Drawing.Point(299, 14);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(200, 116);
         this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.pictureBox1.TabIndex = 2;
         this.pictureBox1.TabStop = false;
         // 
         // frmMangeTestType
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.lblTestTypeNumber);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.pictureBox1);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.dgvTestType);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
         this.Name = "frmMangeTestType";
         this.Text = "Mange Test Type";
         this.Load += new System.EventHandler(this.frmMangeTestType_Load);
         ((System.ComponentModel.ISupportInitialize)(this.dgvTestType)).EndInit();
         this.ctxmsTestTypes.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.DataGridView dgvTestType;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label lblTestTypeNumber;
      private System.Windows.Forms.ContextMenuStrip ctxmsTestTypes;
      private System.Windows.Forms.ToolStripMenuItem tolsmEdit;
   }
}