using BusinessLayer;
using CMS.GlobalClasses;
using CMS.Logger;
using CMS.Properties;
using CMS.Utility;
using Guna.UI2.HtmlRenderer.Adapters;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace CMS.Users
{
    public partial class frmAddEditUser : Form
    {
        string _UserName = null;

        clsUser _User = null;
        clsDoctor _Doctor = null;

        bool _isDoctor = false;
        public delegate void OnUserSavedDelegate();
        public event OnUserSavedDelegate OnUserSaved;

        enum enFormMode { eUpdateMode,eAddNewMode}
        enFormMode _eFormMode;
        public frmAddEditUser(bool isDoctor = false)
        {
            InitializeComponent();
            _eFormMode = enFormMode.eAddNewMode;
            _isDoctor = isDoctor;
        }
        public frmAddEditUser(string UserName, bool isDoctor = false)
        {
            InitializeComponent();
            this._UserName = UserName;
            _eFormMode = enFormMode.eUpdateMode;
            _isDoctor = isDoctor;   
        }
        private void _HandleFormSize()
        {
            if(enFormMode.eUpdateMode == _eFormMode)
            {
                this.Size = new Size(this.Width, this.Height - 80);
                gbUserDetails.Size = new Size(gbPesonalInfo.Width, gbPesonalInfo.Height -140);

                llbChangePassword.Visible = true;
                txtPassword.Visible = false;
                txtConfirmPassword.Visible = false;
                lblPassword.Visible = false;
                lblConfirmPassword.Visible = false;
                pbConfirmPassword.Visible = false;
                pbPassword.Visible = false;

                // handele buttons location
                btnSave.Location = new Point(btnSave.Location.X , btnSave.Location.Y + - 80);
                BtnClose.Location = new Point(BtnClose.Location.X , BtnClose.Location.Y - 80);
            }
           
        }   
        private void _FillCountriesInComoboBox()
        {
            DataTable dtCountries = clsCountry.GetAllCountriesTable();

            foreach (DataRow row in dtCountries.Rows)
            {
                cbCountries.Items.Add(row["CountryName"]);
            }
        }
        private void _ResetDefualtValues()
        {
            //this will initialize the reset the defaule values
            _FillCountriesInComoboBox();
            _ShowFormUI();

            //hide/show the remove linke incase there is no image for the person.
            llRemovePicture.Visible = (pbPersonImage.ImageLocation != null);

            //we set the max date to 18 years from today, and set the default value the same.
            dtpDateOfBirth.MaxDate = DateTime.Now;
            dtpDateOfBirth.Value = dtpDateOfBirth.MaxDate;

            //should not allow adding age more than 100 years
            dtpDateOfBirth.MinDate = DateTime.Now.AddYears(-150);

            //this will set default country to tunisia.
            cbCountries.SelectedIndex = cbCountries.FindString("Tunisia");

            txtName.Text = "";
            txtNationalNo.Text = "";
            rbMale.Checked = true;
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            txtSpecialization.Text = "";
            rbAdmin.Checked = true;
            pbPersonImage.Image = Resources.Male;
            
        }
        void _ShowFormUI()
        {
            string title = null;
            if (_eFormMode == enFormMode.eAddNewMode)
            {
                if (_isDoctor)
                {
                    title = "Add New Doctor";
                }
                else
                {
                    title = "Add New User";
                }
                this.Text = title;
                lblTitle.Text = title;
            }
            else
            {
                if (_isDoctor)
                {
                    title = "Update Doctor";
                }
                else
                {
                    title = "Update User";
                }
                this.Text = title;
                lblTitle.Text = title;
            }

            lblSpecialization.Visible = _isDoctor;
            txtSpecialization.Visible = _isDoctor;
            pbSpecialization.Visible = _isDoctor;   

            rbAdmin.Text = _isDoctor ? "Doctor" : "Admin";
            rbUser.Visible = !_isDoctor;

        }
        private void _initializeUserType()
        {
            _User = new clsUser();
            if (_isDoctor)
            {
                _Doctor = new clsDoctor();
            }
        }
        void _LoadUserInfo()
        {
            _User = clsUser.Find(_UserName);
            if (_User == null) 
            {
                MessageBox.Show("Cannot Retrive User Info", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtName.Text = _User.PersonInfo.Name;
            txtNationalNo.Text = _User.PersonInfo.NationalNo;
            rbMale.Checked = _User.PersonInfo.Gender == false;
            rbFemale.Checked = _User.PersonInfo.Gender == true;
            txtEmail.Text = _User.PersonInfo.Email;
            txtAddress.Text = _User.PersonInfo.Address;  
            dtpDateOfBirth.Value = _User.PersonInfo.DateOfBirth;
            txtPhone.Text = _User.PersonInfo.PhoneNumber;

            cbCountries.Text = clsCountry.Find(_User.PersonInfo.NationalityID).CountryName ?? "Undefine";
           
            llRemovePicture.Visible = (pbPersonImage.ImageLocation != null);
            if (_User.PersonInfo.ImagePath != "")
                pbPersonImage.Load(_User.PersonInfo.ImagePath);

            // load user data
            txtUserName.Text = _User.Username;
            chk_isActive.Checked = _User.IsActive;
            rbAdmin.Checked = _User.RoleId == (int)clsRole.enRole.eAdmin;
            rbUser.Checked = _User.RoleId == (int)clsRole.enRole.eSimpleUser;
            this.ValidateChildren();
        }
        void _LoadDoctorInfo()
        {
            _Doctor = clsDoctor.FindByUsername(_UserName);
            if (_Doctor == null)
            {
                MessageBox.Show("Cannot Retrive Doctor Info", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtName.Text = _Doctor.UserInfo.PersonInfo.Name;
            txtNationalNo.Text = _Doctor.UserInfo.PersonInfo.NationalNo;
            rbMale.Checked = _Doctor.UserInfo.PersonInfo.Gender == false;
            rbFemale.Checked = _Doctor.UserInfo.PersonInfo.Gender == true;
            txtEmail.Text = _Doctor.UserInfo.PersonInfo.Email;
            txtAddress.Text = _Doctor.UserInfo.PersonInfo.Address;
            dtpDateOfBirth.Value = _Doctor.UserInfo.PersonInfo.DateOfBirth;
            txtPhone.Text = _Doctor.UserInfo.PersonInfo.PhoneNumber;

            cbCountries.Text = clsCountry.Find(_Doctor.UserInfo.PersonInfo.NationalityID).CountryName ?? "Undefine";

            if (_Doctor.UserInfo.PersonInfo.ImagePath != "")
                pbPersonImage.Load(_Doctor.UserInfo.PersonInfo.ImagePath);

            // load user data
            txtUserName.Text = _Doctor.UserInfo.Username;
            chk_isActive.Checked = _Doctor.UserInfo.IsActive;
           
            txtSpecialization.Text = _Doctor.Specialization;
            this.ValidateChildren();
        }

        private void _LoadInfo()
        {
            if (_isDoctor)
                _LoadDoctorInfo();
            else
                _LoadUserInfo();
        }

        private void frmAddEditPerson_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();
            _HandleFormSize();
            _initializeUserType();
            if (_eFormMode == enFormMode.eUpdateMode)
                _LoadInfo();
                
        }
        private bool _HandleUserImage()
        {

            //this procedure will handle the person image,
            //it will take care of deleting the old image from the folder
            //in case the image changed. and it will rename the new image with guid and 
            // place it in the images folder.


            //_Person.ImagePath contains the old Image, we check if it changed then we copy the new image
            string userImage = _isDoctor ? _Doctor.UserInfo.PersonInfo.ImagePath : _User.PersonInfo.ImagePath;
            if ( userImage != pbPersonImage.ImageLocation)
            {
                if ( !string.IsNullOrEmpty(userImage))
                {
                    //first we delete the old image from the folder in case there is any.

                    try
                    {
                        File.Delete(userImage);
                    }
                    catch (IOException io)
                    {
                        // We could not delete the file.
                        clsLogger.LogError(io);
                        //log it later   
                    }
                }

                if (pbPersonImage.ImageLocation != null)
                {
                    //then we copy the new image to the image folder after we rename it
                    string SourceImageFile = pbPersonImage.ImageLocation.ToString();

                    if (clsUtil.CopyImageToProjectImagesFolder(ref SourceImageFile))
                    {
                        pbPersonImage.ImageLocation = SourceImageFile;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

            }
            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            if (!_HandleUserImage())
                return;

            int NationalityCountryID = clsCountry.Find(cbCountries.Text).CountryID;
            _User.Username = txtUserName.Text.Trim();

            if (_isDoctor) 
            {
                if (_eFormMode == enFormMode.eUpdateMode)
                    _User = _Doctor.UserInfo;
                _User.RoleId = (int)clsRole.enRole.eDoctor;
                
            }
            else
            {
                if (rbAdmin.Checked)
                {
                    _User.RoleId = (int)clsRole.enRole.eAdmin;
                }
                if (rbUser.Checked)
                {
                    _User.RoleId = (int)clsRole.enRole.eSimpleUser;
                }
            }


            _User.IsActive = chk_isActive.Checked;

            _User.PersonInfo.Name = txtName.Text.Trim();
            _User.PersonInfo.NationalNo = txtNationalNo.Text.Trim();
            _User.PersonInfo.Email = txtEmail.Text.Trim();
            _User.PersonInfo.PhoneNumber = txtPhone.Text.Trim();
            _User.PersonInfo.Address = txtAddress.Text.Trim();
            _User.PersonInfo.DateOfBirth = dtpDateOfBirth.Value;

            if (rbMale.Checked)
                _User.PersonInfo.Gender = false;
            else
                _User.PersonInfo.Gender = true;

            _User.PersonInfo.NationalityID = NationalityCountryID;

            if (pbPersonImage.ImageLocation != null)
                _User.PersonInfo.ImagePath = pbPersonImage.ImageLocation;
            else
                _User.PersonInfo.ImagePath = "";

            //this will handle the password
            if (enFormMode.eAddNewMode == _eFormMode)
                _User.Password = txtPassword.Text.Trim();

            // load the doctor info
            if (_isDoctor)
            {
                _Doctor.UserInfo = _User;
                _Doctor.Specialization = txtSpecialization.Text.Trim();
            }
            
            
            bool save = _isDoctor ? _Doctor.Save() : _User.Save();

            if (save)
            {
                OnUserSaved?.Invoke();
                btnSave.Enabled = false;
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void llRemovePicture_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbPersonImage.ImageLocation = null;

            if (rbMale.Checked)
                pbPersonImage.Image = Resources.Male;
            else
                pbPersonImage.Image = Resources.female;

            llRemovePicture.Visible = false;
        }
        private void llblSetPic_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;
                pbPersonImage.Load(selectedFilePath);
                llRemovePicture.Visible = true;
            }
        }
        private void rbMale_CheckedChanged_1(object sender, EventArgs e)
        {
            if (pbPersonImage.ImageLocation == null) pbPersonImage.Image = Properties.Resources.Male;
        }
        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (pbPersonImage.ImageLocation == null) pbPersonImage.Image = Properties.Resources.female;
        }    
        private void txtPhone_Validating_1(object sender, CancelEventArgs e)
        {
            //validate email format
            if (!clsValidation.ValidateInteger(txtPhone.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPhone, "Invalid Phone Number Format!");
            }
            else
            {
                errorProvider1.SetError(txtPhone, null);
            }
        }
        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            //no need to validate the email incase it's empty.
            if (txtEmail.Text.Trim() == "")
            {
                //errorProvider1.SetError(txtEmail, null);
                return;
            }
                

            //validate email format
            if (!clsValidation.ValidateEmail(txtEmail.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmail, "Invalid Email Address Format!");
            }
            else
            {
                errorProvider1.SetError(txtEmail, null);
            }
        }
        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            // First: set AutoValidate property of your Form to EnableAllowFocusChange in designer 
            Guna2TextBox Temp = ((Guna2TextBox)sender);
            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "This field is required!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(Temp, null);
            }
        }
        private void txtNationalNo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNationalNo.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNationalNo, "This field is required!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtNationalNo, null);
            }
            string nationalNo = _isDoctor ? _Doctor.UserInfo.PersonInfo.NationalNo : _User.PersonInfo.NationalNo;
            //Make sure the national number is not used by another person
            if (txtNationalNo.Text.Trim() != nationalNo && clsPerson.isPersonExistsByNationalNo(txtNationalNo.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNationalNo, "National Number is used for another person!");

            }
            else
            {
                errorProvider1.SetError(txtNationalNo, null);
            }
        }
        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUserName, "This field is required!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtUserName, null);
            }

            //Make sure the user name is not used by another person
            string username = _isDoctor ? _Doctor.UserInfo.Username : _User.Username;
            if (txtUserName.Text.Trim() != username && clsUser.isUserExistsByUserName(txtUserName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUserName, "Username is used for another person!");

            }
            else
            {
                errorProvider1.SetError(txtUserName, null);
            }
        }
        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            Guna2TextBox txt = ((Guna2TextBox)sender);
            if (!txt.Visible)
                return;
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
            if (txtConfirmPassword.Text.Trim() != txtPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "Password deosn't match!");

            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, null);
            }
        }
        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            Guna2TextBox txt = ((Guna2TextBox)sender);
            if (!txt.Visible)
                return;
            if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassword, "This field is required! Password cannot be blank !");
                return;
            }
            else
            {
                errorProvider1.SetError(txtPassword, null);
            }
        }
    }
}
