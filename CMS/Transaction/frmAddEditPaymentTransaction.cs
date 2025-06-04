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
    public partial class frmAddEditPaymentTransaction : Form
    {
        enum eFormMode { eAddNew = 0, eUpdate = 1 }
        eFormMode _Mode;

        int _paymentID;
        int _transactionID;
        clsPaymentTransaction _transaction;
        public frmAddEditPaymentTransaction(int paymentID)
        {
            InitializeComponent();
            _paymentID = paymentID;
            _Mode = eFormMode.eAddNew;
        }
        public frmAddEditPaymentTransaction(int paymentID,int transactionID)
        {
            InitializeComponent();
            _paymentID = paymentID;
            _transactionID = transactionID;
            _Mode = eFormMode.eAddNew;
        }
         
        private void _LoadPaymentData()
        {
            ucPaymentCard1.LoadPaymentInfoByPaymentID( _paymentID );
            ucPaymentCard1.HideTransactionLink();
        }
        private void _LoadTransactionInfo()
        {
            _transaction = clsPaymentTransaction.Find(_transactionID);

            if( _transaction != null )
            {
                lblTransactionID.Text = _transaction.PaymentTransactionID.ToString();
                udAmount.Value = (decimal)_transaction.Amount;
                cbPaymentMethod.SelectedText = _transaction.PaymentMethod;
                cbPaymentType.SelectedIndex = (int)_transaction.PaymentType - 1;
            }
            else
            {
                MessageBox.Show("Cannot load Payment transaction info.", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error); 
            }
        }   
        private void _ShowFormUI() 
        {
            string title = "";
            title = _Mode == eFormMode.eUpdate ? "Update Payment Transaction Info"
                : "Add New Payment Transaction";

            this.Text = title;
            lblTitle.Text = title;
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void frmAddEditPaymentTransaction_Load(object sender, EventArgs e)
        {
            _ShowFormUI();
            _LoadPaymentData();

            cbPaymentMethod.SelectedIndex = 0;
            cbPaymentType.SelectedIndex = 0;


            if(ucPaymentCard1.PaymentInfo == null)
            {
                btnSave.Enabled = false;    
            }
            if(_Mode == eFormMode.eUpdate)
            {
                _LoadTransactionInfo();
            }
            else
            {
                _transaction = new clsPaymentTransaction();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _transaction.PaymentTransactionID = _paymentID;
            _transaction.PaymentDate = DateTime.Now;
            _transaction.PaymentMethod = cbPaymentMethod.SelectedText;
            _transaction.PaymentType = (clsPaymentTransaction.enPaymentType)(cbPaymentType.SelectedIndex + 1);
            // check if the amount exeeded
            _transaction.Amount = (double)udAmount.Value;

            if (_transaction.Save())
            {
                lblTransactionID.Text = _transaction.PaymentTransactionID.ToString();
                // event
            }
            else 
            {
                MessageBox.Show("Cannot save Payment transaction.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
