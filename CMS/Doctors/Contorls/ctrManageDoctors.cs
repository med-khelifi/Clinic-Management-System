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
    }
}
