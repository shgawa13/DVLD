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


namespace DVLD.People
{
   public partial class frmPeople : Form
   {
      private static DataTable _dtAllPeople = clsPerson.GetAllPeople();

      // show only colums in the Table
      private DataTable _dtPeople = _dtAllPeople.DefaultView.ToTable(false, "PersonID", "NationalNo",
                                                       "FirstName", "SecondName", "ThirdName", "LastName",
                                                       "GendorCaption", "DateOfBirth", "CountryName",
                                                       "Phone", "Email");

      // here we will refresh the list 
      private void _RefreshPeopleList()
      {
         _dtAllPeople = clsPerson.GetAllPeople();
         _dtPeople = _dtAllPeople.DefaultView.ToTable(false, "PersonID", "NationalNo",
                                                       "FirstName", "SecondName", "ThirdName", "LastName",
                                                       "GendorCaption", "DateOfBirth", "CountryName",
                                                       "Phone", "Email");
         dgvPeople.DataSource = _dtPeople;
         lblRecordsNum.Text = dgvPeople.RowCount.ToString();
         

      }

      public frmPeople()
      {
         InitializeComponent();
      }

      private void btnCloseLogin_Click(object sender, EventArgs e)
      {
         this.Close();
      }

      private void frmPeople_Load(object sender, EventArgs e)
      {
         dgvPeople.DataSource = _dtPeople;
         cbFilter.SelectedIndex = 0;
         lblRecordsNum.Text = dgvPeople.Rows.Count.ToString();
      }


      private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
      {
         txtFilterValue.Visible = (cbFilter.Text != "None");

         if (txtFilterValue.Visible)
         {
            cbFilter.Text = "";
            cbFilter.Focus();
         }

      }

      private void txtFilterValue_TextChanged(object sender, EventArgs e)
      {
         // we can save case in FilterColumn string 
         string FilterColumn = "";
         //Map Selected Filter to real Column name 
         switch (cbFilter.Text)
         {
            case "Person ID":
               FilterColumn = "PersonID";
               break;

            case "National Number":
               FilterColumn = "NationalNo";
               break;

            case "First Name":
               FilterColumn = "FirstName";
               break;

            case "Second Name":
               FilterColumn = "SecondName";
               break;

            case "Third Name":
               FilterColumn = "ThirdName";
               break;

            case "Last Name":
               FilterColumn = "LastName";
               break;

            case "Nationality":
               FilterColumn = "CountryName";
               break;

            case "Gendor":
               FilterColumn = "GendorCaption";
               break;

            case "Phone Number":
               FilterColumn = "Phone";
               break;

            case "Email":
               FilterColumn = "Email";
               break;

            default:
               FilterColumn = "None";
               break;
         }

         //Reset the filters in case nothing selected or filter value conains nothing.
         if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
         {
            _dtPeople.DefaultView.RowFilter = "";
            lblRecordsNum.Text = _dtPeople.Rows.Count.ToString();
            return;
         }

         if (FilterColumn == "PersonID")
            _dtPeople.DefaultView.RowFilter = string.Format("[{0}]={1}", FilterColumn, txtFilterValue.Text.Trim());
         else
            _dtPeople.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());

         lblRecordsNum.Text = _dtPeople.Rows.Count.ToString();
      }


      private void btnAddPreson_Click(object sender, EventArgs e)
      {
         Form frmAddUpdatePerson = new frmAddUpdatePerson();
         frmAddUpdatePerson.ShowDialog();
         _RefreshPeopleList();
      }

      private void tolstmShowDetils_Click(object sender, EventArgs e)
      {
         Form frm = new frmShowPersonInfo((int)dgvPeople.CurrentRow.Cells[0].Value);
         frm.ShowDialog();
      }

      private void tolstmEdit_Click(object sender, EventArgs e)
      {
         Form frm = new frmAddUpdatePerson((int)dgvPeople.CurrentRow.Cells[0].Value);
         frm.ShowDialog();
         _RefreshPeopleList();
      }

      private void tolstmDelete_Click(object sender, EventArgs e)
      {
         if (MessageBox.Show("Are you sure you want to delete Person [" + dgvPeople.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)

         {

            //Perform Delele and refresh
            if (clsPerson.DeletePerson((int)dgvPeople.CurrentRow.Cells[0].Value))
            {
               MessageBox.Show("Person Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
               _RefreshPeopleList();
            }

            else
               MessageBox.Show("Person was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

         }
      }

      private void dgvPeople_CellContentClick(object sender, DataGridViewCellEventArgs e)
      {

      }
   }
}
