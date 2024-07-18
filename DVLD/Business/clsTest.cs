﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataLayer;
namespace Business
{
   public class clsTest
   {
      public enum enMode { AddNew=0, Update=1};
      public enMode Mode = enMode.AddNew;

      public int TestID { set; get; }
      public int TestAppointmentID { set; get; }
      public clsTestAppointment TestAppointmentInfo { set; get; }
      public bool TestResult { set; get; }
      public string Notes { set; get; }
      public int CreatedByUserID { set; get; }

     

      public clsTest()
      {
         this.TestID = -1;
         this.TestAppointmentID = -1;
         this.TestResult = false;
         this.Notes = "";
         this.CreatedByUserID = -1;
         
         Mode = enMode.AddNew;
      }

      private clsTest(int TestID, int TestAppointmentID, bool TestResult,
         string Notes,int CreatedByUserID)
      {
         this.TestID = TestID;
         this.TestAppointmentID = TestAppointmentID;
         this.TestAppointmentInfo = clsTestAppointment.Find(TestAppointmentID);
         this.TestResult = TestResult;
         this.Notes = Notes;
         this.CreatedByUserID = CreatedByUserID;

         Mode = enMode.Update;

      }

      private bool _AddNewTest()
      {
         int TestID = -1;

         TestID = clsTestData.AddNewTest(this.TestAppointmentID, this.TestResult, this.Notes, this.CreatedByUserID);

         return (TestID != -1);
      }

      private bool _UpdateTest()
      {
         return clsTestData.UpdateTest(this.TestID, this.TestAppointmentID, this.TestResult, this.Notes, this.CreatedByUserID);
      }

      public static clsTest Find(int TestID)
      {
         bool IsFound = false;

         int TestAppointmentID = -1, CreatedByUserID = -1;
         bool TestResult = false;
         string Notes = "";

         IsFound = clsTestData.GetTestInfoByID(TestID, ref TestAppointmentID, ref TestResult, ref Notes, ref CreatedByUserID);

         if (IsFound)
            return new clsTest(TestID, TestAppointmentID, TestResult, Notes, CreatedByUserID);
         else
            return null;
      }


      public static clsTest FindLastTestPerPersonAndLicenseClass
          (int PersonID, int LicenseClassID, clsTestType.enTypeTest TestTypeID)
      {
         int TestID = -1;
         int TestAppointmentID = -1;
         bool TestResult = false; string Notes = ""; int CreatedByUserID = -1;

         if (clsTestData.GetLastTestByPersonAndTestTypeAndLicenseClass
             (PersonID, LicenseClassID, (int)TestTypeID, ref TestID,
         ref TestAppointmentID, ref TestResult,
         ref Notes, ref CreatedByUserID))

            return new clsTest(TestID,
                    TestAppointmentID, TestResult,
                    Notes, CreatedByUserID);
         else
            return null;

      }

      public static DataTable GetAllTests()
      {
         return clsTestData.GetAllTest();

      }

      public bool Save()
      {
         switch (Mode)
         {
            case enMode.AddNew:
               if (_AddNewTest())
               {

                  Mode = enMode.Update;
                  return true;
               }
               else
               {
                  return false;
               }

            case enMode.Update:

               return _UpdateTest();

         }

         return false;
      }

      public static byte GetPassedTestCount(int LocalDrivingLicenseApplicationID)
      {
         return clsTestData.GetPassedTestCount(LocalDrivingLicenseApplicationID);
      }

      public static bool PassedAllTests(int LocalDrivingLicenseApplicationID)
      {
         //if total passed test less than 3 it will return false otherwise will return true
         return GetPassedTestCount(LocalDrivingLicenseApplicationID) == 3;
      }



   }
}
