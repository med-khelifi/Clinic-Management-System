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

namespace CMS.Users
{
    public partial class frmAddEditPerson : Form
    {
        int _PersonID;
        clsPerson _PersonInfo;

        public delegate void SendDataBackDelegate(string NationalNo);
        public SendDataBackDelegate OnSaveClicked;

        enum enFormMode { eUpdateMode,eAddNewMode}
        enFormMode _eFormMode;
        public frmAddEditPerson()
        {
            InitializeComponent();
            _eFormMode = enFormMode.eAddNewMode;
        }
        public frmAddEditPerson(int PersonID)
        {
            InitializeComponent();
            this._PersonID = PersonID;
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
            _ShowFormTitle();

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

        void _ShowFormTitle()
        {
            if(_eFormMode == enFormMode.eAddNewMode)
            {
                this.Text = "Add New Person";
                lblTitle.Text = "Add New Person";
            }
            else
            {
                this.Text = "Edit Person";
                lblTitle.Text = "Edit Person";
            }
        }

        void _LoadInfo()
        {
            _PersonInfo = clsPerson.Find(_PersonID);
            if (_PersonInfo == null) 
            {
                MessageBox.Show("Cannot Retrive Person Info", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtName.Text = _PersonInfo.Name;
            txtNationalNo.Text = _PersonInfo.NationalNo;
            rbMale.Checked = _PersonInfo.Gender == false;
            rbFemale.Checked = _PersonInfo.Gender == true;
            txtEmail.Text = _PersonInfo.Email;
            txtAddress.Text = _PersonInfo.Address;  
            dtpDateOfBirth.Value = _PersonInfo.DateOfBirth;
            txtPhone.Text = _PersonInfo.PhoneNumber;
            cbCountries.Text = clsCountry.Find(_PersonInfo.NationalityID).CountryName ?? "Undefine";
            if(pbPersonImage.Image != null)
                pbPersonImage.Load(_PersonInfo.ImagePath);

        }

        private void frmAddEditPerson_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();
            if (_eFormMode == enFormMode.eUpdateMode)
                _LoadInfo();
            else
                _PersonInfo = new clsPerson();
        }
        private bool _HandlePersonImage()
        {

            //this procedure will handle the person image,
            //it will take care of deleting the old image from the folder
            //in case the image changed. and it will rename the new image with guid and 
            // place it in the images folder.


            //_Person.ImagePath contains the old Image, we check if it changed then we copy the new image
            if (_PersonInfo.ImagePath != pbPersonImage.ImageLocation)
            {
                if ( !string.IsNullOrEmpty(_PersonInfo.ImagePath))
                {
                    //first we delete the old image from the folder in case there is any.

                    try
                    {
                        File.Delete(_PersonInfo.ImagePath);
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

            if (!_HandlePersonImage())
                return;

            int NationalityCountryID = clsCountry.Find(cbCountries.Text).CountryID;

            _PersonInfo.Name = txtName.Text.Trim();
            _PersonInfo.NationalNo = txtNationalNo.Text.Trim();
            _PersonInfo.Email = txtEmail.Text.Trim();
            _PersonInfo.PhoneNumber = txtPhone.Text.Trim();
            _PersonInfo.Address = txtAddress.Text.Trim();
            _PersonInfo.DateOfBirth = dtpDateOfBirth.Value;

            if (rbMale.Checked)
                _PersonInfo.Gender = false;
            else
                _PersonInfo.Gender = true;

            _PersonInfo.NationalityID = NationalityCountryID;

            if (pbPersonImage.ImageLocation != null)
                _PersonInfo.ImagePath = pbPersonImage.ImageLocation;
            else
                _PersonInfo.ImagePath = "";

            if (_PersonInfo.Save())
            {
                //lblPersonID.Text = _Person.PersonID.ToString();

                //change form mode to update.
                _eFormMode = enFormMode.eUpdateMode;
                lblTitle.Text = "Update Person";

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);


                // Trigger the event to send data back to the caller form.
                OnSaveClicked?.Invoke(_PersonInfo.NationalNo);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            //Make sure the national number is not used by another person
            if (txtNationalNo.Text.Trim() != _PersonInfo.NationalNo && clsPerson.isPersonExistsByNationalNo(txtNationalNo.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNationalNo, "National Number is used for another person!");

            }
            else
            {
                errorProvider1.SetError(txtNationalNo, null);
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            //no need to validate the email incase it's empty.
            if (txtEmail.Text.Trim() == "")
                return;

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

        private void txtEmpty_Validating(object sender, CancelEventArgs e)
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

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            //no need to validate the email incase it's empty.
            if (txtEmail.Text.Trim() == "")
                return;

            //validate email format
            if (!clsValidation.ValidateInteger(txtEmail.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmail, "Invalid Email Address Format!");
            }
            else
            {
                errorProvider1.SetError(txtEmail, null);
            }
        }

        private void llblSetPic_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void llRemovePicture_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbPersonImage.ImageLocation = null;



            if (rbMale.Checked)
                pbPersonImage.Image = Resources.Male;
            else
                pbPersonImage.Image = Resources.female;

            llRemovePicture.Visible = false;
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (pbPersonImage.ImageLocation == null) pbPersonImage.Image = Properties.Resources.Male;
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (pbPersonImage.ImageLocation == null) pbPersonImage.Image = Properties.Resources.female;
        }
    }
}
