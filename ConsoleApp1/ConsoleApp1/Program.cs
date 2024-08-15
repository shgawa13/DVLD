using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;
using Business;
using System.Runtime.InteropServices.WindowsRuntime;
namespace ConsoleApp1
{
      public class Book
      {
         public string Title { get; set; }
         public decimal Price { get; set; }

         public Book(string Ttitle, decimal Price)
         {
            this.Title = Ttitle;
            this.Price = Price;
         }

      }

   internal class Program
   {
      public delegate bool Predicate(Book book);

      public static bool BooksGreaterThan30(Book book) => book.Price > 30;
      public static bool BooksLessThan30(Book book) => book.Price <= 30;


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

      public static int CountBook(List<Book> books, Predicate pred)
      {
         int counter = 0;

         foreach(Book book in books)
         {
            if (pred(book))
               counter++;
         }

         return counter;
      }

      public static void FindDriverID(int PersonID)
      {
         clsDriver Driver = clsDriver.FindByPersonID(PersonID);

         if (Driver != null)
            Console.WriteLine($"{Driver.DriverID}");
         else
            Console.WriteLine("can't find this driver");
         

      }

      static void Main(string[] args)
      {
         Console.WriteLine("start");
         // GetConuntyInfoByID(11);
         // FindUser("shgawa","112233");
         // GetAllLicenseClasses(); 
         // GetLicenseClassByID(1);
         //  GetLicenseClassByName("Class 1 - Small Motorcycle");

         //List<Book> books = new List<Book>()
         //{
         //   new Book("C++ Book",30),
         //   new Book("Java Book",40),
         //   new Book("JavaScript Book",55),
         //   new Book("C# OOP",60),

         //};


         //Console.WriteLine(CountBook(books, BooksGreaterThan30));
         //Console.WriteLine(CountBook(books, BooksLessThan30));

         FindDriverID(1032);
         Console.WriteLine("End");

        
      }
   }
}
