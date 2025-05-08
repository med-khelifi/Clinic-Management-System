using BusinessLayer;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Users
{
    public partial class frmChangePassword : Form
    {
        string _username = string.Empty;
        clsUser _user;
        public frmChangePassword(string username)
        {
            InitializeComponent();
            _username = username;
        }
        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            ucUserCard1.LoadUserInfo(_username);
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void txtOldPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtOldPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtOldPassword, "This field is required! Old password cannot be blank !");
                return;
            }
            else
            {
                errorProvider1.SetError(txtOldPassword, null);
            }

            if (!clsPasswordHasher.Verify(txtOldPassword.Text.Trim(), ucUserCard1.User.Password))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtOldPassword, "Old password is incorrect !");
                return;
            }
            else
            {
                errorProvider1.SetError(txtOldPassword, null);
            
            }
        }
        private void txtNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNewPassword, "This field is required! Password cannot be blank !");
                return;
            }
            else
            {
                errorProvider1.SetError(txtNewPassword, null);
            }
        }
        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtConfirmPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "This field is required!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, null);
            }

            //Make sure the user name is not used by another person
            if (txtConfirmPassword.Text.Trim() != txtNewPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "Password deosn't match!");

            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, null);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ucUserCard1.User.ChangePassword(txtNewPassword.Text.Trim()))
            {
                btnSave.Enabled = false;
                MessageBox.Show("Password Changed Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error: Password Not Changed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
