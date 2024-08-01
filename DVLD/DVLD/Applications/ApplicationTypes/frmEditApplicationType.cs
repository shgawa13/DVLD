using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Applications
{
   public partial class frmEditApplicationType : Form
   {
      private int _ApplicationID;
      clsApplicationTypes _ApplicationType;


      public frmEditApplicationType(int ID)
      {
         InitializeComponent();
         _ApplicationID = ID;
      }


      private void _LoadApplicationData()
      {
         _ApplicationType = clsApplicationTypes.GetApplicationTypeByID(_ApplicationID);

         if(_ApplicationType == null)
         {
            MessageBox.Show("Can't get Applicatin");
            return;
         }

         _FillAppDataInfo();
      }

      private void _FillAppDataInfo()
      {
         lblApplicationID.Text = _ApplicationType.ApplicationTypeID.ToString();
         txtbTitle.Text = _ApplicationType.ApplicationTypeTitle;
         txtbFees.Text = Convert.ToString( _ApplicationType.ApplicationFees);
      }

      private void frmEditApplicationType_Load(object sender, EventArgs e)
      {
         _LoadApplicationData();

      }

      private void btnSave_Click(object sender, EventArgs e)
      {
         if (!this.ValidateChildren())
         {
            return;
         }


         _ApplicationType.ApplicationTypeTitle = txtbTitle.Text;
         _ApplicationType.ApplicationFees = Convert.ToSingle(txtbFees.Text);

         if (_ApplicationType.Save())
         {
            MessageBox.Show("Application has been Updated Successfully");
         }
         else
         {
            MessageBox.Show("Something went worng ", "No Updated", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }


         
      }

      private void txtbTitle_Validating(object sender, CancelEventArgs e)
      {
        if(txtbTitle.Text == "")
         {
            e.Cancel = true;
            errorProvider1.SetError(txtbTitle, "Title Should not be an empty");
         }
         else
         {
            e.Cancel = false;
            errorProvider1.SetError(txtbTitle, null);
         }
      }

      private void txtbFees_Validating(object sender, CancelEventArgs e)
      {
         if (txtbTitle.Text == "")
         {
            e.Cancel = true;
            errorProvider1.SetError(txtbFees, "Fees Should not be an empty");
         }
         else
         {
            e.Cancel = false;
            errorProvider1.SetError(txtbFees, null);
         }
      }
   }
}
