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

namespace CMS.Appointments
{
    public partial class frmAddEditAppointments : Form
    {
        public delegate void onAppointmentSaved_Delegate();
        public onAppointmentSaved_Delegate onAppointmentSaved;

        int _appointmentID = 0_0;
        enum eFormMode
        {
            addNew,
            update
        }

        eFormMode _FormeMode;
        public frmAddEditAppointments(int appointmentID)
        {
            InitializeComponent();
            _appointmentID = appointmentID;
            _FormeMode = eFormMode.update;
        } 
        public frmAddEditAppointments()
        {
            InitializeComponent();
            _FormeMode = eFormMode.addNew;
        }


        clsAppointment _appointment;
       

        void _LoadInitialValues()
        {
            dtpAppointmentDate.MinDate = DateTime.Now;

            lblAppointmentID.Text = "N/A";
            string title = _FormeMode == eFormMode.update ? "Edit Appointment" : "Add New Appointment";
            lblTitle.Text = title ;
            Name = lblTitle.Text ;
        }

        private void frmAddEditAppointments_Load(object sender, EventArgs e)
        {
            _LoadInitialValues();
            if (_FormeMode == eFormMode.addNew)
            {
                _appointment = new clsAppointment();
            }
            else
            {
                _loadAppointmentInfo();
            }
        }

        void _loadAppointmentInfo()
        {
            _appointment = clsAppointment.Find(_appointmentID);

            if (_appointment != null)
            {
                lblAppointmentID.Text = _appointment.ToString();
                dtpAppointmentDate.Text = _appointment.AppointmentDateTime.ToString();
                ucFindDoctor1.LoadDoctorInfo(_appointment.DoctorID);
                ucFindPatient1.LoadPatientInfo(_appointment.PatientID);
                lblAppointmentStatus.Text = _appointment.GetStatusString();
            }
            else 
            {
                MessageBox.Show("Cannot Load Appointment Info.", "Null Object", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(ucFindDoctor1.DoctorInfo is null)
            {
                MessageBox.Show("Select doctor to continue !","Invalid Doctor",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if(ucFindPatient1.PatientInfo is null)
            {
                MessageBox.Show("Select patient to continue !","Invalid Patient",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            // check if patient == doctor

            _appointment.AppointmentDateTime = dtpAppointmentDate.Value;

            _appointment.AppointmentStatus = _FormeMode == eFormMode.update ? 
                clsAppointment.enAppointmentStatus.Rescheduled : 
                clsAppointment.enAppointmentStatus.NotConfirmed; ;
            _appointment.DoctorID = ucFindDoctor1.DoctorID;
            _appointment.PatientID = ucFindPatient1.PatientID;

            
            if (_appointment.Save())
            {
                lblAppointmentID.Text = _appointment.AppointmentID.ToString();
                MessageBox.Show("Appointment saved successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                onAppointmentSaved?.Invoke();
            }
            else
            {
                MessageBox.Show("Error data not saved", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucFindDoctor1_OnSearchButtonClicked(string nationalNo)
        {
            if (ucFindDoctor1.DoctorInfo != null) 
            { 
                lblTotalAmount.Text = (ucFindDoctor1.DoctorInfo.BasePrice).ToString() + " $";
            }
            else
            {
                lblTotalAmount.Text = "N/A $";
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
