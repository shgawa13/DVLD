using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Applications
{
   public partial class frmMangeApplicationTypes : Form
   {
      


      public frmMangeApplicationTypes()
      {
         InitializeComponent();
      }

      private void _RefreshApplicationList()
      {
          DataTable dtApplicationTypes = clsApplicationTypes.GetAllApplicationTypes();

         dgvApplicationTypes.DataSource = dtApplicationTypes;

         lblApplicationTypesNumber.Text = dgvApplicationTypes.RowCount.ToString();

      }

      private void frmMangeApplicationTypes_Load(object sender, EventArgs e)
      {
         _RefreshApplicationList();

         dgvApplicationTypes.Columns[0].HeaderText = "ID";
         dgvApplicationTypes.Columns[0].Width = 60;

         dgvApplicationTypes.Columns[1].HeaderText = "Title";
         dgvApplicationTypes.Columns[1].Width = 320;

         dgvApplicationTypes.Columns[2].HeaderText = "Fees";
         dgvApplicationTypes.Columns[2].Width = 120;


      }

      private void tolsmEdit_Click(object sender, EventArgs e)
      {
         Form frm = new frmEditApplicationType((int)dgvApplicationTypes.CurrentRow.Cells[0].Value);
         frm.ShowDialog();
         _RefreshApplicationList();
      }



   }
}
