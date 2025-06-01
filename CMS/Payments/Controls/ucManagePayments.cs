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

namespace CMS.Patients
{
    public partial class ucManagePayments : UserControl
    {
        public ucManagePayments()
        {
            InitializeComponent();
        }
        private void _LoadData()
        {
            dgvPayments.DataSource = clsPayment.GetAllPaymentsTable();
            lbRecordCount.Text = "#Count = " + dgvPayments.Rows.Count;
        }
        private void ucManagePayments_Load(object sender, EventArgs e)
        {
            _LoadData();    
        }
    }
}
