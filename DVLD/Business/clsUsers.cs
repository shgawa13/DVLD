using System;
using System.Linq;
using System.Text;
using System.Data;
using DataLayer;
using BusinessLayer;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace BusinessLayer
{
   public class clsUsers
   {
      public enum enMode { AddNew = 0, Update = 1 };
      public enMode Mode = enMode.AddNew;
      public int UserID { set; get; }
      public int PersonID { set; get; }
      public clsPerson PersonInfo;
      public string UserName { set; get; }
      public string Password { set; get; }
      public bool IsActive { set; get; }

      public clsUsers()
      {
         this.UserID = -1;
         this.UserName = "";
         this.Password = "";
         this.IsActive = true;
         Mode = enMode.AddNew;
      }

      private clsUsers(int UserID, int PersonID, string UserName, string Password, bool IsActive )
      {
         this.UserID = UserID;
         this.PersonID = PersonID;
         this.UserName = UserName;
         this.PersonInfo = clsPerson.Find(PersonID);
         this.Password = Password;
         this.IsActive = true;

         Mode = enMode.Update;
      }

      private bool _AddNewUser()
      {
         this.UserID = clsUsersData.AddNewUser(this.PersonID, this.UserName, this.Password, this.IsActive);
         return (UserID !=-1);
      }

      private bool _UpdateUser()
      {
         return clsUsersData.UpdateUser(this.UserID, this.PersonID, this.UserName, this.Password, this.IsActive);
      }

      // Find User by ID
      public static clsUsers FindByUserID(int UserID)
      {
         int PersonID = -1;
         string UserName = "", Password = "";
         bool IsActive = false;

         bool IsFound = clsUsersData.GetUserByUserID(UserID, ref PersonID, ref UserName, ref Password, ref IsActive);
         if (IsFound)
            return new clsUsers(UserID, PersonID, UserName, Password, IsActive);
         else
            return null;
            
      }

      // Find User by PersonID
      public static clsUsers FindByPersonID(int PersonID)
      {
         int UserID = -1;
         string UserName = "", Password = "";
         bool IsActive = false;

         bool IsFound = clsUsersData.GetUserInfoByPersonID(PersonID, ref UserID, ref UserName, ref Password, ref IsActive);

         if (IsFound)
            return new clsUsers(UserID, PersonID, UserName, Password, IsActive);
         else
            return null;
      }

      // Find by UserName and Password
      public static clsUsers FindByUserNameAndPassword(string UserName, string Password) 
      {
         int UserID = -1, PersonID = -1;
         bool IsActive = false;

         bool IsFound = clsUsersData.GetUserInfoByUsernameAndPassword(UserName, Password, ref UserID, ref PersonID, ref IsActive);
         if (IsFound)
            return new clsUsers(UserID, PersonID, UserName, Password, IsActive);
         else
            return null;
      
      }
      public bool  Save()
      {
         switch (Mode)
         {
            case enMode.AddNew:

               if (_AddNewUser())
               {
                  Mode = enMode.Update;
                  return true;
               }
               else
               {
                  return false;
               }

           
            case enMode.Update:
               return _UpdateUser();
            
         }
         return false;
      }
      
      // Is UserID Exist
      public static bool isUersExist(int UserID)
      {
         return clsUsersData.IsUserExist(UserID);
      }

      // Is UserName Exist
      public static bool isUserExist(string UserName)
      {
         return clsUsersData.IsUserExist(UserName);
      }

      // Delete User
      public static bool DeleteUser(int UserID)
      {
         return clsUsersData.DeleteUser(UserID);
      }

      // checking if person is already a user
      public static bool isUserExistForPersonID(int PersonID)
      {
         return clsUsersData.IsUserExistForPersonID(PersonID);
      }

      public static bool ChangeUserPassword(int UserID, string NewPassword)
      {
         return clsUsersData.ChangePassword(UserID, NewPassword);
        
      }

      
      public static DataTable GetAllUsers() => clsUsersData.GetAllUsers();


   }
}
