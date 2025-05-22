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

namespace CMS.Appointments.Controls
{
    public partial class ucManageAppointments : UserControl
    {
        public ucManageAppointments()
        {
            InitializeComponent();
        }

        private void ucManageAppointments_Load(object sender, EventArgs e)
        {
            _LoadData();    
        }

        private void _LoadData()
        {
            dgvDoctors.Rows.Clear();
            dgvDoctors.DataSource = clsAppointment.GetAllAppointmentsTable();
            lbRecordCount.Text = "#Count = " + dgvDoctors.Rows.Count;   
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            using (frmAddEditAppointments frm = new frmAddEditAppointments())
            {
                frm.ShowDialog();
            }
        }
    }
}
