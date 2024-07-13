using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
namespace Business
{
   public class clsLocalDrivingLicenseApplication :clsApplication
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
         DateTime ApplicationDate, int AppiclationTypeID,enApplicationStatus ApplicationStatus, DateTime LastStatusDate,
         float PaidFees, int CreatedByUserID, int LicenseClassID)
      {
         this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
         this.ApplicationID = ApplicationID;
         this.ApplicantPersonID = this.ApplicantPersonID;
         this.PaidFees = PaidFees;
         this.CreatedByUserID = CreatedByUserID;
         this.LicenseClassID = LicenseClassID;
      }

     
   }
}
