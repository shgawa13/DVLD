using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
   public class clsTestTypeData
   {
      
      public static int AddNewTypeTest(string TypeTestTitle, string TestTypeDescription, float Fees)
      {
         int TestTypeID = 0;
         
         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);
         string Query = @"Insert Into TestTypes(TypeTestTitle,TestTypeDescription,Fees)
                        Values(@TypeTestTitle,@TestTypeDescription,@Fees);
                        Select SCOPE_IDENTITY();";
         SqlCommand command = new SqlCommand(Query, connection);

         command.Parameters.AddWithValue("@TypeTestTitle", TypeTestTitle);
         command.Parameters.AddWithValue("@TestTypeDescription", TestTypeDescription);
         command.Parameters.AddWithValue("@Fees", Fees);

         try
         {
            connection.Open();
            object result = command.ExecuteScalar();
            
            if(result !=null && int.TryParse((string)result, out int ID))
            {
               TestTypeID = ID;
            }
         
         }
         catch(Exception ex)
         {
            return 0;
         }
         finally
         {
            connection.Close();
         }

         return TestTypeID;
      }

      public static bool GetTestTypeByID(int TestTypeID,ref string TestTypeTitle,
         ref string TestTypeDescription, ref float TestTypeFees)
      {
         bool IsFound=false;

         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);
         string Query = @"Select * From TestTypes where TestTypeID=@TestTypeID;";
         SqlCommand command = new SqlCommand(Query, connection);

         command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

         try
         {
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
               IsFound = true;
               TestTypeTitle = (string)reader["TestTypeTitle"];
               TestTypeDescription = (string)reader["TestTypeDescription"];
               TestTypeFees = Convert.ToSingle(reader["TestTypeFees"]);
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

      public static DataTable GetAllTypeTes()
      {
         DataTable dt = new DataTable();

         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);
         string Query = @"Select * From TestTypes;";
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
            connection.Close();
         }
         finally
         {
            connection.Close();

         }

         return dt;
      }


      public static bool UpdateTestType(int TestTypeID, string TestTypeTitle,
         string TestTypeDescription, float TestTypeFees)
      {
         int rowsEffected = 0;


         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);
         string Query = @"Update TestTypes
                        set TestTypeTitle=@TestTypeTitle,
                        TestTypeDescription=@TestTypeDescription,
                        TestTypeFees=@TestTypeFees
                        Where TestTypeID=@TestTypeID;";
         SqlCommand command = new SqlCommand(Query, connection);

         command.Parameters.AddWithValue("@TestTypeTitle", TestTypeTitle);
         command.Parameters.AddWithValue("@TestTypeDescription", TestTypeDescription);
         command.Parameters.AddWithValue("@TestTypeFees", TestTypeFees);
         command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
         
         try
         {
            connection.Open();
            rowsEffected = command.ExecuteNonQuery();
         }
         catch (Exception ex)
         {
            rowsEffected = 0;
         }
         finally
         {
            connection.Close();
         }

         return (rowsEffected > 0);
      }

   }
}
