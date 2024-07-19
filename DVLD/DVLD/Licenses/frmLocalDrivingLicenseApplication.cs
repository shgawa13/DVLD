using Business;
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
using DVLD.Global_Classes;
using System.Windows.Forms;

namespace DVLD.Applications
{
   public partial class frmLocalDrivingLicenseApplication : Form
   {
      public enum enMode { AddNew =0, Update =1}
      private enMode _Mode = enMode.AddNew;
      clsLocalDrivingLicenseApplication _App { set; get; }
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
            labApplicationDate.Text = DateTime.Now.ToString();
            lblCreatedByUser.Text = clsGlobal.CurrnetUser.UserName;
            _FillLicenseClass();
         }

      }

      private void _FillLicenseClass()
      {
         DataTable dtLicenseClass = clsLicenseClass.GetAllLicenseClasses();
         if(dtLicenseClass != null)
         {
            foreach (DataRow row in dtLicenseClass.Rows)
            {
               cmbLicenseClasses.Items.Add(row["ClassName"]);
            }
            cmbLicenseClasses.SelectedIndex = 0;
         }
         else
         {
            MessageBox.Show("Something went worng, couldn't Load License Class ");
         }
         
      }



      private void btnNext_Click(object sender, EventArgs e)
      {
         tabCtrlApp.SelectedTab = tabCtrlApp.TabPages["tabpApplicationInfo"];
      }

      private void btnSave_Click(object sender, EventArgs e)
      {
         _App.ApplicationDate = DateTime.Now;
        // _App.

      }
   }
}
