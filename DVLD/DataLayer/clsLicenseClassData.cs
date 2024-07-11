using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataLayer
{
   public  class clsLicenseClassData
   {

      public static int AddNewLicense(string ClassName,string ClassDescription,
            byte MinimumAllowedAge, byte DefaultValidityLength, float ClassFees)
      {
         int LicenseClassID = -1;

         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);
         string Query = @"Insert into LicenseClasses
                        (ClassName,ClassDescription,MinimumAllowedAge,DefaultValidityLength,ClassFees)
                        Values(@ClassName,@ClassDescription,@MinimumAllowedAge,@DefaultValidityLength,@ClassFees);
                         Select SCOPE_IDENTITY();";

         SqlCommand command = new SqlCommand(Query, connection);

         command.Parameters.AddWithValue("@ClassName",ClassName);
         command.Parameters.AddWithValue("@ClassDescription", ClassDescription);
         command.Parameters.AddWithValue("@MinimumAllowedAge", MinimumAllowedAge);
         command.Parameters.AddWithValue("@DefaultValidityLength", DefaultValidityLength);
         command.Parameters.AddWithValue("@ClassFees", ClassFees);

         try
         {

            connection.Open();
            object resutl = command.ExecuteScalar();

            if(resutl !=null && int.TryParse((string)resutl,out int ID))
            {
               LicenseClassID = ID;
            }
         }
         catch(Exception ex)
         {
            // throw ex
            return -1;
         }
         finally
         {
            connection.Close();
         }

         return LicenseClassID;
      }

      public static bool GetLicenseClassInfoByID(int LicenseClassID, ref string ClassName,ref string ClassDescription,
           ref byte MinimumAllowedAge,ref byte DefaultValidityLength,ref float ClassFees)
      {

         bool IsFound = false;

         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);
         string Query = @"Select * from LicenseClasses where LicenseClassID=@LicenseClassID";
         SqlCommand command = new SqlCommand(Query, connection);

         command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

         try
         {
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
               IsFound = true;

               ClassName = (string)reader["ClassName"];
               ClassDescription = (string)reader["ClassDescription"];
               MinimumAllowedAge = (byte)reader["MinimumAllowedAge"];
               DefaultValidityLength = (byte)reader["DefaultValidityLength"];
               ClassFees = Convert.ToSingle(reader["ClassFees"]);
            }

            reader.Close();
         }
         catch(Exception ex)
         {
            IsFound = false;
         }
         finally
         {
            connection.Close();
         }
         return IsFound;
      }

      public static bool GetLicenseClassInfoByClassName(string ClassName, ref int LicenseClassID, ref string ClassDescription,
           ref byte MinimumAllowedAge, ref byte DefaultValidityLength, ref float ClasseFees)
      {

         bool IsFound = false;

         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);
         string Query = @"Select * from LicenseClasses where ClassName=@ClassName";
         SqlCommand command = new SqlCommand(Query, connection);

         command.Parameters.AddWithValue("@ClassName", ClassName);

         try
         {
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
               IsFound = true;

               LicenseClassID = (int)reader["LicenseClassID"];
               ClassDescription = (string)reader["ClassDescription"];
               MinimumAllowedAge = (byte)reader["MinimumAllowedAge"];
               DefaultValidityLength = (byte)reader["DefaultValidityLength"];
               ClasseFees = Convert.ToSingle(reader["ClassFees"]);
            }

         }
         catch (Exception ex)
         {
            IsFound = false;
         }
         finally
         {
            connection.Close();
         }

         return IsFound;
      }

      public static DataTable GetAllLicenseClasses()
      {
         DataTable dt = new DataTable();

         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);
         string Query = @"Select * From LicenseClasses;";
         SqlCommand command = new SqlCommand(Query, connection);

         try
         {
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
               dt.Load(reader);
            }
         }
         catch(Exception ex)
         {
            return null;
         }
         finally
         {
            connection.Close();
         }

         return dt;
      }

      public static bool UpdateLicenseClass(int LicenseClassID, string ClassName,  string ClassDescription,
            byte MinimumAllowedAge, byte DefaultValidityLength,  float ClassFees)
      {
         int rowsEffected = 0;


         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);
         string Query = @"Update LicenseClasses
                        set ClassName = @ClassName,
                        ClassDescription = @ClassDescription,
                        MinimumAllowedAge = @MinimumAllowedAge,
                        DefaultValidityLength = @DefaultValidityLength,
                        ClassFees = @ClassFees Where LicenseClassID = @LicenseClassID;";

         SqlCommand command = new SqlCommand(Query, connection);

         command.Parameters.AddWithValue("@ClassName", ClassName);
         command.Parameters.AddWithValue("@ClassDescription", ClassDescription);
         command.Parameters.AddWithValue("@MinimumAllowedAge", MinimumAllowedAge);
         command.Parameters.AddWithValue("@DefaultValidityLength", DefaultValidityLength);
         command.Parameters.AddWithValue("@ClassFees", ClassFees);
         command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

         try
         {
            connection.Open();
            rowsEffected = command.ExecuteNonQuery();
         }
         catch(Exception ex)
         {
            rowsEffected = 0;
         }
         finally
         {
            connection.Close();
         }


         return (rowsEffected != 0);
      }
   }
}
