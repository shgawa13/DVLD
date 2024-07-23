﻿using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
   public class clsLicenseData
   {
      public static bool FindLicenseInfoByID(int LicenseID, ref int ApplicationID, ref int DriverID, ref int LicenseClass,
            ref DateTime IssueDate, ref DateTime ExpirationDate, ref string Notes,
            ref float PaidFees, ref bool IsActive, ref byte IssueReason, ref int CreatedByUserID)
      {
         bool IsFound = false;

         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);
         string Query = @"Select * From Licenses Where LicenseID=@LicenseID;";
         SqlCommand command = new SqlCommand(Query, connection);

         command.Parameters.AddWithValue("@LicenseID", LicenseID);

         try
         {
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
               IsFound = true;

               ApplicationID = (int)reader["ApplicationID"];
               DriverID = (int)reader["DriverID"];
               LicenseClass = (int)reader["LicenseClass"];
               IssueDate = (DateTime)reader["IssueDate"];
               ExpirationDate = (DateTime)reader["ExpirationDate"];
               Notes = (string)reader["Notes"];
               PaidFees = Convert.ToSingle(reader["PaidFees"]);
               IsActive = (bool)reader["IsActive"];
               IssueReason = (byte)reader["IssueReason"];
               CreatedByUserID = (int)reader["CreatedByUserID"];

            }
            reader.Close();
         }
         catch(Exception ex)
         {

         }
         finally
         {
            connection.Open();
         }


         return IsFound;
      }


      public static DataTable GetAllLicenses()
      {
         DataTable dtAllLicenses = new DataTable();

         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);
         string Query = @"Select * From Licenses;";
         SqlCommand command = new SqlCommand(Query, connection);

         try
         {
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
               dtAllLicenses.Load(reader);
            }
            reader.Close();
         }
         catch(Exception ex)
         {
            dtAllLicenses = null;
         }
         finally
         {
            connection.Close();
         }

         return dtAllLicenses;
      }

      public static DataTable GetDriverLicenses(int DriverID)
      {

         DataTable dt = new DataTable();
         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);

         string query = @"SELECT     
                           Licenses.LicenseID,
                           ApplicationID,
		                   LicenseClasses.ClassName, Licenses.IssueDate, 
		                   Licenses.ExpirationDate, Licenses.IsActive
                           FROM Licenses INNER JOIN
                                LicenseClasses ON Licenses.LicenseClass = LicenseClasses.LicenseClassID
                            where DriverID=@DriverID
                            Order By IsActive Desc, ExpirationDate Desc";

         SqlCommand command = new SqlCommand(query, connection);
         command.Parameters.AddWithValue("@DriverID", DriverID);

         try
         {
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)

            {
               dt.Load(reader);
            }

            reader.Close();


         }

         catch (Exception ex)
         {
            // Console.WriteLine("Error: " + ex.Message);
         }
         finally
         {
            connection.Close();
         }

         return dt;

      }

      public static int AddNewLicense(int ApplicationID, int DriverID, int LicenseClass,
           DateTime IssueDate, DateTime ExpirationDate, string Notes,
           float PaidFees, bool IsActive, byte IssueReason, int CreatedByUserID)
      {
         int LicenseID = -1;

         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);

         string query = @"
                              INSERT INTO Licenses
                               (ApplicationID,
                                DriverID,
                                LicenseClass,
                                IssueDate,
                                ExpirationDate,
                                Notes,
                                PaidFees,
                                IsActive,IssueReason,
                                CreatedByUserID)
                         VALUES
                               (
                               @ApplicationID,
                               @DriverID,
                               @LicenseClass,
                               @IssueDate,
                               @ExpirationDate,
                               @Notes,
                               @PaidFees,
                               @IsActive,@IssueReason, 
                               @CreatedByUserID);
                            SELECT SCOPE_IDENTITY();";

         SqlCommand command = new SqlCommand(query, connection);
         command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
         command.Parameters.AddWithValue("@DriverID", DriverID);
         command.Parameters.AddWithValue("@LicenseClass", LicenseClass);
         command.Parameters.AddWithValue("@IssueDate", IssueDate);

         command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);

         if (Notes == "")
            command.Parameters.AddWithValue("@Notes", DBNull.Value);
         else
            command.Parameters.AddWithValue("@Notes", Notes);

         command.Parameters.AddWithValue("@PaidFees", PaidFees);
         command.Parameters.AddWithValue("@IsActive", IsActive);
         command.Parameters.AddWithValue("@IssueReason", IssueReason);

         command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);



         try
         {
            connection.Open();

            object result = command.ExecuteScalar();

            if (result != null && int.TryParse(result.ToString(), out int insertedID))
            {
               LicenseID = insertedID;
            }
         }

         catch (Exception ex)
         {
            //Console.WriteLine("Error: " + ex.Message);

         }

         finally
         {
            connection.Close();
         }


         return LicenseID;

      }

      public static bool UpdateLicense(int LicenseID, int ApplicationID, int DriverID, int LicenseClass,
           DateTime IssueDate, DateTime ExpirationDate, string Notes,
           float PaidFees, bool IsActive, byte IssueReason, int CreatedByUserID)
      {

         int rowsAffected = 0;
         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);

         string query = @"UPDATE Licenses
                           SET ApplicationID=@ApplicationID, DriverID = @DriverID,
                              LicenseClass = @LicenseClass,
                              IssueDate = @IssueDate,
                              ExpirationDate = @ExpirationDate,
                              Notes = @Notes,
                              PaidFees = @PaidFees,
                              IsActive = @IsActive,IssueReason=@IssueReason,
                              CreatedByUserID = @CreatedByUserID
                         WHERE LicenseID=@LicenseID";

         SqlCommand command = new SqlCommand(query, connection);

         command.Parameters.AddWithValue("@LicenseID", LicenseID);
         command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
         command.Parameters.AddWithValue("@DriverID", DriverID);
         command.Parameters.AddWithValue("@LicenseClass", LicenseClass);
         command.Parameters.AddWithValue("@IssueDate", IssueDate);
         command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);

         if (Notes == "")
            command.Parameters.AddWithValue("@Notes", DBNull.Value);
         else
            command.Parameters.AddWithValue("@Notes", Notes);

         command.Parameters.AddWithValue("@PaidFees", PaidFees);
         command.Parameters.AddWithValue("@IsActive", IsActive);
         command.Parameters.AddWithValue("@IssueReason", IssueReason);
         command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

         try
         {
            connection.Open();
            rowsAffected = command.ExecuteNonQuery();

         }
         catch (Exception ex)
         {
            //Console.WriteLine("Error: " + ex.Message);
            return false;
         }

         finally
         {
            connection.Close();
         }

         return (rowsAffected > 0);
      }

      public static int GetActiveLicenseIDByPersonID(int PersonID, int LicenseClassID)
      {
         int LicenseID = -1;

         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);

         string query = @"SELECT        Licenses.LicenseID
                            FROM Licenses INNER JOIN
                                                     Drivers ON Licenses.DriverID = Drivers.DriverID
                            WHERE  
                             
                             Licenses.LicenseClass = @LicenseClass 
                              AND Drivers.PersonID = @PersonID
                              And IsActive=1;";

         SqlCommand command = new SqlCommand(query, connection);

         command.Parameters.AddWithValue("@PersonID", PersonID);
         command.Parameters.AddWithValue("@LicenseClass", LicenseClassID);

         try
         {
            connection.Open();

            object result = command.ExecuteScalar();

            if (result != null && int.TryParse(result.ToString(), out int insertedID))
            {
               LicenseID = insertedID;
            }
         }

         catch (Exception ex)
         {
            //Console.WriteLine("Error: " + ex.Message);

         }

         finally
         {
            connection.Close();
         }


         return LicenseID;
      }

      public static bool DeactivateLicense(int LicenseID)
      {

         int rowsAffected = 0;
         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);

         string query = @"UPDATE Licenses
                           SET 
                              IsActive = 0
                             
                         WHERE LicenseID=@LicenseID";

         SqlCommand command = new SqlCommand(query, connection);

         command.Parameters.AddWithValue("@LicenseID", LicenseID);


         try
         {
            connection.Open();
            rowsAffected = command.ExecuteNonQuery();

         }
         catch (Exception ex)
         {
            //Console.WriteLine("Error: " + ex.Message);
            return false;
         }

         finally
         {
            connection.Close();
         }

         return (rowsAffected > 0);
      }
   }
}
