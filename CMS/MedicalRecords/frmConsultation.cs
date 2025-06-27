using BusinessLayer;
using CMS.Prescription;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Appointments
{
    public partial class frmConsultation : Form
    {
        clsMedicalRecord _medicalRecord;
        int _medicalRecordID;
        int _appointmentID;
        enum enFormMode
        {
            eAddNew,
            eUpdate
        }
        enFormMode _FormMode;
        public frmConsultation(int appointmentID)
        {
            InitializeComponent();
            _FormMode = enFormMode.eAddNew;
            _appointmentID = appointmentID;
        }
        public frmConsultation(int appointmentID,int medicalRecordID)
        {
            InitializeComponent();
            _medicalRecordID = medicalRecordID;
            _appointmentID = appointmentID;
            _FormMode = enFormMode.eUpdate;
        }
        void _SetFormLayout()
        {
            string text = _FormMode == enFormMode.eAddNew ? "Add new Medical Record" : "Update Medical Record";
            lblTitle.Text = text;
            this.Text = text;
        }
        void _LoadMedicalRecordInfo()
        {
            _medicalRecord = clsMedicalRecord.Find(_medicalRecordID);
            if (_medicalRecord == null)
            {
                MessageBox.Show("Cannot Load Medical Record info Due it is null");
                btnSave.Enabled = false;
            }
            else
            {
                lblMedicalRecordID.Text = _medicalRecord.MedicalRecordID.ToString();
                txtAddtionalNotes.Text = _medicalRecord.AdditionalNotes;
                txtDiagnosis.Text = _medicalRecord.Diagnosis;
                txtVisitDescription.Text = _medicalRecord.VisitDescription;
            }
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtVisitDescription.Text))
            {
                MessageBox.Show("Visit Descrition Cannot Be Empty !","Cannot be empty",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            _medicalRecord.VisitDescription = txtVisitDescription.Text;
            _medicalRecord.Diagnosis = txtDiagnosis.Text;
            _medicalRecord.AdditionalNotes = txtAddtionalNotes.Text;
            _medicalRecord.AppointmentID = _appointmentID;

            if (_medicalRecord.Save())
            {
                llAddPrescription.Visible = true;
                lblMedicalRecordID.Text = _medicalRecord.ToString();
                MessageBox.Show("Medical Record saved successfuly!","Saved",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Medical Record Not Saved!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        void ValidateLinkLabels()
        {
            if (_medicalRecord != null && _medicalRecord.HasPrescription())
            {
                llShowPrescriptionInfo.Visible = true;
                llAddPrescription.Visible = false;
            }
            else
            {
                llShowPrescriptionInfo.Visible = false;
                llAddPrescription.Visible = true;
            }
        }
        private void frmConsultation_Load(object sender, EventArgs e)
        {
            
            _SetFormLayout();
            ucAppointmentCard1.LoadAppointmentInfo(_appointmentID);
            if (_FormMode == enFormMode.eAddNew)
            {
                _medicalRecord = new clsMedicalRecord();   
            }
            else
            {
                _LoadMedicalRecordInfo();

                ValidateLinkLabels();
            }
        }

        private void llAddPrescription_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (frmAddEditPrescription frm = new frmAddEditPrescription(_medicalRecord.MedicalRecordID))
            {
                frm.OnDataSaved += ValidateLinkLabels;
                frm.ShowDialog();
            }
        }

        private void llShowPrescriptionInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (frmPrescriptionInfo frm = new frmPrescriptionInfo(_medicalRecord.MedicalRecordID,frmPrescriptionInfo.enLoadInfoBy.eMedicalRecordID))
            {
                frm.ShowDialog();
            }
        }
    }
}
