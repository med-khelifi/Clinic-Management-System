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
        public DateTime PaymentDate { get; set; }
        public string PaymentMethod { get; set; }
        public decimal AmountPaid { get; set; }
        public string AdditionalNotes { get; set; }

        public clsPayment()
        {
            Mode = enMode.AddNew;
            PaymentID = -1;
            PaymentDate = DateTime.Now;
            PaymentMethod = null;
            AmountPaid = 0;
            AdditionalNotes = null;
        }
        private clsPayment(int PaymentID, DateTime PaymentDate, string PaymentMethod, decimal AmountPaid, string AdditionalNotes)
        {
            this.PaymentID = PaymentID;
            this.PaymentDate = PaymentDate;
            this.PaymentMethod = PaymentMethod;
            this.AmountPaid = AmountPaid;
            this.AdditionalNotes = AdditionalNotes;
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
            this.PaymentID = clsPaymentData.AddNew(this.PaymentDate, this.PaymentMethod, this.AmountPaid, this.AdditionalNotes);
             return this.PaymentID != 0;
        }
        private bool _update()
        {
            return clsPaymentData.Update(PaymentID, PaymentDate, PaymentMethod, AmountPaid, AdditionalNotes);
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
            DateTime PaymentDate = DateTime.Now;
            string PaymentMethod = null;
            decimal AmountPaid = 0;
            string AdditionalNotes = null;
            if (clsPaymentData.GetByID(PaymentID, ref PaymentDate, ref PaymentMethod, ref AmountPaid, ref AdditionalNotes))
            {
                return new clsPayment(PaymentID, PaymentDate, PaymentMethod, AmountPaid, AdditionalNotes);
            }
            return null;
        }
    }
}
