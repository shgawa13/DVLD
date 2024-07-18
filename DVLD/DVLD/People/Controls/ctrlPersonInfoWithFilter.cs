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
using System.Runtime.CompilerServices;

namespace DVLD.People.Controls
{
   public partial class ctrlPersonInfoWithFilter : UserControl
   {
      public event Action<int> OnPersonSelected;

      protected virtual void PersonSelected(int PersonID)
      {
         Action<int> handler = OnPersonSelected;
         if(handler != null)
         {
            handler(PersonID);
         }
      }

      private bool _ShowAddPerson = true;
      public bool ShowAddPerson
      {
         get { return _ShowAddPerson; }

         set 
         { 
            _ShowAddPerson = value;
            btnAddNewPerson.Visible = _ShowAddPerson;
         }
      }

      private bool _FilterEnable = true;
      public bool FilterEnable
      {
         get { return _FilterEnable; }

         set
         {
            _FilterEnable = value;
            grbFilter.Visible = _FilterEnable;
         }
      }

      private int _PersonID =-1;
      
      public int PersonID
      {
         get { return ctrlPersonInfo1.PersonID; }
      }

      public clsPerson SelectedPerson
      {
         get { return ctrlPersonInfo1.SelectedPerson; }
      }

      public void LoadPersonInfo(int PersonID)
      {
         cbFilterBy.SelectedIndex = 0;
         txtFilterValue.Text = PersonID.ToString();
         FindNow();
      }

      public void LoeadPersonInfo(string NationalNo)
      {
         cbFilterBy.SelectedIndex = 1;
         txtFilterValue.Text = NationalNo;
         FindNow();
      }

      public void FindNow()
      {
         switch (cbFilterBy.Text)
         {
            case "Person ID":
               ctrlPersonInfo1.LoadPersonData(int.Parse(txtFilterValue.Text));
               break;

            case "National No": // National No
               ctrlPersonInfo1.LoadPersonData(txtFilterValue.Text.ToString());
               break;


            default:
               break;
         }

         if (OnPersonSelected != null && FilterEnable)
            OnPersonSelected(ctrlPersonInfo1.PersonID);
      }



      public ctrlPersonInfoWithFilter()
      {
         InitializeComponent();
      }



      private void btnAddNewPerson_Click_1(object sender, EventArgs e)
      {
         frmAddUpdatePerson frm = new frmAddUpdatePerson();
         frm.DataBack += Frm_DataBack1;
         frm.ShowDialog();
      }

      private void Frm_DataBack1(object sender, int PersonID)
      {
         ctrlPersonInfo1.LoadPersonData(PersonID);
      }


     
      public void btnSearch_Click_1(object sender, EventArgs e)
      {
         FindNow();
         
      }

      private void ctrlPersonInfo1_Load(object sender, EventArgs e)
      {
         cbFilterBy.SelectedIndex = 0;

      }

      
   }
}
