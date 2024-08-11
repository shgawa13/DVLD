﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using System.IO;
using DVLD.Properties;

namespace DVLD.Licenses.Local_License.controls
{
   public partial class ctrlDriverLicenseInfo : UserControl
   {
      private int _LicenseID;
      private clsLicense _License;
      public ctrlDriverLicenseInfo()
      {
         InitializeComponent();
      }

      public int LicenseID
      {
         get { return _LicenseID; }
      }

      public clsLicense SelectedLicenseInfo
      {
         get { return _License; }
      }

      private void _LoadPersonImage()
      {
         if (_License.DriverInfo.PersonInfo.Gendor == 0)
            pbPersonImage.Image = Resources.Male_avatar;
         else
            pbPersonImage.Image = Resources.Female_avatar;

         string ImagePath = _License.DriverInfo.PersonInfo.ImagePath;

         if (ImagePath != "")
            if (File.Exists(ImagePath))
               pbPersonImage.Load(ImagePath);
            else
               MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

      }

      public void LoadInfo(int LicenseID)
      {
         _LicenseID = LicenseID;
         _License = clsLicense.Find(_LicenseID);
         if (_License == null)
         {
            MessageBox.Show("Could not find License ID = " + _LicenseID.ToString(),
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            _LicenseID = -1;
            return;
         }

         lblLicenseID.Text = _License.LicenseID.ToString();
         lblIsActive.Text = _License.IsActive ? "Yes" : "No";
         lblIsDetained.Text = _License.IsDetained ? "Yes" : "No";
         lblClass.Text = _License.LicenseClassIfo.ClassName;
         lblName.Text = _License.DriverInfo.PersonInfo.FullName;
         lblNatonalNo.Text = _License.DriverInfo.PersonInfo.NationalNo;
         lblGendor.Text = _License.DriverInfo.PersonInfo.Gendor == 0 ? "Male" : "Female";
         lblDateOfBirth.Text = (_License.DriverInfo.PersonInfo.DateOfBirth).ToShortDateString();

         lblDriverID.Text = _License.DriverID.ToString();
         lblDateIssue.Text = (_License.IssueDate).ToShortDateString();
         lblExpirationDate.Text = (_License.ExpirationDate).ToShortDateString();
         lblIssueReson.Text = _License.IssueReasonText;
         lblNotes.Text = _License.Notes == "" ? "No Notes" : _License.Notes;
         _LoadPersonImage();



      }
   }
}