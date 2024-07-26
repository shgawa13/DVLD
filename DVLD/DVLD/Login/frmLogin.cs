using DVLD.People;
using DVLD.Users;
using DVLD.Global_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace DVLD
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

      private void btnCloseLogin_Click(object sender, EventArgs e)
      {
         Application.Exit();
      }

      // Checking Active User
      private bool _CheckingIsUserActive(clsUsers User)
      {
         return User.IsActive;
      }

      private void btnLogin_Click(object sender, EventArgs e)
      {

         // first we Get the user form DB
         clsUsers User = clsUsers.FindByUserNameAndPassword(txtboxUserName.Text.Trim(), txtboxPassword.Text.Trim());

         // checking if user exist
         if(User != null)
         {

            // checking if the user is Active or not
            if (!User.IsActive)
            {
               MessageBox.Show($"Please Contact Admin");
               return;
            }

            // Store User Info in txt
            if (cboxRemember.Checked)
            {
               clsGlobal.RememberUserNameAndPassword(User.UserName, User.Password);
            }
            else
            {
               clsGlobal.RememberUserNameAndPassword("", "");
            }

            // now we can store the user in Global CurrentUser
             clsGlobal.CurrnetUser = User;
             Form DashBoard = new frmMain(this);
             this.Hide();
             DashBoard.ShowDialog();

         }
         else
         {
            MessageBox.Show($"Wrong credentils");
            return;
         }

      }

   

      private void frmLogin_Load(object sender, EventArgs e)
      {
         string UserName = "", Password = "";

         if (clsGlobal.GetStoredCredential(ref UserName, ref Password))
         {
            txtboxUserName.Text = UserName;
            txtboxPassword.Text = Password;
            cboxRemember.Checked = true;
         }
         else
         {
            cboxRemember.Checked = false;
         }

      }

    
   }
}
