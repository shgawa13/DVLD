using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DataLayer
{
   public class clsDriverData
   {

      public static int AddNewDriver(int PersonID, int CreatedByUserID)
      {
         int DriverID = -1;

         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);
         string Query = @"Insert Into Drivers (PersonID,CreatedByUserID,CreatedDate)
                            Values (@PersonID,@CreatedByUserID,@CreatedDate);
                          
                            SELECT SCOPE_IDENTITY();";
         SqlCommand command = new SqlCommand(Query, connection);

         command.Parameters.AddWithValue("@PersonID",PersonID);
         command.Parameters.AddWithValue("@CreatedByUserID",CreatedByUserID);
         command.Parameters.AddWithValue("@CreatedDate", DateTime.Now);

         try
         {
            connection.Open();
            object result = command.ExecuteScalar();

            if(result != null && int.TryParse((string)result, out int ID))
            {
               DriverID = ID;
            }
         }
         catch(Exception ex)
         {

         }
         finally
         {
            connection.Close();
         }

         return DriverID;
      }

      public static bool UpdateDriver(int DriverID, int PersonID, int CreatedByUserID)
      {
         int rowsEffected = 0;

         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);
         string Query = @"Updated Drivers 
                         set PersonID = @PersonID,
                         CreatedByUserID = @CreatedByUserID
                         where DriverID = @DriverID";
         SqlCommand command = new SqlCommand(Query, connection);

         command.Parameters.AddWithValue("@DriverID", DriverID);
         command.Parameters.AddWithValue("@PersonID", PersonID);
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


         return (rowsEffected >0);
      }

      // GetDriver by DriverID
      public static bool GetDriverInfoByDriverID(int DriverID, ref int PersonID, ref int CreatedByUserID,
         ref DateTime CreatedDate)
      {
         bool IsFound = false;

         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);
         string Query = @"Select * From Drivers Where DriverID=@DriverID";
         SqlCommand command = new SqlCommand(Query, connection);

         command.Parameters.AddWithValue("@DriverID", DriverID);

         try
         {
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
               IsFound = true;

               PersonID = (int)reader["PersonID"];
               CreatedByUserID = (int)reader["CreatedByUserID"];
               CreatedDate = (DateTime)reader["CreatedDate"];

            }

            reader.Close();
         }
         catch(Exception ex)
         {
            return false;
         }
         finally
         {
            connection.Close();
         }


         return IsFound;
      }

      // GetDriver by PersonID
      public static bool GetDriverInfoByPersonID(int PersonID,ref int DriverID, ref int CreatedByUserID,
         ref DateTime CreatedDate)
      {
         bool IsFound = false;

         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);
         string Query = @"Select * From Drivers Where PersonID=@PersonID";
         SqlCommand command = new SqlCommand(Query, connection);

         command.Parameters.AddWithValue("@PersonID", PersonID);

         try
         {
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
               IsFound = true;

               PersonID = (int)reader["DriverID"];
               CreatedByUserID = (int)reader["CreatedByUserID"];
               CreatedDate = (DateTime)reader["CreatedDate"];

            }

            reader.Close();
         }
         catch (Exception ex)
         {
            return false;
         }
         finally
         {
            connection.Close();
         }


         return IsFound;
      }

      // Get All Drivers
      public static DataTable GetAllDrivers()
      {
         DataTable dtDrivers = new DataTable();

         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);
         string Query = @"SELECT * FROM Drivers_View order by FullName";
         SqlCommand command = new SqlCommand(Query, connection);

         try
         {
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
               dtDrivers.Load(reader);
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

         return dtDrivers;
      }

      

   }
}
