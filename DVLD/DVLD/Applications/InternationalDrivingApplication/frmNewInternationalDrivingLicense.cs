﻿using Business;
using DVLD.Global_Classes;
using DVLD.Licenses;
using DVLD_Buisness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Applications.InternationalDrivingApplication
{
   public partial class frmNewInternationalDrivingLicense : Form
   {
      private int _InternationalLicenseID = -1;
      public frmNewInternationalDrivingLicense()
      {
         InitializeComponent();
      }

      private void ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected(int obj)
      {
         int SelectedLicenseID = obj;

         lblLocalLicenseID.Text = SelectedLicenseID.ToString();

         linkShowLicenseHistory.Enabled = (SelectedLicenseID != -1);

         if (SelectedLicenseID == -1)

         {
            return;
         }




         //check the license class, person could not issue international license without having
         //normal license of class 3.

         if (ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.LicenseClass != 3)
         {
            MessageBox.Show("Selected License should be Class 3, select another one.", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
         }

         //check if person already have an active international license
         int ActiveInternaionalLicenseID = clsInternationalLicense.GetActiveInternationalLicenseIDByDriverID(ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DriverID);

         if (ActiveInternaionalLicenseID != -1)
         {
            MessageBox.Show("Person already have an active international license with ID = " + ActiveInternaionalLicenseID.ToString(), "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            linkShowLicenseInfo.Enabled = true;
            _InternationalLicenseID = ActiveInternaionalLicenseID;
            btnIssueLicense.Enabled = false;
            return;
         }

         btnIssueLicense.Enabled = true;

      }

      private void frmNewInternationalDrivingLicense_Load(object sender, EventArgs e)
      {

         lblApplicationDate.Text = (DateTime.Now).ToShortDateString();
         lblIssueDate.Text = lblApplicationDate.Text;
         lblExpirationDate.Text = (DateTime.Now.AddYears(1)).ToShortDateString();//add one year.
         lblFees.Text = clsApplicationTypes.GetApplicationTypeByID((int)clsApplication.enApplicationType.NewInternationalLicense).ApplicationFees.ToString();
         lblCreatedBy.Text = clsGlobal.CurrnetUser.UserName;

      }

      private void btnIssueLicense_Click(object sender, EventArgs e)
      {

         if (MessageBox.Show("Are you sure you want to issue the license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
         {
            return;
         }






         clsInternationalLicense InternationalLicense = new clsInternationalLicense();
         //those are the information for the base application, because it inhirts from application, they are part of the sub class.

         InternationalLicense.ApplicantPersonID = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DriverInfo.PersonID;
         InternationalLicense.ApplicationDate = DateTime.Now;
         InternationalLicense.ApplicationStatus = clsApplication.enApplicationStatus.Completed;
         InternationalLicense.LastStatusDate = DateTime.Now;
         InternationalLicense.PaidFees = clsApplicationTypes.GetApplicationTypeByID((int)clsApplication.enApplicationType.NewInternationalLicense).ApplicationFees;
         InternationalLicense.CreatedByUserID = clsGlobal.CurrnetUser.UserID;


         InternationalLicense.DriverID = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DriverID;
         InternationalLicense.IssuedUsingLocalLicenseID = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.LicenseID;
         InternationalLicense.IssueDate = DateTime.Now;
         InternationalLicense.ExpirationDate = DateTime.Now.AddYears(1);

         InternationalLicense.CreatedByUserID = clsGlobal.CurrnetUser.UserID;

         if (!InternationalLicense.Save())
         {
            MessageBox.Show("Faild to Issue International License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return;
         }

         lblApplicationID.Text = InternationalLicense.ApplicationID.ToString();
         _InternationalLicenseID = InternationalLicense.InternationalLicenseID;
         lblInternationalLicenseID.Text = InternationalLicense.InternationalLicenseID.ToString();
         MessageBox.Show("International License Issued Successfully with ID=" + InternationalLicense.InternationalLicenseID.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);

         btnIssueLicense.Enabled = false;
         ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;
         linkShowLicenseInfo.Enabled = true;

      }

      private void linkShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
      {
         frmShowPersonLicenseHistory frm =
                 new frmShowPersonLicenseHistory(ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DriverInfo.PersonID);
         frm.ShowDialog();
      }

      private void linkShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
      {
         frmShowInternationalLicenseInfo frm =
               new frmShowInternationalLicenseInfo(_InternationalLicenseID);
         frm.ShowDialog();
      }

      private void frmNewInternationalDrivingLicense_Activated(object sender, EventArgs e)
      {
         ctrlDriverLicenseInfoWithFilter1.txtLicenseIDFocus();
      }
   }
}