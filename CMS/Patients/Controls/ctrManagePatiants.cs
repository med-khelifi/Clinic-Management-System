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
    public partial class ctrManagePatiants : UserControl
    {
        public ctrManagePatiants()
        {
            InitializeComponent();
        }
        public void RefreshData()
        {
            dgvPatients.DataSource = clsPatient.GetAllPatientsTable();
            lbRecordCount.Text = "#Count = " + dgvPatients.Rows.Count;
        }
        private void ctrManagePatiants_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            using (frmAddEditPatient frm = new frmAddEditPatient())
            {
                frm.OnPatientSaved += () =>
                {
                    RefreshData();
                };
                frm.ShowDialog();
            }
        }

        private void cmsIUpdate_Click(object sender, EventArgs e)
        {
            using (frmAddEditPatient frm = new frmAddEditPatient(dgvPatients.CurrentRow.Cells[0].Value.ToString()))
            {
                frm.OnPatientSaved += () =>
                {
                    RefreshData();
                };
                frm.ShowDialog();
            }
        }

        private void cmsIShowDetails_Click(object sender, EventArgs e)
        {
            using (frmPatientInfo frm = new frmPatientInfo(dgvPatients.CurrentRow.Cells[0].Value.ToString()))
            {
                frm.ShowDialog();
            }
        }
    }
}
