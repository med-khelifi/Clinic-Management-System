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

        private void cmsIChangePassword_Click(object sender, EventArgs e)
        {
            using (frmChangePassword frm = new frmChangePassword(dgvUsersList.CurrentRow.Cells[2].Value.ToString()))
            {
                frm.ShowDialog();
            }
        }

        private void cmsIActivate_Deactivate_Click(object sender, EventArgs e)
        {
            string username = dgvUsersList.CurrentRow.Cells[2].Value?.ToString(); // تأكد من العمود الصحيح

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Invalid username. Please select a valid user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // جلب الحالة من قاعدة البيانات
            bool? isActive = clsUser.getUserStatus(username);

            if (isActive == null)
            {
                MessageBox.Show("The selected user was not found in the database.", "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool newStatus = !isActive.Value;
            string actionText = newStatus ? "activate" : "deactivate";

            // رسالة تأكيد
            DialogResult result = MessageBox.Show(
                $"Are you sure you want to {actionText} the user '{username}'?",
                "Confirm Action",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            // تنفيذ التغيير
            if (clsUser.ChangeUserStatus(username, newStatus).Value)
            {
                MessageBox.Show($"User '{username}' has been successfully {(newStatus ? "activated" : "deactivated")}.",
                                "Operation Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshData(); // إعادة تحميل البيانات
            }
            else
            {
                MessageBox.Show($"Failed to {actionText} the user '{username}'. Please try again.",
                                "Operation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmsUsers_Opening(object sender, CancelEventArgs e)
        {
            string username = dgvUsersList.CurrentRow.Cells[2].Value?.ToString(); // عمود اسم المستخدم

            if (string.IsNullOrWhiteSpace(username))
            {
                cmsIActivate_Deactivate.Text = "Unknown";
                return;
            }

            bool? isActive = clsUser.getUserStatus(username);

            if (isActive.HasValue)
            {
                cmsIActivate_Deactivate.Text = isActive.Value ? "Deactivate" : "Activate";
                cmsIActivate_Deactivate.Image = isActive.Value ? Properties.Resources.deactivate : Properties.Resources.isActive;
            }
            else
            {
                cmsIActivate_Deactivate.Text = "Unknown";
            }
        }

    }
}
