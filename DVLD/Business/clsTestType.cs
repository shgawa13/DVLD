using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
   public class clsTestType
   {
      public enum enMode { AddNew =0, Update=1 }
      public enMode Mode = enMode.AddNew;
      public enum enTypeTest { VisionTest = 1, WrittenTest = 2,StreetTest=3 };

      public clsTestType.enTypeTest ID;
      public string TestTypeTitle { set; get; }
      public string TestTypeDescription { set; get; }
      public float TestTypeFees { set; get; }

      public clsTestType()
      {
         this.ID = enTypeTest.VisionTest;
         this.TestTypeTitle = "";
         this.TestTypeDescription = "";
         this.TestTypeFees = -1;
         Mode = enMode.AddNew;
      }

      private clsTestType(clsTestType.enTypeTest ID, string TestTypeTitle, string TestTypeDescription, float TestTypeFees)
      {
         this.ID = ID;
         this.TestTypeTitle = TestTypeTitle;
         this.TestTypeDescription = TestTypeDescription;
         this.TestTypeFees = TestTypeFees;
         Mode = enMode.Update;
      }


      private bool _AddNewTestType()
      {
         this.ID = (clsTestType.enTypeTest) clsTestTypeData.AddNewTypeTest(this.TestTypeTitle,this.TestTypeDescription,this.TestTypeFees); 
         return (this.ID !=0); 
      }
      

      private bool _UpdateTestType()
      {
         return clsTestTypeData.UpdateTestType((int) this.ID,this.TestTypeTitle,this.TestTypeDescription,this.TestTypeFees);
      }


      public static clsTestType Find(clsTestType.enTypeTest TestTypeID)
      {
         string TestTypeTitle = "", TestTypeDescription = "";
         float TestTypeFees = 0;

         bool Found = clsTestTypeData.GetTestTypeByID((int)TestTypeID, ref TestTypeTitle, ref TestTypeDescription, ref TestTypeFees);
         if (Found)
            return new clsTestType(TestTypeID, TestTypeTitle, TestTypeDescription, TestTypeFees);
         else
            return null;
      }

      public static DataTable GetAllTypeTest() => clsTestTypeData.GetAllTypeTes();




      public bool Save()
      {
         switch (Mode)
         {
            case enMode.AddNew:
               if (_AddNewTestType())
               {
                Mode = enMode.Update;
                return true;
               }
               else
               {
                  return false;
               }

            case enMode.Update:
              return _UpdateTestType();
             
         }
         return false;
      }
   }
}
