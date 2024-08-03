using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Applications.LocalDrivingLicenseApplication.controls
{
   public partial class ctrlDrivingLicenseApplicationInfo : UserControl
   {

      private clsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication;
      private int _LocalDrivingLicenseApplicationID =-1;
      private int _LicenseID;

      public int LocalDrivingLicenseApplicationID
      {
        get { return _LocalDrivingLicenseApplicationID; }
      }

      public ctrlDrivingLicenseApplicationInfo()
      {
         InitializeComponent();
      }

      public void LoadApplicationInfoByLocalDrivingAppID(int LocalDrivingLicenseApplicationID)
      {
         _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(LocalDrivingLicenseApplicationID);

         if (_LocalDrivingLicenseApplication == null)
         {
           // _ResetLocalDrivingLicenseApplicationInfo();


            MessageBox.Show($"No Application with ApplicationID = {LocalDrivingLicenseApplicationID}" , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
         }

          _FillDrivingLicenseApplicationInfo();
      }

      public void LoadApplicationInfoByApplicationID(int ApplicationID)
      {
         _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByApplicationID(ApplicationID);

         if (_LocalDrivingLicenseApplication == null)
         {
            // _ResetLocalDrivingLicenseApplicationInfo();


            MessageBox.Show($"No Application with ApplicationID = {ApplicationID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
         }

          _FillDrivingLicenseApplicationInfo();

      }

      private void _FillDrivingLicenseApplicationInfo()
      {

         _LocalDrivingLicenseApplicationID = _LocalDrivingLicenseApplication.ApplicationID;
         lblDrivingAppID.Text = _LocalDrivingLicenseApplicationID.ToString();
         lblLicenseTypeName.Text = clsLicenseClass.FindLicenseClassByID(_LocalDrivingLicenseApplication.LicenseClassID).ClassName;
         lblPassedTest.Text = $"[ {_LocalDrivingLicenseApplication.GetPassedTestCount()} - 3 ]";
         ctrlApplicationBasicInfo1.LoadApplicationBasicInfo(_LocalDrivingLicenseApplication.ApplicationID);

      }

      private void _ResetLocalDrivingLicenseApplicationInfo()
      {

         _LocalDrivingLicenseApplicationID = -1;
         lblDrivingAppID.Text = "[????]";
         lblLicenseTypeName.Text = "[????]";
         lblPassedTest.Text = "[????]";
         

      }

      

      //private void llShowLicenceInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
      //{
      //   frmShowLicenseInfo frm = new frmShowLicenseInfo(_LocalDrivingLicenseApplication.GetActiveLicenseID());
      //   frm.ShowDialog();

      //}
   }
}
