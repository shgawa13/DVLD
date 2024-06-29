using BusinessLayer;
using DVLD.People.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Users.Controls
{
   public partial class ctrlChangePassword : UserControl
   {
      private int _UserID = -1;
      public int UserID
      {
         get { return _UserID; }
      }

      clsUsers _User;


      public ctrlChangePassword()
      {
         InitializeComponent();

      }


      public void LoadUserInfo(int UserID)
      {
         _User = clsUsers.FindByUserID(UserID);

         if (_User == null)
         {
            MessageBox.Show("No User with UserID = " + UserID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
         }
         _User.UserID = UserID;
         ctrlUserInfo1.LoadUserInfo(UserID);

         txtbCurrentPassword.Visible = true;
         txtbNewPassword.Visible = true;
         txtbConfirmPassword.Visible = true;
        
      }


  

      private void txtbCurrentPassword_Validating(object sender, CancelEventArgs e)
      {
         // we make sure the password is the same in database
         if(_User.Password != txtbCurrentPassword.Text)
         {
            e.Cancel = true;
            errorProvider1.SetError(txtbCurrentPassword, "Password is not correct");

         }
         else
         {
            e.Cancel = false;
            errorProvider1.SetError(txtbCurrentPassword, null);
         }
      }

      private void txtbConfirmPassword_TextChanged(object sender, EventArgs e)
      {
        if(txtbNewPassword.Text != txtbConfirmPassword.Text)
         {
            // e.Cancel = true;
            errorProvider1.SetError(txtbConfirmPassword, "Password is not Match");
         }
         else
         {
            errorProvider1.SetError(txtbConfirmPassword, null);
         }
      }

      public void ChangePassword()
      {
         if (!this.ValidateChildren()) 
         {
            MessageBox.Show("Some Filds are not corrcet");
            return;
         }

         if (clsUsers.ChangeUserPassword(_User.UserID,txtbNewPassword.Text))
            MessageBox.Show("Password has been changed Successfully");
         else
            MessageBox.Show("Couldn't Change the password");
      }

    
   }
}
