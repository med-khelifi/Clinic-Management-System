using BusinessLayer;
using CMS.Appointments;
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
    public partial class ucPaymentCard : UserControl
    {
        clsPayment _payment;
        clsAppointment _appointment;
        public clsPayment PaymentInfo
        {
            get
            {
                return _payment;
            }
        }
        public ucPaymentCard()
        {
            InitializeComponent();
        }
        public  void LoadPaymentInfoByPaymentID(int paymentID)
        {
            _payment = clsPayment.Find(paymentID);  
            if( _payment != null)
            {
                _loadPaymentInfo();
                llAppointmentInfo.Visible = true;
            }
            else
            {  
                llAppointmentInfo.Visible = false; 
                MessageBox.Show("Cannot Load Payment Info.", "Null Object", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void LoadPaymentInfoByPaymentObj(clsPayment payment)
        {
            _payment = payment;
            if (_payment != null)
            {
                _loadPaymentInfo();
                llAppointmentInfo.Visible = true;
            }
            else
            {
                llAppointmentInfo.Visible = false;
                MessageBox.Show("Cannot Load Payment Info.", "Null Object", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void _loadPaymentInfo()
        {
            lblAppointmentID.Text = _payment.AppointmentID.ToString();
            lblPaymentID.Text = _payment.PaymentID.ToString();  
            lblPaidAmount.Text = _payment.AmountPaid.ToString();
            lblTotalAmount.Text = _payment.TotalAmount.ToString();
            lblisFullyPaid.Text = _payment.isFullyPaid ? "Yes" : "No";
        }
        private void _loadPaymentInfoByAppointment()
        {
            lblAppointmentID.Text = _appointment.AppointmentID.ToString();
            lblPaymentID.Text = "N/A";
            lblTotalAmount.Text = _appointment.DoctorInfo.BasePrice.ToString();
            lblPaidAmount.Text = "0";
            lblisFullyPaid.Text = "No";
        }
        private void llAppointmentInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int id =  _appointment is null ? _appointment.AppointmentID : _appointment.AppointmentID;
            using (frmAppointmentInfo frm = new frmAppointmentInfo(id))
            {
                frm.ShowDialog();
            }
        }   
        public void LoadPaymentInfoByAppointmentID(int appointmentID)
        {
            _appointment = clsAppointment.Find(appointmentID);
            llTransactionList.Visible = false;
            if (_appointment != null)
            {
                _loadPaymentInfoByAppointment();
                llAppointmentInfo.Visible = true;
            }
            else
            {
                llAppointmentInfo.Visible = false;
                MessageBox.Show("Cannot Load Appointment Info.", "Null Object", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void LoadPaymentInfoByAppointmentObj(clsAppointment appointment)
        {
            _appointment = appointment;
            llTransactionList.Visible = false;
            if (_appointment != null)
            {
                _loadPaymentInfoByAppointment();
                llAppointmentInfo.Visible = true;
            }
            else
            {
                llAppointmentInfo.Visible = false;
                MessageBox.Show("Cannot Load Appointment Info.", "Null Object", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void SetTheSavedPayment(clsPayment payment)
        {
            if (payment == null)
            {
                MessageBox.Show("Cannot Load Appointment Info.", "Null Object", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _payment = payment; 
            lblPaymentID.Text = payment.PaymentID.ToString();
            llTransactionList.Visible = true;
        }
        public void ResetInfo()
        {
            lblAppointmentID.Text = "-";
            lblPaymentID.Text = "-";
            lblPaidAmount.Text = "-";
            lblTotalAmount.Text = "-";
            lblisFullyPaid.Text = "-";
        }

        public clsPayment GetPaymentInfo()
        {
            var payment = new clsPayment();
            payment.AppointmentID = _appointment.AppointmentID;
            payment.TotalAmount = _appointment.DoctorInfo.BasePrice;
            payment.AmountPaid = 0;
            payment.isFullyPaid = false;

            return payment;
        }

        private void llTransactionList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
