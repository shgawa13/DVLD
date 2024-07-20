using Business;
using BusinessLayer;
using DVLD.People.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD.Global_Classes;
using System.Windows.Forms;

namespace DVLD.Applications
{
   public partial class frmAddUpdateLocalDrivingLicenseApplication : Form
   {
      public enum enMode { AddNew =0, Update =1}

      private enMode _Mode = enMode.AddNew;
      private int _LocalDrivingLicenseApplicationID = -1;
      private int _SelectedPersonID = -1;
      clsLocalDrivingLicenseApplication _LocalApp { set; get; }

      public frmAddUpdateLocalDrivingLicenseApplication()
      {
         InitializeComponent();
         _Mode = enMode.AddNew;
      }

      public frmAddUpdateLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID)
      {
         InitializeComponent();
         _Mode = enMode.Update;
         _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
      }


      private void _FillLicenseClassesInComoboBox()
      {
         DataTable dtLicenseClass = clsLicenseClass.GetAllLicenseClasses();
         if(dtLicenseClass != null)
         {
            foreach (DataRow row in dtLicenseClass.Rows)
            {
               cmbLicenseClasses.Items.Add(row["ClassName"]);
            }
            cmbLicenseClasses.SelectedIndex = 0;
         }
         else
         {
            MessageBox.Show("Something went worng, couldn't Load License Class ");
         }
         
      }

      private void _ResetDefualtValues()
      {
         _FillLicenseClassesInComoboBox();

         // we check the mode
         if (_Mode==enMode.AddNew)
         {
            lblTitle.Text = "New Local Driving License Application";
            this.Text = "New Local Driving License Application";

            _LocalApp = new clsLocalDrivingLicenseApplication();
            btnNext.Enabled = false;
            tabpApplicationInfo.Enabled = false;
            lblFees.Text = clsApplicationTypes.GetApplicationTypeByID((int)clsApplication.enApplicationType.NewDrivingLicense).ApplicationFees.ToString();
            lblApplicationDate.Text = DateTime.Now.ToString();
            lblCreatedByUser.Text = clsGlobal.CurrnetUser.UserName;

         }
         else
         {
            lblTitle.Text = "Update Local Driving License Application";
            this.Text = "Update Local Driving License Application";

            btnNext.Enabled = true;
            tabpApplicationInfo.Enabled = true;
         }
      }

      private void _LoadData()
      {
         _LocalApp = clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(_LocalDrivingLicenseApplicationID);
         // if there is no LocalDrivingLicenseApplication 
         if(_LocalApp == null)
         {
            MessageBox.Show("No Application with ID = " + _LocalDrivingLicenseApplicationID, "Application Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.Close();

            return;
         }

         // if there a LocalDrivingLicenseApplication  then we load the data in the ctrl
         ctrlPersonInfoWithFilter1.LoadPersonInfo(_LocalApp.ApplicantPersonID);
         lablLocalDrivingLicenseApplicationID.Text = _LocalApp.ApplicationID.ToString();
         lblApplicationDate.Text = _LocalApp.ApplicationDate.ToString();
         cmbLicenseClasses.SelectedIndex = cmbLicenseClasses.FindString(clsLicenseClass.FindLicenseClassByID(_LocalApp.LicenseClassID).ClassName);
         lblFees.Text = _LocalApp.PaidFees.ToString();
         lblCreatedByUser.Text = clsUsers.FindByPersonID(_LocalApp.CreatedByUserID).ToString();
      }


      private void DataBackEvent(object sender, int PersonID)
      {
         // Handle the data received
         _SelectedPersonID = PersonID;
         ctrlPersonInfoWithFilter1.LoadPersonInfo(PersonID);

      }

      private void frmLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
      {
         _ResetDefualtValues();
         if (_Mode == enMode.Update)
            _LoadData();

      }

      private void btnNext_Click(object sender, EventArgs e)
      {
         if(_Mode == enMode.Update)
         {
            btnSave.Enabled = true;
            tabpApplicationInfo.Enabled = true;
            tabCtrlApp.SelectedTab = tabCtrlApp.TabPages["tabpApplicationInfo"];
            return;
         }

         //incase of add new mode.
         if (ctrlPersonInfoWithFilter1.PersonID != -1)
         {

            btnSave.Enabled = true;
            tabpApplicationInfo.Enabled = true;
            tabCtrlApp.SelectedTab = tabCtrlApp.TabPages["tabpApplicationInfo"];


         }

         else

         {
            MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
           // ctrlPersonInfoWithFilter1
         }


      }


      private void btnSave_Click(object sender, EventArgs e)
      {

         if (!this.ValidateChildren())
         {
            //Here we dont continue becuase the form is not valid
            MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;

         }

         int LicenseClassID = clsLicenseClass.FindLicenseClassByName(cmbLicenseClasses.Text).LicenseClassID;


         int ActiveApplicationID = clsApplication.GetActiveApplicationIDForLicenseClass(_SelectedPersonID, clsApplication.enApplicationType.NewDrivingLicense, LicenseClassID);

         if (ActiveApplicationID != -1)
         {
            MessageBox.Show("Choose another License Class, the selected Person Already have an active application for the selected class with id=" + ActiveApplicationID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            cmbLicenseClasses.Focus();
            return;
         }


         //check if user already have issued license of the same driving  class.
         //if (.IsLicenseExistByPersonID(ctrlPersonInfoWithFilter1.PersonID, LicenseClassID))
         //{

         //   MessageBox.Show("Person already have a license with the same applied driving class, Choose diffrent driving class", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
         //   return;
         //}

         _LocalApp.ApplicantPersonID = ctrlPersonInfoWithFilter1.PersonID; ;
         _LocalApp.ApplicationDate = DateTime.Now;
         _LocalApp.ApplicationTypeID = 1;
         _LocalApp.ApplicationStatus = clsApplication.enApplicationStatus.New;
         _LocalApp.LastStatusDate = DateTime.Now;
         _LocalApp.PaidFees = Convert.ToSingle(lblFees.Text);
         _LocalApp.CreatedByUserID = clsGlobal.CurrnetUser.UserID;
         _LocalApp.LicenseClassID = LicenseClassID;


         if (_LocalApp.Save())
         {
            lablLocalDrivingLicenseApplicationID.Text = _LocalApp.LocalDrivingLicenseApplicationID.ToString();
            //change form mode to update.
            _Mode = enMode.Update;
            lblTitle.Text = "Update Local Driving License Application";

            MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

         }
         else
            MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



      }
   }
}
