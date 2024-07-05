using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Tests.Test_Types
{
   public partial class frmEditTestType : Form
   {
      private clsTestType.enTypeTest _TestTypeID = clsTestType.enTypeTest.VisionTest;
      private clsTestType _TestType;

      public frmEditTestType(clsTestType.enTypeTest ID)
      {
         InitializeComponent();
         _TestTypeID = ID;
      }

      private void _LoadeTestType()
      {
         _TestType = clsTestType.Find(_TestTypeID);

         if(_TestType == null)
         {
            MessageBox.Show("Couldn't load Test Type");
            return;
         }

         lblTestTypeID.Text = _TestTypeID.ToString();
         txtbTtitle.Text = _TestType.TestTypeTitle;
         txtbDescription.Text = _TestType.TestTypeDescription;
         txtbFees.Text = _TestType.TestTypeFees.ToString();
      }

      private void frmEditTestType_Load(object sender, EventArgs e)
      {
         _LoadeTestType();
      }

      private void btnSave_Click(object sender, EventArgs e)
      {
         _TestType.TestTypeTitle = txtbTtitle.Text;
         _TestType.TestTypeDescription = txtbDescription.Text;
         _TestType.TestTypeFees = Convert.ToSingle(txtbFees.Text);

         if (_TestType.Save())
            MessageBox.Show("Test Type has been Updated Successfully");
         else
            MessageBox.Show("Something went wrong");

         
      }
   }
}
