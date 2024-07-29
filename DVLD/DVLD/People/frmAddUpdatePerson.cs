using BusinessLayer;
using DVLD.Global_Classes;
using DVLD.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.People
{
   public partial class frmAddUpdatePerson : Form
   {
      public delegate void DataBackEventHandler(object sender, int PersonID);
      public event DataBackEventHandler DataBack;

      public enum enMode { AddNew = 0, Update = 1};
      public enum enGendor { Male = 0, Female = 1};

      private enMode _Mode;
      private int _PersonID = -1;
      clsPerson _Person;

      public frmAddUpdatePerson()
      {
         InitializeComponent();
         _Mode = enMode.AddNew;
      }

      public frmAddUpdatePerson(int PersonID)
      {
         InitializeComponent();
         _PersonID = PersonID;
         _Mode = enMode.Update;
        
      }

      private void btnCloseLogin_Click(object sender, EventArgs e)
      {
         this.Close();
      }

      private void _ResetDefualtValues()
      {
        
         _FillCountriesInComoboBox();
         if(_Mode == enMode.AddNew)
         {
            lblTitle.Text = "Add New Person";
            _Person = new clsPerson();
         }
         else
         {
            lblTitle.Text = "Update Person";
         }

         if (rdbMale.Checked)
            pbPersonImage.Image = Resources.Male_avatar;
         else
            pbPersonImage.Image = Resources.Female_avatar;
         

         //hide/show the remove linke incase there is no image for the person.
         llRemoveImage.Visible = (pbPersonImage.ImageLocation != null);

         //we set the max date to 18 years from today, and set the default value the same
         dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
         dtpDateOfBirth.Value = dtpDateOfBirth.MaxDate;

         cmbCountry.SelectedIndex = cmbCountry.FindString("Bahrain");

         txtbFirstName.Text = "";
         txtbSecondName.Text = "";
         txtbThirdName.Text = "";
         txtbLastName.Text = "";
         txtbNationaNo.Text = "";
         rdbMale.Checked = true;
         txtbPhone.Text = "";
         txtbEmail.Text = "";
         txtbAddress.Text = "";

      }

      // filling comboBox with countries
      private void _FillCountriesInComoboBox()
      {
         DataTable dataCountries = clsCounrty.GetAllCountries();

         foreach (DataRow row in dataCountries.Rows)
         {
            cmbCountry.Items.Add(row["CountryName"]);
         }

      }


      private void _LoadData()
      {
         _Person = clsPerson.Find(_PersonID);

         if(_Person == null)
         {
            MessageBox.Show($"there is no Person with {_PersonID}","Person Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.Close();
            return;
         }

         lblPersonID.Text = _Person.PersonID.ToString();
         txtbFirstName.Text = _Person.FirstName;
         txtbSecondName.Text = _Person.SecondName;
         txtbThirdName.Text = _Person.ThirdName;
         txtbLastName.Text = _Person.LastName;
         txtbNationaNo.Text = _Person.NationalNo;
         dtpDateOfBirth.Value = _Person.DateOfBirth;

         if (_Person.Gendor == 0)
            rdbMale.Checked = true;
         else
            rdbFemale.Checked = true;

         txtbPhone.Text = _Person.Phone;
         txtbEmail.Text = _Person.Email;
         //cmbCountry.SelectedIndex = cmbCountry.FindString(_Person.CountryInfo.CountryName);
         cmbCountry.SelectedIndex = cmbCountry.FindString(_Person.CountryInfo.CountryName);


         if (_Person.ImagePath != "")
         {
            pbPersonImage.ImageLocation = _Person.ImagePath;
         }

         llRemoveImage.Visible = (_Person.ImagePath !="");
      }

      
      private void frmAddUpdatePerson_Load(object sender, EventArgs e)
      {
         _ResetDefualtValues();
         if (_Mode == enMode.Update)
            _LoadData();  
      }


      private bool _HandlePersonImage()
      {
         // we check if ImagePath isn't equle to picturebox
         if(_Person.ImagePath != pbPersonImage.ImageLocation)
         {
            // we check if the ImagePath is not empty string
            if(_Person.ImagePath != "")
            {
               //first we delete the old image from the folder in case there is any.

               try
               {
                  File.Delete(_Person.ImagePath);
               }
               catch(IOException iox)
               {
                  MessageBox.Show("Something went worng we couldn't delete image", "Can't Delete Image",
                                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               }

            }
         }

         // here we change image name to guid and copy it to the project file
         if (pbPersonImage.ImageLocation != null)
         {
            string SourceImageFile = pbPersonImage.ImageLocation.ToString();

            if(clsUtilities.CopyImageToProjectImages(ref SourceImageFile))
            {
               pbPersonImage.ImageLocation = SourceImageFile;
               return true;
            }
            else
            {
               return false;
            }
         }

         return true; 

      }

      private void btnSave_Click(object sender, EventArgs e)
      {
         // here we should validate textbox

         if (!this.ValidateChildren())
         {
            //Here we dont continue becuase the form is not valid
            MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
         }


         if (!_HandlePersonImage())
            return;

         int NationalCountryID = clsCounrty.Find(cmbCountry.Text).ID;

         _Person.FirstName = txtbFirstName.Text.Trim();
         _Person.SecondName = txtbSecondName.Text.Trim();
         _Person.ThirdName = txtbThirdName.Text.Trim();
         _Person.LastName = txtbLastName.Text.Trim();
         _Person.NationalNo = txtbNationaNo.Text.Trim();
         _Person.Phone = txtbPhone.Text.Trim();
         _Person.Email = txtbEmail.Text.Trim();
         _Person.Address = txtbAddress.Text.Trim();
         _Person.DateOfBirth = dtpDateOfBirth.Value;

         if (rdbMale.Checked)
            _Person.Gendor = (byte)enGendor.Male;
         else
            _Person.Gendor = (byte)enGendor.Female;

         _Person.NationalityCountryID = NationalCountryID;

         if (pbPersonImage.ImageLocation != null)
            _Person.ImagePath = pbPersonImage.ImageLocation;
         else
            _Person.ImagePath = "";

         if (_Person.Save())
         {
            lblPersonID.Text = _Person.PersonID.ToString();
            //change form mode to update.
            _Mode = enMode.Update;
            lblTitle.Text = "Update Person";

            MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Trigger the event to send data back to the caller form.
            // DataBack?.Invoke(this, _Person.PersonID);
            
            DataBack?.Invoke(this, _Person.PersonID);
         }
         else
            MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

      }

      private void linkSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
      {
         openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
         openFileDialog1.FilterIndex = 1;
         openFileDialog1.RestoreDirectory = true;

         if (openFileDialog1.ShowDialog() == DialogResult.OK)
         {
            // Process the selected file
            string selectedFilePath = openFileDialog1.FileName;
            pbPersonImage.Load(selectedFilePath);
            llRemoveImage.Visible = true;
            // ...
         }
      }

      private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
      {
        pbPersonImage.ImageLocation = null;

         if (rdbMale.Checked)
            pbPersonImage.Image = Resources.Male_avatar;
         else
            pbPersonImage.Image = Resources.Female_avatar;

         llRemoveImage.Visible = false;
      }

      private void rdbMale_CheckedChanged(object sender, EventArgs e)
      {
         if (pbPersonImage.ImageLocation == null)
         {
            pbPersonImage.Image = Resources.Male_avatar;
         }
      }

      private void rdbFemale_CheckedChanged(object sender, EventArgs e)
      {
         if (pbPersonImage.ImageLocation == null)
         {
            pbPersonImage.Image = Resources.Female_avatar;
         }
      }

      // Validate Empty box
      private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
      {
         TextBox Temp = ((TextBox)sender);
         if (string.IsNullOrEmpty(Temp.Text.Trim()))
         {
            e.Cancel = true;
            errorProvider1.SetError(Temp, "This Field is required!");
         }
         else
         {
            errorProvider1.SetError(Temp, null);
         }
      }

      // Validate Email 

      private void txtEmail_Validating(object sender, CancelEventArgs e)
      {
         //no need to validate the email incase it's empty.
         if (txtbEmail.Text == "")
            return;

         if (!clsValidatoin.ValidateEmail(txtbEmail.Text))
         {
            e.Cancel = true;
            errorProvider1.SetError(txtbEmail, "Invalid Email Address Format!");
         }
         else
         {
            errorProvider1.SetError(txtbEmail, null);
         }
      }

      // Validate NationalNo if empty
      
      private void txtbNationaNo_Validating(object sender, CancelEventArgs e)
      {
         if (String.IsNullOrEmpty(txtbNationaNo.Text.Trim()))
         {
            e.Cancel = true;
            errorProvider1.SetError(txtbEmail, "This Field is required");
            return;
         }
         else
         {
            errorProvider1.SetError(txtbEmail, null);
         }

         //Make sure the national number is not used by another person
         if (txtbNationaNo.Text != _Person.NationalNo && clsPerson.IsExist(txtbNationaNo.Text.Trim()))
         {
            e.Cancel = true;
            errorProvider1.SetError(txtbNationaNo, "National Number is used for another person!");
         }
         else
         {
            errorProvider1.SetError(txtbNationaNo, null);
         }
      }

      private void txtbPhone_KeyPress(object sender, KeyPressEventArgs e)
      {
        e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
      }

      private void cmbCountry_SelectedIndexChanged(object sender, EventArgs e)
      {

      }
   }
}
