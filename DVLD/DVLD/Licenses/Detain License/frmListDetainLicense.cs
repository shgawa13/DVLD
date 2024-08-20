using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using BusinessLayer;
using DVLD.Licenses.Local_License;
using DVLD.People;
namespace DVLD.Licenses.Detain_License
{
   public partial class frmListDetainedLicense : Form
   {
      private DataTable _dtAllDetainedLicenses;


      public frmListDetainedLicense()
      {
         InitializeComponent();
      }

      private void frmListDetainedLicense_Load(object sender, EventArgs e)
      {
         cbFilterBy.SelectedIndex = 0;

         _dtAllDetainedLicenses = clsDetainedLicense.GetAllDetainedLicenses();
         dgvDetainedLicenses.DataSource = _dtAllDetainedLicenses;
         lblTotalRecords.Text = dgvDetainedLicenses.RowCount.ToString();

         if (dgvDetainedLicenses.Rows.Count > 0)
         {
            dgvDetainedLicenses.Columns[0].HeaderText = "D.ID";
            dgvDetainedLicenses.Columns[0].Width = 90;

            dgvDetainedLicenses.Columns[1].HeaderText = "L.ID";
            dgvDetainedLicenses.Columns[1].Width = 90;

            dgvDetainedLicenses.Columns[2].HeaderText = "D.Date";
            dgvDetainedLicenses.Columns[2].Width = 160;

            dgvDetainedLicenses.Columns[3].HeaderText = "Is Released";
            dgvDetainedLicenses.Columns[3].Width = 110;

            dgvDetainedLicenses.Columns[4].HeaderText = "Fine Fees";
            dgvDetainedLicenses.Columns[4].Width = 110;

            dgvDetainedLicenses.Columns[5].HeaderText = "Release Date";
            dgvDetainedLicenses.Columns[5].Width = 160;

            dgvDetainedLicenses.Columns[6].HeaderText = "N.No.";
            dgvDetainedLicenses.Columns[6].Width = 90;

            dgvDetainedLicenses.Columns[7].HeaderText = "Full Name";
            dgvDetainedLicenses.Columns[7].Width = 330;

            dgvDetainedLicenses.Columns[8].HeaderText = "Rlease App.ID";
            dgvDetainedLicenses.Columns[8].Width = 150;

         }
      }

         private void txtFilterValue_TextChanged(object sender, EventArgs e)
      {
         string FilterColumn = "";
         //Map Selected Filter to real Column name 
         switch (cbFilterBy.Text)
         {
            case "Detain ID":
               FilterColumn = "DetainID";
               break;
            case "Is Released":
               {
                  FilterColumn = "IsReleased";
                  break;
               };

            case "National No.":
               FilterColumn = "NationalNo";
               break;


            case "Full Name":
               FilterColumn = "FullName";
               break;

            case "Release Application ID":
               FilterColumn = "ReleaseApplicationID";
               break;

            default:
               FilterColumn = "None";
               break;
         }

         //Reset the filters in case nothing selected or filter value conains nothing.
         if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
         {
            _dtAllDetainedLicenses.DefaultView.RowFilter = "";
            lblTotalRecords.Text = dgvDetainedLicenses.Rows.Count.ToString();
            return;
         }


         if (FilterColumn == "DetainID" || FilterColumn == "ReleaseApplicationID")
            //in this case we deal with numbers not string.
            _dtAllDetainedLicenses.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
         else
            _dtAllDetainedLicenses.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());

         lblTotalRecords.Text = _dtAllDetainedLicenses.Rows.Count.ToString();

      }

      private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
      {
         if (cbFilterBy.Text == "Is Released")
         {
            txtFilterValue.Visible = false;
            cbIsReleased.Visible = true;
            cbIsReleased.Focus();
            cbIsReleased.SelectedIndex = 0;
         }

         else

         {

            txtFilterValue.Visible = (cbFilterBy.Text != "None");
            cbIsReleased.Visible = false;

            if (cbFilterBy.Text == "None")
            {
               txtFilterValue.Enabled = false;
               //_dtDetainedLicenses.DefaultView.RowFilter = "";
               //lblTotalRecords.Text = dgvDetainedLicenses.Rows.Count.ToString();

            }
            else
               txtFilterValue.Enabled = true;

            txtFilterValue.Text = "";
            txtFilterValue.Focus();
         }

      }

      private void cbIsReleased_SelectedIndexChanged(object sender, EventArgs e)
      {
         string FilterColumn = "IsReleased";
         string FilterValue = cbIsReleased.Text;

         switch (FilterValue)
         {
            case "All":
               break;
            case "Yes":
               FilterValue = "1";
               break;
            case "No":
               FilterValue = "0";
               break;
         }


         if (FilterValue == "All")
            _dtAllDetainedLicenses.DefaultView.RowFilter = "";
         else
            //in this case we deal with numbers not string.
            _dtAllDetainedLicenses.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, FilterValue);

         lblTotalRecords.Text = _dtAllDetainedLicenses.Rows.Count.ToString();
      }

      private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
      {
         //we allow number incase person id or user id is selected.
         if (cbFilterBy.Text == "Detain ID" || cbFilterBy.Text == "Release Application ID")
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
      }

      private void tlsmShowPersonDetails_Click(object sender, EventArgs e)
      {
         int LicenseID = (int)dgvDetainedLicenses.CurrentRow.Cells[1].Value;
         int PersonID = clsLicense.Find(LicenseID).DriverInfo.PersonID;

         frmShowPersonInfo frm = new frmShowPersonInfo(PersonID);
         frm.ShowDialog();
      }

      private void tlsmShowLicenseDetails_Click(object sender, EventArgs e)
      {
         int LicenseID = (int)dgvDetainedLicenses.CurrentRow.Cells[1].Value;

         frmShowLicenseInfo frm = new frmShowLicenseInfo(LicenseID);
         frm.ShowDialog();
      }

      private void tlsmShowLicenseHistory_Click(object sender, EventArgs e)
      {
         int LicenseID = (int)dgvDetainedLicenses.CurrentRow.Cells[1].Value;
         int PersonID = clsLicense.Find(LicenseID).DriverInfo.PersonID;
         frmShowPersonLicenseHistory frm = new frmShowPersonLicenseHistory(PersonID);
         frm.ShowDialog();
      }

      private void tlsmReleaseDetainedLicesne_Click(object sender, EventArgs e)
      {
         int LicenseID = (int)dgvDetainedLicenses.CurrentRow.Cells[1].Value;

         frmReleaseDetainLicense frm = new frmReleaseDetainLicense(LicenseID);
         frm.ShowDialog();
         //refresh
         frmListDetainedLicense_Load(null, null);
      }

      
      
   }
}
