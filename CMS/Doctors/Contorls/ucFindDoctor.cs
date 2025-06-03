using BusinessLayer;
using CMS.Patients.Controls;
using CMS.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CMS.Patients.Controls.ucFindPatient;

namespace CMS.Doctors.Contorls
{
    public partial class ucFindDoctor : UserControl
    {
        public delegate void OnSearchButtonClickedDelegate(string nationalNo);
        public event OnSearchButtonClickedDelegate OnSearchButtonClicked;
       
        public int DoctorID
        {
            get
            {
                return ucShortDoctorCard1.DoctorID;
            }
        }
        public clsDoctor DoctorInfo
        {
            get
            {
                return ucShortDoctorCard1.DoctorInfo;
            }
        }
        public ucFindDoctor()
        {
            InitializeComponent();
        }
        clsDoctor _doctor;

        private void FindDoctor()
        {
            switch (cbFindBy.Text)
            {
                case "NationalNo":
                    _doctor = clsDoctor.FindByNationalNo(txtSearchBox.Text.Trim());
                    break;
                case "Username":
                    _doctor = clsDoctor.FindByUsername(txtSearchBox.Text.Trim());
                    break;
                default:
                    _doctor = null;
                    break;
            }
        }
        private void btnSearchPerson_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchBox.Text))
            {
                MessageBox.Show("Enter text to search doctor !", "Invalid Input",MessageBoxButtons.OK,MessageBoxIcon.Error); 
                return;
            }
            FindDoctor();

            if (_doctor is null)
            {
                OnSearchButtonClicked?.Invoke(null);
                ucShortDoctorCard1.ResetUserInfo();
                MessageBox.Show("Wrong NationalNo/Username Doctor is Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ucShortDoctorCard1.LoadDoctorInfo(_doctor);
            OnSearchButtonClicked?.Invoke(_doctor.UserInfo.PersonInfo.NationalNo);
        }   
        private void gbFilter_Click(object sender, EventArgs e)
        {

        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            using (frmAddEditUser frm = new frmAddEditUser(true))
            {
                frm.OnUserSavedDataBack += (username) =>
                {
                    txtSearchBox.Text = username;
                    cbFindBy.Text = "Username";
                    btnSearchPerson.PerformClick();
                    gbFilter.Enabled = false;
                };
                frm.ShowDialog();
            }
        }

        private void ucShortDoctorCard1_Load(object sender, EventArgs e)
        {
            cbFindBy.SelectedIndex = 0;
        }
        public void LoadDoctorInfo(int DoctorID)
        {
            _doctor = clsDoctor.Find(DoctorID);

            if (_doctor is null)
            {
                MessageBox.Show("Cannot load info,Doctor is null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            txtSearchBox.Text = _doctor.UserInfo.PersonInfo.NationalNo;
            ucShortDoctorCard1.LoadDoctorInfo(_doctor);
        }
        public void LoadDoctorInfo(clsDoctor _doctor)
        {
            if (_doctor is null)
            {
                MessageBox.Show("Cannot load info,Doctor is null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this._doctor = _doctor;
            txtSearchBox.Text = _doctor.UserInfo.PersonInfo.NationalNo;
            ucShortDoctorCard1.LoadDoctorInfo(_doctor);
        }

        public void EnableFilter()
        {
            gbFilter.Enabled = true;
        }
        public void DisableFilter() 
        {
            gbFilter.Enabled = false;
        }
    }
}
