using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace DataLayer
{
   public class clsUsersData
   {
      // Get User by UserID

      public static bool GetUserByUserID(int UserID, ref int PersonID, ref string UserName,
                   ref string Password, ref bool IsActive)
      {
         bool IsFound = false;

         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);
         string Query = @"Select * From Users Where UserID =@UserID;";
         SqlCommand command = new SqlCommand(Query, connection);

         command.Parameters.AddWithValue("UserID", UserID);

         try
         {
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
               // User Found
               IsFound = true;

               PersonID = (int)reader["PersonID"];
               UserName = (string)reader["UserName"];
               Password = (string)reader["Password"];
               IsActive = (bool)reader["IsActive"];
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

      // Get User by PersonID
      public static bool GetUserInfoByPersonID(int PersonID, ref int UserID, ref string UserName,
                   ref string Password, ref bool IsActive)
      {
         bool IsFound = false;

         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);
         string Query = @"Select * From Users Where PersonID =@PersonID;";
         SqlCommand command = new SqlCommand(Query, connection);

         command.Parameters.AddWithValue("@PersonID", PersonID);

         try
         {
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
               IsFound = true;


               UserID = (int)reader["UserID"];
               UserName = (string)reader["UserName"];
               Password = (string)reader["Password"];
               IsActive = (bool)reader["IsActive"];
            }
            else
            {
               IsFound = false;
            }
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


      // Get User by UserName and Password
      public static bool GetUserInfoByUsernameAndPassword(string UserName, string Password,
            ref int UserID, ref int PersonID, ref bool IsActive)
      {
         bool IsFound = false;

         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);
         string Query = @"Select * From Users Where UserName =@UserName and Password=@Password;";
         SqlCommand command = new SqlCommand(Query, connection);

         command.Parameters.AddWithValue("@UserName", UserName);
         command.Parameters.AddWithValue("@Password", Password);

         try
         {
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
               IsFound = true;

               UserID = (int)reader["UserID"];
               PersonID = (int)reader["PersonID"];
               IsActive = (bool)reader["IsActive"];

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

      // Add new User
      public static int  AddNewUser(int PersonID, string UserName, string Password, bool IsActive)
      {
         int UserID = -1;

         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);
         string Query = @"Insert into Users (PersonID,UserName,Password,IsActive)
                         values(@PersonID,@UserName,@Password,@IsActive);
                         SELECT SCOPE_IDENTITY();";
         SqlCommand command = new SqlCommand(Query, connection);

         command.Parameters.AddWithValue("@PersonID", PersonID);
         command.Parameters.AddWithValue("@UserName", UserName);
         command.Parameters.AddWithValue("@Password", Password);
         command.Parameters.AddWithValue("@IsActive", IsActive);

         try
         {
            connection.Open();
            object result = command.ExecuteScalar();
         
            if(result !=null && int.TryParse(result.ToString(), out int ID))
            {
               UserID = ID;
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

         return UserID;
      }

      // Update User
      public static bool UpdateUser(int UserID, int PersonID, string UserName,
             string Password, bool IsActive)
      {
         int rowsAffected = 0;

         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);
         string Query = @"Update Users
                         set PersonID = @PersonID,
                                UserName = @UserName,
                                Password = @Password,
                                IsActive = @IsActive
                                where UserID = @UserID";
         SqlCommand command = new SqlCommand(Query, connection);

         command.Parameters.AddWithValue("@PersonID", PersonID);
         command.Parameters.AddWithValue("@UserName", UserName);
         command.Parameters.AddWithValue("@Password", Password);
         command.Parameters.AddWithValue("@IsActive", IsActive);
         command.Parameters.AddWithValue("@UserID", UserID);

         try
         {
            connection.Open();
            rowsAffected = command.ExecuteNonQuery();

         }
         catch(Exception ex)
         {
            
         }
         finally
         {
            connection.Close();
         }

         return (rowsAffected > 0);
      }

      // Get All Users
      public static DataTable GetAllUsers()
      {
         DataTable dtUsers = new DataTable();

         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);
         string Query = @"Select Users.UserID, Users.PersonID, People.FirstName + ' ' + People.SecondName + ' '+
                        IsNull(People.ThirdName,'')+ ' '+ People.LastName as FullName, Users.UserName,
                        Users.IsActive from Users inner join People on Users.PersonID = People.PersonID; ";
         SqlCommand command = new SqlCommand(Query, connection);

         try
         {
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
               dtUsers.Load(reader);
            }
            reader.Close();
         }
         catch (Exception ex) 
         {
            connection.Close();
         }

         finally
         {
            connection.Close();
         }


         return dtUsers;
      }

      // Delete User
      public static bool DeleteUser(int UserID)
      {
         int rowsAffected = 0;

         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);
         string Query = @"Delete From Users Where UserID = @UserID;";
         SqlCommand command = new SqlCommand(Query, connection);

         command.Parameters.AddWithValue("@UserID", UserID);

         try
         {
            connection.Open();
            rowsAffected = command.ExecuteNonQuery();

         }
         catch(Exception ex)
         {

         }
         finally
         {
            connection.Close();
         }

         return (rowsAffected > 0);
      }

      // Is UserID Exist
      public static bool IsUserExist(int UserID)
      {
         bool IsFound = false;

         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);
         string Query = @"Select Found=1 From Users Where UserID =@UserID;";
         SqlCommand command = new SqlCommand(Query, connection);

         command.Parameters.AddWithValue("@UserID", UserID);

         try
         {
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            IsFound = reader.HasRows;
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

      // Is UserName Exist
      public static bool IsUserExist(string UserName)
      {
         bool IsFound = false;

         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);
         string Query = @"Select Found=1 From Users Where UserName =@UserName;";
         SqlCommand command = new SqlCommand(Query, connection);

         command.Parameters.AddWithValue("@UserName", UserName);

         try
         {
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            IsFound = reader.HasRows;
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

      // Is User Exist for PeronsID
      public static bool IsUserExistForPersonID(int PersonID)
      {
         bool IsFound = false;

         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);
         string Query = @"Select Found=1 From Users Where PersonID =@PersonID;";
         SqlCommand command = new SqlCommand(Query, connection);

         command.Parameters.AddWithValue("@PersonID", PersonID);

         try
         {
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            IsFound = reader.HasRows;
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

      public static bool DoesPersonHaveUser(int PersonID)
      {
         bool IsFound = false;

         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);
         string Query = @"Select Found=1 From Users Where PersonID =@PersonID;";
         SqlCommand command = new SqlCommand(Query, connection);

         command.Parameters.AddWithValue("@PersonID", PersonID);

         try
         {
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            IsFound = reader.HasRows;
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

      public static bool ChangePassword(int UserID, string NewPassword)
      {
         int rowsAffected = 0;

         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);
         string Query = @"Update Users
                        set Password=@NewPassword
                        Where UserID=@UserID;";
         SqlCommand command = new SqlCommand(Query, connection);

         command.Parameters.AddWithValue("@NewPassword", NewPassword);
         command.Parameters.AddWithValue("@UserID", UserID);

         try
         {
            connection.Open();
            rowsAffected = command.ExecuteNonQuery();
         }
         catch(Exception ex)
         {
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
