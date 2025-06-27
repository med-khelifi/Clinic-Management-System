using BusinessLayer;
using CMS.Appointments;
using CMS.GlobalClasses;
using CMS.Payments;
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

namespace CMS.MediicalRecords.Controls
{
    public partial class ucMedicalRecordCard : UserControl
    {
        clsMedicalRecord _medicalRecord;
        public ucMedicalRecordCard()
        {
            InitializeComponent();
        }
        public void loadMedicalRecordInfo(int medicalRecordID)
        {
            _medicalRecord = clsMedicalRecord.Find(medicalRecordID);
            if (_medicalRecord != null)
            { 
                lblMedicalRecordID.Text= _medicalRecord.MedicalRecordID.ToString();
                lblVisitDiscription.Text = _medicalRecord.VisitDescription.ToString();
                lblDiagnosis.Text = string.IsNullOrEmpty(_medicalRecord.Diagnosis) ? "Not available" : _medicalRecord.Diagnosis;
                lblAdditionalNotes.Text  = string.IsNullOrEmpty(_medicalRecord.AdditionalNotes) ? "Not available" :_medicalRecord.AdditionalNotes;
                llAppointmentInfo.Enabled = true;

                CheckUser();
            }
            else
            {
                llAddPrescription.Visible = !true;
                llAppointmentInfo.Visible = !true;
                llEdit.Visible = !true;
                llShowPrescriptionInfo.Visible = !true;
                ResetInfo();
                MessageBox.Show("Cannot Load Medical Record Information !","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        public void ResetInfo()
        {
            lblMedicalRecordID.Text = "N/A";
            lblVisitDiscription.Text = "-";
            lblDiagnosis.Text = "-";
            lblAdditionalNotes.Text = "-";
            llAppointmentInfo.Enabled = false;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (frmAppointmentInfo frm = new frmAppointmentInfo(_medicalRecord.AppointmentID))
            {
                frm.ShowDialog();
            }
        }

        private void llEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (frmConsultation frm = new frmConsultation(_medicalRecord.AppointmentID,_medicalRecord.MedicalRecordID))
            {
                frm.ShowDialog();
            }
        }

        
        private void CheckUser()
        {
            bool isDoctor = clsGlobal.CurrentUser is clsDoctor;
            llEdit.Visible = isDoctor;
            if (isDoctor)
            {
                if (_medicalRecord != null && _medicalRecord.HasPrescription())
                {
                    llAddPrescription.Visible = false;
                    llShowPrescriptionInfo.Visible = true;
                }
                else
                {
                    llAddPrescription.Visible = true;
                    llShowPrescriptionInfo.Visible = false;
                }
            }
        }
        private void llAddPrescription_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (frmAddEditPrescription frm = new frmAddEditPrescription(_medicalRecord.MedicalRecordID))
            {
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
