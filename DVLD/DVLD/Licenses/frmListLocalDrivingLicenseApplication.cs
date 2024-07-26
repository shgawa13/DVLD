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
      private DataTable _dtLocalApplications = clsLocalDrivingLicenseApplication.GetAllApplications();
      public frmListLocalDrivingLicenseApplication()
      {
         InitializeComponent();
      }

      private void _RefreshApplicationList()
      {
         _dtLocalApplications = clsLocalDrivingLicenseApplication.GetAllApplications();
         dgvDrivingLincesApplications.DataSource = _dtLocalApplications;
      }

      private void frmListDrivingLicenseApplication_Load(object sender, EventArgs e)
      {
         _RefreshApplicationList();
      }

      private void bntAddNewApplication_Click(object sender, EventArgs e)
      {
         Form frm = new frmAddUpdateLocalDrivingLicenseApplication();
         frm.ShowDialog();
      }
   }
}
