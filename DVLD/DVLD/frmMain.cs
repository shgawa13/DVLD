using DVLD.Applications;
using DVLD.Tests;
using DVLD.Users;
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
      public frmMain()
      {
         InitializeComponent();
      }

      private void btnCloseLogin_Click(object sender, EventArgs e)
      {
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
   }
}
