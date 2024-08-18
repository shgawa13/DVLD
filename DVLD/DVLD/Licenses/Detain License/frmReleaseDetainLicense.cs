﻿using Business;
using DVLD.Global_Classes;
using DVLD.Licenses.Local_License;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Licenses.Detain_License
{
   public partial class frmReleaseDetainLicense : Form
   {
      private int _SelectedLicenseID = -1;

      public frmReleaseDetainLicense()
      {
         InitializeComponent();
      }

      public frmReleaseDetainLicense(int LicenseID)
      {
         InitializeComponent();
         _SelectedLicenseID = LicenseID;

         ctrlDriverLicenseInfoWithFilter1.LoadLicenseInfo(_SelectedLicenseID);
         ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;
      }

      private void ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected(int obj)
      {
         _SelectedLicenseID = obj;

         lblLicenseID.Text = _SelectedLicenseID.ToString();

         linkLicenseHistory.Enabled = (_SelectedLicenseID != -1);

         if (_SelectedLicenseID == -1)

         {
            return;
         }

         //ToDo: make sure the license is not detained already.
         if (!ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.IsDetained)
         {
            MessageBox.Show("Selected License i is not detained, choose another one.", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
         }

         lblApplicationFees.Text = clsApplicationTypes.GetApplicationTypeByID((int)clsApplication.enApplicationType.ReleaseDetainedDrivingLicsense).ApplicationFees.ToString();
         lblCreatedBy.Text = clsGlobal.CurrnetUser.UserName;

         lblDetainID.Text = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DetainedInfo.DetainID.ToString();
         lblLicenseID.Text = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.LicenseID.ToString();

         lblCreatedBy.Text = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DetainedInfo.CreatedByUserInfo.UserName;
         lblDetainDate.Text = (ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DetainedInfo.DetainDate).ToShortDateString();
         lblFineFees.Text = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DetainedInfo.FineFees.ToString();
         lblTotalFees.Text = (Convert.ToSingle(lblApplicationFees.Text) + Convert.ToSingle(lblFineFees.Text)).ToString();

         btnRelease.Enabled = true;
      }

      private void linkLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
      {
         frmShowPersonLicenseHistory frm =
              new frmShowPersonLicenseHistory(ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DriverInfo.PersonID);
         frm.ShowDialog();
      }

      private void linkShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
      {
         frmShowLicenseInfo frm =
            new frmShowLicenseInfo(_SelectedLicenseID);
         frm.ShowDialog();
      }

      private void btnRelease_Click(object sender, EventArgs e)
      {
         if (MessageBox.Show("Are you sure you want to release this detained  license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
         {
            return;
         }

         int ApplicationID = -1;


         bool IsReleased = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.ReleaseDetainedLicense(clsGlobal.CurrnetUser.UserID, ref ApplicationID); ;

         lblApplicationID.Text = ApplicationID.ToString();

         if (!IsReleased)
         {
            MessageBox.Show("Faild to to release the Detain License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
         }

         MessageBox.Show("Detained License released Successfully ", "Detained License Released", MessageBoxButtons.OK, MessageBoxIcon.Information);

         btnRelease.Enabled = false;
         ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;
         linkShowLicenseInfo.Enabled = true;
      }
   }
}
