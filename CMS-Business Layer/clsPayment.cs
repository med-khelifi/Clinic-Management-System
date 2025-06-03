using DataLayer;
using System;
using System.Data;
namespace BusinessLayer
{
    public class clsPayment
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int PaymentID { get; set; }
        public double TotalAmount { get; set; }
        public double AmountPaid { get; set; }
        public bool isFullyPaid { get; set; }
        public int AppointmentID { get; set; }
        public clsAppointment AppointmentInfo { get; set; }
        public clsPayment()
        {
            Mode = enMode.AddNew;
            PaymentID = -1;
            TotalAmount = 0;
            AmountPaid = 0;
            isFullyPaid = false;
            AppointmentID = -1;
            AppointmentInfo = new clsAppointment();
        }
        private clsPayment(int PaymentID, double TotalAmount, double AmountPaid, bool isFullyPaid, int AppointmentID)
        {
            this.PaymentID = PaymentID;
            this.TotalAmount = TotalAmount;
            this.AmountPaid = AmountPaid;
            this.isFullyPaid = isFullyPaid;
            this.AppointmentID = AppointmentID;
            AppointmentInfo = clsAppointment.Find(AppointmentID);
            Mode = enMode.Update;
        }
        public bool Save()
        {
            bool success = false;
            if (Mode == enMode.AddNew)
            {
                success = _addnew();
                if (success)
                {
                    Mode = enMode.Update;
                }
            }
            else if (Mode == enMode.Update)
            {
                success = _update();
            }
            return success;
        }
        private bool _addnew()
        {
            this.PaymentID = clsPaymentData.AddNew(this.TotalAmount, this.AmountPaid, this.isFullyPaid, this.AppointmentID);
             return this.PaymentID != 0;
        }
        private bool _update()
        {
            return clsPaymentData.Update(PaymentID, TotalAmount, AmountPaid, isFullyPaid, AppointmentID);
        }
        public bool Delete()
        {
            return clsPaymentData.Delete(this.PaymentID);
        }
        public static DataTable GetAllPaymentsTable()
        {
            return clsPaymentData.GetAll();
        }
        public static clsPayment Find(int PaymentID)
        {
            double TotalAmount = 0;
            double AmountPaid = 0;
            bool isFullyPaid = false;
            int AppointmentID = -1;
            if (clsPaymentData.GetByID(PaymentID, ref TotalAmount, ref AmountPaid, ref isFullyPaid, ref AppointmentID))
            {
                return new clsPayment(PaymentID, TotalAmount, AmountPaid, isFullyPaid, AppointmentID);
            }
            return null;
        }
    }
}
