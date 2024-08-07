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

namespace DVLD.Tests
{
   //frmScheduleTest
   public partial class frmScheduleTest : Form
   {
      private int _LocalDrivingLicenseApplicationID = -1;
      private clsTestType.enTypeTest _TestType = clsTestType.enTypeTest.VisionTest;
      private int _AppointmentID = -1;

      public frmScheduleTest(int LocalDrivingLicenseApplicationID,clsTestType.enTypeTest TestType, int AppointmentID =-1)
      {
         InitializeComponent();
         _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
         _TestType = TestType;
         _AppointmentID = AppointmentID;
      }

      private void frmScheduleTest_Load(object sender, EventArgs e)
      {
         ctrlScheduleTest1.TestTypeID = _TestType;
         ctrlScheduleTest1.LoadInfo(_LocalDrivingLicenseApplicationID, _AppointmentID);
      }

      
   }
}
