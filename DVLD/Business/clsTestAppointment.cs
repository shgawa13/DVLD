﻿using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
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

      public int TestID
      {
         get { return _GetTestID(); }
      }


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

         TestAppointmentID = clsTestAppointmentData.AddNewTestAppointment(
            (int)this.TestTypeID, this.LocalDrivingLicenseApplicationID, this.AppointmentDate, this.PaidFees, this.CreatedByUserID
            ,this.RetakeTestApplicationID);

         return (TestAppointmentID != -1);
      }

      private bool _UpdateTestAppointment()
      {
         return clsTestAppointmentData.UpdateTestAppointment(this.TestAppointmentID, (int)this.TestTypeID,
            this.LocalDrivingLicenseApplicationID, this.AppointmentDate, this.PaidFees, this.CreatedByUserID,
            this.IsLocked, this.RetakeTestApplicationID);
      }

      public static clsTestAppointment Find(int TestAppointmentID)
      {
         bool IsFound = false;

         int TestTypeID =-1, LocalDrivingLicenseApplicationID =-1,
            CreatedByUserID =-1,RetakeTestApplicationID = -1;
         DateTime AppointmentDate = DateTime.Now;
         float PaidFees = 0; 
         bool IsLocked = false;

         IsFound = clsTestAppointmentData.GetTestAppointmentInfoByID(TestAppointmentID, ref TestTypeID,
            ref LocalDrivingLicenseApplicationID, ref AppointmentDate, ref PaidFees, ref CreatedByUserID,
            ref IsLocked, ref RetakeTestApplicationID);

         if (IsFound)
            return new clsTestAppointment(TestAppointmentID, (clsTestType.enTypeTest)TestTypeID, LocalDrivingLicenseApplicationID,
               AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID);
         else
            return null;

      }

      public static clsTestAppointment GetLastTestAppointment(int LocalDrivingLicenseApplicationID, clsTestType.enTypeTest TestTypeID)
      {
         bool IsFound = false;

         int TestAppointmentID =-1, CreatedByUserID = -1, RetakeTestApplicationID = -1;
         DateTime AppointmentDate = DateTime.Now;
         float PaidFees = 0;
         bool IsLocked = false;

         IsFound = clsTestAppointmentData.GetLastTestAppointment(LocalDrivingLicenseApplicationID,(int)TestTypeID,
            ref TestAppointmentID, ref AppointmentDate, ref PaidFees, ref CreatedByUserID, ref IsLocked,
            ref RetakeTestApplicationID);

         if (IsFound)
            return new clsTestAppointment(TestAppointmentID, (clsTestType.enTypeTest)TestTypeID, LocalDrivingLicenseApplicationID,
               AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID);
         else
            return null;

      }

      public static DataTable GetAllTestAppointments()
      {
         return clsTestAppointmentData.GetAllTestAppointments();
      }

      public DataTable GetApplicationTestAppointmentsPerTestType(clsTestType.enTypeTest TestTypeID)
      {
         return clsTestAppointmentData.GetApplicationTestAppointmentsPerTestType(this.LocalDrivingLicenseApplicationID, (int)TestTypeID);
      }



      public static DataTable GetApplicationTestAppointmentsPerTestType(int LocalDrivingLicenseApplicationID, clsTestType.enTypeTest TestTypeID)
      {
         return clsTestAppointmentData.GetApplicationTestAppointmentsPerTestType(LocalDrivingLicenseApplicationID, (int)TestTypeID);

      }

      public bool Save()
      {
         switch (Mode)
         {
            case enMode.AddNew:
               if (_AddNewTestAppointment())
               {

                  Mode = enMode.Update;
                  return true;
               }
               else
               {
                  return false;
               }

            case enMode.Update:

               return _UpdateTestAppointment();

         }

         return false;
      }

      private int _GetTestID()
      {
         return clsTestAppointmentData.GetTestID(TestAppointmentID);
      }

   }
}
