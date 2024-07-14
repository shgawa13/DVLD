using BusinessLayer;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
namespace Business
{
   public class clsLocalDrivingLicenseApplication : clsApplication
   {
      public enum enMode { AddNew = 0, Update = 1 }
      public enMode Mode = enMode.AddNew;

      public int LocalDrivingLicenseApplicationID { set; get; }
      public int LicenseClassID { set; get; }
      public clsLicenseClass LicenseCalssInfo { set; get; }
      public string FullName
      {
         get { return clsPerson.Find(ApplicantPersonID).FullName; }
      }

      public clsLocalDrivingLicenseApplication()
      {
         this.LocalDrivingLicenseApplicationID = -1;
         this.LicenseClassID = -1;

         Mode = enMode.AddNew;
      }


      private clsLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID, int ApplicationID, int ApplicantPersonID,
         DateTime ApplicationDate, int ApplicationTypeID, enApplicationStatus ApplicationStatus, DateTime LastStatusDate,
         float PaidFees, int CreatedByUserID, int LicenseClassID)
      {
         this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
         this.ApplicationID = ApplicationID;
         this.ApplicantPersonID = ApplicantPersonID;
         this.PaidFees = PaidFees;
         this.CreatedByUserID = CreatedByUserID;
         this.LicenseClassID = LicenseClassID;
      }

      private bool _AddNewLocalDrivingLicenesApplication()
      {
         int ID = -1;
         ID = clsLocalDrivingLicenseApplicaionData.AddNewLocalDrivingLicenseApplication(this.ApplicationID, this.LicenseClassID);

         return (ID != -1);

      }

      private bool _UpdateLocalDrivingLicenseApplication()
      {
         return clsLocalDrivingLicenseApplicaionData.UpdateLocalDrivingLicenseApplication(this.LocalDrivingLicenseApplicationID,
            this.ApplicationID, this.LicenseClassID);
      }

      public DataTable GetAllApplications()
      {
         return clsLocalDrivingLicenseApplicaionData.GetAllLocalDrivingLicenseApplications();
      }

      public static clsLocalDrivingLicenseApplication FindByLocalDrivingAppLicenseID(int LocalDrivingLicenseApplicationID)
      {
         int ApplicationID = -1, LicenseClassID = -1;

         bool IsFound = clsLocalDrivingLicenseApplicaionData.GetLocalDrivingLicenseApplicationInfoByID(
            LocalDrivingLicenseApplicationID, ref ApplicationID, ref LicenseClassID);

         if (IsFound)
         {
            clsApplication Application = clsApplication.FindBaseApplication(ApplicationID);

            return new clsLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID, ApplicationID
               , Application.ApplicantPersonID, Application.ApplicationDate, Application.ApplicationTypeID,
               (enApplicationStatus)Application.ApplicationStatus, Application.LastStatusDate, Application.PaidFees,
               Application.CreatedByUserID, LicenseClassID);
         }

         return null;
      }

      public clsLocalDrivingLicenseApplication GetApplicationinfoByID(int ApplicationID)
      {
         int LocalDrivingLicenseApplicationID = -1, LicenseClassID = -1;

         bool IsFound = clsLocalDrivingLicenseApplicaionData.GetLocalDrivingLicenseApplicationInfoByApplicationID
            (ApplicationID, ref LocalDrivingLicenseApplicationID, ref LicenseClassID);


         if (IsFound)
         {
            clsApplication Application = clsApplication.FindBaseApplication(ApplicationID);

            return new clsLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID, ApplicationID
               , Application.ApplicantPersonID, Application.ApplicationDate, Application.ApplicationTypeID,
               (enApplicationStatus)Application.ApplicationStatus, Application.LastStatusDate, Application.PaidFees,
               Application.CreatedByUserID, LicenseClassID);
         }


         return null;
      }


      public bool Save()
      {
         //Because of inheritance first we call the save method in the base class,
         //it will take care of adding all information to the application table.
         base.Mode = (clsApplication.enMode) Mode;
         if (!base.Save())
            return false;

         //After we save the main application now we save the sub application.
         switch (Mode)
         {
            case enMode.AddNew:
               if (_AddNewLocalDrivingLicenesApplication())
               {
                  Mode = enMode.Update;
                  return true;
               }
               else
               {
                  return false;
               }

            case enMode.Update:
               return _UpdateLocalDrivingLicenseApplication();
         }

         return false;
      }

      public bool Delete()
      {
         bool IsLocalDrivingLicenseApplicationDeleted = false;
         bool IsBaseApplicationDeleted = false;

         // First we delete the Local Driving License Application
         IsLocalDrivingLicenseApplicationDeleted = clsLocalDrivingLicenseApplicaionData.DeleteLocalDrivingLicenseApplication(this.LocalDrivingLicenseApplicationID);

         // if it was not deleted we return false;
         if (!IsLocalDrivingLicenseApplicationDeleted)
            return false;

         // now we delete the base Application
         IsBaseApplicationDeleted = base.Delete();
         return IsBaseApplicationDeleted;

      }

       public bool DosePassTestType(clsTestType.enTypeTest TestTypeID)
       {
         return clsLocalDrivingLicenseApplicaionData.DosePassTestType(this.LocalDrivingLicenseApplicationID, (int)TestTypeID);
       }

      public bool DoesPassPreviousTest(clsTestType.enTypeTest CurrentTestType)
      {
         switch (CurrentTestType)
         {
            case clsTestType.enTypeTest.VisionTest:
               //in this case no required prvious test to pass.
               return true;

            case clsTestType.enTypeTest.WrittenTest:
               //Written Test, you cannot sechdule it before person passes the vision test.
               //we check if pass visiontest 1.
               return DoesPassPreviousTest(clsTestType.enTypeTest.VisionTest);

            case clsTestType.enTypeTest.StreetTest:
               //Street Test, you cannot sechdule it before person passes the written test.
               //we check if pass Written 2.
               return DosePassTestType(clsTestType.enTypeTest.WrittenTest);

            default:
               return false;

         }
      }

      public bool DoesPassTestType(int LocalDrivingLicenseApplication, clsTestType.enTypeTest TestTypeID) 
      {
         return clsLocalDrivingLicenseApplicaionData.DosePassTestType(LocalDrivingLicenseApplicationID, (int)TestTypeID);
      }

      public bool DoesAttendTestType(clsTestType.enTypeTest TestTypeID) 
      {
         return clsLocalDrivingLicenseApplicaionData.DoesAttendTestType(this.LocalDrivingLicenseApplicationID, (int)TestTypeID);
      }

      public byte TotalTrialsPerTest(clsTestType.enTypeTest TestTypeID)
      {
         return clsLocalDrivingLicenseApplicaionData.TotalTrialsPerTest(this.LocalDrivingLicenseApplicationID, (int)TestTypeID);
      }

      public static byte TotalTrialsPerTest(int LocalDrivingLicenseApplicationID, clsTestType.enTypeTest TestTypeID)
      {
         return clsLocalDrivingLicenseApplicaionData.TotalTrialsPerTest(LocalDrivingLicenseApplicationID, (int)TestTypeID);
      }

      public static  bool AttendedTest(int LocalDrivingLicenseApplicationID, clsTestType.enTypeTest TestTypeID) 
      {
         return clsLocalDrivingLicenseApplicaionData.TotalTrialsPerTest(LocalDrivingLicenseApplicationID, (int)TestTypeID) > 0;
      }

      public bool AttendedTest(clsTestType.enTypeTest TestTypeID)
      {
         return clsLocalDrivingLicenseApplicaionData.TotalTrialsPerTest(this.LocalDrivingLicenseApplicationID, (int)TestTypeID) > 0;
      }

      public static bool IsThereAnActiveScheduledTest(int LocalDrivingLicenseApplicationID, clsTestType.enTypeTest TestTypeID)
      {
         return clsLocalDrivingLicenseApplicaionData.IsThereAnActiveScheduledTest(LocalDrivingLicenseApplicationID, (int)TestTypeID);
      }

      public bool IsThereAnActiveScheduledTest(clsTestType.enTypeTest TestTypeID)
      {
         return clsLocalDrivingLicenseApplicaionData.IsThereAnActiveScheduledTest(this.LocalDrivingLicenseApplicationID, (int)TestTypeID);
      }



   }
}
