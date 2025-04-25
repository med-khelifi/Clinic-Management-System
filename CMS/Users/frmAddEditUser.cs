using BusinessLayer;
using Guna.UI2.HtmlRenderer.Adapters;
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
    public partial class frmAddEditUser : Form
    {
        int _UserID;
        clsUser _User;
        enum enFormMode { eAddNewMode, eUpdateMode }
        enFormMode _eFormMode;
        public frmAddEditUser()
        {
            InitializeComponent();
            _eFormMode = enFormMode.eAddNewMode;
        }

        
        public frmAddEditUser(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
            _eFormMode = enFormMode.eUpdateMode;
        }

        void _ShowFormTitle()
        {
            if (_eFormMode == enFormMode.eAddNewMode)
            {
                this.Text = "Add New User";
                lblTitle.Text = "Add New User";
            }
            else
            {
                this.Text = "Edit User";
                lblTitle.Text = "Edit User";
            }
        }

        void _LoadInfo()
        {
            _User = clsUser.Find(_UserID);
            if (_User == null)
            {
                MessageBox.Show("Cannot Retrive User Info", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtUserName.Text = _User.Username;
            txtPassword.Text = _User.Password;
            chk_isActive.Checked = _User.IsActive;
            ucPersonCardWithSearch1.LoadPersonInfo(_User.PersonInfo.NationalNo); 
        }

        private void frmAddEditUser_Load(object sender, EventArgs e)
        {
            _ShowFormTitle();
           
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }          
            
            _User.Username = txtUserName.Text.Trim();
            _User.Password = txtPassword.Text.Trim();
            _User.IsActive = _User.IsActive;


            if (_User.Save())
            {
                

                //change form mode to update.
                _eFormMode = enFormMode.eUpdateMode;
                lblTitle.Text = "Update Person";

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
