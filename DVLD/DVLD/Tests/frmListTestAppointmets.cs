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

namespace DVLD.Applications.LocalDrivingLicenseApplication
{
   public partial class frmListTestAppointmets : Form
   {
      private DataTable _dtLicenseTestAppointments;
      private int _LocalDrivingLicenseApplicationID = -1;
      private clsTestType.enTypeTest _TestType = clsTestType.enTypeTest.VisionTest;

      public frmListTestAppointmets(int LocalDrivingLicenseApplicationID,clsTestType.enTypeTest TestType)
      {
         InitializeComponent();
         _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
         _TestType = TestType;
      }

      private void frmLocalDrivingLicenseApplicationInfo_Load(object sender, EventArgs e)
      {
         ctrlDrivingLicenseApplicationInfo1.LoadApplicationInfoByLocalDrivingAppID(_LocalDrivingLicenseApplicationID);
         _dtLicenseTestAppointments = clsTestAppointment.GetApplicationTestAppointmentsPerTestType(_LocalDrivingLicenseApplicationID, _TestType);

         dgvTestAppointments.DataSource = _dtLicenseTestAppointments.DefaultView;
      }

      private void btnSave_Click(object sender, EventArgs e)
      {
         this.Close();
      }

      
   }
}
