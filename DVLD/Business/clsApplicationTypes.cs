using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
   public class clsApplicationTypes
   {
      public enum enMode { AddNew=0, Update=1}
      private enMode _Mode = enMode.AddNew;
      public int ApplicationTypeID { set; get; }
      public string ApplicationTypeTitle { set; get; }
      public float ApplicationFees { set; get; }   


      public clsApplicationTypes()
      {
         this.ApplicationTypeID = -1;
         this.ApplicationTypeTitle = "";
         this.ApplicationFees = 0;
         _Mode = enMode.AddNew;
         
      }

      private clsApplicationTypes(int ApplicationTypeID, string ApplicationTypeTitle, float ApplicationFees)
      {
         this.ApplicationTypeID = ApplicationTypeID;
         this.ApplicationTypeTitle = ApplicationTypeTitle;
         this.ApplicationFees = ApplicationFees;
         _Mode = enMode.Update;
      }
      
      private bool _AddNewApplicationType()
      {
         return false;
      } 

      private bool _UpdateApplication()
      {
         return clsApplicationTypesData.UpdateApplicationType(this.ApplicationTypeID, this.ApplicationTypeTitle, this.ApplicationFees);
      }

      public static clsApplicationTypes GetApplicationTypeByID(int ApplicationTypeID)
      {
         string ApplicationTypeTitle = "";
         float ApplicationFees =0;

         bool IsFound = clsApplicationTypesData.GetApplicationTypeByID(ApplicationTypeID,
            ref ApplicationTypeTitle, ref ApplicationFees);

         if (IsFound)
            return new clsApplicationTypes(ApplicationTypeID, ApplicationTypeTitle, ApplicationFees);
         else
           return null;
      }

      public static DataTable GetAllApplicationTypes()
      {
         return clsApplicationTypesData.GetAllApplicationTypes();
      }

      public  bool Save() 
      {
         switch (_Mode)
         {
            case enMode.AddNew:
               if (_AddNewApplicationType())
               {
                  _Mode = enMode.Update;
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

   }
}
