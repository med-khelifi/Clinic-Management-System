using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CMS.Users
{
    public partial class ctrManagePeople : UserControl
    {
        
        public ctrManagePeople()
        {
            InitializeComponent();
        }

        private void ctrManageUsers_Load(object sender, EventArgs e)
        {
            RefreshData();
        }
        public void RefreshData()
        {
            dgvUsers.DataSource = clsUser.GetAllUsersTable();
            lbRecordCount.Text = "#Count = " + dgvUsers.Rows.Count;
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            frmAddEditUser frmAddEditUser = new frmAddEditUser();
            frmAddEditUser.ShowDialog();
        }
    }
}
