//using BusinessLayer;
//using System;
//using System.Data;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Permissions;
//using System.Text;
//using System.Threading.Tasks;
//using DataLayer;
//namespace Business
//{
//   public class clsLocalDrivingLicenseApplication : clsApplication
//   {
//      public enum enMode { AddNew = 0, Update = 1 }
//      public enMode Mode = enMode.AddNew;

//      public int LocalDrivingLicenseApplicationID { set; get; }
//      public int LicenseClassID { set; get; }
//      public clsLicenseClass LicenseCalssInfo { set; get; }
//      public string FullName
//      {
//         get { return clsPerson.Find(ApplicantPersonID).FullName; }
//      }

//      public clsLocalDrivingLicenseApplication()
//      {
//         this.LocalDrivingLicenseApplicationID = -1;
//         this.LicenseClassID = -1;

//         Mode = enMode.AddNew;
//      }


//      private clsLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID, int ApplicationID, int ApplicantPersonID,
//         DateTime ApplicationDate, int ApplicationTypeID,enApplicationStatus ApplicationStatus, DateTime LastStatusDate,
//         float PaidFees, int CreatedByUserID, int LicenseClassID)
//      {
//         this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
//         this.ApplicationID = ApplicationID;
//         this.ApplicantPersonID = ApplicantPersonID;
//         this.PaidFees = PaidFees;
//         this.CreatedByUserID = CreatedByUserID;
//         this.LicenseClassID = LicenseClassID;
//      }

//      private bool _AddNewLocalDrivingLicenesApplication()
//      {
//         int ID = -1;
//         ID = clsLocalDrivingLicenseApplicaionData.AddNewLocalDrivingLicenseApplication(this.ApplicationID, this.LicenseClassID);

//         return (ID != -1);

//      }

//      private bool _UpdateLocalDrivingLicenseApplication()
//      {
//         return clsLocalDrivingLicenseApplicaionData.UpdateLocalDrivingLicenseApplication(this.LocalDrivingLicenseApplicationID,
//            this.ApplicationID, this.LicenseClassID);
//      }

//      public DataTable GetAllApplications()
//      {
//         return clsLocalDrivingLicenseApplicaionData.GetAllLocalDrivingLicenseApplications();
//      }

//      public static clsLocalDrivingLicenseApplication FindByLocalDrivingAppLicenseID(int LocalDrivingLicenseApplicationID)
//      {
//         int ApplicationID = -1, LicenseClassID = -1;
         
//         bool IsFound = 
//      }

//      public  clsLocalDrivingLicenseApplication GetApplicationinfoByID(int ApplicationID)
//      {
//         int LocalDrivingLicenseApplicationID = -1, LicenseClassID = -1;

//         bool IsFound = clsLocalDrivingLicenseApplicaionData.GetLocalDrivingLicenseApplicationInfoByApplicationID
//            (ApplicationID,ref LocalDrivingLicenseApplicationID, ref LicenseClassID);


//         if (IsFound)
//         {
//            clsApplication Application = clsApplication.FindBaseApplication(ApplicationID);

//            return new clsLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID, ApplicationID
//               , Application.ApplicantPersonID, Application.ApplicationDate, Application.ApplicationTypeID,
//               (enApplicationStatus)Application.ApplicationStatus, Application.LastStatusDate, Application.PaidFees,
//               Application.CreatedByUserID, LicenseClassID);
//         }


//         return null;
//      }
     
//   }
//}
