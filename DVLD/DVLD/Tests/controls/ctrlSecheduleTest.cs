﻿using Business;
using DVLD.Global_Classes;
using DVLD.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Tests.controls
{
   public partial class ctrlSecheduleTest : UserControl
   {
      public enum enMode { AddNew =0, Update=1}
      private enMode _Mode = enMode.AddNew;

      public enum enCreationMode { FirstTimeSchedule=0, RetakeSchedule = 1}
      private enCreationMode _CreationMode=enCreationMode.FirstTimeSchedule;

      private clsTestType.enTypeTest _TestTypeID = clsTestType.enTypeTest.VisionTest;
      private clsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication;
      private int _LocalDrivingLicenseApplicationID = -1;
      private clsTestAppointment _TestAppointment;
      private int _TestAppointmentID = -1;


      public clsTestType.enTypeTest TestTypeID
      {
         get { return _TestTypeID; }
         set { 
            
            _TestTypeID = value;

            switch (_TestTypeID)
            {

               case clsTestType.enTypeTest.VisionTest:
                  {
                     gbTestType.Text = "Vision Test";
                     pbTestTypeImage.Image = Resources.Vision_512;
                     break;
                  }

               case clsTestType.enTypeTest.WrittenTest:
                  {
                     gbTestType.Text = "Written Test";
                     pbTestTypeImage.Image = Resources.Written_Test_512;
                     break;
                  }
                  

               case clsTestType.enTypeTest.StreetTest:
                  {
                     gbTestType.Text = "Street Test";
                     pbTestTypeImage.Image = Resources.driving_test_512;
                     break;
                  }

            }
         }

      }

      public void LoadInfo(int LocalDrivingLicenseApplicationID, int AppointmentID=-1)
      {
         //if no appointment id this means AddNew mode otherwise it's update mode.
         if (AppointmentID == -1)
            _Mode = enMode.AddNew;
         else
            _Mode = enMode.Update;

         _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
         _TestAppointmentID = AppointmentID;
         _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(_LocalDrivingLicenseApplicationID);

         if (_LocalDrivingLicenseApplication == null)
         {
            MessageBox.Show("Error: No Local Driving License Application with ID = " + _LocalDrivingLicenseApplicationID.ToString(),
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            btnSave.Enabled = false;
            return;
         }
         

         //decide if the createion mode is retake test or not based if the person attended this test before
         if (_LocalDrivingLicenseApplication.DoesAttendTestType(_TestTypeID))

            _CreationMode = enCreationMode.RetakeSchedule;
         else
            _CreationMode = enCreationMode.FirstTimeSchedule;


         if(_CreationMode== enCreationMode.RetakeSchedule)
         {
            lblRetakeFees.Text = clsApplicationTypes.GetApplicationTypeByID((int)clsApplication.enApplicationType.RetakeTest).ApplicationFees.ToString();
            gbRetakeTestInfo.Enabled = true;
            lblTestTitle.Text = "Schedule Retake Test";
            lblRetakeTestAppID.Text = "0";
         }
         else
         {
            gbRetakeTestInfo.Enabled = false;
            lblTestTitle.Text = "Schedule Test";
            lblRetakeFees.Text = "0";
            lblRetakeTestAppID.Text = "N/A";
         }

         lblDLAppID.Text = _LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
         lblDrivingClass.Text = _LocalDrivingLicenseApplication.LicenseClassInfo.ClassName;
         lblFullName.Text = _LocalDrivingLicenseApplication.ApplicantFullName;
         //this will show the trials for this test before  
         lblTrial.Text = _LocalDrivingLicenseApplication.TotalTrialsPerTest(_TestTypeID).ToString();

         if(_Mode == enMode.AddNew)
         {
            lblFees.Text = clsTestType.Find(_TestTypeID).TestTypeFees.ToString();
            dtpTestDate.MinDate = DateTime.Now;
            lblRetakeTestAppID.Text = "N/A";

            _TestAppointment = new clsTestAppointment();

         }
         else
         {
            if (!_LoadTestAppointmentData())
               return;
         }

         lblTotalFees.Text= (Convert.ToSingle(lblFees.Text) + Convert.ToSingle(lblRetakeFees.Text)).ToString();

         if (!_HandleActiveTestAppointmentConstraint())
            return;

         if (!_HandleAppointmentLockedConstraint())
            return;

         if (!_HandlePrviousTestConstraint())
            return;

      }

      private bool _HandleActiveTestAppointmentConstraint()
      {
         if (_Mode == enMode.AddNew && clsLocalDrivingLicenseApplication.IsThereAnActiveScheduledTest(_LocalDrivingLicenseApplicationID, _TestTypeID))
         {
            lblUserMessage.Text = "Person Already have an active appointment for this test";
            btnSave.Enabled = false;
            dtpTestDate.Enabled = false;
            return false;
         }

         return true;
      }

      private bool _LoadTestAppointmentData()
      {

         _TestAppointment = clsTestAppointment.Find(_TestAppointmentID);

         if(_TestAppointment == null)
         {
            MessageBox.Show("Error: No Appointment with ID = " + _TestAppointmentID.ToString(),
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            btnSave.Enabled = false;
            return false;
         }

         lblFees.Text = _TestAppointment.PaidFees.ToString();

         //we compare the current date with the appointment date to set the min date.
         if (DateTime.Compare(DateTime.Now, _TestAppointment.AppointmentDate) < 0)
            dtpTestDate.MinDate = DateTime.Now;
         else
            dtpTestDate.MinDate = _TestAppointment.AppointmentDate;

         dtpTestDate.Value = _TestAppointment.AppointmentDate;

         if (_TestAppointment.RetakeTestApplicationID == -1)
         {
            lblRetakeFees.Text = "0";
            lblRetakeTestAppID.Text = "N/A";
         }
         else
         {
            lblRetakeFees.Text = _TestAppointment.RetakeTestAppInfo.PaidFees.ToString();
            gbRetakeTestInfo.Enabled = true;
            lblTestTitle.Text = "Schedule Retake Test";
            lblRetakeTestAppID.Text = _TestAppointment.RetakeTestApplicationID.ToString();

         }
         return true;
      }

      private bool _HandleAppointmentLockedConstraint()
      {
         //if appointment is locked that means the person already sat for this test
         //we cannot update locked appointment
         if (_TestAppointment.IsLocked)
         {
            lblUserMessage.Visible = true;
            lblUserMessage.Text = "Person already sat for the test, appointment loacked.";
            dtpTestDate.Enabled = false;
            btnSave.Enabled = false;
            return false;

         }
         else
            lblUserMessage.Visible = false;

         return true;
      }

      private bool _HandlePrviousTestConstraint()
      {
         //we need to make sure that this person passed the prvious required test before apply to the new test.
         //person cannno apply for written test unless s/he passes the vision test.
         //person cannot apply for street test unless s/he passes the written test.

         switch (TestTypeID)
         {
            case clsTestType.enTypeTest.VisionTest:
               //in this case no required prvious test to pass.
               lblUserMessage.Visible = false;

               return true;

            case clsTestType.enTypeTest.WrittenTest:
               //Written Test, you cannot sechdule it before person passes the vision test.
               //we check if pass visiontest 1.
               if (!_LocalDrivingLicenseApplication.DoesPassTestType(clsTestType.enTypeTest.VisionTest))
               {
                  lblUserMessage.Text = "Cannot Sechule, Vision Test should be passed first";
                  lblUserMessage.Visible = true;
                  btnSave.Enabled = false;
                  dtpTestDate.Enabled = false;
                  return false;
               }
               else
               {
                  lblUserMessage.Visible = false;
                  btnSave.Enabled = true;
                  dtpTestDate.Enabled = true;
               }


               return true;

            case clsTestType.enTypeTest.StreetTest:

               //Street Test, you cannot sechdule it before person passes the written test.
               //we check if pass Written 2.
               if (!_LocalDrivingLicenseApplication.DoesPassTestType(clsTestType.enTypeTest.WrittenTest))
               {
                  lblUserMessage.Text = "Cannot Sechule, Written Test should be passed first";
                  lblUserMessage.Visible = true;
                  btnSave.Enabled = false;
                  dtpTestDate.Enabled = false;
                  return false;
               }
               else
               {
                  lblUserMessage.Visible = false;
                  btnSave.Enabled = true;
                  dtpTestDate.Enabled = true;
               }


               return true;

         }
         return true;

      }

      private bool _HandleRetakeApplication()
      {
         //this will decide to create a seperate application for retake test or not.
         // and will create it if needed , then it will linkit to the appoinment.
         if (_Mode == enMode.AddNew && _CreationMode == enCreationMode.RetakeSchedule)
         {
            //incase the mode is add new and creation mode is retake test we should create a seperate application for it.
            //then we linke it with the appointment.

            //First Create Applicaiton 
            clsApplication Application = new clsApplication();

            Application.ApplicantPersonID = _LocalDrivingLicenseApplication.ApplicantPersonID;
            Application.ApplicationDate = DateTime.Now;
            Application.ApplicationTypeID = (int)clsApplication.enApplicationType.RetakeTest;
            Application.ApplicationStatus = clsApplication.enApplicationStatus.Completed;
            Application.LastStatusDate = DateTime.Now;
            Application.PaidFees = clsApplicationTypes.GetApplicationTypeByID((int)clsApplication.enApplicationType.RetakeTest).ApplicationFees;
            Application.CreatedByUserID = clsGlobal.CurrnetUser.UserID;

            if (!Application.Save())
            {
               _TestAppointment.RetakeTestApplicationID = -1;
               MessageBox.Show("Faild to Create application", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
               return false;
            }

            _TestAppointment.RetakeTestApplicationID = Application.ApplicationID;

         }
         return true;
      }

      public ctrlSecheduleTest()
      {
         InitializeComponent();
      }

      private void btnSave_Click(object sender, EventArgs e)
      {

         if (!_HandleRetakeApplication())
            return;

         _TestAppointment.TestTypeID = _TestTypeID;
         _TestAppointment.LocalDrivingLicenseApplicationID = _LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID;
         _TestAppointment.AppointmentDate = dtpTestDate.Value;
         _TestAppointment.PaidFees = Convert.ToSingle(lblFees.Text);
         _TestAppointment.CreatedByUserID = clsGlobal.CurrnetUser.UserID;

         if (_TestAppointment.Save())
         {
            _Mode = enMode.Update;
            MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

         }
         else
            MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

      }




   }
}
