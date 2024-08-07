using Business;
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
using DVLD.People;

namespace DVLD.Applications.controls
{
   public partial class ctrlApplicationBasicInfo : UserControl
   {
      public ctrlApplicationBasicInfo()
      {
         InitializeComponent();
      }

      private clsApplication _Application;
      private int _ApplicationID;

      public int ApplicationID
      {
         get { return _ApplicationID; }
      }

      public void LoadApplicationBasicInfo(int ApplicationID)
      {
         // find application 
         _Application = clsApplication.FindBaseApplication(ApplicationID);
         // if application in null
         if(_Application == null)
         {
            ResetApplicationInfo();
            MessageBox.Show("No Person with PersonID = " + ApplicationID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;

         }
         // if application was found and the object was filled then we show the info
          _FillApplicationCardWithInfo();

      }



      private void _FillApplicationCardWithInfo()
      {

         _ApplicationID = _Application.ApplicationID;
         lblID.Text = _Application.ApplicationID.ToString();
         lblStatus.Text = _Application.StatusText;
         lblFees.Text = _Application.PaidFees.ToString();
         lblType.Text = _Application.ApplicationTypeInfo.ApplicationTypeTitle;
         lblApplicant.Text = _Application.ApplicantFullName;
         lblDate.Text = _Application.ApplicationDate.ToShortDateString();
         lblStatusDate.Text = _Application.LastStatusDate.ToShortDateString();
         lblCreatedBy.Text = _Application.CreatedByUserInfo.UserName;

      }

      public void ResetApplicationInfo()
      {
         _ApplicationID = -1;

         lblID.Text = "[????]";
         lblStatus.Text = "[????]";
         lblType.Text = "[????]";
         lblFees.Text = "[????]";
         lblApplicant.Text = "[????]";
         lblDate.Text = "[????]";
         lblStatusDate.Text = "[????]";
         lblCreatedBy.Text = "[????]";

      }

      private void linkViewPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
      {
         frmShowPersonInfo frm = new frmShowPersonInfo(_Application.ApplicantPersonID);
         frm.ShowDialog();
         // Refreshing
         LoadApplicationBasicInfo(_ApplicationID);
      }
   }
}
