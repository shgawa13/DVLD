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
using DVLD.Applications.LocalDrivingLicenseApplication;
using DVLD.Tests;
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
         txtFilterValue.Visible = (cbFilterBy.Text != "None");

         if (txtFilterValue.Visible)
         {
            txtFilterValue.Text = "";
            txtFilterValue.Focus();
         }

         _dtLocalApplications.DefaultView.RowFilter = "";
         lblLDVLAppNumber.Text = _dtLocalApplications.Rows.Count.ToString();

      }

   

      private void txtFilterValue_TextChanged(object sender, EventArgs e)
     {
         string FilterColumn = "";
         //Map Selected Filter to real Column name 

         switch (cbFilterBy.Text)
         {

            case "L.D.L.AppID":
               FilterColumn = "LocalDrivingLicenseApplicationID";
               break;

            case "National No.":
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

      

      private void tlsmShowApplicationDetails_Click(object sender, EventArgs e)
      {
         frmLocalDrivingLicenseApplicationInfo frm =
                         new frmLocalDrivingLicenseApplicationInfo((int)dgvDrivingLincesApplications.CurrentRow.Cells[0].Value);
         frm.ShowDialog();
         //refresh
         frmListDrivingLicenseApplication_Load(null, null);
      }

      private void tlsmEditApplication_Click(object sender, EventArgs e)
      {

         int LocalDrivingLicenseApplicationID = (int)dgvDrivingLincesApplications.CurrentRow.Cells[0].Value;
         frmAddUpdateLocalDrivingLicenseApplication frm =
            new frmAddUpdateLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID);
         frm.ShowDialog();

         frmListDrivingLicenseApplication_Load(null, null);

      }

      private void tlsmDeleteApplication_Click(object sender, EventArgs e)
      {
        if(MessageBox.Show("Are you sure to delete this applicatoin.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
          return;


         int LocalDrivingLicenseApplicationID = (int)dgvDrivingLincesApplications.CurrentRow.Cells[0].Value;
         clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication =
            clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(LocalDrivingLicenseApplicationID);

         if(LocalDrivingLicenseApplication != null)
         {

            if (LocalDrivingLicenseApplication.Delete())
            {
               MessageBox.Show("Application Has been deleted Successully", "Confimed", MessageBoxButtons.OK);
               frmListDrivingLicenseApplication_Load(null, null);
            }
            else
            {
               MessageBox.Show("Error Couldn't Delete this Application", "ERORR", MessageBoxButtons.OK,MessageBoxIcon.Error);

            }


         }

      }

      // Enable and disable option
      private void ctmsApplication_Opening(object sender, CancelEventArgs e)
      {

         int LocalDrivingLicenseApplicationID = (int)dgvDrivingLincesApplications.CurrentRow.Cells[0].Value;
         clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication =
            clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(LocalDrivingLicenseApplicationID);
        
         // we get total passed test and if there is a license
         int TotalPassedTests = (int)dgvDrivingLincesApplications.CurrentRow.Cells[5].Value;
         bool LicenseExist = LocalDrivingLicenseApplication.IsLicenseIssued();

         //Enabled only if person passed all tests and Does not have license. 
         issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = (TotalPassedTests == 3) && !LicenseExist;

         showLicenseToolStripMenuItem.Enabled = LicenseExist;
         tlsmEditApplication.Enabled = !LicenseExist && (LocalDrivingLicenseApplication.ApplicationStatus == clsApplication.enApplicationStatus.New);
         ScheduleTestsMenue.Enabled = !LicenseExist;
         //Enable/Disable Cancel Menue Item
         //We only canel the applications with status=new.
         tlsmCancelApplication.Enabled = (LocalDrivingLicenseApplication.ApplicationStatus == clsApplication.enApplicationStatus.New);
         //Enable/Disable Delete Menue Item
         //We only allow delete incase the application status is new not complete or Cancelled.
         tlsmDeleteApplication.Enabled = (LocalDrivingLicenseApplication.ApplicationStatus == clsApplication.enApplicationStatus.New);

         //Enable Disable Schedule menue and it's sub menue
         bool PassVisionTest = LocalDrivingLicenseApplication.DoesPassTestType(clsTestType.enTypeTest.VisionTest);
         bool PassWrittenTest = LocalDrivingLicenseApplication.DoesPassTestType(clsTestType.enTypeTest.WrittenTest);
         bool PassStreetTest = LocalDrivingLicenseApplication.DoesPassTestType(clsTestType.enTypeTest.StreetTest);

         ScheduleTestsMenue.Enabled = (!PassVisionTest || !PassWrittenTest || !PassStreetTest) && (LocalDrivingLicenseApplication.ApplicationStatus == clsApplication.enApplicationStatus.New);

         if (ScheduleTestsMenue.Enabled)
         {
            //To Allow Schdule vision test, Person must not passed the same test before.
            vistionTestToolStripMenuItem.Enabled = !PassVisionTest;

            //To Allow Schdule written test, Person must pass the vision test and must not passed the same test before.
            writtenTestToolStripMenuItem.Enabled = PassVisionTest && !PassWrittenTest;

            //To Allow Schdule steet test, Person must pass the vision * written tests, and must not passed the same test before.
            streetTestToolStripMenuItem.Enabled = PassVisionTest && PassWrittenTest && !PassStreetTest; 
         }

      }

      private void _ScheduleTest(clsTestType.enTypeTest TestType)
      {
         int LocalDrivingLicenseApplicationID = (int)dgvDrivingLincesApplications.CurrentRow.Cells[0].Value;
         frmListTestAppointments frm = new frmListTestAppointments(LocalDrivingLicenseApplicationID, TestType);
         frm.ShowDialog();

         frmListDrivingLicenseApplication_Load(null, null);
      }


      private void vistionTestToolStripMenuItem_Click(object sender, EventArgs e)
      {
         _ScheduleTest(clsTestType.enTypeTest.VisionTest);
      }

      private void writtenTestToolStripMenuItem_Click(object sender, EventArgs e)
      {
         _ScheduleTest(clsTestType.enTypeTest.WrittenTest);
      }

      private void streetTestToolStripMenuItem_Click(object sender, EventArgs e)
      {
         _ScheduleTest(clsTestType.enTypeTest.StreetTest); ;
      }

      private void issueDrivingLicenseFirstTimeToolStripMenuItem_Click(object sender, EventArgs e)
      {

      }
   }
}
