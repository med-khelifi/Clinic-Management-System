using BusinessLayer;
using CMS.GlobalClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Dashboard
{
    public partial class ucDashbord : UserControl
    {
        public ucDashbord()
        {
            InitializeComponent();
        }

        private void ucDashbord_Load(object sender, EventArgs e)
        {
            if (clsGlobal.CurrentUser is clsUser)
            {
                lbl01.Text = "Users";
                lbl02.Text = "Doctors";
                lblDoctors_or_MedicalRecordsCount.Text = clsDoctor.GetDoctorsCount().ToString();
                lblUsers_or_PatientsCount.Text = clsUser.GetUsersCount().ToString();
                lblAppointmentsCount.Text = clsAppointment.GetAppointmentsCount().ToString();
                dgvGroupsList.DataSource = clsAppointment.GetAppointmentsByDate(DateTime.Now);
                lblDgvCount.Text = dgvGroupsList.RowCount.ToString();
            }
            if (clsGlobal.CurrentUser is clsDoctor d)
            {
                lbl01.Text = "Patients";
                lbl02.Text = "Records";
                lblDoctors_or_MedicalRecordsCount.Text = d.GetMedicalRecordsCount().ToString();
                lblUsers_or_PatientsCount.Text = d.GetPatientsCount().ToString();
                lblAppointmentsCount.Text = clsAppointment.GetAllAppointmentsTableByDoctorID(d.DoctorID).Rows.Count.ToString();
                dgvGroupsList.DataSource = clsAppointment.GetAllAppointmentsTableByDoctorIDAndDate(d.DoctorID,DateTime.Now);
                lblDgvCount.Text = dgvGroupsList.RowCount.ToString();
            }
        }
    }
}
