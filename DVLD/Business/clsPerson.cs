using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLayer
{
   public class clsPerson
   {
      public enum enMode { AddNew = 0, Update = 1 };
      public enMode Mode = enMode.AddNew;
      public int PersonID;
      public string NationalNo { get; set; }
      public string FirstName { set; get; }
      public string SecondName { set; get; }
      public string ThirdName { set; get; }
      public string LastName { set; get; }
      public string FullName
      {
         get { return FirstName + " " + SecondName + " " + ThirdName + " " + LastName; }
      }
      public DateTime DateOfBirth { set; get; }
      public byte Gendor { set; get; }
      public string Address { set; get; }
      public string Phone { set; get; }
      public string Email { set; get; }
      public int NationalityCountryID { set; get; }
      public clsCounrty CountryInfo { set; get; }
      private string _ImagePath;

      public string ImagePath
      {
         set { _ImagePath = value; }
         get { return _ImagePath; }
      }

      public clsPerson()
      {
         this.PersonID = -1;
         this.NationalNo = "";
         this.FirstName = "";
         this.SecondName = "";
         this.ThirdName = "";
         this.LastName = "";
         this.DateOfBirth = DateTime.Now;
         this.Address = "";
         this.Phone = "";
         this.Email = "";
         this.NationalityCountryID = -1;
         this.ImagePath = "";
         Mode = enMode.AddNew;

      }

      private clsPerson(int PersonID, string NationalNo, string FirstName, string SecondName, 
            string ThirdName,string LastName, DateTime DateOfBirth, byte Gendor,
            string Address, string Phone, string Email, 
            int NationalityCountryID, string ImagePath)
      {
         this.PersonID = PersonID;
         this.NationalNo = NationalNo;
         this.FirstName = FirstName;
         this.SecondName = SecondName;
         this.ThirdName = ThirdName;
         this.LastName = LastName;
         this.DateOfBirth = DateOfBirth;
         this.Gendor = Gendor;
         this.Email = Email;
         this.Phone = Phone;
         this.Address = Address;
         this.NationalityCountryID = NationalityCountryID;
         this.CountryInfo = clsCounrty.Find(NationalityCountryID);
         this.ImagePath = ImagePath;
         Mode = enMode.Update;
      }
      
      // Add New Person
      private bool _AddNewPerson()
      {
         this.PersonID = clsPersonData.AddNewPerson(this.NationalNo, this.FirstName, this.SecondName, this.ThirdName,
            this.LastName, this.DateOfBirth, this.Gendor, this.Address, this.Phone, this.Email,  this.NationalityCountryID,
            this.ImagePath);

         return (this.PersonID != -1);
      }
      
      // Update Person
      private bool _UpdatePerson()
      {
         return clsPersonData.UpdatePerson(this.PersonID, this.NationalNo, this.FirstName, this.SecondName, this.ThirdName,
            this.LastName, this.DateOfBirth, this.Gendor, this.Address, this.Phone, this.Email, this.NationalityCountryID,
            this.ImagePath);
      }

      // Find Person By ID
      public static clsPerson Find(int PersonID)
      {
         string FirstName = "", SecondName = "", ThirdName = "", LastName = "", NationalNo = "", Email = "", Phone = "",
                  Address = "", ImagePath = "";

         DateTime DateOfBirth = DateTime.Now;
         int NationalityCountryID = -1;
         byte Gendor = 0;
         
         bool IsFound =  clsPersonData.GetPersonByID(PersonID, ref NationalNo, ref FirstName, ref SecondName,
                                                     ref ThirdName, ref LastName, ref DateOfBirth, ref Gendor,
                                                     ref Address, ref Phone, ref Email,ref NationalityCountryID, ref ImagePath);

         if (IsFound)
            return new clsPerson(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName,
                                 DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath);
         else
            return null;
         
      }

      // Find Person by NationalNo
      public static clsPerson Find(string NationalNo)
      {
         string FirstName = "", SecondName = "", ThirdName = "", LastName = "", Email = "", Phone = "",
                  Address = "", ImagePath = "";
         DateTime DateOfBirth = DateTime.Now;
         int PersonID = -1, NationalityCountryID = -1;
         byte Gendor = 0;

         bool IsFound = clsPersonData.GetPersonByNationalNo(NationalNo, ref PersonID, ref FirstName, ref SecondName, ref ThirdName, 
                                                            ref LastName, ref DateOfBirth, ref Gendor, ref Address, ref Phone,
                                                            ref Email,  ref NationalityCountryID, ref ImagePath);

         if (IsFound)
            return new clsPerson(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth,
                                 Gendor, Address, Phone, Email, NationalityCountryID, ImagePath);
         else
            return null;
      }

      public bool Save()
      {
         switch (Mode)
         {
            case enMode.AddNew:
               if (_AddNewPerson())
               {
                  Mode = enMode.Update;
                  return true;
               }
               else
               {
                  return false;
               }
            case enMode.Update:
               return _UpdatePerson();
         }
         return false;
      }

      public static DataTable GetAllPeople()
      {
         return clsPersonData.GetAllPeople();
      }

      public static bool DeletePerson(int PersonID)
      {
         return clsPersonData.DeletePerson(PersonID);
      }

      public static bool IsExist(int PersonID)
      {
         return clsPersonData.IsPersonExist(PersonID);
      }
      
      public static bool IsExist(string NationalNo)
      {
         return clsPersonData.IsPersonExist(NationalNo);
      }
   }
}
