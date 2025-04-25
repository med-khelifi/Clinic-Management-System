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
            dgvPatients.DataSource = clsDoctor.GetAllDoctorsTable();
            lbRecordCount.Text = "#Count = " + dgvPatients.Rows.Count;
        }
        private void ctrManagePatiants_Load(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
