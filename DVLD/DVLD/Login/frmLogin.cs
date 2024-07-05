using DVLD.People;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
         this.Close();
      }

      private void btnLogin_Click(object sender, EventArgs e)
      {
         Form DashBoard = new frmMain();
         DashBoard.ShowDialog();
      }

     
   }
}
