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

namespace CMS.Users.Controls
{
    public partial class ucManageUsers : UserControl
    {
        public ucManageUsers()
        {
            InitializeComponent();
        }

        public void RefreshData()
        {
            dgvUsersList.DataSource = clsUser.GetAllUsersTable();
            lbRecordCount.Text = "#Count = " + dgvUsersList.Rows.Count;
        }

        private void ucManageUsers_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            using(var frm = new frmAddEditUser())
            {
                frm.OnUserSaved += () =>
                {
                    RefreshData();
                };
                frm.ShowDialog();
            }
        }

        private void cmsIUpdate_Click(object sender, EventArgs e)
        {
            using (var frm = new frmAddEditUser(dgvUsersList.CurrentRow.Cells[2].Value.ToString()))
            {
                frm.OnUserSaved += () =>
                {
                    RefreshData();
                };
                frm.ShowDialog();
            }
        }

        private void cmsIShowDetails_Click(object sender, EventArgs e)
        {
            using (frmUserInfo frm = new frmUserInfo(dgvUsersList.CurrentRow.Cells[2].Value.ToString())) 
            {
                frm.ShowDialog();
            }          
        }
    }
}
