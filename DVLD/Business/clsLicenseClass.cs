using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
namespace Business
{
   public class clsLicenseClass
   {
      public enum enMode { AddNew = 0, Update = 1 }
      public enMode Mode = enMode.AddNew;

      public int LicenseClassID { set; get; }
      public string ClassName { set; get; }
      public string ClassDescription { set; get; }
      public byte MinimumAllowedAge { set; get; }
      public byte DefaultValidityLength { set; get; }
      public float ClassFees { set; get; }


      public clsLicenseClass()
      {
         this.LicenseClassID = -1;
         this.ClassName = "";
         this.ClassDescription = "";
         this.MinimumAllowedAge = 18;
         this.DefaultValidityLength = 10;
         this.ClassFees = 0;
         Mode = enMode.AddNew;
      }

      private clsLicenseClass(int LicenseClassID, string ClassName, string ClassDescription,
         byte MinimumAllowedAge, byte DefaultValidityLength, float ClassFees)
      {
         this.LicenseClassID = LicenseClassID;
         this.ClassName = ClassName;
         this.ClassDescription = ClassDescription;
         this.MinimumAllowedAge = MinimumAllowedAge;
         this.DefaultValidityLength = DefaultValidityLength;
         this.ClassFees = ClassFees;
         Mode = enMode.Update;
      }

      private bool _AddNewLicenseClass()
      {
         int ID = clsLicenseClassData.AddNewLicense(this.ClassName, this.ClassDescription, this.MinimumAllowedAge,
                                                     this.DefaultValidityLength, this.ClassFees);

         return (ID != -1);
      }

      private bool _UpdateLicenseClass()
      {
         return clsLicenseClassData.UpdateLicenseClass(this.LicenseClassID,this.ClassName, this.ClassDescription,
            this.MinimumAllowedAge, this.DefaultValidityLength, this.ClassFees);
      }

      public static  clsLicenseClass FindLicenseClassByID(int LicenseClassID)
      {
         string ClassName = "", ClassDescription = "";
         byte MinimumAllowedAge = 0, DefaultValidityLength = 0;
         float ClassFees = 0;

         bool IsFound = clsLicenseClassData.GetLicenseClassInfoByID(LicenseClassID, ref ClassName, ref ClassDescription,
            ref MinimumAllowedAge, ref DefaultValidityLength, ref ClassFees);

         if (IsFound)
            return new clsLicenseClass(LicenseClassID, ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength
               , ClassFees);
         else
            return null;

      }

      public static  clsLicenseClass FindLicenseClassByName(string ClassName)
      {
         int LicenseClassID = 0;
         string ClassDescription = "";
         byte MinimumAllowedAge = 0, DefaultValidityLength = 0;
         float ClassFees = 0;


         bool IsFound = clsLicenseClassData.GetLicenseClassInfoByClassName(ClassName, ref LicenseClassID, ref ClassDescription,
           ref  MinimumAllowedAge, ref  DefaultValidityLength, ref ClassFees);

         if (IsFound)
            return new clsLicenseClass(LicenseClassID, ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength
               , ClassFees);
         else
            return null;

      }

      public static  DataTable GetAllLicenseClasses()
      {
         return clsLicenseClassData.GetAllLicenseClasses();
      }

      public  bool Save()
      {
         switch (Mode)
         {
            case enMode.AddNew:
               
               if (_AddNewLicenseClass())
               {
                  Mode = enMode.Update;
                  return true;
               }
               else
               {
                  return false;
               }

            case enMode.Update:
               return _UpdateLicenseClass();
         }

         return false;
      }
   }
}
