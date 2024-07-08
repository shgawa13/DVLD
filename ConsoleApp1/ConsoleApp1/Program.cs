using Business;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
      

      static void Main(string[] args)
      {
         Console.WriteLine("start");
         FindUser("shgawa","112233");
         Console.WriteLine("End");

        
      }
   }
}
