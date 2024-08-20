﻿using System;
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
   public partial class frmShowInternationalLicenseInfo : Form
   {
      private int _InternationalLicenseID;
      public frmShowInternationalLicenseInfo(int InternationalLicenseID)
      {
         InitializeComponent();
         _InternationalLicenseID = InternationalLicenseID;
      }

      private void frmShowInternationalLicenseInfo_Load(object sender, EventArgs e)
      {
         ctrlInternationalLicenseInfo1.LoadInfo(_InternationalLicenseID);
      }
   }
}
