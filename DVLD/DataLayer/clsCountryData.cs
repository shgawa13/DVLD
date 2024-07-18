using System;
using System.Data;
using System.Data.SqlClient;

namespace DataLayer
{ 

   public class clsCountryData
   {
      public static bool GetCountryByID(int ID, ref string CountryName)
      {
         bool IsFound = false;

         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);
         string Query = "Select * from Countries where CountryID=@ID;";
         SqlCommand command = new SqlCommand(Query, connection);
         command.Parameters.AddWithValue("@ID", ID);
         try
         {
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
               IsFound = true;
               CountryName = (string)reader["CountryName"];
            }
            reader.Close();
         }
         catch (Exception)
         {
            IsFound = false;
         }
         finally
         {
            connection.Close();
         }
         return IsFound;
      }

      public static bool GetCountryByName(string CountryName, ref int ID)
      {
         bool IsFound = false;
         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);
         string Query = "select * from Countries where CountryName =@CountryName;";
         SqlCommand command = new SqlCommand(Query, connection);
         command.Parameters.AddWithValue("@CountryName", CountryName);
         try
         {
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
               IsFound = true;
               ID = (int)reader["CountryID"];
            }
            reader.Close();
         }
         catch (Exception)
         {
         }
         finally
         {
            connection.Close();
         }
         return IsFound;
      }

      public static DataTable GetAllCountries()
      {
         DataTable Dt = new DataTable();
         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);
         string Query = "Select * from Countries;";
         SqlCommand command = new SqlCommand(Query, connection);
         try
         {
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
               Dt.Load(reader);
            }
         }
         catch (Exception ex)
         {
         }
         finally
         {
            connection.Close();
         }
         return Dt;
      }
   }
}
