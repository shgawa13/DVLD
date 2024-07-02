using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
   public class clsApplicationTypes
   {
      public int ApplicationTypeID { set; get; }
      public string ApplicationTypeTitle { set; get; }
      public float ApplicationFees { set; get; }   


      public clsApplicationTypes()
      {
         this.ApplicationTypeID = -1;
         this.ApplicationTypeTitle = "";
         this.ApplicationFees = 0;
      }

      private clsApplicationTypes(int ApplicationTypeID, string ApplicationTypeTitle, float ApplicationFees)
      {
         this.ApplicationTypeID = ApplicationTypeID;
         this.ApplicationTypeTitle = ApplicationTypeTitle;
         this.ApplicationFees = ApplicationFees;
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

      public static bool UpdateApplication(int ApplicationID, string ApplicationTypeTitle, double AppliactionFees)
      {
         return clsApplicationTypesData.UpdateApplicationType(ApplicationID,ApplicationTypeTitle, AppliactionFees);
      }
   }
}
