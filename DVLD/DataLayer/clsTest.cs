﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataLayer
{
   public class clsTest
   {
      public static bool GetTestInfoByID(int TestID,ref int TestAppointment, ref bool TestResult,
               ref string Notes,ref int CreatedByUserID)
      {
         bool IsFound = false;

         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);
         string Query = @"Select * From Tests where TestID=@TestID;";
         SqlCommand command = new SqlCommand(Query, connection);

         command.Parameters.AddWithValue("@TestID", TestID);

         try
         {
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
               IsFound = true;

               TestAppointment = (int)reader["TestAppointment"];
               TestResult = (bool)reader["TestResult"];

               if (reader["Notes"] == DBNull.Value)
                  Notes = "";
               else
                  Notes = (string)reader["Notes"];

               CreatedByUserID = (int)reader["CreatedByUserID"];
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

      public static bool GetLastTestByPersonAndTestTypeAndLicenseClass
          (int PersonID, int LicenseClassID, int TestTypeID, ref int TestID,
            ref int TestAppointmentID, ref bool TestResult,
            ref string Notes, ref int CreatedByUserID)
      {
         bool isFound = false;

         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);

         string query = @"SELECT  top 1 Tests.TestID, 
                Tests.TestAppointmentID, Tests.TestResult, 
			    Tests.Notes, Tests.CreatedByUserID, Applications.ApplicantPersonID
                FROM            LocalDrivingLicenseApplications INNER JOIN
                                         Tests INNER JOIN
                                         TestAppointments ON Tests.TestAppointmentID = TestAppointments.TestAppointmentID ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID INNER JOIN
                                         Applications ON LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID
                WHERE        (Applications.ApplicantPersonID = @PersonID) 
                        AND (LocalDrivingLicenseApplications.LicenseClassID = @LicenseClassID)
                        AND ( TestAppointments.TestTypeID=@TestTypeID)
                ORDER BY Tests.TestAppointmentID DESC";

         SqlCommand command = new SqlCommand(query, connection);

         command.Parameters.AddWithValue("@PersonID", PersonID);
         command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
         command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

         try
         {
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {

               // The record was found
               isFound = true;
               TestID = (int)reader["TestID"];
               TestAppointmentID = (int)reader["TestAppointmentID"];
               TestResult = (bool)reader["TestResult"];
               if (reader["Notes"] == DBNull.Value)

                  Notes = "";
               else
                  Notes = (string)reader["Notes"];

               CreatedByUserID = (int)reader["CreatedByUserID"];

            }
            else
            {
               // The record was not found
               isFound = false;
            }

            reader.Close();


         }
         catch (Exception ex)
         {
            //Console.WriteLine("Error: " + ex.Message);
            isFound = false;
         }
         finally
         {
            connection.Close();
         }

         return isFound;
      }

      public static DataTable GetAllTest()
      {
         DataTable dt = new DataTable();

         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);
         string Query = @"Select * From Tests order by TestID;";
         SqlCommand command = new SqlCommand(Query, connection);

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
         catch(Exception ex)
         {
            dt = null;
         }
         finally
         {
            connection.Close();
         }

         return dt;
      }


      public static int AddNewTest(int TestAppointmentID, bool TestResult,
           string Notes, int CreatedByUserID)
      {
         int TestID = -1;

         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);

         string query = @"Insert Into Tests (TestAppointmentID,TestResult,
                                                Notes,   CreatedByUserID)
                            Values (@TestAppointmentID,@TestResult,
                                                @Notes,   @CreatedByUserID);
                            
                                UPDATE TestAppointments 
                                SET IsLocked=1 where TestAppointmentID = @TestAppointmentID;

                                SELECT SCOPE_IDENTITY();";

         SqlCommand command = new SqlCommand(query, connection);

         command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
         command.Parameters.AddWithValue("@TestResult", TestResult);

         if (Notes != "" && Notes != null)
            command.Parameters.AddWithValue("@Notes", Notes);
         else
            command.Parameters.AddWithValue("@Notes", System.DBNull.Value);



         command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

         try
         {
            connection.Open();

            object result = command.ExecuteScalar();

            if (result != null && int.TryParse(result.ToString(), out int insertedID))
            {
               TestID = insertedID;
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


         return TestID;

      }

      public static bool UpdateTest(int TestID, int TestAppointmentID, bool TestResult,
           string Notes, int CreatedByUserID)
      {

         int rowsAffected = 0;
         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);

         string query = @"Update  Tests  
                            set TestAppointmentID = @TestAppointmentID,
                                TestResult=@TestResult,
                                Notes = @Notes,
                                CreatedByUserID=@CreatedByUserID
                                where TestID = @TestID";

         SqlCommand command = new SqlCommand(query, connection);

         command.Parameters.AddWithValue("@TestID", TestID);
         command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
         command.Parameters.AddWithValue("@TestResult", TestResult);
         command.Parameters.AddWithValue("@Notes", Notes);
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

      public static byte GetPassedTestCount(int LocalDrivingLicenseApplicationID)
      {
         byte PassedTestCount = 0;

         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);

         string query = @"SELECT PassedTestCount = count(TestTypeID)
                         FROM Tests INNER JOIN
                         TestAppointments ON Tests.TestAppointmentID = TestAppointments.TestAppointmentID
						 where LocalDrivingLicenseApplicationID =@LocalDrivingLicenseApplicationID and TestResult=1";

         SqlCommand command = new SqlCommand(query, connection);

         command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);


         try
         {
            connection.Open();

            object result = command.ExecuteScalar();

            if (result != null && byte.TryParse(result.ToString(), out byte ptCount))
            {
               PassedTestCount = ptCount;
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

         return PassedTestCount;



      }


   }
}
