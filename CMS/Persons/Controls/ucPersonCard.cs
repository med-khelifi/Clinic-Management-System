using BusinessLayer;
using CMS.Properties;
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

namespace CMS.Users.Controls
{
    public partial class ucPersonCard : UserControl
    {
         clsPerson _Person;
        int _PersonID = -1;
        string _NationalNo = string.Empty;
        public string NationalNo
        {
            get { return _NationalNo; }
        }
        public int PersonID
        {
            get { return _PersonID; }
        }
        public clsPerson PersonInfo
        {
            get { return _Person; }  
        }
        public ucPersonCard()
        {
            InitializeComponent();
        }
        private void _LoadPersonImage()
        {
            string ImagePath = _Person.ImagePath;
            if (ImagePath == "")
            {
                pbPersonImage.Image = (_Person.Gender == false ? Resources.Male : Resources.female);
                return;
            }
            if (File.Exists(ImagePath))
                pbPersonImage.ImageLocation = ImagePath;
            else
                MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void _FillPersonInfo()
        {
            llEditPersonInfo.Enabled = true;
            _NationalNo = _Person.NationalNo;
            _PersonID = _Person.PersonID;
            lblNationalNo.Text = _Person.NationalNo;
            lblFullName.Text = _Person.Name;
            lblGender.Text = _Person.Gender == false ? "Male" : "Female";
            lblEmail.Text = string.IsNullOrEmpty(_Person.Email) ? "Not Available" : _Person.Email;
            lblPhone.Text = _Person.PhoneNumber;
            lblDateOfBirth.Text = _Person.DateOfBirth.ToShortDateString();
            lblCountry.Text = clsCountry.Find(_Person.NationalityID).CountryName;
            lblAddress.Text = _Person.Address;
            _LoadPersonImage();
        }
        public void ResetPersonInfo()
        {
            _PersonID = -1;
            lblNationalNo.Text = "-";
            lblFullName.Text = "-";
            lblGender.Text = "-";
            lblEmail.Text = "-";
            lblPhone.Text = "-";
            lblDateOfBirth.Text = "-";
            lblCountry.Text = "-";
            lblAddress.Text = "-";
            pbPersonImage.Image = Resources.Male;

        }
        
        public void LoadPersonInfo(string NationalNo)
        {
            _Person = clsPerson.Find(NationalNo);

            if (_Person == null)
            {
                llEditPersonInfo.Enabled = false;
                ResetPersonInfo();
                MessageBox.Show("No Person with National No. = " + NationalNo, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillPersonInfo();
        }

        private void llEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson(_PersonID);
            frm.OnSaveClicked += LoadPersonInfo;
            frm.ShowDialog();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }
    }
}
