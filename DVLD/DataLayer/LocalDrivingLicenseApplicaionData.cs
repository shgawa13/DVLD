using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace DataLayer
{
   public class LocalDrivingLicenseApplicaionData
   {

      public static int AddNewLocalDrivingLicenseApplication(int ApplicationID,int LicenseClassID)
      {
         int LocalDrivingAppID = -1;

         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);
         string Query = @"Insert Into LocalDrivingLicenseApplications(ApplicationID,LicenseClassID)
                        Values(@ApplicationID,@LicenseClassID);
                        Select  SCOPE_IDENTITY();";
         SqlCommand command = new SqlCommand(Query, connection);

         command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
         command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);


         try
         {

            connection.Open();
            object result = command.ExecuteScalar();

            if(result !=null && int.TryParse((string)result, out int ID))
            {
               LocalDrivingAppID = ID;
            }

         }
         catch(Exception ex)
         {
            return -1;
         }
         finally
         {
            connection.Close();
         }

         return LocalDrivingAppID;
      }


      public static bool UpdateLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID,
         int ApplicationID, int LicenseClassID)
      {
         int rowsEffected = -1;

         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);
         string Query = @"Update LocalDrivingLicenseApplications 
                     set ApplicationID=@ApplicationID,
                         LicenseClassID=@LicenseClassID
           Where LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID;";
         SqlCommand command = new SqlCommand(Query, connection);

         command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
         command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
         command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

         try
         {
            connection.Open();
            rowsEffected = command.ExecuteNonQuery();
         }
         catch(Exception ex)
         {
            return false;
         }
         finally
         {
            connection.Close();
         }

         return (rowsEffected != -1);
      }

      public static bool GetLocalDrivingLicenseApplicationInfoByID(int LocalDrivingLicenseApplicationID,
         ref int ApplicationID,ref int LicenseClassID)
      {
         bool IsFound = false;
         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);
         string Query = @"Select * From LocalDrivingLicenseApplications Where LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID;";
         SqlCommand command = new SqlCommand(Query, connection);

         command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

         try
         {
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
               IsFound = true;

               ApplicationID = (int)reader["ApplicationID"];
               LicenseClassID = (int)reader["LicenseClassID"];
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


      public static bool GetLocalDrivingLicenseApplicationInfoByApplicationID( int ApplicationID,
         ref int LocalDrivingLicenseApplicationID, ref int LicenseClassID)
      {
         bool IsFound = false;
         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);
         string Query = @"Select * From LocalDrivingLicenseApplications Where ApplicationID=@ApplicationID;";
         SqlCommand command = new SqlCommand(Query, connection);

         command.Parameters.AddWithValue("@ApplicationID",ApplicationID);

         try
         {
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
               IsFound = true;

               LocalDrivingLicenseApplicationID = (int)reader["LocalDrivingLicenseApplicationID"];
               LicenseClassID = (int)reader["LicenseClassID"];
            }
            else
            {
               IsFound = false;
            }
            reader.Close();
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


      public static DataTable GetAllLocalDrivingLicenseApplications()
      {
         DataTable dt = new DataTable();
         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);
         string Query = @"Select * From LocalDrivingLicenseApplications_View
                              order by ApplicationDate Desc;";
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
            return null;
         }
         finally
         {
            connection.Close();
         }

         return dt;
      }

      public static bool DeleteLocalDrivingLicenseApplication(int LocalDrivingLicenseApplication)
      {
         int rowsEffected = 0;

         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);
         string Query = @"Delete LocalDrivingLicenseApplications
                        Where LocalDrivingLicenseApplication=@LocalDrivingLicenseApplication;";
         SqlCommand command = new SqlCommand(Query, connection);

         command.Parameters.AddWithValue("@LocalDrivingLicenseApplication", LocalDrivingLicenseApplication);

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

         return (rowsEffected > 0);
      }

      public static bool DosePassTestType(int LocalDrivingLicenseApplicationID,int TestTypeID)
      {
         bool Result = false;

         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);
         string Query = @" SELECT top 1 TestResult
                            FROM LocalDrivingLicenseApplications INNER JOIN
                                 TestAppointments ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID INNER JOIN
                                 Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                            WHERE
                            (LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID) 
                            AND(TestAppointments.TestTypeID = @TestTypeID)
                            ORDER BY TestAppointments.TestAppointmentID desc";
         SqlCommand command = new SqlCommand(Query, connection);

         command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
         command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

         try
         {
            connection.Open();
            object result = command.ExecuteScalar();

            if (result != null && bool.TryParse((string)result, out bool returnResult)) 
            {

               Result = returnResult;

            }
         }
         catch(Exception ex)
         {

         }
         finally
         {
            connection.Close();
         }

         return Result;
      }

      public static bool DoesAttendTestType(int LocalDrivingLicenseApplicationID, int TestTypeID)

      {


         bool IsFound = false;

         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);

         string query = @" SELECT top 1 Found=1
                            FROM LocalDrivingLicenseApplications INNER JOIN
                                 TestAppointments ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID INNER JOIN
                                 Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                            WHERE
                            (LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID) 
                            AND(TestAppointments.TestTypeID = @TestTypeID)
                            ORDER BY TestAppointments.TestAppointmentID desc";

         SqlCommand command = new SqlCommand(query, connection);

         command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
         command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

         try
         {
            connection.Open();

            object result = command.ExecuteScalar();

            if (result != null)
            {
               IsFound = true;
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

         return IsFound;

      }

      public static byte TotalTrialsPerTest(int LocalDrivingLicenseApplicationID, int TestTypeID)

      {


         byte TotalTrialsPerTest = 0;

         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);

         string query = @" SELECT TotalTrialsPerTest = count(TestID)
                            FROM LocalDrivingLicenseApplications INNER JOIN
                                 TestAppointments ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID INNER JOIN
                                 Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                            WHERE
                            (LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID) 
                            AND(TestAppointments.TestTypeID = @TestTypeID)
                       ";

         SqlCommand command = new SqlCommand(query, connection);

         command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
         command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

         try
         {
            connection.Open();

            object result = command.ExecuteScalar();

            if (result != null && byte.TryParse(result.ToString(), out byte Trials))
            {
               TotalTrialsPerTest = Trials;
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

         return TotalTrialsPerTest;

      }

      public static bool IsThereAnActiveScheduledTest(int LocalDrivingLicenseApplicationID, int TestTypeID)

      {

         bool Result = false;

         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);

         string query = @" SELECT top 1 Found=1
                            FROM LocalDrivingLicenseApplications INNER JOIN
                                 TestAppointments ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID 
                            WHERE
                            (LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID)  
                            AND(TestAppointments.TestTypeID = @TestTypeID) and isLocked=0
                            ORDER BY TestAppointments.TestAppointmentID desc";

         SqlCommand command = new SqlCommand(query, connection);

         command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
         command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

         try
         {
            connection.Open();

            object result = command.ExecuteScalar();


            if (result != null)
            {
               Result = true;
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

         return Result;

      }
   }
}
