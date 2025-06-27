using BusinessLayer;
using CMS.GlobalClasses;
using CMS.MediicalRecords;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Prescription.Controls
{
    public partial class ucPrescriptionCard : UserControl
    {
        clsPrescription _prescription;
        public ucPrescriptionCard()
        {
            InitializeComponent();
        }

       public void LoadPrescriptionData(int prescriptionID)
       {
            _prescription = clsPrescription.Find(prescriptionID);
            if (_prescription == null) 
            { 
                lblPrescriptionID.Text = _prescription.PrescriptionID.ToString();
                lblMedicalRecordID.Text = _prescription.MedicalRecordID.ToString();

                lblMedicationName.Text = _prescription.MedicationName.ToString();   

                lblDosage.Text = _prescription.Dosage.ToString();
                lblFrequency.Text = _prescription.Frequency.ToString();
                lblStartDate.Text = _prescription.StartDate.ToString();
                lblEndDate.Text = _prescription.EndDate.ToString();

                lblSpecialInstruction.Text = string.IsNullOrEmpty(_prescription.SpecialInstructions) ? "Not availabele" : _prescription.SpecialInstructions;
            }
            else
            {
                llEditPrescrition.Visible = false;
                llMedicalRecordInfo.Visible = false;    
                _ResetInfo();
                MessageBox.Show("Prescription is null !","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
       }
        public void LoadPrescriptionData(clsPrescription prescription)
        {
            _prescription = prescription;
            if (_prescription != null)
            {
                lblPrescriptionID.Text = _prescription.PrescriptionID.ToString();
                lblMedicalRecordID.Text = _prescription.MedicalRecordID.ToString();

                lblMedicationName.Text = _prescription.MedicationName.ToString();

                lblDosage.Text = _prescription.Dosage.ToString();
                lblFrequency.Text = _prescription.Frequency.ToString();
                lblStartDate.Text = _prescription.StartDate.ToString();
                lblEndDate.Text = _prescription.EndDate.ToString();

                lblSpecialInstruction.Text = string.IsNullOrEmpty(_prescription.SpecialInstructions) ? "Not availabele" : _prescription.SpecialInstructions;
            }
            else
            {
                llEditPrescrition.Visible = false;
                llMedicalRecordInfo.Visible = false;
                _ResetInfo();
                MessageBox.Show("Prescription is null !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void _ResetInfo()
        {
            lblPrescriptionID.Text = "N/A";
            lblMedicalRecordID.Text = "-";

            lblMedicationName.Text = "-";

            lblDosage.Text = "-";
            lblFrequency.Text = "-";
            lblStartDate.Text = "-";
            lblEndDate.Text = "-";

            lblSpecialInstruction.Text = "-";
        }

        private void ucPrescriptionCard_Load(object sender, EventArgs e)
        {
            if(clsGlobal.CurrentUser is clsDoctor)
            {

            }
        }

        private void llEditPrescrition_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (frmAddEditPrescription frm = new frmAddEditPrescription(_prescription.MedicalRecordID,_prescription.PrescriptionID))
            {
                frm.OnDataSaved += () =>
                {
                    LoadPrescriptionData(_prescription.PrescriptionID);
                };
                frm.ShowDialog();
            }
        }

        private void llMedicalRecordInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (frmMedicalRecordInfo frm = new frmMedicalRecordInfo(_prescription.MedicalRecordID))
            {
                frm.ShowDialog();
            }
        }
    }
}
