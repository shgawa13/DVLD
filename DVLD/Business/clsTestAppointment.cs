using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
   public class clsTestAppointment
   {

      public enum enMode { AddNew =0, Update = 1 }
      public enMode Mode = enMode.AddNew;

      public int TestAppointmentID { set; get; }
      public clsTestType.enTypeTest TestTypeID { set; get; }
      public int LocalDrivingLicenseApplicationID { set; get; }
      public DateTime AppointmentDate { set; get; }
      public float PaidFees { set; get; }
      public int CreatedByUserID { set; get; }
      public bool IsLocked { set; get; }
      public int RetakeTestApplicationID { set; get; }
      public clsApplication RetakeTestAppInfo { set; get; }

      public int TestID;


      public clsTestAppointment()
      {
         this.TestAppointmentID = -1;
         this.TestTypeID = clsTestType.enTypeTest.VisionTest;
         this.AppointmentDate = DateTime.Now;
         this.PaidFees = 0;
         this.CreatedByUserID = -1;
         this.RetakeTestApplicationID = -1;

         Mode = enMode.AddNew;
      }

      private clsTestAppointment(int TestAppointmentID, clsTestType.enTypeTest TestTypeID,
           int LocalDrivingLicenseApplicationID, DateTime AppointmentDate, float PaidFees,
           int CreatedByUserID, bool IsLocked, int RetakeTestApplicationID)
      {
         this.TestAppointmentID = TestAppointmentID;
         this.TestTypeID = TestTypeID;
         this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
         this.AppointmentDate = AppointmentDate;
         this.PaidFees = PaidFees;
         this.CreatedByUserID = CreatedByUserID;
         this.IsLocked = IsLocked;
         this.RetakeTestApplicationID = RetakeTestApplicationID;
         this.RetakeTestAppInfo = clsApplication.FindBaseApplication(RetakeTestApplicationID);

         Mode = enMode.Update;
      }

      private bool _AddNewTestAppointment()
      {
         int TestAppointmentID = -1;

        
      }

     


   }
}
