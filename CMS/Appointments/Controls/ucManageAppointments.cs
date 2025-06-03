using BusinessLayer;
using CMS.Doctors;
using CMS.Patients;
using CMS.Payments;
using CMS.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
            //dgvAppointments.Rows.Clear();
            dgvAppointments.DataSource = clsAppointment.GetAllAppointmentsTable();
            lbRecordCount.Text = "#Count = " + dgvAppointments.Rows.Count;   
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            using (frmAddEditAppointments frm = new frmAddEditAppointments())
            {
                frm.onAppointmentSaved += _LoadData;
                frm.ShowDialog();
            }
        }

        private void doctorInformarionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var frm = new frmDoctorInfo(dgvAppointments.CurrentRow.Cells[4].Value.ToString()))
            {
                frm.ShowDialog();
            }
        }

        private void patientInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var frm = new frmPatientInfo(dgvAppointments.CurrentRow.Cells[2].Value.ToString()))
            {
                
                frm.ShowDialog();
            }
        }

        private void csmAppointments_Opening(object sender, CancelEventArgs e)
        {
            var status = clsAppointment.GetAppointmentStatus((int)dgvAppointments.CurrentRow.Cells[0].Value);

            // First, disable both actions for Cancelled or Completed status
            if (status == clsAppointment.enAppointmentStatus.Cancelled ||
                status == clsAppointment.enAppointmentStatus.Completed)
            {
                toolStripMenuCancel.Enabled = false;
                toolStripMenuReschedule.Enabled = false;
                ToolStripMenuConfirm.Enabled = false;
            }
            else if (status == clsAppointment.enAppointmentStatus.NotConfirmed)
            {
                toolStripMenuCancel.Enabled = true;
                toolStripMenuReschedule.Enabled = false;
                ToolStripMenuConfirm.Enabled = true;
            }
            else if (status == clsAppointment.enAppointmentStatus.Scheduled)
            {
                toolStripMenuCancel.Enabled = true;
                toolStripMenuReschedule.Enabled = true;
                ToolStripMenuConfirm.Enabled = false;
            }
            else if(status == clsAppointment.enAppointmentStatus.NoShow)
            {
                toolStripMenuCancel.Enabled = false;
                toolStripMenuReschedule.Enabled = true;
            }
            else
            {
                toolStripMenuCancel.Enabled = true;
                toolStripMenuReschedule.Enabled = true;
            }
        }


        private void toolStripMenuReschedule_Click(object sender, EventArgs e)
        {
            using (frmAddEditAppointments frm = new frmAddEditAppointments((int)dgvAppointments.CurrentRow.Cells[0].Value))
            {
                frm.onAppointmentSaved += _LoadData;
                frm.ShowDialog();
            }
        }

        private void toolStripMenuCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel this appointment", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsAppointment.CancelAppointment((int)dgvAppointments.CurrentRow.Cells[0].Value))
                {
                    _LoadData();
                    MessageBox.Show("Appointment was cancelled successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cancelling the appointment faild", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void toolStripMenuShowDetails_Click(object sender, EventArgs e)
        {
            using (frmAppointmentInfo frm = new frmAppointmentInfo((int)dgvAppointments.CurrentRow.Cells[0].Value))
            {
                frm.ShowDialog();
            }
        }

        private void ToolStripMenuConfirm_Click(object sender, EventArgs e)
        {
            var mode = frmAddShowPayment.enFormInfoMode.eByAppointmentID;
            int id = (int)dgvAppointments.CurrentRow.Cells[0].Value;
            using (frmAddShowPayment frm = new frmAddShowPayment(mode,id ))
            {
                frm.OnPaymentSaved += _LoadData;
                frm.ShowDialog();
            }
        }
    }
}
