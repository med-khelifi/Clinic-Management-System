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
    public partial class frmAppointmentInfo : Form
    {
        int _appointmentID;
        public frmAppointmentInfo(int appointmentID)
        {
            InitializeComponent();
            _appointmentID = appointmentID;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAppointmentInfo_Load(object sender, EventArgs e)
        {
            ucAppointmentCard1.LoadAppointmentInfo(_appointmentID);
        }
    }
}
