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
         lblLDVLAppNumber.Text = dgvDrivingLincesApplications.RowCount.ToString();
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
            cbStatus.Focus();
         }
         else
         {
            txtFilterValue.Visible = (cbFilterBy.Text != "None");
            cbStatus.Visible = false;

            if (cbFilterBy.Text == "None")
               txtFilterValue.Enabled = false;
            else
               txtFilterValue.Enabled = true;
               txtFilterValue.Text = "";
               txtFilterValue.Focus();


         }
      }

   

      private void txtFilterValue_TextChanged(object sender, EventArgs e)
      {
         string FilterColumn = "";
         //Map Selected Filter to real Column name 

         switch (cbFilterBy.Text)
         {

            case "L.DLA ID":
               FilterColumn = "LocalDrivingLicenseApplicaionID";
               break;

            case "National No":
               FilterColumn = "NationalNo";
               break;

            case "Full Name":
               FilterColumn = "FullName";
               break;

            default:
               FilterColumn = "None";
               break;

         }


         if(txtFilterValue.Text.Trim() =="" && FilterColumn == "None")
         {
            _dtLocalApplications.RowFilter = "";
            lblLDVLAppNumber.Text = dgvDrivingLincesApplications.RowCount.ToString();
            return;
         }


         if(FilterColumn != "FullName" && FilterColumn != "None")
            _dtLocalApplications.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
         else
            _dtLocalApplications.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());

         lblLDVLAppNumber.Text = dgvDrivingLincesApplications.RowCount.ToString();

      }
   }
}
