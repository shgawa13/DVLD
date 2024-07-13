﻿using BusinessLayer;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
   public class clsApplication
   {
      public enum enMode { AddNew =0, Update=1}
      public enum enApplicationType { NewDrivingLicense = 1, RenewDrivingLicense = 2, ReplaceLostDrivingLicense = 3,
         ReplaceDamagedDrivingLicense = 4, ReleaseDetainedDrivingLicsense = 5, NewInternationalLicense = 6, RetakeTest = 7
      }

      public enMode Mode = enMode.AddNew;
      public enum enApplicationStatus { New =0, Cancelled=1,Completed=2}
      public int ApplicationID { set; get; }
      public int ApplicantPersonID { set; get; }
      public string ApplicantFullName
      {
         get { return clsPerson.Find(ApplicantPersonID).FullName;}
      }

      public DateTime ApplicationDate { set; get; }
      public int ApplicationTypeID { set; get; }
      public clsApplicationTypes ApplicationTypeInfo;
      public enApplicationStatus ApplicationStatus { set; get; }
      public string StatusText
      {
         get
         {
            switch (ApplicationStatus)
            {
               case enApplicationStatus.New:
                  return "New";
               case enApplicationStatus.Cancelled:
                  return "Cancelled";
               case enApplicationStatus.Completed:
                  return "Completed";
               default:
                  return "Unknown";

            }
         }
      }

      public DateTime LastStatusDate { set; get; }
      public float PaidFees { set; get; }
      public int CreatedByUserID { set; get; }
      public clsUsers CreatedByUserInfo;

      public clsApplication()
      {
         this.ApplicationID = -1;
         this.ApplicantPersonID = -1;
         this.ApplicationDate = DateTime.Now;
         this.ApplicationTypeID = -1;
         this.ApplicationStatus = enApplicationStatus.New;
         this.LastStatusDate = DateTime.Now;
         this.PaidFees = 0;
         this.CreatedByUserID = -1;

         Mode = enMode.AddNew;
      }


      private clsApplication(int ApplicationID,int ApplicantPersonID,DateTime ApplicationDate,int AppiclationTypeID,
         enApplicationStatus ApplicationStatus, DateTime LastStatusDate, float PaidFees, int CreatedByUserID)
      {
         this.ApplicationID = ApplicationID;
         this.ApplicantPersonID = ApplicantPersonID;
         this.ApplicationDate = ApplicationDate;
         this.ApplicationTypeID = ApplicationTypeID;
         this.ApplicationStatus = ApplicationStatus;
         this.LastStatusDate = LastStatusDate;
         this.PaidFees = PaidFees;
         this.CreatedByUserID = CreatedByUserID;

         Mode = enMode.Update;
      }


      private bool _AddNewApplication()
      {
         int AppID = -1;

         AppID = clsApplicationData.AddNewApplication(this.ApplicantPersonID, this.ApplicationDate, this.ApplicationTypeID,
            (byte)this.ApplicationStatus, this.LastStatusDate, this.PaidFees, this.CreatedByUserID);

         return (AppID != -1);
      }

      private bool _UpdateApplication()
      {
         return clsApplicationData.UpdateApplication(this.ApplicationID, this.ApplicantPersonID, this.ApplicationDate,
            this.ApplicationTypeID, (byte)this.ApplicationStatus, this.LastStatusDate, this.PaidFees, this.CreatedByUserID);
      }

      public clsApplication FindApplication(int ApplicationID) 
      {
         bool IsFound = false;

         int ApplicantPersonID = -1, ApplicationTypeID = -1, CreatedByUserID = -1;
         DateTime ApplicationDate = DateTime.Now, LastStatusDate = DateTime.Now;
         byte ApplicationStatus = 0;
         float PaidFees = 0;

         IsFound = clsApplicationData.GetApplicationInfoByID(ApplicationID, ref ApplicantPersonID, ref ApplicationDate,
            ref ApplicationTypeID, ref ApplicationStatus, ref LastStatusDate, ref PaidFees, ref CreatedByUserID);

         if (IsFound)
            return new clsApplication(ApplicationID, ApplicantPersonID, ApplicationDate, ApplicationTypeID,
               (enApplicationStatus)ApplicationStatus,LastStatusDate, PaidFees, CreatedByUserID);
         else
            return null;

      }

      public bool Cancel()
      {
         return clsApplicationData.UpdateStatus(ApplicationID, 2);
      }

      public bool SetComplete()
      {
         return clsApplicationData.UpdateStatus(ApplicationID, 3);
      }

      public bool Save()
      {

         switch (Mode)
         {
            case enMode.AddNew:
               
               if (_AddNewApplication())
               {
                  Mode = enMode.Update;
                  return true;
               }
               else
               {
                  return false;
               }

            case enMode.Update:
               return _UpdateApplication();
         }

         return false;

      }

      public bool Delete()
      {
         return clsApplicationData.DeleteApplication(this.ApplicationID);
      }

      public static bool IsApplicationExist(int ApplicationID)
      {
         return clsApplicationData.IsApplicationExist(ApplicationID);
      }

      public static bool DoesPersonHaveActiveApplication(int PersonID,int ApplicationTypeID)
      {
         return clsApplicationData.DoesPersonHaveActiveApplication(PersonID, ApplicationTypeID);
      }

      public  bool DoesPersonHaveActiveApplication(int ApplicationTypeID)
      {
         return DoesPersonHaveActiveApplication(this.ApplicantPersonID, ApplicationTypeID);
      }


      public static int GetActiveApplicationID(int PersonID, clsApplication.enApplicationType ApplicationTypeID)
      {
         return clsApplicationData.GetActiveApplicationID(PersonID, (int)ApplicationTypeID);
      }

      public static int GetActiveApplicationIDForLicenseClass(int PersonID, clsApplication.enApplicationType ApplicationTypeID, int LicenseClassID)
      {
         return clsApplicationData.GetActiveApplicationIDForLicenseClass(PersonID, (int)ApplicationTypeID, LicenseClassID);
      }

      public int GetActiveApplicationID(clsApplication.enApplicationType ApplicationTypeID)
      {
         return GetActiveApplicationID(this.ApplicantPersonID, ApplicationTypeID);
      }


   }
}
