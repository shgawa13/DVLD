﻿using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
   public class clsApplication
   {
      public enum enMode { AddNew =0, Update=0}
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


     // private bool _AddNew()
   }
}
