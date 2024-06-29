﻿using DVLD.People.Controls;
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
   public partial class frmShowPersonInfo : Form
   {
      public frmShowPersonInfo(int PersonID)
      {
         InitializeComponent();
         ctrlPersonInfo1.LoadPersonData(PersonID);
      }

      public frmShowPersonInfo(string NationalNo) 
      {
         InitializeComponent();
         ctrlPersonInfo1.LoadPersonData(NationalNo);
      }

      private void btnCloseLogin_Click(object sender, EventArgs e)
      {
         this.Close();
      }

     
   }
}
