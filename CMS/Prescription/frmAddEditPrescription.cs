using BusinessLayer;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Prescription
{
    public partial class frmAddEditPrescription : Form
    {
        clsPrescription _prescritin;
        int _prescriptionID;
        int _medicalRecordID;

        public Action OnDataSaved;
        public enum enFormMode
        {
            eAddNew,Update
        }
        enFormMode _Mode;
        public frmAddEditPrescription(int MedicalRecordID,int PrescriptionID)
        {
            InitializeComponent();
            _prescriptionID = PrescriptionID;
            _medicalRecordID = MedicalRecordID;
            _Mode = enFormMode.Update;

        }  
        public frmAddEditPrescription(int MedicalRecordID)
        {
            InitializeComponent();
            _Mode = enFormMode.eAddNew;
            _medicalRecordID= MedicalRecordID;
        }

        private void _LoadData()
        {
            _prescritin = clsPrescription.Find(_prescriptionID);
            if (_prescritin != null) 
            { 
                lblMedicalRecordID.Text = _prescritin.MedicalRecordID.ToString();
                lblPrescriptionID.Text = _prescriptionID.ToString();

                txtAdditionalNotes.Text = _prescritin.SpecialInstructions.ToString();
                txtDosage.Text = _prescritin.Dosage.ToString(); 
                txtFrequency.Text = _prescritin.Frequency.ToString();
                txtMedicationName.Text = _prescritin.MedicationName.ToString();
            }
            else
            {
                MessageBox.Show("Prescreption object is null Cannot load info","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                
            }
        }
        private void txtMedicationName_Validating(object sender, CancelEventArgs e)
        {
            var txt = sender as Guna2TextBox;
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txt,"This field cannot be blank !");
            }
            else
            {
                e.Cancel = false;
                
            }
        }
        private void frmAddEditPrescription_Load(object sender, EventArgs e)
        {
            setUI();
            txtMedicationName.Focus();
            dtpEndDate.MinDate = dtpStartDate.MinDate = DateTime.Now;
            if (_Mode == enFormMode.eAddNew)
            {
                lblMedicalRecordID.Text = _medicalRecordID.ToString();
                _prescritin = new clsPrescription();
            }
            else
            {
                _LoadData();
            }
        }
        private void setUI()
        {
            string txt;
            if (_Mode == enFormMode.eAddNew)
            {
                txt = "Add New Prescription";
            }
            else
            {
                txt = "Update Prescription";
            }
            Text = txt;
            lblTitle.Text = txt;    
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Fill all needed boxes", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            _prescritin.MedicalRecordID = _medicalRecordID;
            _prescritin.MedicationName = txtMedicationName.Text.Trim();
            _prescritin.Dosage = txtDosage.Text.Trim();
            _prescritin.Frequency = txtFrequency.Text.Trim();
            _prescritin.SpecialInstructions = txtAdditionalNotes.Text.Trim();   
            _prescritin.StartDate = dtpStartDate.Value;
            _prescritin.EndDate = dtpEndDate.Value;

            if (_prescritin.Save())
            {
                lblPrescriptionID.Text = _prescritin.PrescriptionID.ToString();

                MessageBox.Show("Prescription saved successfully !","Data Saved",MessageBoxButtons.OK, MessageBoxIcon.Information);
                OnDataSaved?.Invoke();
            }
            else
            {
                MessageBox.Show("Prescription not saved !", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
