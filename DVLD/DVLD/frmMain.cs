using DVLD.Applications;
using DVLD.Applications.RenewLocalLicense;
using DVLD.Applications.ReplaceLostOrDamagedLicense;
using DVLD.Global_Classes;
using DVLD.Licenses;
using DVLD.Tests;
using DVLD.Users;
using DVLD.Drivers;
using DVLD.Licenses.Detain_License;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.People
{
   public partial class frmMain : Form
   {
      frmLogin _frmLogin;

      public frmMain(frmLogin frm)
      {
         InitializeComponent();
         _frmLogin = frm;
      }

  

      //protected override void OnClosed(EventArgs e)
      //{
      //   clsGlobal.CurrnetUser = null;
      //   _frmLogin.Show();
      //   this.Close();
      //   base.OnClosed(e);
      //}
      private void btnCloseLogin_Click(object sender, EventArgs e)
      {
         clsGlobal.CurrnetUser = null;
         base.OnClosed(e);
         _frmLogin.Show();
         this.Close();
      }

      private void tolStripPeople_Click(object sender, EventArgs e)
      {
         Form frmMangePeople = new frmPeople();
         frmMangePeople.ShowDialog();
      }

      private void tolStripUsers_Click(object sender, EventArgs e)
      {
         Form frmListUsers = new frmListUsers();
         frmListUsers.ShowDialog();
      }

      private void mangeApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
      {
         Form frm = new frmMangeApplicationTypes();
         frm.ShowDialog();
      }

      private void mangeTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
      {
         Form frm = new frmMangeTestType();
         frm.ShowDialog();
      }

      private void signOutToolStripMenuItem1_Click(object sender, EventArgs e)
      {
         this.Close();
         _frmLogin.Show();
      }

      private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
      {
         Form frm = new frmChangePassword(clsGlobal.CurrnetUser.UserID);
         frm.ShowDialog();
      }

      private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
      {
         Form frm = new frmAddUpdateLocalDrivingLicenseApplication();
         frm.ShowDialog();
      }


      private void localDrivingLicneseApplicationToolStripMenuItem_Click(object sender, EventArgs e)
      {
         Form frm = new frmListLocalDrivingLicenseApplication();
         frm.ShowDialog();
      }

      private void renewDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
      {
         Form frm = new frmRenwLocalDrivingLicenseApplication();
         frm.ShowDialog();
      }

      private void replacementForLostOrDamagedLicenseToolStripMenuItem1_Click(object sender, EventArgs e)
      {
         Form frm = new frmReplaceLostOrDamagedLicenseApplication();
         frm.ShowDialog();
      }

      private void tolStripDrivers_Click(object sender, EventArgs e)
      {
         Form frm = new frmListDrivers();
         frm.ShowDialog();
      }

      private void detainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
      {
         Form frm = new frmDetainLicenseApplication();
         frm.ShowDialog();
      }

      private void releaseDetainedDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
      {
         Form frm = new frmReleaseDetainLicense();
         frm.ShowDialog();
      }

      //private void detianLicensesToolStripMenuItem_Click(object sender, EventArgs e)
      //{
      //   Form frm = new frmDetainLicenseApplication();
      //   frm.ShowDialog();
      //}
   }
}
