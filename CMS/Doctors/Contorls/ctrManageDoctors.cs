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

namespace CMS.Doctors.Controls
{
    public partial class ctrManageDoctors : UserControl
    {
        public ctrManageDoctors()
        {
            InitializeComponent();
        }
        public void RefreshData()
        {
            dgvDoctors.DataSource = clsDoctor.GetAllDoctorsTable();
            lbRecordCount.Text = "#Count = " + dgvDoctors.Rows.Count;
        }
        private void ctrManageDoctors_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            using(frmAddEditUser frm = new frmAddEditUser(true))
            {

                frm.OnUserSaved += () =>
                {
                    RefreshData();
                };
                frm.ShowDialog();
                
            }
        }

        private void cmsIUpdate_Click(object sender, EventArgs e)
        {
            using (frmAddEditUser frm = new frmAddEditUser(dgvDoctors.CurrentRow.Cells[1].Value.ToString(),true))
            {
                frm.OnUserSaved += () =>
                {
                    RefreshData();
                };
                frm.ShowDialog();
                
            }
        }

        private void cmsIShowDetails_Click(object sender, EventArgs e)
        {
            using(frmDoctorInfo frm = new frmDoctorInfo(dgvDoctors.CurrentRow.Cells[1].Value.ToString()))
            {
                frm.ShowDialog();
            }
        }
    }
}
