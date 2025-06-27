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

namespace CMS.Prescription
{
    public partial class frmPrescriptionInfo : Form
    {
        public enum enLoadInfoBy
        {
            ePrescriptionID,eMedicalRecordID
        }
        enLoadInfoBy _LoadingMode;
        int ID;
        public frmPrescriptionInfo(int id, enLoadInfoBy Mode)
        {
            InitializeComponent();
            ID = id;
            _LoadingMode = Mode;
        }

        private void frmPrescriptionInfo_Load(object sender, EventArgs e)
        {
            if (_LoadingMode == enLoadInfoBy.ePrescriptionID)
                ucPrescriptionCard1.LoadPrescriptionData(ID);
            else
            {
                clsPrescription prescription = clsPrescription.FindByMedicalRecordID(ID);
                ucPrescriptionCard1.LoadPrescriptionData(prescription);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
