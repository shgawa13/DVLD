using Business;
using DVLD.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Tests.controls
{
   public partial class ctrlScheduleTest : UserControl
   {
      public enum enMode { AddNew =0, Update=1}
      private enMode _Mode = enMode.AddNew;
      public enum enCreationMode { FirstTimeSchedule=0, RetakeSchedule = 1}
      private enCreationMode _CreationMode=enCreationMode.FirstTimeSchedule;

      private clsTestType.enTypeTest _TestTypeID = clsTestType.enTypeTest.VisionTest;
      private clsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication;
      private int _LocalDrivingLicenseApplicationID = -1;
      private clsTestAppointment _TestAppointment;
      private int _TestAppointmentID = -1;

      public clsTestType.enTypeTest TestTypeID
      {
         get { return _TestTypeID; }
         set { 
            
            _TestTypeID = value;

            switch (_TestTypeID)
            {

               case clsTestType.enTypeTest.VisionTest:
                  {
                     gbTestType.Text = "Vision Test";
                     pbTestTypeImage.Image = Resources.Vision_512;
                     break;
                  }

               case clsTestType.enTypeTest.WrittenTest:
                  {
                     gbTestType.Text = "Written Test";
                     pbTestTypeImage.Image = Resources.Written_Test_512;
                     break;
                  }


               case clsTestType.enTypeTest.StreetTest:
                  {
                     gbTestType.Text = "Street Test";
                     pbTestTypeImage.Image = Resources.driving_test_512;
                     break;
                  }




            }
         }

      }

      public ctrlScheduleTest()
      {
         InitializeComponent();
      }

      //public clsTestType.enTypeTest TestTypeID()
      //{

      //}
   }
}
