using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business;
using BusinessLayer;
namespace DVLDTest
{
   internal class Program
   {




      public static void GetPersonInfo(int ID)
      {
         clsUsers User = clsUsers.FindByUserID(ID);

         if (User != null)
         {
            {
               Console.WriteLine(User.UserName);
            }
         }
         else
         {
            Console.WriteLine("Somthing wrong");
         }
      }

      public static void GetUserByUserNameAndPassword(string userName, string password) 
      {
         clsUsers user = clsUsers.FindByUserNameAndPassword(userName, password);

         if (user != null)
            Console.WriteLine($"{user.UserID}, {user.PersonID}, {user.IsActive}");
         else
            Console.WriteLine("Something went worng");
      }

      

      public static void GetAllUsers()
      {
         DataTable dtUsers = clsUsers.GetAllUsers();

         if(dtUsers != null)
         {
            foreach(DataRow row in dtUsers.Rows)
            {
               Console.WriteLine($" UserID: {row["UserID"]}, PersonID: {row["PersonID"]}, {row["FullName"]} UserName: {row["UserName"]}, Password: {row["Password"]} ");
            }
         }
         else
         {
            Console.WriteLine("Something went wrong");
         }

      }

      public static void ChangePassword(int UserID,string NewPassword)
      {
         bool IsChanged = clsUsers.ChangeUserPassword(UserID,NewPassword);

         if (IsChanged)

            Console.WriteLine($"{UserID} changed the password for {NewPassword} ");
         else
            Console.WriteLine("Something went worng");

      }

      public static void  CheckIfPersonIsUser(int PersonID)
      {
         if (clsUsers.isUserExistForPersonID(PersonID))
         {
            Console.WriteLine("This Person Has User");
         }
         else
         {
            Console.WriteLine("You can add this person as User");

         }

      }

      public static void FindPersonByNationalNo(string NationalNo)
      {
         clsPerson person = clsPerson.Find(NationalNo);

         string CountryName = clsCounrty.Find(person.NationalityCountryID).CountryName;
         if (person != null)
         {
            Console.WriteLine($"{person.CountryInfo.CountryName}");
            Console.WriteLine($"{CountryName}");
         }
         else
         {
            Console.WriteLine("Somthing went wrong");
         }
      }

      public static void GetAllApplicationTypes()
      {
         DataTable dtApplcationTypes = clsApplicationTypes.GetAllApplicationTypes();

         if(dtApplcationTypes != null)
         {
            foreach(DataRow row in dtApplcationTypes.Rows)
            {
               Console.WriteLine($"{row["ApplicationTypeID"]} , {row["ApplicationTypeTitle"]} , {row["ApplicationFees"]}");
            }
         }
         else
         {
            Console.WriteLine("Something went worng");
         }
      }

      public static void GetApplicationTypeByID(int ID)
      {
         clsApplicationTypes Application = clsApplicationTypes.GetApplicationTypeByID(ID);

         if (Application != null)
            Console.WriteLine($"{Application.ApplicationTypeID} {Application.ApplicationTypeTitle}");
         else
            Console.WriteLine("Something went worng");

      }

         static void Main(string[] args)
         {
            Console.WriteLine("test");
         // GetPersonInfo(1);
         // ChangePassword(15, "0500");
         // GetAllUsers();
         //  CheckIfPersonIsUser(1024);
         // GetUserByUserNameAndPassword("user4", "1234");
         // FindPersonByNationalNo("N77");
         GetAllApplicationTypes();
         GetApplicationTypeByID(1);
         Console.WriteLine("test end");
            Console.ReadKey();
         }
      }
   }


