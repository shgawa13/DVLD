using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DVLD.Global_Classes
{
   public class clsValidatoin
   {
      // Validate eamil
      public static bool ValidateEmail(string Email)
      {
        var Patern = @"^[a-zA-Z0-9.!#$%&'*+-/=?^_`{|}~]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";
         var regx = new Regex(Patern);
         return regx.IsMatch(Email);
      }

      // Validate Integer
      public static bool ValidateInteger(string Number)
      {
         var Patern = @"^[0-9]*$";
         var regx = new Regex(Patern); 
         return regx.IsMatch(Number);  
      }

      // Validate Float
      public static bool ValidateFloat(string Number) 
      {
         var Patern = @"^[0-9]*(?:\.[0-9]*)?$";
         var regx = new Regex(Patern);
         return regx.IsMatch(Number);
      }

      public static bool IsNumber(string Number)
      {
         return (ValidateInteger(Number) || ValidateFloat(Number));
      }

   }
}
