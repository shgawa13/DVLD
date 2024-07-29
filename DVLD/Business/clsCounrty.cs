using System;
using System.Collections.Generic;
using System.Data;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
   public class clsCounrty
   {
      public int ID { set; get; }
      public string CountryName { set; get; }

      public clsCounrty()
      {
         this.ID = -1;
         this.CountryName = "";
      }

      private clsCounrty(int ID, string CountryName)
      {
         this.ID = ID;
         this.CountryName = CountryName;
      }

     public static clsCounrty Find(int ID)
      {
         string CountryName = "";
         if(clsCountryData.GetCountryByID(ID, ref CountryName))
         {
            return new clsCounrty(ID,CountryName);
         }
         else
         {

           return null;
         }

      }

      public static clsCounrty Find(string CountryName)
      {
         int ID = -1;
         if(clsCountryData.GetCountryByName(CountryName,ref ID))
         {
            return new clsCounrty(ID, CountryName);
         }
         else
         {
           return null;
         }

      }

      public static DataTable GetAllCountries() => clsCountryData.GetAllCountries();
      

   }
}
