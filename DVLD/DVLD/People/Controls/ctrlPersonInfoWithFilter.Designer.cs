namespace DVLD.People.Controls
{
   partial class ctrlPersonInfoWithFilter
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
         this.panel1 = new System.Windows.Forms.Panel();
         this.grbFilter = new System.Windows.Forms.GroupBox();
         this.btnAddNewPerson = new System.Windows.Forms.Button();
         this.btnSearch = new System.Windows.Forms.Button();
         this.label2 = new System.Windows.Forms.Label();
         this.txtFilterValue = new System.Windows.Forms.TextBox();
         this.cbFilterBy = new System.Windows.Forms.ComboBox();
         this.ctrlPersonInfo1 = new DVLD.People.Controls.ctrlPersonInfo();
         this.panel1.SuspendLayout();
         this.grbFilter.SuspendLayout();
         this.SuspendLayout();
         // 
         // panel1
         // 
         this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(37)))), ((int)(((byte)(73)))));
         this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.panel1.Controls.Add(this.grbFilter);
         this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
         this.panel1.Location = new System.Drawing.Point(0, 0);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(953, 70);
         this.panel1.TabIndex = 1;
         // 
         // grbFilter
         // 
         this.grbFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(37)))), ((int)(((byte)(73)))));
         this.grbFilter.Controls.Add(this.btnAddNewPerson);
         this.grbFilter.Controls.Add(this.btnSearch);
         this.grbFilter.Controls.Add(this.label2);
         this.grbFilter.Controls.Add(this.txtFilterValue);
         this.grbFilter.Controls.Add(this.cbFilterBy);
         this.grbFilter.Dock = System.Windows.Forms.DockStyle.Top;
         this.grbFilter.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.grbFilter.ForeColor = System.Drawing.Color.Gainsboro;
         this.grbFilter.Location = new System.Drawing.Point(0, 0);
         this.grbFilter.Name = "grbFilter";
         this.grbFilter.Size = new System.Drawing.Size(951, 70);
         this.grbFilter.TabIndex = 3;
         this.grbFilter.TabStop = false;
         this.grbFilter.Text = "Filter";
         // 
         // btnAddNewPerson
         // 
         this.btnAddNewPerson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
         this.btnAddNewPerson.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
         this.btnAddNewPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnAddNewPerson.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnAddNewPerson.ForeColor = System.Drawing.Color.Transparent;
         this.btnAddNewPerson.Location = new System.Drawing.Point(788, 12);
         this.btnAddNewPerson.Name = "btnAddNewPerson";
         this.btnAddNewPerson.Size = new System.Drawing.Size(144, 55);
         this.btnAddNewPerson.TabIndex = 28;
         this.btnAddNewPerson.Text = "Add New \r\nPerson";
         this.btnAddNewPerson.UseVisualStyleBackColor = false;
         this.btnAddNewPerson.Click += new System.EventHandler(this.btnAddNewPerson_Click_1);
         // 
         // btnSearch
         // 
         this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(33)))), ((int)(((byte)(67)))));
         this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
         this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnSearch.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnSearch.ForeColor = System.Drawing.Color.White;
         this.btnSearch.Location = new System.Drawing.Point(547, 24);
         this.btnSearch.Name = "btnSearch";
         this.btnSearch.Size = new System.Drawing.Size(94, 30);
         this.btnSearch.TabIndex = 27;
         this.btnSearch.Text = "Search";
         this.btnSearch.UseVisualStyleBackColor = false;
         this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
         this.label2.Location = new System.Drawing.Point(47, 29);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(67, 21);
         this.label2.TabIndex = 24;
         this.label2.Text = "Find by";
         // 
         // txtFilterValue
         // 
         this.txtFilterValue.Location = new System.Drawing.Point(323, 26);
         this.txtFilterValue.Name = "txtFilterValue";
         this.txtFilterValue.Size = new System.Drawing.Size(188, 26);
         this.txtFilterValue.TabIndex = 26;
         // 
         // cbFilterBy
         // 
         this.cbFilterBy.BackColor = System.Drawing.SystemColors.Window;
         this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cbFilterBy.ImeMode = System.Windows.Forms.ImeMode.NoControl;
         this.cbFilterBy.Items.AddRange(new object[] {
            "Person ID",
            "National No"});
         this.cbFilterBy.Location = new System.Drawing.Point(129, 26);
         this.cbFilterBy.Name = "cbFilterBy";
         this.cbFilterBy.Size = new System.Drawing.Size(188, 26);
         this.cbFilterBy.TabIndex = 25;
         // 
         // ctrlPersonInfo1
         // 
         this.ctrlPersonInfo1.BackColor = System.Drawing.Color.Gainsboro;
         this.ctrlPersonInfo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(154)))), ((int)(((byte)(231)))));
         this.ctrlPersonInfo1.Location = new System.Drawing.Point(3, 73);
         this.ctrlPersonInfo1.Name = "ctrlPersonInfo1";
         this.ctrlPersonInfo1.Size = new System.Drawing.Size(946, 306);
         this.ctrlPersonInfo1.TabIndex = 2;
         this.ctrlPersonInfo1.Load += new System.EventHandler(this.ctrlPersonInfo1_Load);
         // 
         // ctrlPersonInfoWithFilter
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.Gainsboro;
         this.Controls.Add(this.ctrlPersonInfo1);
         this.Controls.Add(this.panel1);
         this.Name = "ctrlPersonInfoWithFilter";
         this.Size = new System.Drawing.Size(953, 373);
         this.panel1.ResumeLayout(false);
         this.grbFilter.ResumeLayout(false);
         this.grbFilter.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.TextBox txtFilterValue;
      private System.Windows.Forms.ComboBox cbFilterBy;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Button btnAddNewPerson;
      private System.Windows.Forms.Button btnSearch;
      private ctrlPersonInfo ctrlPersonInfo1;
      private System.Windows.Forms.GroupBox grbFilter;
   }
}
