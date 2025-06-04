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

namespace CMS.Transaction
{
    public partial class frmTransactionList : Form
    {
        int _paymentID;
        public frmTransactionList(int paymentID)
        {
            InitializeComponent();
            _paymentID = paymentID;
        }
        private void _LoadPaymentInfo()
        {
            ucPaymentCard1.LoadPaymentInfoByPaymentID(_paymentID);
            ucPaymentCard1.HideTransactionLink();
        }
        private void _LoadTransactionInfo()
        {
            dgvTransactions.DataSource = clsPaymentTransaction.GetAllPaymentTransactionsTable();
            lbRecordCount.Text = "#Count = " + dgvTransactions.Rows.Count;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmTransactionList_Load(object sender, EventArgs e)
        {
            _LoadPaymentInfo();
            _LoadTransactionInfo();

            if(ucPaymentCard1.PaymentInfo == null) btnAddNewTransaction.Enabled = false;
        }

        private void btnAddNewTransaction_Click(object sender, EventArgs e)
        {
            using (frmAddEditPaymentTransaction frm = new frmAddEditPaymentTransaction(_paymentID))
            {
                frm.ShowDialog();
            }
        }
    }
}
