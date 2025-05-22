using BusinessLayer;
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
using System.Xml.Linq;

namespace CMS.Patients
{
    public partial class frmAddEditPatient : Form
    {
        enum FormMode { eAddNew, eUpdate }
        FormMode _formMode ;
        string _nationalNo;
        clsPatient _Patient;

        public delegate void OnPatientSavedDelegate();
        public OnPatientSavedDelegate OnPatientSaved;
        
        public delegate void OnPatientSaved_BackDelegate(string NationalNo);
        public OnPatientSaved_BackDelegate OnPatientSaved_Back;
        private void _LoadBloodTypes()
        {
            var bloodTypes = clsBloodType.GetAllBloodTypesTable();
            foreach (DataRow item in bloodTypes.Rows)
            {
                cbBloodTypes.Items.Add(item["BloodTypeName"]);
            }           
        }
        private void _LoadPatientInfo()
        {
            _Patient = clsPatient.FindByNationalNo(_nationalNo);
            if (_Patient != null)
            {
                ucPersonCardWithSearch1.LoadPersonInfo(_Patient.PersonInfo);
                cbBloodTypes.SelectedItem = _Patient.BloodTypeInfo.BloodTypeName;
                llEditPersonInfo.Visible = true;
            }
            else
            {
                MessageBox.Show("Cannot load Patient Info", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ucPersonCardWithSearch1.ResetPersonInfo();
            }
        }
        private void showTitle()
        {
            this.Text = _formMode == FormMode.eAddNew ? "Add New Patient" : "Update Patient";
            lblTitle.Text = _formMode == FormMode.eAddNew ? "Add New Patient" : "Update Patient";
        }
        public frmAddEditPatient()
        {
            InitializeComponent();
            _formMode = FormMode.eAddNew;
        }
        public frmAddEditPatient(string NationalNo)
        {
            InitializeComponent();
            _formMode = FormMode.eUpdate;
            _nationalNo = NationalNo;
        }

        private void ucPersonCardWithSearch1_OnSearchPersonClicked(object sender, string nationalNo)
        {
            //should not be exists in patient table
            if(clsPerson.isPatient(nationalNo))
            {
                MessageBox.Show("This person is already a patient !","Patient Exists",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            //should be doctor or user 
            bool isDoctor = clsPerson.isDoctor(nationalNo);
            bool isUser = clsPerson.isUser(nationalNo);

            if (isDoctor || isUser)
            {
                ucPersonCardWithSearch1.LoadPersonInfo(nationalNo);
            }
            else
            {
                MessageBox.Show("This person is not a doctor or user ! Add Person To Continue !", "Wrong selection", MessageBoxButtons.OK,MessageBoxIcon.Error);
                ucPersonCardWithSearch1.ResetPersonInfo();
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ucPersonCardWithSearch1.PersonInfo == null)
            {
                MessageBox.Show("Please Select Person First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbBloodTypes.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select Blood Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
         
            _Patient.BloodTypeID = clsBloodType.Find(cbBloodTypes.SelectedItem.ToString()).BloodTypeID;
            if(_formMode == FormMode.eUpdate)
                _Patient.PersonID = ucPersonCardWithSearch1.PersonInfo.PersonID;
            _Patient.PersonInfo = ucPersonCardWithSearch1.PersonInfo;





            bool save = _Patient.Save();

            if (save)
            {
                OnPatientSaved?.Invoke();
                OnPatientSaved_Back.Invoke(_Patient.PersonInfo.NationalNo);
                btnSave.Enabled = false;
                llEditPersonInfo.Visible = true;
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void frmAddEditPatient_Load(object sender, EventArgs e)
        {
            _LoadBloodTypes();
            cbBloodTypes.SelectedIndex = 0;
            showTitle();
            if (_formMode == FormMode.eUpdate)
            {
                _LoadPatientInfo();
            }
            else
            {
                ucPersonCardWithSearch1.EnableSearch = true;
                _Patient = new clsPatient();
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (frmAddEditPerson frm = new frmAddEditPerson(_Patient.PersonInfo.NationalNo))
            {
                frm.OnUserSaved += (p) =>
                {
                    ucPersonCardWithSearch1.LoadPersonInfo(p);                    
                };
                frm.ShowDialog();
            }
        }
    }
}
