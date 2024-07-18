using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Applications
{
   public partial class frmLocalDrivingLicenseApplication : Form
   {
      public frmLocalDrivingLicenseApplication()
      {
         InitializeComponent();
      }

      private void frmLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
      {
         btnNext.Enabled = false;
         tabpApplicationInfo.Enabled = false;

      }


      private void btnNext_Click(object sender, EventArgs e)
      {

      }
   }
}
