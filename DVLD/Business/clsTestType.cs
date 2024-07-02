using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
   public class clsTestType
   {

      public int TestTypeID { set; get; }
      public string TestTypeTitle { set; get; }
      public string TestTypeDescription { set; get; }
      public float TestTypeFees { set; get; }

      public clsTestType()
      {
         this.TestTypeID = -1;
         this.TestTypeTitle = "";
         this.TestTypeDescription = "";
         this.TestTypeFees = -1;
      }

      private clsTestType(int TestTypeID, string TestTypeTitle, string TestTypeDescription, float TestTypeFees)
      {
         this.TestTypeID = TestTypeID;
         this.TestTypeTitle = TestTypeTitle;
         this.TestTypeDescription = TestTypeDescription;
         this.TestTypeFees = TestTypeFees;
      }

   }
}
