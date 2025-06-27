using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.MediicalRecords
{
    public partial class frmMedicalRecordInfo : Form
    {
        int _medicalRecordID;
        public frmMedicalRecordInfo(int medicalRecordID)
        {
            InitializeComponent();
            _medicalRecordID = medicalRecordID;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmMedicalRecordInfo_Load(object sender, EventArgs e)
        {
            ucMedicalRecordCard1.loadMedicalRecordInfo(_medicalRecordID);
        }
    }
}
