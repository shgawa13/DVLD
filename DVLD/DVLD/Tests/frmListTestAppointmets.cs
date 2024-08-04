﻿using System;
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
   public partial class frmListTestAppointmets : Form
   {
      private int _ApplicationID = -1;
      public frmListTestAppointmets(int ApplicationID)
      {
         InitializeComponent();
         _ApplicationID = ApplicationID;
      }

      private void frmLocalDrivingLicenseApplicationInfo_Load(object sender, EventArgs e)
      {
         ctrlDrivingLicenseApplicationInfo1.LoadApplicationInfoByLocalDrivingAppID(_ApplicationID);
      }

      private void btnSave_Click(object sender, EventArgs e)
      {
         this.Close();
      }

      
   }
}
