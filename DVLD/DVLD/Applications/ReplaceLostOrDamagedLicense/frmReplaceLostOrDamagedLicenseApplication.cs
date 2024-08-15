using Business;
using DVLD.Global_Classes;
using DVLD.Licenses;
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
using static Business.clsLicense;

namespace DVLD.Applications.ReplaceLostOrDamagedLicense
{
   public partial class frmReplaceLostOrDamagedLicenseApplication : Form
   {
      private int _NewLicenseID = -1;
      public frmReplaceLostOrDamagedLicenseApplication()
      {
         InitializeComponent();
      }

      private int _GetApplicationTypeID()
      {
         //this will decide which application type to use accirding 
         // to user selection.

         if (rbDamagedLicense.Checked)

            return (int)clsApplication.enApplicationType.ReplaceDamagedDrivingLicense;
         else
            return (int)clsApplication.enApplicationType.ReplaceLostDrivingLicense;
      }

      private enIssueReason _GetIssueReason()
      {
         //this will decide which reason to issue a replacement for

         if (rbDamagedLicense.Checked)

            return enIssueReason.DamagedReplacement;
         else
            return enIssueReason.LostReplacement;
      }


      private void frmReplaceLostOrDamagedLicenseApplication_Load(object sender, EventArgs e)
      {

         lblApplicationDate.Text = DateTime.Now.ToShortDateString();
         lblCreatedBy.Text = clsGlobal.CurrnetUser.UserName;

         rbDamagedLicense.Checked = true;
      }

      private void linkShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
      {
         frmShowLicenseInfo frm =
                new frmShowLicenseInfo(_NewLicenseID);
         frm.ShowDialog();
      }

      private void linkLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
      {
         frmShowPersonLicenseHistory frm =
            new frmShowPersonLicenseHistory(ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DriverInfo.PersonID);
         frm.ShowDialog();
      }

      private void rbDamagedLicense_CheckedChanged(object sender, EventArgs e)
      {
         lblTitle.Text = "Replacement for Damaged License";
         this.Text = lblTitle.Text;
         lblApplicationFees.Text = clsApplicationTypes.GetApplicationTypeByID(_GetApplicationTypeID()).ApplicationFees.ToString();
      }

      private void rbLostLicense_CheckedChanged(object sender, EventArgs e)
      {
         lblTitle.Text = "Replacement for Lost License";
         this.Text = lblTitle.Text;
         lblApplicationFees.Text = clsApplicationTypes.GetApplicationTypeByID(_GetApplicationTypeID()).ApplicationFees.ToString();
      }

      private void ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected(int obj)
      {
         int SelectedLicenseID = obj;
         lblOldLicenseID.Text = SelectedLicenseID.ToString();
         linkLicenseHistory.Enabled = (SelectedLicenseID != -1);

         if (SelectedLicenseID == -1)
         {
            return;
         }

         //dont allow a replacement if is Active .
         if (!ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.IsActive)
         {
            MessageBox.Show("Selected License is not Not Active, choose an active license."
                , "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            btnIssueReplacement.Enabled = false;
            return;
         }

         btnIssueReplacement.Enabled = true;
      }

      private void btnIssueReplacement_Click(object sender, EventArgs e)
      {
         if (MessageBox.Show("Are you sure you want to Issue a Replacement for the license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
         {
            return;
         }


         clsLicense NewLicense =
            ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.Replace(_GetIssueReason(),
            clsGlobal.CurrnetUser.UserID);

         if (NewLicense == null)
         {
            MessageBox.Show("Faild to Issue a replacemnet for this  License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return;
         }

       //  lblApplicationID.Text = NewLicense.ApplicationID.ToString();
         _NewLicenseID = NewLicense.LicenseID;

         lblReplacementAppID.Text = _NewLicenseID.ToString();
         MessageBox.Show("Licensed Replaced Successfully with ID=" + _NewLicenseID.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);

         btnIssueReplacement.Enabled = false;
         gbReplacementFor.Enabled = false;
         ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;
         linkShowLicenseInfo.Enabled = true;

      }
   }
}
