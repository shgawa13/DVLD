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
using BusinessLayer;
using DVLD.Properties;

namespace DVLD.People.Controls
{
   public partial class ctrlPersonInfo : UserControl
   {
      private  int _PersonID;
      private clsPerson _Person;

      public int PersonID
      {
         get { return _PersonID; }
      }

      public clsPerson SelectedPerson
      {
         get { return _Person; }
      }


      public ctrlPersonInfo()
      {
         InitializeComponent();
      }

      public void LoadPersonData(int PersonID)
      {
         _Person = clsPerson.Find(PersonID);
         if(_Person == null)
         {
            ResetPersonInfo();
            MessageBox.Show("No Person with PersonID = " + PersonID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
         }
         _FillPersonInfo();
      }

      public void LoadPersonData(string NationalNo)
      {
         _Person = clsPerson.Find(NationalNo);
         if (_Person == null)
         {
            ResetPersonInfo();
            MessageBox.Show("No Person with National No. = " + NationalNo.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
         }
         _FillPersonInfo();
      }

      private void _LoadPersonImage()
      {
         if (_Person.Gendor == 0)
            pictureBox1.Image = Resources.Male_avatar;
         else
            pictureBox1.Image = Resources.Female_avatar;

         string ImagePath = _Person.ImagePath;
         if(ImagePath != "")
         {
            if (File.Exists(ImagePath))
               pictureBox1.ImageLocation = ImagePath;
            else
               MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

         }
      }

      private void _FillPersonInfo()
      {
         linkSetImage.Enabled = true;
         _PersonID = _Person.PersonID;
         lblNationalNo.Text = _Person.NationalNo.ToString();
         lblPersonID.Text = _Person.PersonID.ToString();
         lblName.Text = _Person.FullName.ToString();
         lblDOB.Text = _Person.DateOfBirth.ToString();
         lblGendor.Text = (_Person.Gendor ==0) ? "Male":"Female";
         lblCountry.Text = clsCounrty.Find(_Person.NationalityCountryID).CountryName;
         lblEmail.Text = _Person.Email;
         lblPhone.Text = _Person.Phone;
         lblAddress.Text = _Person.Address;

         _LoadPersonImage();
      }

      public void ResetPersonInfo()
      {
         _PersonID = -1;
         lblPersonID.Text = "???";
         lblName.Text = "???";
         lblNationalNo.Text = "???";
         lblDOB.Text = "???";
         lblGendor.Text = "???";
         lblCountry.Text = "???";
         lblEmail.Text = "???";
         lblPhone.Text = "???";
         lblAddress.Text = "???";
         pictureBox1.Image = Resources.Male_avatar;

      }

      private void linkSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
      {
         Form frm = new frmAddUpdatePerson(_PersonID);
         frm.ShowDialog();

         // refreching
         LoadPersonData(_PersonID);
      }

     
   }
}
