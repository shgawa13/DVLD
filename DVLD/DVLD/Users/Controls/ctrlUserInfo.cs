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

namespace DVLD.Users.Controls
{
   public partial class ctrlUserInfo : UserControl
   {
      private int _UserID = -1;
      clsUsers _User;

      public int UserID
      {
         get { return _UserID; }
      }

      public clsUsers SelectedUser
      {
         get { return _User; }
      }

      public ctrlUserInfo()
      {
         InitializeComponent();
      }


      public ctrlUserInfo(int ID)
      {
         InitializeComponent();
         _UserID = ID;
      }

      public void LoadUserInfo(int UserID) 
      {
         _User = clsUsers.FindByUserID(UserID);

         if(_User == null)
         {
            MessageBox.Show("No User with ID. = " + UserID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
         }

         _FillUserInfo();
      }

      private void _FillUserInfo()
      {
         // here we load Person info
         ctrlPersonInfo1.LoadPersonData(_User.PersonID);
         // here we fill User info
         lblUserID.Text = _User.UserID.ToString();
         lblUserName.Text = _User.UserName;
         lblisActive.Text = (_User.IsActive) ? "Yse" : "No";
      }

      
   }
}
