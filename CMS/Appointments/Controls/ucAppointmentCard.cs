using BusinessLayer;
using CMS.Doctors;
using CMS.Patients;
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
    public partial class ucAppointmentCard : UserControl
    {
        clsAppointment _appointment;
        public ucAppointmentCard()
        {
            InitializeComponent();
        }

        public void LoadAppointmentInfo(int appointmentID)
        {
            _appointment = clsAppointment.Find(appointmentID);
            if(_appointment == null)
            {
                _HideLinkLabels();
                MessageBox.Show("Cannot Load Appointment Info.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                _LoadAppointmentInfo();
            }
        }
        public void LoadAppointmentInfo(clsAppointment appointment)
        {
            _appointment = appointment;
            if (_appointment == null)
            {
                _HideLinkLabels();
                MessageBox.Show("Cannot Load Appointment Info.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _LoadAppointmentInfo();
            }
        }

        private void _LoadAppointmentInfo()
        {
            lblAppointmentID.Text = _appointment.AppointmentID.ToString();
            lblAppointmentStatus.Text = _appointment.GetStatusString();

            lblPatientFullName.Text = _appointment.PatientInfo.PersonInfo.Name ?? "unkown";
            lblPatientNationalNo.Text = _appointment.PatientInfo.PersonInfo?.NationalNo ?? "unkown";

            lblDoctorFullName.Text = _appointment.DoctorInfo.UserInfo.PersonInfo.Name ?? "unkown";
            lblDoctorNationalNo.Text = _appointment.DoctorInfo.UserInfo.PersonInfo.NationalNo ?? "unkown";
            
            lblAppointmentDate.Text = _appointment.AppointmentDateTime.ToString();
        }
        private void _HideLinkLabels()
        {
            llDoctorInfo.Visible = false;
            llPatientInfo.Visible = false;  
        }

        private void llDoctorInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (frmDoctorInfo frm = new frmDoctorInfo(_appointment.DoctorInfo.UserInfo.Username))
            {
                frm.ShowDialog();
            }
        }

        private void llPatientInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (frmPatientInfo frm = new frmPatientInfo(_appointment.PatientInfo.PersonInfo.NationalNo))
            {
                frm.ShowDialog();
            }
        }
    }
}
