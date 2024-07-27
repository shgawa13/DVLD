using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting.Messaging;

namespace DVLD.Users
{
   public partial class frmAddUpdateUser : Form
   {
      public enum enMode {AddNew=0, Update=1 };
      private enMode _Mode = enMode.AddNew;
      private int _UserID = -1;
      private int _PersonID = -1;
      clsUsers _User;
      
      
      public frmAddUpdateUser()
      {
         InitializeComponent();
         _User = new clsUsers();
         _Mode = enMode.AddNew;
         
      }

      public frmAddUpdateUser(int ID)
      {
         InitializeComponent();
         _UserID = ID;
         _Mode = enMode.Update;

      }

      private void _ResetValues()
      {
         // Cheaking Mode and Rest Values
         if (_Mode == enMode.AddNew)
         {
            _User = new clsUsers();
            lblTitle.Text = "Add New User";
            this.Text = "Add New User";
            btnNext.Enabled = false;
            tbpLoginInfo.Enabled = false;
         }
         else
         {
            lblTitle.Text = "Update User";
            this.Text = "Update User";
            btnNext.Enabled = true;
            tbpLoginInfo.Enabled = true ;

         }

         lblUserID.Text = "???";
         txtbUserName.Text = "";
         txtbPassword.Text = "";
         txtbConfirmPassword.Text = "";
         checkbIsActive.Checked = true;
      }

      private void _LoadData()
      {
         _User = clsUsers.FindByUserID(_UserID);

         if(_User == null)
         {
            MessageBox.Show("No User with ID = " + _User, "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.Close();

            return;
         }

         lblUserID.Text = _User.UserID.ToString();
         txtbUserName.Text = _User.UserName;
         txtbPassword.Text = _User.Password;
         txtbConfirmPassword.Text = _User.Password;
         checkbIsActive.Checked = _User.IsActive;
         ctrlPersonInfoWithFilter1.LoadPersonInfo(_User.PersonID);
        
      }

      private void frmAddUser_Load(object sender, EventArgs e)
      {
         _ResetValues();
         if (_Mode == enMode.Update)
            _LoadData();
         btnNext.Enabled = true;
         
      }

      private void btnSave_Click(object sender, EventArgs e)
      {

         // Validate inputs
         if(!this.ValidateChildren())
         {
            MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
         }

         _User.PersonID = _PersonID;
         _User.UserName = txtbUserName.Text;
         _User.Password = txtbPassword.Text;
         _User.IsActive = (checkbIsActive.Checked) ? true : false;

         if (_User.Save())
         {
            lblUserID.Text = _User.UserID.ToString();
            _Mode = enMode.Update;
            lblTitle.Text = "Update User";
            MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

         }
         else
            MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

      }


      private void btnNext_Click(object sender, EventArgs e)
      {
        // if the mode is Update it means he is a user 
        if(_Mode == enMode.Update)
         {
            tbpLoginInfo.Enabled = true ;
            btnSave.Enabled = true;
            tcUserInfo.SelectedTab = tcUserInfo.TabPages["tbpLoginInfo"];
            return;
         }

         // Checking if person info is correct
        if(ctrlPersonInfoWithFilter1.PersonID != -1)
         {
            // checking if person is not a user
            if (clsUsers.isUserExistForPersonID(ctrlPersonInfoWithFilter1.PersonID))
            {
               MessageBox.Show("Selected Person already has a user, choose another one.", "Select another Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
               btnSave.Enabled = true;
               tbpLoginInfo.Enabled = true;
               tcUserInfo.SelectedTab = tcUserInfo.TabPages["tbpLoginInfo"];

            }

         }
         else
         {

            MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }

      }

      private void btnCloseLogin_Click(object sender, EventArgs e)
      {
         this.Close();
      }
     
     

      private void txtbUserName_Validating(object sender, CancelEventArgs e)
      {
         if (string.IsNullOrEmpty(txtbUserName.Text))
         {
            e.Cancel = true;
            errorProvider1.SetError(txtbUserName, "this fild is require");
         }
         else
         {
            errorProvider1.SetError(txtbUserName, null);
         }

         // make sure the user is not exist
         if (txtbUserName.Text != _User.UserName && clsUsers.isUserExist(txtbUserName.Text.Trim()))
         {
            e.Cancel = true;
            errorProvider1.SetError(txtbUserName, "This UserName is already used, Please Chose another UserName");
         }
         else
         {
            errorProvider1.SetError(txtbUserName, null);
         }
      }

      private void txtbPassword_Validating(object sender, CancelEventArgs e)
      {
         if (String.IsNullOrEmpty(txtbPassword.Text.Trim()))
         {
            e.Cancel= true;
            errorProvider1.SetError(txtbPassword, "This Fild is required");
         }
         else
         {
            errorProvider1.SetError(txtbPassword, null);
         }
      }

      // validating Confirm Password
      private void txtbConfirmPassword_Validating(object sender, CancelEventArgs e)
      {
         if (String.IsNullOrEmpty(txtbConfirmPassword.Text.Trim()))
         {
            e.Cancel = true;
            errorProvider1.SetError(txtbConfirmPassword, "This Fild is required");
         }
         else
         {
            errorProvider1.SetError(txtbConfirmPassword, null);
         }

         // check if password is match with confirm password

         if(txtbPassword.Text.Trim()  != txtbConfirmPassword.Text.Trim())
         {
            errorProvider1.SetError(txtbConfirmPassword, "Password is not match");
         }
         else
         {
            errorProvider1.SetError(txtbConfirmPassword, null);
         }
      }

      private void ctrlPersonInfoWithFilter1_OnPersonSelected(int obj)
      {
         _PersonID = obj;
         if (_PersonID != -1)
         {
            ctrlPersonInfoWithFilter1.ShowAddPerson = false;
            ctrlPersonInfoWithFilter1.FilterEnable = false;

         }
      }
   }
}

