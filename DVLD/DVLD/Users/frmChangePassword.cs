using BusinessLayer;
using DVLD.People.Controls;
using DVLD.Users.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Users
{
   public partial class frmChangePassword : Form
   {
      private int _UserID = -1;
      clsUsers _User;
 

      public frmChangePassword(int ID)
      {
         InitializeComponent();
         _UserID = ID;
      }

     

      private void frmChangePassword_Load(object sender, EventArgs e)
      {
         ctrlChangePassword1.LoadUserInfo(_UserID);
         
      }

     
      private void btnSavePassword_Click(object sender, EventArgs e)
      {
         ctrlChangePassword1.ChangePassword();
      }

      
   }
}
