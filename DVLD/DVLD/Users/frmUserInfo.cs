using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Users
{
   public partial class frmUserInfo : Form
   {
      private int _UserID = -1;
      public int UserID
      {
         get { return _UserID; }
      }


      public frmUserInfo(int ID)
      {
         InitializeComponent();
         this._UserID = ID;
      }

      private void frmUserInfo_Load(object sender, EventArgs e)
      {
         ctrlUserInfo1.LoadUserInfo(_UserID);
      }
   }
}
