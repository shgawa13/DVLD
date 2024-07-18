using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Security.Permissions;


namespace DVLD
{
  internal class clsUtilities
   {
      // create New GuidID
      public static string GenrateGUID()
      {
         Guid GuidID = Guid.NewGuid();
         return GuidID.ToString();
      }

      // check if the file exist or not
      public static bool CreateFileIfNotExist(string FolderPath)
      {
         // if the folder is not Exist 
         if (!Directory.Exists(FolderPath)) 
         {
            // we try to create it
            try
            {
               Directory.CreateDirectory(FolderPath);
               return true;
            }
            catch (Exception ex)
            {
               MessageBox.Show($"Can't create folder due to {ex.Message}");
               return false;

            }
         }

         return true;

      }

      // Replace image name with guid
      public static string ReplaceFileNameWithGUID(string sourceFile)
      {
         string FileName = sourceFile;
         FileInfo info = new FileInfo(FileName);
         string extn = info.Extension;
         return GenrateGUID() + extn;

      }

      // this funciton will Copy image to Project Images;
      public static bool CopyImageToProjectImages(ref string sourceFile)
      {

         string DestinationFolder = @"C:\DVLD-People-Image\";

         if (!CreateFileIfNotExist(DestinationFolder))
         {
            return false;
         }

         // the new destinationFile will be the DestinationFolder + the image after replacing the name
         string destinationFile = DestinationFolder + ReplaceFileNameWithGUID(sourceFile);
         try
         {
            File.Copy(sourceFile, destinationFile, true);
         }
         catch(IOException iox)
         {
            MessageBox.Show(iox.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
         }
        
         sourceFile = destinationFile;
         return true;
      }

   }

}
