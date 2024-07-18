using Business;
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
         btnSave.Enabled = false;
        if(ctrlPersonInfoWithFilter1.PersonID > -1)
         {
            btnNext.Enabled = true;
            tabpApplicationInfo.Enabled = true;
           // comboxLicense.Items
         }

      }

      private void _FillLicenseClass()
      {
         DataTable dtLicenseClass = clsLicenseClass.GetAllLicenseClasses();
         
         foreach(DataRow row in dtLicenseClass.Rows)
         {
            cmbLicenseClasses.Items.Add(row["ID"]);
         }
      }


      private void btnNext_Click(object sender, EventArgs e)
      {
         tabCtrlApp.SelectedTab = tabCtrlApp.TabPages["tabpApplicationInfo"];
      }

      private void btnCloseLogin_Click(object sender, EventArgs e)
      {
         this.Close();
      }
   }
}
