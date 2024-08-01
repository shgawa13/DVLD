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
      private DataTable _dtLocalApplications;
      

      public frmListLocalDrivingLicenseApplication()
      {
         InitializeComponent();
      }

      private void _RefreshApplicationList()
      {
         
         _dtLocalApplications = clsLocalDrivingLicenseApplication.GetAllLocalDrivingLicenseApplications();

         dgvDrivingLincesApplications.DataSource = _dtLocalApplications;
         lblLDVLAppNumber.Text = dgvDrivingLincesApplications.RowCount.ToString();

         
         if (dgvDrivingLincesApplications.Rows.Count > 0)
         {

            dgvDrivingLincesApplications.Columns[0].HeaderText = "L.D.L.AppID";
            dgvDrivingLincesApplications.Columns[0].Width = 80;

            dgvDrivingLincesApplications.Columns[1].HeaderText = "Driving Class";
            dgvDrivingLincesApplications.Columns[1].Width = 200;

            dgvDrivingLincesApplications.Columns[2].HeaderText = "National No.";
            dgvDrivingLincesApplications.Columns[2].Width = 70;

            dgvDrivingLincesApplications.Columns[3].HeaderText = "Full Name";
            dgvDrivingLincesApplications.Columns[3].Width = 250;

            dgvDrivingLincesApplications.Columns[4].HeaderText = "Application Date";
            dgvDrivingLincesApplications.Columns[4].Width = 120;

            dgvDrivingLincesApplications.Columns[5].HeaderText = "Passed Tests";
            dgvDrivingLincesApplications.Columns[5].Width = 50;

            dgvDrivingLincesApplications.Columns[6].HeaderText = "Status";
            dgvDrivingLincesApplications.Columns[6].Width = 100;
         }

         cbFilterBy.SelectedIndex = 0;
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
         frmAddUpdateLocalDrivingLicenseApplication frm = new frmAddUpdateLocalDrivingLicenseApplication();
        
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
               //txtFilterValue.Enabled = false;
               txtFilterValue.Visible = false;
            else
               txtFilterValue.Enabled = true;
               txtFilterValue.Text = "";
               txtFilterValue.Focus();

            _dtLocalApplications.DefaultView.RowFilter = "";
            lblLDVLAppNumber.Text = dgvDrivingLincesApplications.RowCount.ToString();

         }
      }

   

      private void txtFilterValue_TextChanged(object sender, EventArgs e)
     {
         string FilterColumn = "";
         //Map Selected Filter to real Column name 

         switch (cbFilterBy.Text)
         {

            case "L.DLA ID":
               FilterColumn = "LocalDrivingLicenseApplicationID";
               break;
            
            case "National No":
               FilterColumn = "NationalNo";
               break;

            case "Full Name":
               FilterColumn = "FullName";
               break;

            case "Status":
               FilterColumn = "Status";
               break;

            default:
               FilterColumn = "None";
               break;

         }


         if(txtFilterValue.Text.Trim() =="" || FilterColumn == "None")
         {
            _dtLocalApplications.DefaultView.RowFilter = "";
            lblLDVLAppNumber.Text = dgvDrivingLincesApplications.RowCount.ToString();
            return;
         }

         // here we check if input in not empty
         
            if( FilterColumn == "LocalDrivingLicenseApplicationID")
                _dtLocalApplications.DefaultView.RowFilter  = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
            else
                _dtLocalApplications.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());

          lblLDVLAppNumber.Text = dgvDrivingLincesApplications.RowCount.ToString();

         

          
      }

         
      

      private void tlsmEditApplication_Click(object sender, EventArgs e)
      {
         int LocalDrivingLicenseApplicationID = (int)dgvDrivingLincesApplications.CurrentRow.Cells[0].Value;
         frmAddUpdateLocalDrivingLicenseApplication frm =
            new frmAddUpdateLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID);
         frm.ShowDialog();

         frmListDrivingLicenseApplication_Load(null, null);

      }

      // here we should handle the input if it's a number
      private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
      {
        if(cbFilterBy.Text == "L.DLA ID")
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
      }

      private void tlsmCancelApplication_Click(object sender, EventArgs e)
      {
         if (MessageBox.Show("Are you sure do want to cancel this application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            return;
         // we get the ID from DataGridView
         int LocalDrivingApplicationID = (int)dgvDrivingLincesApplications.CurrentRow.Cells[0].Value;
         // we Search for the applicaion
         clsLocalDrivingLicenseApplication LocalDrivingApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(LocalDrivingApplicationID);
         // if Local application was found
         if (LocalDrivingApplication != null)
         {
            MessageBox.Show($"Application with ID {LocalDrivingApplication.ApplicationID} Found");
            // we call Cancel function
            if (LocalDrivingApplication.Cancel())
            {

               MessageBox.Show("Application Cancelled Successfully.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
               //refresh the form again.
               _RefreshApplicationList();

            }
            else
            {
               MessageBox.Show("Could not cancel applicatoin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
         }

      }

      // here

   }
}
