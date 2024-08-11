﻿using Business;
using DVLD.Properties;
using DVLD.Tests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Applications.LocalDrivingLicenseApplication
{
   public partial class frmListTestAppointments : Form
   {
      private DataTable _dtLicenseTestAppointments;
      private int _LocalDrivingLicenseApplicationID = -1;
      private clsTestType.enTypeTest _TestType = clsTestType.enTypeTest.VisionTest;

      public frmListTestAppointments(int LocalDrivingLicenseApplicationID,clsTestType.enTypeTest TestType)
      {
         InitializeComponent();
         _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
         _TestType = TestType;
      }

      private void _LoadTestTypeImageAndTitle()
      {

         switch (_TestType)
         {

            case clsTestType.enTypeTest.VisionTest:
               {
                  lblTitle.Text = "Vision Test Appointments";
                  this.Text = lblTitle.Text;
                  pbTestTypeImage.Image = Resources.Vision_512;
                  break;
               }

            case clsTestType.enTypeTest.WrittenTest:
               {
                  lblTitle.Text = "Written Test Appointments";
                  this.Text = lblTitle.Text;
                  pbTestTypeImage.Image = Resources.Written_Test_512;
                  break;
               }
            case clsTestType.enTypeTest.StreetTest:
               {
                  lblTitle.Text = "Street Test Appointments";
                  this.Text = lblTitle.Text;
                  pbTestTypeImage.Image = Resources.driving_test_512;
                  break;
               }
         }

      }



      private void frmListTestAppointments_Load(object sender, EventArgs e)
      {

         _LoadTestTypeImageAndTitle();

         ctrlDrivingLicenseApplicationInfo1.LoadApplicationInfoByLocalDrivingAppID(_LocalDrivingLicenseApplicationID);
         _dtLicenseTestAppointments = clsTestAppointment.GetApplicationTestAppointmentsPerTestType(_LocalDrivingLicenseApplicationID, _TestType);

         dgvTestAppointments.DataSource = _dtLicenseTestAppointments.DefaultView;
         lblRecordsCount.Text = _dtLicenseTestAppointments.Rows.Count.ToString();

         if (dgvTestAppointments.Rows.Count > 0)
         {
            dgvTestAppointments.Columns[0].HeaderText = "Appointment ID";
            dgvTestAppointments.Columns[0].Width = 150;

            dgvTestAppointments.Columns[1].HeaderText = "Appointment Date";
            dgvTestAppointments.Columns[1].Width = 200;

            dgvTestAppointments.Columns[2].HeaderText = "Paid Fees";
            dgvTestAppointments.Columns[2].Width = 150;

            dgvTestAppointments.Columns[3].HeaderText = "Is Locked";
            dgvTestAppointments.Columns[3].Width = 100;
         }

      }
      

      private void btnSave_Click(object sender, EventArgs e)
      {
         this.Close();
      }

      private void btnAddAppointment_Click(object sender, EventArgs e)
      {

         clsLocalDrivingLicenseApplication localDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(_LocalDrivingLicenseApplicationID);


         if (localDrivingLicenseApplication.IsThereAnActiveScheduledTest(_TestType))
         {
            MessageBox.Show("Person Already have an active appointment for this test, You cannot add new appointment", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
         }



         //---
         clsTest LastTest = localDrivingLicenseApplication.GetLastTestPerTestType(_TestType);

         if (LastTest == null)
         {
            frmScheduleTest frm1 = new frmScheduleTest(_LocalDrivingLicenseApplicationID, _TestType);
            frm1.ShowDialog();
            frmListTestAppointments_Load(null, null);
            return;
         }

         //if person already passed the test s/he cannot retak it.
         if (LastTest.TestResult == true)
         {
            MessageBox.Show("This person already passed this test before, you can only retake faild test", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
         }

         frmScheduleTest frm2 = new frmScheduleTest
             (LastTest.TestAppointmentInfo.LocalDrivingLicenseApplicationID, _TestType);
         frm2.ShowDialog();
         frmListTestAppointments_Load(null, null);
         //---

      }

      private void editToolStripMenuItem_Click(object sender, EventArgs e)
      {
         int TestAppointmentID = (int)dgvTestAppointments.CurrentRow.Cells[0].Value;


         frmScheduleTest frm = new frmScheduleTest(_LocalDrivingLicenseApplicationID, _TestType, TestAppointmentID);
         frm.ShowDialog();
         frmListTestAppointments_Load(null, null);
      }

      private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
      {
         int TestAppointmentID = (int)dgvTestAppointments.CurrentRow.Cells[0].Value;

         frmTakeTest frm = new frmTakeTest(TestAppointmentID, _TestType);
         frm.ShowDialog();
         frmListTestAppointments_Load(null, null);
      }




   }
}
