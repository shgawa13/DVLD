using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DataLayer
{
   public  class clsApplicationTypesData
   {

      public static bool GetApplicationTypeByID(int ApplicationTypeID,ref string ApplicationTypeTitle
         ,ref float ApplicationFees)
      {
         bool IsFound = false;
         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);
         string Query = @"Select * from ApplicationTypes where ApplicationTypeID=@ApplicationTypeID;";
         SqlCommand command = new SqlCommand(Query, connection);

         command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);

         try
         {
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
               IsFound = true;
               ApplicationTypeTitle = (string)reader["ApplicationTypeTitle"];
               ApplicationFees = Convert.ToSingle( reader["ApplicationFees"]);

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


      public static DataTable GetAllApplicationTypes()
      {
         DataTable dt = new DataTable();
         
         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);
         string Query = @"Select * From ApplicationTypes";
         SqlCommand command = new SqlCommand(Query, connection);

         try
         {
            connection.Open();
            SqlDataReader reder = command.ExecuteReader();

            if (reder.HasRows)
            {
               dt.Load(reder);
            }

         }
         catch(Exception ex)
         {
            connection.Close();
         }
         finally
         {
            connection.Close() ;
         }

         return dt;
      }

       public static bool UpdateApplicationType(int ApplicationTypeID, string ApplicationTypeTitle,
         double ApplicationFees)
      {
         int rowsEffected = 0;
         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);
         string Query = @"Update ApplicationTypes
                        set ApplicationTypeTitle=@ApplicationTypeTitle,
                            ApplicationFees=@ApplicationFees Where
                            ApplicationTypeID=@ApplicationTypeID;";
         SqlCommand command = new SqlCommand(Query, connection);

         command.Parameters.AddWithValue("@ApplicationTypeTitle", ApplicationTypeTitle);
         command.Parameters.AddWithValue("@ApplicationFees", ApplicationFees);
         command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);

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
