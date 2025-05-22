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
    public partial class frmAddEditPerson : Form
    {
        
        public delegate void OnUserSavedDelegate(clsPerson person);
        public event OnUserSavedDelegate OnUserSaved;
        string nationalNo = "";
        clsPerson _Person = null;
        enum enFormMode { eUpdateMode,eAddNewMode}
        enFormMode _eFormMode;
        public frmAddEditPerson()
        {
            InitializeComponent();
            _eFormMode = enFormMode.eAddNewMode;
        }
        public frmAddEditPerson(string NationalNo)
        {
            InitializeComponent();
            this.nationalNo = NationalNo;
            _eFormMode = enFormMode.eUpdateMode; 
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
            pbPersonImage.Image = Resources.Male;
            
        }

        private void _ShowFormUI()
        {
            string title = _eFormMode == enFormMode.eUpdateMode ? "Edit Person" : "Add New Person";
            this.Text = title;
            lblTitle.Text = title;
        }

        void _LoadPersonInfo()
        {
            _Person = clsPerson.Find(nationalNo);
            if (_Person == null) 
            {
                MessageBox.Show("Cannot Retrive User Info", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtName.Text = _Person.Name;
            txtNationalNo.Text = _Person.NationalNo;
            rbMale.Checked = _Person.Gender == false;
            rbFemale.Checked = _Person.Gender == true;
            txtEmail.Text = _Person.Email;
            txtAddress.Text = _Person.Address;  
            dtpDateOfBirth.Value = _Person.DateOfBirth;
            txtPhone.Text = _Person.PhoneNumber;

            cbCountries.Text = clsCountry.Find(_Person.NationalityID).CountryName ?? "Undefine";
           
            llRemovePicture.Visible = (pbPersonImage.ImageLocation != null);
            if (_Person.ImagePath != "")
                pbPersonImage.Load(_Person.ImagePath);
        }

        private void frmAddEditPerson_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();
            
            if (_eFormMode == enFormMode.eUpdateMode)
                _LoadPersonInfo();
            else
                _Person = new clsPerson();
        }
        private bool _HandleUserImage()
        {

            //this procedure will handle the person image,
            //it will take care of deleting the old image from the folder
            //in case the image changed. and it will rename the new image with guid and 
            // place it in the images folder.


            //_Person.ImagePath contains the old Image, we check if it changed then we copy the new image
            string userImage = _Person.ImagePath;
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
           

            _Person.Name = txtName.Text.Trim();
            _Person.NationalNo = txtNationalNo.Text.Trim();
            _Person.Email = txtEmail.Text.Trim();
            _Person.PhoneNumber = txtPhone.Text.Trim();
            _Person.Address = txtAddress.Text.Trim();
            _Person.DateOfBirth = dtpDateOfBirth.Value;
            _Person.NationalityID = NationalityCountryID;
            if(pbPersonImage.ImageLocation != null)
                _Person.ImagePath = pbPersonImage.ImageLocation.ToString();


            OnUserSaved?.Invoke(_Person);
            MessageBox.Show("Data Appled Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            Close();

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

            // validate that nationalNo is Not assigned to a Doctor or User
            bool isDoctor = clsPerson.isDoctor(txtNationalNo.Text.Trim());
            bool isUser = clsPerson.isUser(txtNationalNo.Text.Trim());
           
            if (clsPerson.isPatient(txtNationalNo.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNationalNo, "This NationalNo is Assigned to Exists Patient !");
                return;
            }
            else
            {
                errorProvider1.SetError(txtNationalNo, null);
            }
            
            if (isDoctor)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNationalNo,value : "This NationalNo is Assigned to Exists Doctor !");
                return;
            }
            else
            {
                errorProvider1.SetError(txtNationalNo, null);
            }

            if (isUser)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNationalNo, "This NationalNo is Assigned to Exists User !");
                return;
            }
            else
            {
                errorProvider1.SetError(txtNationalNo, null);
            }
        }

    }
}
