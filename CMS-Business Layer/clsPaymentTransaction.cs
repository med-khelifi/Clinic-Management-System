using DataLayer;
using System;
using System.Data;
namespace BusinessLayer
{
    public class clsPaymentTransaction
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public enum enPaymentType
        {
            Advance = 1,Remaining = 2,wholeAmount = 3
        }
        public enum enPaymentMethod
        {
            Cash,CreditCard
        }

        public int PaymentTransactionID { get; set; }
        public int PaymentID { get; set; }
        public double Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public int PaymentType { get; set; }
        public string PaymentMethod { get; set; }

        public clsPaymentTransaction()
        {
            Mode = enMode.AddNew;
            PaymentTransactionID = -1;
            PaymentID = -1;
            Amount = 0;
            PaymentDate = DateTime.Now;
            PaymentType = -1;
            PaymentMethod = "";
        }
        private clsPaymentTransaction(int PaymentTransactionID, int PaymentID, double Amount, DateTime PaymentDate, int PaymentType, string PaymentMethod)
        {
            this.PaymentTransactionID = PaymentTransactionID;
            this.PaymentID = PaymentID;
            this.Amount = Amount;
            this.PaymentDate = PaymentDate;
            this.PaymentType = PaymentType;
            this.PaymentMethod = PaymentMethod;
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
            this.PaymentTransactionID = clsPaymentTransactionData.AddNew(this.PaymentID, this.Amount, this.PaymentDate, this.PaymentType, this.PaymentMethod);
             return this.PaymentTransactionID != 0;
        }
        private bool _update()
        {
            return clsPaymentTransactionData.Update(PaymentTransactionID, PaymentID, Amount, PaymentDate, PaymentType, PaymentMethod);
        }
        public bool Delete()
        {
            return clsPaymentTransactionData.Delete(this.PaymentTransactionID);
        }
        public static DataTable GetAllPaymentTransactionsTable()
        {
            return clsPaymentTransactionData.GetAll();
        }
        public static clsPaymentTransaction Find(int PaymentTransactionID)
        {
            int PaymentID = -1;
            double Amount = 0;
            DateTime PaymentDate = DateTime.Now;
            int PaymentType = -1;
            string PaymentMethod = "";
            if (clsPaymentTransactionData.GetByID(PaymentTransactionID, ref PaymentID, ref Amount, ref PaymentDate, ref PaymentType, ref PaymentMethod))
            {
                return new clsPaymentTransaction(PaymentTransactionID, PaymentID, Amount, PaymentDate, PaymentType, PaymentMethod);
            }
            return null;
        }
    }
}
