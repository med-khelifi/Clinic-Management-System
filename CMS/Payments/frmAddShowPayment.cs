using BusinessLayer;
using CMS.Doctors.Contorls;
using CMS.Patients.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Payments
{
    public partial class frmAddShowPayment : Form
    {
        int _ID;
        enFormInfoMode _Mode;
        public delegate void OnPaymentSaved_Delegate();
        public OnPaymentSaved_Delegate OnPaymentSaved;
        public enum enFormInfoMode
        {
            eByPaymentID,
            eByAppointmentID,
        }
        public frmAddShowPayment(enFormInfoMode mode,int id)
        {
            InitializeComponent();
            _ID = id; 
            _Mode = mode;
        }
        void ShowFormUI()
        {
            string title;
            if (enFormInfoMode.eByAppointmentID == _Mode)
            {
                 title = "Add New Payment Record";

            }
            else 
            {
                title = "Payment Info";
                btnSave.Visible = false;
                BtnClose.Location = btnSave.Location;
            }
            this.Text = title;
            this.lblCaption.Text = title;
        }
        void ShowInfo()
        {
            if (_Mode == enFormInfoMode.eByAppointmentID)
            {
                ucPaymentCard1.LoadPaymentInfoByAppointmentID(_ID);
            }
            else
            {
                ucPaymentCard1.LoadPaymentInfoByPaymentID(_ID);
            }
        }
        private void frmAddShowPayment_Load(object sender, EventArgs e)
        {
            ShowFormUI();
            ShowInfo(); 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            clsPayment payment = ucPaymentCard1.GetPaymentInfo();
            if (payment is null)
            {
                MessageBox.Show("Payment info is null", "Null Object", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (payment.Save())
            {
                ucPaymentCard1.SetTheSavedPayment(payment);
                OnPaymentSaved?.Invoke();
                MessageBox.Show("Payment saved successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Payment not saved", "Done", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
