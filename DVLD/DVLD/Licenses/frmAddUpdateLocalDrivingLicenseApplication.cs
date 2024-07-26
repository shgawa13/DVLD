using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Licenses
{
   public partial class frmAddUpdateLocalDrivingLicenseApplication : Form
   {
      public enum enMode { AddNew =0, Update=1}
      private enMode _Mode = enMode.AddNew;
      private int _PersonID;

      public frmAddUpdateLocalDrivingLicenseApplication()
      {
         InitializeComponent();
         _Mode = enMode.AddNew;
      }

      public frmAddUpdateLocalDrivingLicenseApplication(int PersonID)
      {
         InitializeComponent();
         _PersonID = PersonID;
         _Mode = enMode.AddNew;
      }



   }
}
