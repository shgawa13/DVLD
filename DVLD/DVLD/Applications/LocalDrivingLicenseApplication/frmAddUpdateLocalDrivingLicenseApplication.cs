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
using DVLD.Global_Classes;
namespace DVLD.Licenses
{
   public partial class frmAddUpdateLocalDrivingLicenseApplication : Form
   {
      public enum enMode { AddNew =0, Update=1}
      private enMode _Mode = enMode.AddNew;
      private int _LocalDrivingLicenseApplicationID = -1;
      private int _SelectedPersonID = -1;
      clsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication;

      public frmAddUpdateLocalDrivingLicenseApplication()
      {
         InitializeComponent();
         _Mode = enMode.AddNew;
      }

      public frmAddUpdateLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID)
      {
         InitializeComponent();
         _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
         _Mode = enMode.Update;
      }


      private void _ResetDefualtValues()
      {
         _FillLicenseClassesInComboBox();
         if (_Mode == enMode.AddNew)
         {
            lblTitle.Text = "New Local Driving License Application";
            this.Text = "New Local Driving License Application";
            _LocalDrivingLicenseApplication = new clsLocalDrivingLicenseApplication();
            ctrlPersonInfoWithFilter1.Focus();
            tabApplicationInfo.Enabled = false;

            cbLicenseClasses.SelectedIndex = 2;
            lblApplicationFees.Text = clsApplicationTypes.GetApplicationTypeByID((int)clsApplication.enApplicationType.NewDrivingLicense).ApplicationFees.ToString();
            lblApplicationDate.Text = DateTime.Now.ToShortDateString();
            lblCreatedByUser.Text = clsGlobal.CurrnetUser.UserName;

         }
         else
         {
            lblTitle.Text = "Update Local Driving License Application";
            this.Text = "Update Local Driving License Application";

            tabApplicationInfo.Enabled = true;
            btnSave.Enabled = true;
         }
         

      }

      private void _LoadData()
      {
         ctrlPersonInfoWithFilter1.FilterEnable = false;
         _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(_LocalDrivingLicenseApplicationID);

         if(_LocalDrivingLicenseApplication == null)
         {
            MessageBox.Show("No Application with ID = " + _LocalDrivingLicenseApplicationID, "Application Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.Close();

            return;
         }

         // Filling UserInfo
         ctrlPersonInfoWithFilter1.LoadPersonInfo(_LocalDrivingLicenseApplication.ApplicantPersonID);
         lblApplicationID.Text = _LocalDrivingLicenseApplication.ApplicationID.ToString();
         lblApplicationDate.Text = _LocalDrivingLicenseApplication.ApplicationDate.ToString();
         cbLicenseClasses.SelectedIndex = cbLicenseClasses.FindString(clsLicenseClass.FindLicenseClassByID(_LocalDrivingLicenseApplication.LicenseClassID).ClassName);
         lblApplicationFees.Text = _LocalDrivingLicenseApplication.PaidFees.ToString();
         lblCreatedByUser.Text = clsUsers.FindByUserID(_LocalDrivingLicenseApplication.CreatedByUserID).UserName;

      }


      private void _FillLicenseClassesInComboBox()
      {
         DataTable dtLicenseClasses = clsLicenseClass.GetAllLicenseClasses();

         if(dtLicenseClasses != null)
         {
            foreach(DataRow row in dtLicenseClasses.Rows)
            {
               cbLicenseClasses.Items.Add(row["ClassName"]);
            }
         }
         cbLicenseClasses.SelectedIndex = 0;
      }

      private void ctrlPersonInfoWithFilter1_OnPersonSelected(int obj)
      {
         if(obj != -1)
         {

            _SelectedPersonID = obj;
            btnNext.Enabled = true;
            tabApplicationInfo.Enabled = true;
            
         }
      }

      private void frmAddUpdateLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
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
            tabApplicationInfo.Enabled = true;
            tabApplication.SelectedTab = tabApplication.TabPages["tabApplicationInfo"];
            return;
         }

         // in case add new Application
         if(ctrlPersonInfoWithFilter1.PersonID != -1)
         {

            btnSave.Enabled = true;
            tabApplicationInfo.Enabled = true;
            tabApplication.SelectedTab = tabApplication.TabPages["tabApplicationInfo"];

         }
         else
         {

            MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
            ctrlPersonInfoWithFilter1.FilterFocus();

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

         int LicenseClassID = clsLicenseClass.FindLicenseClassByName(cbLicenseClasses.Text).LicenseClassID;

         int ActiveApplicationID = clsApplication.GetActiveApplicationIDForLicenseClass(_SelectedPersonID, clsApplication.enApplicationType.NewDrivingLicense, LicenseClassID);

         if (ActiveApplicationID != -1)
         {
            MessageBox.Show("Choose another License Class, the selected Person Already have an active application for the selected class with id=" + ActiveApplicationID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            cbLicenseClasses.Focus();
            return;
         }

         //check if user already have issued license of the same driving  class.
         if (clsLicense.IsLicenseExistByPersonID(ctrlPersonInfoWithFilter1.PersonID, LicenseClassID))
         {

            MessageBox.Show("Person already have a license with the same applied driving class, Choose diffrent driving class", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
         }

         // now we Fill the opject 
         _LocalDrivingLicenseApplication.ApplicantPersonID = ctrlPersonInfoWithFilter1.PersonID; ;
         _LocalDrivingLicenseApplication.ApplicationDate = DateTime.Now;
         _LocalDrivingLicenseApplication.ApplicationTypeID = 1;
         _LocalDrivingLicenseApplication.ApplicationStatus = clsApplication.enApplicationStatus.New;
         _LocalDrivingLicenseApplication.LastStatusDate = DateTime.Now;
         _LocalDrivingLicenseApplication.PaidFees = Convert.ToSingle(lblApplicationFees.Text);
         _LocalDrivingLicenseApplication.CreatedByUserID = clsGlobal.CurrnetUser.UserID;
         _LocalDrivingLicenseApplication.LicenseClassID = LicenseClassID;



         // here we can save the the application

         if (_LocalDrivingLicenseApplication.Save())
         {
            lblApplicationID.Text = _LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
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
