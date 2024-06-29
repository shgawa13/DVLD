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
      public static void FindUser(int ID)
      {
         // counrty = 

         clsUsers user = clsUsers.Find(ID);

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
         FindUser(1);
         Console.WriteLine("End");

        
      }
   }
}
