using Business;
using DVLD.Tests.Test_Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Tests
{
   public partial class frmMangeTestType : Form
   {
      private DataTable _dtAllTestType;
     

      public frmMangeTestType()
      {
         InitializeComponent();
      }


      private void _RefreshTestTypeList()
      {
         _dtAllTestType = clsTestType.GetAllTypeTest();
         dgvTestType.DataSource = _dtAllTestType;
         lblTestTypeNumber.Text = dgvTestType.RowCount.ToString();

      }

      private void frmMangeTestType_Load(object sender, EventArgs e)
      {
         _RefreshTestTypeList();

         dgvTestType.Columns[0].HeaderText = "ID";
         dgvTestType.Columns[0].Width = 120;

         dgvTestType.Columns[1].HeaderText = "Title";
         dgvTestType.Columns[1].Width = 200;
            
         dgvTestType.Columns[2].HeaderText = "Description";
         dgvTestType.Columns[2].Width = 400;

         dgvTestType.Columns[3].HeaderText = "Fees";
         dgvTestType.Columns[3].Width = 100;
      }

      private void tolsmEdit_Click(object sender, EventArgs e)
      {
          Form frm = new frmEditTestType((clsTestType.enTypeTest)dgvTestType.CurrentRow.Cells[0].Value);
         frm.ShowDialog();
         _RefreshTestTypeList();
      }
   }
}
