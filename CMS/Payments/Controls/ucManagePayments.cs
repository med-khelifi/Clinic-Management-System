using BusinessLayer;
using CMS.Payments;
using CMS.Transaction;
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

        private void cmsIShowDetails_Click(object sender, EventArgs e)
        {
            var id = (int)dgvPayments.CurrentRow.Cells[0].Value;
            var mode = frmAddShowPayment.enFormInfoMode.eByPaymentID;
            using (frmAddShowPayment frm = new frmAddShowPayment(mode,id))
            {
                frm.ShowDialog();
            }
        }

        private void cmsIUpdate_Click(object sender, EventArgs e)
        {
            var id = (int)dgvPayments.CurrentRow.Cells[0].Value;
            using (frmTransactionList frm = new frmTransactionList(id))
            {
                frm.ShowDialog();
            }
        }
    }
}
