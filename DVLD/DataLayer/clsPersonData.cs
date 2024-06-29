using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;


namespace DataLayer
{
  public class clsPersonData
  {
      
      // Add new Person
      public static int AddNewPerson(string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName,
                                     DateTime DateOfBirth, byte Gendor, string Address, string Phone, string Email,
                                     int NationalityCountryID, string ImagePath)
      {
         int PersonID = -1;
         
         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);
         string Query = @"Insert into People(NationalNo,FirstName,SecondName,ThirdName,LastName,DateOfBirth,Gendor,
                      Address,Phone,Email,NationalityCountryID,ImagePath)
                    values(@NationalNo,@FirstName,@SecondName,@ThirdName,@LastName,@DateOfBirth,@Gendor,@Address,
                    @Phone,@Email,@NationalityCountryID,@ImagePath);
                    Select SCOPE_IDENTITY();";
         SqlCommand command = new SqlCommand(Query, connection);

         command.Parameters.AddWithValue("@NationalNo", NationalNo);
         command.Parameters.AddWithValue("@FirstName", FirstName);
         command.Parameters.AddWithValue("@SecondName", SecondName);
         command.Parameters.AddWithValue("@ThirdName", ThirdName);
         command.Parameters.AddWithValue("@LastName", LastName);
         command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
         command.Parameters.AddWithValue("@Gendor", Gendor);
         command.Parameters.AddWithValue("@Address", Address);
         command.Parameters.AddWithValue("@Phone", Phone);
         if (Email != "" && Email != null)
            command.Parameters.AddWithValue("@Email", Email);
         else
            command.Parameters.AddWithValue("@Email", System.DBNull.Value);

         command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);

         if (ImagePath != "" && ImagePath != null)
            command.Parameters.AddWithValue("@ImagePath", ImagePath);
         else
            command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);

         try
         {
            connection.Open();
            object result = command.ExecuteScalar();

            if(result !=null && int.TryParse(result.ToString(),out int ID))
            {
               PersonID = ID;
            }
         }
         catch(Exception ex)
         {
            // throw ex
         }
         finally
         {
            connection.Close();
         }

         return PersonID;
      }

      // Update Person
      public static bool UpdatePerson(int PersonID, string NationalNo, string FirstName, string SecondName, string ThirdName,
                               string LastName, DateTime DateOfBirth, short Gendor, string Address, string Phone, string Email,
                               int NationalityCountryID, string ImagePath)
      {
         int EffectedRow = -1;
         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);
         string Query = @"update People
          set NationalNo=@NationalNo,
          FirstName=@FirstName,
          SecondName=@SecondName,
          ThirdName=@ThirdName,
          LastName=@LastName,
          DateOfBirth=@DateOfBirth,
          Gendor=@Gendor,
          Address=@Address,
          Phone=@Phone,
          Email=@Email,
          NationalityCountryID=@NationalityCountryID,
          ImagePath=@ImagePath
          where PersonID=@PersonID";

         SqlCommand command = new SqlCommand(Query, connection);
         command.Parameters.AddWithValue("@PersonID", PersonID);
         command.Parameters.AddWithValue("@NationalNo", NationalNo);
         command.Parameters.AddWithValue("@FirstName", FirstName);
         command.Parameters.AddWithValue("@SecondName", SecondName);
         command.Parameters.AddWithValue("@ThirdName", ThirdName);
         command.Parameters.AddWithValue("@LastName", LastName);
         command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
         command.Parameters.AddWithValue("@Gendor", Gendor);
         command.Parameters.AddWithValue("@Address", Address);
         command.Parameters.AddWithValue("@Phone", Phone);

         if (Email != "" && Email != null)
            command.Parameters.AddWithValue("@Email", Email);
         else
            command.Parameters.AddWithValue("@Email", System.DBNull.Value);

            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);

         if (ImagePath != "" && ImagePath != null)
            command.Parameters.AddWithValue("@ImagePath", ImagePath);
         else
            command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);

         try
         {
            connection.Open();
            EffectedRow= command.ExecuteNonQuery();
         }
         catch(Exception ex)
         {
            // throw ex
         }
         finally
         {
            connection.Close();
         }

         return (EffectedRow>0);
      }

      public static bool DeletePerson(int PersonID)
      {
         int IsDeleted = -1;
         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);
         string Query = @"Delete From People where PersonID=@PersonID;";
         SqlCommand command = new SqlCommand(Query, connection);
         command.Parameters.AddWithValue("@PersonID", PersonID);

         try
         {
            connection.Open();

            IsDeleted = command.ExecuteNonQuery();
         }
         catch(Exception ex)
         {
            // throw ex
         }
         finally
         {
            connection.Close();
         }

         return (IsDeleted > 0);
      }
      // Get all People
      public static DataTable GetAllPeople()
      {
         DataTable DT = new DataTable();

         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);
         string Query = @"select People.PersonID,People.NationalNo,People.FirstName, People.SecondName,
                       People.ThirdName,People.LastName,People.DateOfBirth,People.Gendor,
                      Case
	                      when People.Gendor =0 then 'Male'
	                      else 'Female'
                      end
                      as GendorCaption
                      ,People.Address,People.Phone, People.Email,People.NationalityCountryID,Countries.CountryName, People.ImagePath
                      from People inner join Countries on People.NationalityCountryID = Countries.CountryID
                      order by People.FirstName; ";
         SqlCommand command = new SqlCommand(Query, connection);

         try
         {
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
               DT.Load(reader);
            }
            reader.Close();
         }
         catch (Exception ex)
         {
            //Exception ex

         }
         finally
         {
            connection.Close();
         }


         return DT;
      }

      // Find Person by ID
      public static bool GetPersonByID(int PersonID, ref string NationalNo, ref string FirstName, ref string SecondName,ref string ThirdName,
                                       ref string LastName, ref DateTime DateOfBirth,ref byte Gendor,
                                        ref string Address, ref string Phone, ref string Email, ref int NationalityCountryID,
                                       ref string ImagePath
                                       )
      {
         bool IsFound = false;

         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);
         string Query = @"select * from People Where PersonID =@PersonID;";
         SqlCommand command = new SqlCommand(Query, connection);
         command.Parameters.AddWithValue("@PersonID", PersonID);

         try
         {
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
               IsFound = true;

               NationalNo = (string)reader["NationalNo"];
               FirstName = (string)reader["FirstName"];
               SecondName = (string)reader["SecondName"];
               ThirdName = (string)reader["ThirdName"];
               LastName = (string)reader["LastName"];
               DateOfBirth = (DateTime)reader["DateOfBirth"];
               Gendor = (byte)reader["Gendor"];
               Address = (string)reader["Address"];
               Phone = (string)reader["Phone"];
               Email = (string)reader["Email"];
               NationalityCountryID = (int)reader["NationalityCountryID"];

               if (reader["ImagePath"]  != DBNull.Value)
               {
                ImagePath = (string)reader["ImagePath"];
               }
               else
               {
                ImagePath = "";
               }
            }
            reader.Close();
         }
         catch(Exception ex)
         {
            // throw ex
            IsFound = false;
         }
         finally
         {
            connection.Close();
         }

         return IsFound;
      }

      // Find Person By NationalNumber
      public static bool GetPersonByNationalNo( string NationalNo,ref int PersonID, ref string FirstName, ref string SecondName,
                                             ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref byte Gendor,
                                             ref string Address, ref string Phone, ref string Email, ref int NationalityCountryID,
                                             ref string ImagePath)
      {
         bool IsFound = false;

         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);
         string Query = @"select * from People where NationalNo =@NationalNo;";
         SqlCommand command = new SqlCommand(Query, connection);

         command.Parameters.AddWithValue("@NationalNo", NationalNo);

         try
         {
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
               IsFound = true;
               PersonID = (int)reader["PersonID"];
               FirstName = (string)reader["FirstName"];
               SecondName = (string)reader["SecondName"];
               ThirdName = (string)reader["ThirdName"];
               LastName = (string)reader["LastName"];
               DateOfBirth = (DateTime)reader["DateOfBirth"];
               Gendor = (byte)reader["Gendor"];
               Address = (string)reader["Address"];
               Phone = (string)reader["Phone"];
               Email = (string)reader["Email"];
               NationalityCountryID = (int)reader["NationalityCountryID"];
               if (reader["ImagePath"] != DBNull.Value)
               {
                  ImagePath = (string)reader["ImagePath"];
               }
               else
               {
                  ImagePath = "";
               }


            }
            reader.Close();
         }
         catch(Exception ex)
         {
            // throw ex
         }
         finally
         {
            connection.Close();
         }
         return IsFound;
      }


      // Find Person By Email
      public static bool GetPersonByEmail(string Email, ref int PersonID, ref string FirstName, ref string SecondName,
                                       ref string ThirdName, ref string LastName, ref string NationalNo, ref DateTime DateOfBirth,
                                       ref byte Gendor, ref string Address, ref string Phone, ref int NationalityCountryID,
                                       ref string ImagePath)
      {
         bool IsFound = false;
         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);
         string Query = @"Select * from People where Email =@Email;";
         SqlCommand command = new SqlCommand(Query, connection);

         command.Parameters.AddWithValue("@Email", Email);

         try
         {
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
               IsFound = true;
               PersonID = (short)reader["PersonID"];
               NationalNo = (string)reader["NationalNo"];
               FirstName = (string)reader["FirstName"];
               SecondName = (string)reader["SecondName"];
               ThirdName = (string)reader["ThirdName"];
               LastName = (string)reader["LastName"];
               DateOfBirth = (DateTime)reader["DateOfBirth"];
               Gendor = (byte)reader["Gendor"];
               Address = (string)reader["Address"];
               Phone = (string)reader["Phone"];
               NationalityCountryID = (int)reader["NationalityCountryID"];
               if (reader["ImagePath"] != DBNull.Value)
               {
                  ImagePath = (string)reader["ImagePath"];
               }
               else
               {
                  ImagePath = "";
               }

            }
         }
         catch(Exception ex)
         {
            // Throw ex
         }
         finally
         {
            connection.Close();
         }
         return IsFound;
      }
    
      // Find Person By Phone
      public static bool GetPeronsByPhone(string Phone, ref int PersonID, ref string NationalNo, ref string FirstName, 
                                          ref string SecondName,ref string ThirdName, ref string LastName, 
                                          ref DateTime DateOfBirth, ref byte Gendor, ref string Address, ref string Email,
                                          ref int NationalityCountryID, ref string ImagePath)
      {
         bool IsFound = false;

         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);
         string Query = @"Select * from People where Phone=@Phone;";
         SqlCommand command = new SqlCommand(Query,connection);

         command.Parameters.AddWithValue("@Phone", Phone);
         try
         {
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
               IsFound = true;
               PersonID = (short)reader["PersonID"];
               NationalNo = (string)reader["NationalNo"];
               FirstName = (string)reader["FirstName"];
               SecondName = (string)reader["SecondName"];
               ThirdName = (string)reader["ThirdName"];
               LastName = (string)reader["LastName"];
               DateOfBirth = (DateTime)reader["DateOfBirth"];
               Gendor = (byte)reader["Gendor"];
               Address = (string)reader["Address"];
               Email = (string)reader["Email"];
               NationalityCountryID = (int)reader["NationalityCountryID"];
               if (reader["ImagePath"] != DBNull.Value)
               {
                  ImagePath = (string)reader["ImagePath"];
               }
               else
               {
                  ImagePath = "";
               }

            }
         }
         catch(Exception)
         {

         }
         return IsFound;
      }
      
      // IsExist PersonID
      public static bool IsPersonExist(int PersonID)
      {
         bool IsExist = false;

         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);
         string Query = @"Select Found=1 from People where PersonID=@PersonID;";
         SqlCommand command = new SqlCommand(Query, connection);

         command.Parameters.AddWithValue("@PersonID", PersonID);

         try
         {
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            IsExist = reader.HasRows;
         }
         catch(Exception ex)
         {
            // throw ex
         }
         finally
         {
            connection.Close();
         }

         return IsExist;
      }

      public static bool IsPersonExist(string NationalNo)
      {
         bool IsExist = false;

         SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectingString);
         string Query = @"Select Found=1 from People where NationalNo = @NationalNo; ";
         SqlCommand command = new SqlCommand(Query, connection);

         command.Parameters.AddWithValue("@NationalNo", NationalNo);

         try
         {
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            IsExist = reader.HasRows;
         }
         catch (Exception ex)
         {
            // throw Error;
         }
         finally
         {
            connection.Close();
         }

         return IsExist;
      }
   }
}
