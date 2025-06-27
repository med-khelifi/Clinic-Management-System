using BusinessLayer;
using CMS.Doctors;
using CMS.GlobalClasses;
using CMS.Patients;
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
    public partial class ucManageMedicalRecords : UserControl
    {
        clsMedicalRecord _MedicalRecord;
        public ucManageMedicalRecords()
        {
            InitializeComponent();
        }
        private void _LoadData()
        {
            if (clsGlobal.CurrentUser is clsDoctor doctor)
                dgvMedicalRecords.DataSource = clsMedicalRecord.GetAllMedicalRecordsTableByDoctorNationalNo(doctor.UserInfo.PersonInfo.NationalNo);
            else
                        dgvMedicalRecords.DataSource = clsMedicalRecord.GetAllMedicalRecordsTable();
            lbRecordCount.Text = "#Count = " + dgvMedicalRecords.Rows.Count;
        }
        private void ucManageMedicalRecords_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void toolStripMenuShowDetails_Click(object sender, EventArgs e)
        {
            int id = (int)dgvMedicalRecords.CurrentRow.Cells[0].Value;
            using (frmMedicalRecordInfo frm = new frmMedicalRecordInfo(id))
            {
                frm.ShowDialog();
            }
        }

        private void csmAppointments_Opening(object sender, CancelEventArgs e)
        {
            int id =(int)dgvMedicalRecords.CurrentRow.Cells[0].Value;
            _MedicalRecord = clsMedicalRecord.Find(id);
            if (_MedicalRecord != null && _MedicalRecord.HasPrescription())
            {
                PrescriptionToolStripMenuItem.Enabled = true; 
            }
            else
            {
                PrescriptionToolStripMenuItem.Enabled = false;
            }
        }

        private void doctorInformarionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmDoctorInfo frm = new frmDoctorInfo(_MedicalRecord.AppointmentInfo.DoctorInfo.UserInfo.PersonInfo.NationalNo))
            {
                frm.ShowDialog();
            }
        }

        private void patientInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmPatientInfo frm = new frmPatientInfo(_MedicalRecord.AppointmentInfo.PatientInfo.PersonInfo.NationalNo))
            {
                frm.ShowDialog();
            }
        }

        private void PrescriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmPrescriptionInfo frm = new frmPrescriptionInfo(_MedicalRecord.MedicalRecordID,frmPrescriptionInfo.enLoadInfoBy.eMedicalRecordID))
            {
                frm .ShowDialog();
            }
        }
    }
}
