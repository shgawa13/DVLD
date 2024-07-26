using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using BusinessLayer;
namespace DVLD.Licenses
{
   public partial class frmListLocalDrivingLicenseApplication : Form
   {
      private static DataTable _dtAllLocalApplications = clsLocalDrivingLicenseApplication.GetAllApplications();
      private DataView _dtLocalApplications = _dtAllLocalApplications.DefaultView;

      public frmListLocalDrivingLicenseApplication()
      {
         InitializeComponent();
      }

      private void _RefreshApplicationList()
      {
         _dtLocalApplications = _dtAllLocalApplications.DefaultView;
         dgvDrivingLincesApplications.DataSource = _dtLocalApplications;
      }

      private void frmListDrivingLicenseApplication_Load(object sender, EventArgs e)
      {
         _RefreshApplicationList();
         cbFilterBy.SelectedIndex = 0;

         txtFilterValue.Visible = false;
         cbStatus.Visible = false;

      }

      private void bntAddNewApplication_Click(object sender, EventArgs e)
      {
         Form frm = new frmAddUpdateLocalDrivingLicenseApplication();
         frm.ShowDialog();

         // Refreshing 
         _RefreshApplicationList();
      }

      private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
      {
         //Status
         if (cbFilterBy.Text == "Status")
         {
            txtFilterValue.Visible = false;
            cbStatus.Visible = true;
            cbStatus.SelectedIndex = 0;
         }
      }
   }
}
