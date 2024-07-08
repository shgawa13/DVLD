using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
namespace DVLD.Users
{
   public partial class frmListUsers : Form
   {
      private static DataTable _dtAllUsers = clsUsers.GetAllUsers();

      private DataTable _dtUsers = _dtAllUsers.DefaultView.ToTable(false, "UserID", "PersonID",
                                                          "FullName", "UserName", "IsActive");

      public frmListUsers()
      {
         InitializeComponent();
      }
     

      private void _RefreshUsersList()
      {
         _dtAllUsers = clsUsers.GetAllUsers();
         _dtUsers = _dtAllUsers.DefaultView.ToTable(false, "UserID", "PersonID",
                                                          "FullName","UserName", "IsActive");

         dgvUsers.DataSource = _dtUsers;
         lblRecordsNumber.Text = dgvUsers.RowCount.ToString();

      }

   

      private void frmListUsers_Load_1(object sender, EventArgs e)
      {
         _RefreshUsersList();

         cbFilterBy.SelectedIndex = 0;
         
         dgvUsers.Columns[0].HeaderText = "User ID";
         dgvUsers.Columns[0].Width = 110;

         dgvUsers.Columns[1].HeaderText = "Person ID";
         dgvUsers.Columns[1].Width = 120;

         dgvUsers.Columns[2].HeaderText = "Full Name";
         dgvUsers.Columns[2].Width = 350;

         dgvUsers.Columns[3].HeaderText = "User Name";
         dgvUsers.Columns[3].Width = 150;

         dgvUsers.Columns[4].HeaderText = "Is Active";
         dgvUsers.Columns[4].Width = 60;


      }

      private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
      {
        if(cbFilterBy.Text =="Is Active")
         {
            txtFilterValue.Visible = false;
            cbIsActive.Visible = true;
            cbIsActive.SelectedIndex = 0;
            cbIsActive.Focus();
         }
         else
         {
            txtFilterValue.Visible = (cbFilterBy.Text != "None");
            cbIsActive.Visible = false;

            if(cbFilterBy.Text == "None")
               txtFilterValue.Enabled = false;
            
            else
               txtFilterValue.Enabled = true;
               txtFilterValue.Text = "";
               txtFilterValue.Focus();
         }
      }

      private void txtFilterValue_TextChanged(object sender, EventArgs e)
      {
         string FilterColumn = "";
         //Map Selected Filter to real Column name 
         switch (cbFilterBy.Text)
         {
            case "User ID":
               FilterColumn = "UserID";
               break;

            case "User Name":
               FilterColumn = "UserName";
               break;

            case "Person ID":
               FilterColumn = "PersonID";
               break;

            case "Full Name":
               FilterColumn = "FullName";
               break;

            default:
               FilterColumn = "None";
               break;

         }


         if(txtFilterValue.Text.Trim() == "" && FilterColumn != "None" )
         {
            _dtUsers.DefaultView.RowFilter = "";
            lblRecordsNumber.Text = dgvUsers.Rows.Count.ToString();
            return;
         }


         if (FilterColumn != "FullName" && FilterColumn != "None" && FilterColumn != "UserName")
            // in this case we deal with numbers
            _dtUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
         else
            _dtUsers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());

         lblRecordsNumber.Text = dgvUsers.Rows.Count.ToString();

      }

      private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
      {
         string FilterColumn = "IsActive";
         string FilterValue = cbIsActive.Text;

         switch (FilterValue)
         {

            case "Yes":
               FilterValue = "1";
               break;

            case "No":
               FilterValue = "0";
               break;

            case "All":
               break;
               
         }

         if (FilterValue == "All")
            _dtUsers.DefaultView.RowFilter = "";
         else
                _dtUsers.DefaultView.RowFilter = string.Format("[{0}]={1}", FilterColumn, FilterValue);

         lblRecordsNumber.Text = _dtUsers.Rows.Count.ToString();

      }

      private void btnAddUser_Click(object sender, EventArgs e)
      {
         Form frm = new frmAddUpdateUser();
         frm.ShowDialog();
         _RefreshUsersList();
      }

      private void tolsShowDetails_Click(object sender, EventArgs e)
      {
         Form frm = new frmUserInfo((int)dgvUsers.CurrentRow.Cells[0].Value);
         frm.ShowDialog();
         _RefreshUsersList();
      }

      private void tolsAddNewUser_Click(object sender, EventArgs e)
      {
         Form frm = new frmAddUpdateUser();
         frm.ShowDialog();
         _RefreshUsersList();
      }

      private void tolsDelete_Click(object sender, EventArgs e)
      {
         MessageBox.Show($"Are you sure to delete this user. {(int)dgvUsers.CurrentRow.Cells[0].Value}","Delete User",MessageBoxButtons.YesNoCancel,
         MessageBoxIcon.Exclamation);
         clsUsers.DeleteUser((int)dgvUsers.CurrentRow.Cells[0].Value);
         _RefreshUsersList();
      }

      private void tolsEdit_Click(object sender, EventArgs e)
      {
         Form frm = new frmAddUpdateUser((int)dgvUsers.CurrentRow.Cells[0].Value);
         frm.ShowDialog();
         _RefreshUsersList();
      }

      private void tolsChangePassword_Click(object sender, EventArgs e)
      {
         Form frm = new frmChangePassword((int)dgvUsers.CurrentRow.Cells[0].Value);
         frm.ShowDialog();
         _RefreshUsersList();
      }

     
   }
}
