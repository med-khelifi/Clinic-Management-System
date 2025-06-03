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

namespace CMS.Patients.Controls
{
    public partial class ucFindPatient : UserControl
    {
        public delegate void OnSearchPatientButtonClicked(string NationalNo);
        public event OnSearchPatientButtonClicked OnSearchPatientButton_Clicked;

        clsPatient _patient;
        public ucFindPatient()
        {
            InitializeComponent();
        }
        public int PatientID
        {
            get
            {
                return ucPatientCard1.PatientID;
            }
        }
        public clsPatient PatientInfo
        {
            get 
            { 
                return ucPatientCard1.PatientInfo; 
            }
        }
        private void btnSearchPerson_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchBox.Text))
            {
                MessageBox.Show("Please enter a National No to search.", "Empty Box", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //ucPersonCard1.LoadPersonInfo(txtSearchBox.Text);
            

            _patient = clsPatient.FindByNationalNo(txtSearchBox.Text.Trim());
            if(_patient is null)
            {
                OnSearchPatientButton_Clicked?.Invoke(null);
                ucPatientCard1.ResetPatientInfo();
                MessageBox.Show("Wrong NationalNo Patient is Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ucPatientCard1.LoadPatientData(_patient);
            OnSearchPatientButton_Clicked?.Invoke(txtSearchBox.Text.Trim());
        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            using (frmAddEditPatient frm = new frmAddEditPatient())
            {
                frm.OnPatientSaved_Back += (p) =>
                {
                    ucPatientCard1.LoadPatientData(p);
                };
                frm.ShowDialog();
            }
        }

        public void LoadPatientInfo(int patientID)
        {
            _patient = clsPatient.Find(patientID);  
            if(_patient is null)
            {
                MessageBox.Show("Cannot load info,Patient is null","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            txtSearchBox.Text = _patient.PersonInfo.NationalNo;
            ucPatientCard1.LoadPatientData(_patient);
        }
        public void LoadPatientInfo(clsPatient _patient)
        {
            if (_patient is null)
            {
                MessageBox.Show("Cannot load info,Patient is null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this._patient = _patient;
            txtSearchBox.Text = _patient.PersonInfo.NationalNo;
            ucPatientCard1.LoadPatientData(_patient);
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
