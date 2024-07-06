using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;
using System.IO;
using System.Windows.Forms;
using System.Web;
namespace DVLD.Global_Classes
{
   internal class clsGlobal
   {
      public static clsUsers CurrnetUser;

      public static bool RememberUserNameAndPassword(string userName, string password)
      {
         try
         {
            // Getting the Current Dirctory
            string CurrentDirctory = System.IO.Directory.GetCurrentDirectory();
            string filePath = CurrentDirctory + "\\data.txt";
           
            // if userName is empty we delete the file;
            if(userName =="" && File.Exists(filePath) )
            {
               File.Delete(filePath);
               return true;
            }

            
            string savedata = userName + "#//#" + password;

            // Writing data with StreamWriter that will create file too
            using(StreamWriter writer = new StreamWriter(filePath))
            {
               writer.WriteLine(savedata);
               return true;
            }



         }
         catch(IOException ex)
         {
            MessageBox.Show($"An error Occurred {ex.Message}");

            return false;
         }

      }

      public static bool GetStoredCredential(ref string userName, ref string password) 
      {

         try
         {
            string CurrentDirctory = System.IO.Directory.GetCurrentDirectory();
            string filePath = CurrentDirctory + "\\data.txt";

            // Checking if the file is exist
            if (File.Exists(filePath))
            {
               // we read the data from txt file
               using (StreamReader reader = new StreamReader(filePath))
               {
                  // Read data line by line until the end of the file
                  string line;
                  while ((line = reader.ReadLine()) != null)
                  {
                     // we can store data in array
                     string[] result = line.Split(new string[] { "#//#" }, StringSplitOptions.None);

                     userName = result[0];
                     password = result[1];
                  }
                  return true;
               }
            }
            else
            {
               return false;
            }
         }
         catch(Exception ex)
         {
            MessageBox.Show($"An error occurred: {ex.Message}");
            return false;
         }
        

      }

   }
}
