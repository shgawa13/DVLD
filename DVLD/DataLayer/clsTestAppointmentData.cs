using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.SqlServer.Server;

namespace DataLayer
{
   public class clsTestAppointmentData
   {

      public static bool GetTestAppointmentInfoByID(int TestAppointmentID,
           ref int TestTypeID, ref int LocalDrivingLicenseApplicationID,
           ref DateTime AppointmentDate, ref float PaidFees, ref int CreatedByUserID, ref bool IsLocked, ref int RetakeTestApplicationID)
      {
         bool IsFound = false;

         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);
         string Query = @"Select * From TestAppointments Where TestAppointmentID=@TestAppointmentID;";
         SqlCommand command = new SqlCommand(Query, connection);

         command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
        

         try
         {
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
               IsFound = true;

               TestTypeID = (int)reader["TestTypeID"];
               LocalDrivingLicenseApplicationID = (int)reader["LocalDrivingLicenseApplicationID"];
               AppointmentDate = (DateTime)reader["AppointmentDate"];
               PaidFees = Convert.ToSingle(reader["PaidFees"]);
               CreatedByUserID = (int)reader["CreatedByUserID"];
               IsLocked = (bool)reader["IsLocked"];
               if (reader["RetakeTestApplicationID"] == DBNull.Value)
                  RetakeTestApplicationID = -1;
               else
                  RetakeTestApplicationID = (int)reader["RetakeTestApplicationID"];
            }
            else
            {
               IsFound = false;
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


      public static bool GetLastTestAppointment(
             int LocalDrivingLicenseApplicationID, int TestTypeID,
            ref int TestAppointmentID, ref DateTime AppointmentDate,
            ref float PaidFees, ref int CreatedByUserID, ref bool IsLocked, ref int RetakeTestApplicationID)
      {
         bool IsFound = false;

         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);
         string Query = @"Select top 1 * From TestAppointment
                        Where (TestTypeID=@TestTypeID) And
           (LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID)
                        order by TestAppointmentID Desc;";
         SqlCommand command = new SqlCommand(Query, connection);

         command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
         command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

         try
         {
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
               IsFound = true;

               TestAppointmentID = (int)reader["TestAppointmentID"];
               AppointmentDate = (DateTime)reader["AppointmentDate"];
               PaidFees = Convert.ToSingle(reader["PaidFees"]);
               CreatedByUserID = (int)reader["CreatedByUserID"];
               IsLocked = (bool)reader["IsLocked"];

               if (reader["RetakeTestApplicationID"] == DBNull.Value)
                  RetakeTestApplicationID = -1;
               else
                  RetakeTestApplicationID = (int)reader["RetakeTestApplicationID"];

            }
            else
            {
               IsFound = false;
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


         public static int AddNewTestAppointment(
             int TestTypeID, int LocalDrivingLicenseApplicationID,
             DateTime AppointmentDate, float PaidFees, int CreatedByUserID, int RetakeTestApplicationID)
      {
         int TestAppointmentID = -1;

         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);
         string Query = @"Insert into TestAppointments(TestTypeID,LocalDrivingLicenseApplicationID,AppointmentDate,PaidFees,CreatedByUserID,RetakeTestApplicationID)
                        Values(@TestTypeID,@LocalDrivingLicenseApplicationID,@AppointmentDate,@PaidFees,@CreatedByUserID,@RetakeTestApplicationID);
                        SELECT SCOPE_IDENTITY();";
         SqlCommand command = new SqlCommand(Query, connection);

         command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
         command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
         command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
         command.Parameters.AddWithValue("@PaidFees", PaidFees);
         command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

         if(RetakeTestApplicationID ==-1)
            command.Parameters.AddWithValue("@RetakeTestApplicationID", DBNull.Value);
         else
            command.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestApplicationID);

         try
         {
            connection.Open();
            object result = command.ExecuteScalar();

            if(result != null && int.TryParse((string)result, out int ID))
            {
               TestAppointmentID = ID;
            }
         }
         catch(Exception ex)
         {


         }
         finally
         {

         }

         return TestAppointmentID;
      }


      public static DataTable GetAllTestAppointments()
      {
         DataTable dt = new DataTable();

         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);
         string Query = @"select * from TestAppointments_View
                                  order by AppointmentDate Desc";
         SqlCommand command = new SqlCommand(Query,connection);

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
           
         }
         finally
         {
            connection.Close();
         }


         return dt;
      }

      public static DataTable GetApplicationTestAppointmentsPerTestType(int LocalDrivingLicenseApplicationID, int TestTypeID)
      {
         DataTable dt = new DataTable();

         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);
         string Query = @"SELECT TestAppointmentID, AppointmentDate,PaidFees, IsLocked
                        FROM TestAppointments
                        WHERE  
                        (TestTypeID = @TestTypeID) 
                        AND (LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID)
                        order by TestAppointmentID desc;";
         SqlCommand command = new SqlCommand(Query, connection);

         command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
         command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

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

         }
         finally
         {
            connection.Close();
         }

         return dt;
      }

      public static bool UpdateTestAppointment(int TestAppointmentID, int TestTypeID, int LocalDrivingLicenseApplicationID,
             DateTime AppointmentDate, float PaidFees,
             int CreatedByUserID, bool IsLocked, int RetakeTestApplicationID)
      {
         int rowsEffected = 0;

         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);
         string Query = @"Update TestAppointments
                  Set TestTypeID=@TestTypeID,
                  LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID,
                  AppointmentDate=@AppointmentDate,
                  PaidFees=@PaidFees,
                  CreatedByUserID=@CreatedByUserID,
                  IsLocked=@IsLocked,
                  RetakeTestApplicationID=@RetakeTestApplicationID
                  Where TestAppointmentID=@TestAppointmentID";
         SqlCommand command = new SqlCommand(Query, connection);

         command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
         command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
         command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
         command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
         command.Parameters.AddWithValue("@PaidFees", PaidFees);
         command.Parameters.AddWithValue("@IsLocked", IsLocked);
         command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
         if (RetakeTestApplicationID == -1)
            command.Parameters.AddWithValue("@RetakeTestApplicationID", DBNull.Value);
         else
            command.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestApplicationID);
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
         return (rowsEffected > 0);
      }

       public static int GetTestID(int TestAppointmentID)
      {
         int TestID = -1;

         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);
         string Query = @"Select TestID From Tests Where TestAppointmentID=@TestAppointmentID";
         SqlCommand command = new SqlCommand(Query, connection);

         command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

         try
         {
            connection.Open();

            object result = command.ExecuteScalar();

            if(result != null && int.TryParse((string)result,out int ID))
            {
               TestID = ID;
            }

         }
         catch (Exception ex)
         {

         }
         finally
         {
            connection.Close();
         }

         return TestID;
      }

      
   }
}
