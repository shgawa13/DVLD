using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;
using Business;
namespace ConsoleApp1
{
   internal class Program
   {
      public static void FindUser(string UserName, string Password)
      {
         // counrty = 

         clsUsers user = clsUsers.FindByUserNameAndPassword(UserName,Password);

         if (user != null)
         {
            Console.WriteLine($"{user.UserName} {user.Password}");

         }
         else
         {
            Console.WriteLine("somthing went worng");
         }

         

      }
      
      public static void GetAllLicenseClasses()
      {
         DataTable AllLicenses = clsLicenseClass.GetAllLicenseClasses();

         if(AllLicenses != null)
         {
            foreach(DataRow row in AllLicenses.Rows)
            {

               Console.WriteLine($"{row["LicenseClassID"]} {row["ClassName"]}");
            }
         }
         else
         {
               Console.WriteLine($"Something went Wrong");
            
         }
      }

      public static void GetLicenseClassByID(int ID)
      {
         clsLicenseClass License = clsLicenseClass.FindLicenseClassByID(ID);

         if (License != null)
         {

            Console.WriteLine($"{License.LicenseClassID} {License.ClassName}");

         }
      }

      public static void GetLicenseClassByName(string ClassName)
      {
         clsLicenseClass License = clsLicenseClass.FindLicenseClassByName(ClassName);
         if (License != null)
         {

            Console.WriteLine($"{License.LicenseClassID} {License.ClassName}");

         }
      }

      public static void GetConuntyInfoByID(int ID)
      {
         clsCounrty country = clsCounrty.Find(ID);

         if (country != null)
            Console.WriteLine($"{country.ID} {country.CountryName}");
         else
            Console.WriteLine("something went worng");
       
      }

      

      static void Main(string[] args)
      {
         Console.WriteLine("start");
         GetConuntyInfoByID(11);
         // FindUser("shgawa","112233");
         // GetAllLicenseClasses(); 
         // GetLicenseClassByID(1);
         //  GetLicenseClassByName("Class 1 - Small Motorcycle");
         Console.WriteLine("End");

        
      }
   }
}
