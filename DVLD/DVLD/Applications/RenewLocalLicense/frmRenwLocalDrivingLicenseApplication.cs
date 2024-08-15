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
using DVLD.Global_Classes;
using DVLD.Licenses;
using DVLD.Licenses.Local_License;

namespace DVLD.Applications.RenewLocalLicense
{
   public partial class frmRenwLocalDrivingLicenseApplication : Form
   {
      private int _NewLicenseID = -1;
      public frmRenwLocalDrivingLicenseApplication()
      {
         InitializeComponent();
      }

      private void frmRenwLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
      {
         ctrlDriverLicenseInfoWithFilter1.txtLicenseIDFocus();
         lblApplicationDate.Text = DateTime.Now.ToShortDateString();

         lblExpirationDate.Text = "???";
         lblApplicationFees.Text = clsApplicationTypes.GetApplicationTypeByID((int)clsApplication.enApplicationType.RenewDrivingLicense).ApplicationFees.ToString();
         lblCreatedBy.Text = clsGlobal.CurrnetUser.UserName;
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

         int DefaultValidityLength = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.LicenseClassIfo.DefaultValidityLength;
         lblExpirationDate.Text = DateTime.Now.AddYears(DefaultValidityLength).ToShortDateString();
         lblLicenseFees.Text = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.LicenseClassIfo.ClassFees.ToString();
         lblTotalFees.Text = (Convert.ToSingle(lblApplicationFees.Text) + Convert.ToSingle(lblLicenseFees.Text)).ToString();
         txtNotes.Text = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.Notes;


         //check the license is not Expired.
         if (!ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.IsLicenseExpired())
         {
            MessageBox.Show("Selected License is not yet expiared, it will expire on: " + ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.ExpirationDate.ToShortDateString()
                , "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            btnRenew.Enabled = false;
            gbNewApplication.Enabled = false;
            linkShowLicenseInfo.Enabled = false;
            return;
         }

         //check the license is not Expired.
         if (!ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.IsActive)
         {
            MessageBox.Show("Selected License is not Not Active, choose an active license."
                , "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            btnRenew.Enabled = false;
            return;
         }



         btnRenew.Enabled = true;
      }

      private void btnRenew_Click(object sender, EventArgs e)
      {
         if (MessageBox.Show("Are you sure you want to Renew the license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
         {
            return;
         }


         clsLicense NewLicense =
             ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.RenewLicense(txtNotes.Text.Trim(),
             clsGlobal.CurrnetUser.UserID);

         if (NewLicense == null)
         {
            MessageBox.Show("Faild to Renew the License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return;
         }

         lblApplicationID.Text = NewLicense.ApplicationID.ToString();
         _NewLicenseID = NewLicense.LicenseID;
         lblRenewedLicenseID.Text = _NewLicenseID.ToString();
         MessageBox.Show("Licensed Renewed Successfully with ID=" + _NewLicenseID.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);

         btnRenew.Enabled = false;
         ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;
         linkShowLicenseInfo.Enabled = true;

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
           new frmShowLicenseInfo(_NewLicenseID);
         frm.ShowDialog();
      }
   }
}
