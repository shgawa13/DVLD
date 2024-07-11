using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataLayer
{
   public class clsApplicationData
   {

     public static int AddNewApplication(int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID,
         byte ApplicationStatus, DateTime LastStatusDate, float PaidFees, int CreatedByUserID)
      {
         int ApplicationID = -1;

         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);
         string Query = @"Insert Into Applications(ApplicantPersonID,ApplicationDate, ApplicationTypeID
                        ,ApplicationStatus,LastStatusDate,PaidFees,CreatedByUserID)
                        Values(@ApplicantPersonID,@ApplicationDate,@ApplicationTypeID
                        ,@ApplicationStatus,@LastStatusDate,@PaidFees,@CreatedByUserID);
                        SELECT SCOPE_IDENTITY();";

         SqlCommand command = new SqlCommand(Query, connection);

         command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
         command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
         command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
         command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
         command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
         command.Parameters.AddWithValue("@PaidFees", PaidFees);
         command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

         try
         {
            connection.Open();
            object result = command.ExecuteScalar();

            if (result != null && int.TryParse((string)result, out int ID)) 
            {
               ApplicationID = ID;       
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

         return ApplicationID;
      }

      // Find ApplicationByID

      public static bool GetApplicationInfoByID(int ApplicationID,ref int ApplicantPersonID,ref DateTime ApplicationDate,
         ref int ApplicationTypeID,ref byte ApplicationStatus,ref DateTime LastStatusDate,ref float PaidFees,
         ref int CreatedByUserID)
      {
         bool IsFound = false;

         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);
         string Query = @"Select * from Applications Where ApplicationID=@ApplicationID";
         SqlCommand command = new SqlCommand(Query, connection);

         command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
         

         try
         {
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
               IsFound = true;

               ApplicantPersonID = (int)reader["ApplicantPersonID"];
               ApplicationDate = (DateTime)reader["ApplicationDate"];
               ApplicationTypeID = (int)reader["ApplicationTypeID"];
               ApplicationStatus = (byte)reader["ApplicationStatus"];
               LastStatusDate = (DateTime)reader["LastStatusDate"];
               PaidFees = Convert.ToSingle(reader["PaidFees"]);
               CreatedByUserID = (int)reader["CreatedByUserID"];

            }
            else
            {
               IsFound = false;
            }
            connection.Close();
         }
         catch(Exception ex)
         {

         }
         finally
         {
            connection.Close();
         }

         return IsFound;
      }

      public static DataTable GetAllApplications()
      {
         DataTable dt = new DataTable();

         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);
         string Query = @"Select * from ApplicationsList_View order by ApplicationDate desc;";
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
            dt = null;
         }
         finally
         {
            connection.Close();
         }

         return dt;
      }


      public static bool UpdateApplication(int ApplicationID, int ApplicantPersonID, DateTime ApplicationDate,
          int ApplicationTypeID, byte ApplicationStatus, DateTime LastStatusDate,  float PaidFees,
          int CreatedByUserID)
      {
         int rowsEffected = 0;

         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);
         string Query = @"Update Applications
                        set ApplicantPersonID=@ApplicantPersonID,
                        ApplicationDate=@ApplicationDate,
                        ApplicationTypeID=@ApplicationTypeID,
                        ApplicationStatus=@ApplicationStatus,
                        LastStatusDate=@LastStatusDate,
                        PaidFees=@PaidFees,
                        CreatedByUserID=@CreatedByUserID
                        where ApplicationID=@ApplicationID;";
         SqlCommand command = new SqlCommand(Query, connection);

         command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
         command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
         command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
         command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
         command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
         command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
         command.Parameters.AddWithValue("@PaidFees", PaidFees);
         command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

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

      public static bool DeleteApplication(int ApplicationID) 
      {
         int rowsEffected = 0;

         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);
         string Query = @"Delete Applications Where ApplicationID=@ApplicationID;";
         SqlCommand command = new SqlCommand(Query, connection);

         command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

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


   }
}
