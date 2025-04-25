using DataLayer;
using System;
using System.Data;
namespace BusinessLayer
{
    public class clsAppointment
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int AppointmentID { get; set; }
        public int PatientID { get; set; }
        public int DoctorID { get; set; }
        public DateTime AppointmentDateTime { get; set; }
        public byte AppointmentStatus { get; set; }
        public int? MedicalRecordID { get; set; }
        public int? PaymentID { get; set; }

        public clsAppointment()
        {
            Mode = enMode.AddNew;
            AppointmentID = -1;
            PatientID = -1;
            DoctorID = -1;
            AppointmentDateTime = DateTime.Now;
            AppointmentStatus = 0;
            MedicalRecordID = null;
            PaymentID = null;
        }
        private clsAppointment(int AppointmentID, int PatientID, int DoctorID, DateTime AppointmentDateTime, byte AppointmentStatus, int? MedicalRecordID, int? PaymentID)
        {
            this.AppointmentID = AppointmentID;
            this.PatientID = PatientID;
            this.DoctorID = DoctorID;
            this.AppointmentDateTime = AppointmentDateTime;
            this.AppointmentStatus = AppointmentStatus;
            this.MedicalRecordID = MedicalRecordID;
            this.PaymentID = PaymentID;
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
            this.AppointmentID = clsAppointmentData.AddNew(this.PatientID, this.DoctorID, this.AppointmentDateTime, this.AppointmentStatus, this.MedicalRecordID, this.PaymentID);
             return this.AppointmentID != 0;
        }
        private bool _update()
        {
            return clsAppointmentData.Update(AppointmentID, PatientID, DoctorID, AppointmentDateTime, AppointmentStatus, MedicalRecordID, PaymentID);
        }
        public bool Delete()
        {
            return clsAppointmentData.Delete(this.AppointmentID);
        }
        public static DataTable GetAllAppointmentsTable()
        {
            return clsAppointmentData.GetAll();
        }
        public static clsAppointment Find(int AppointmentID)
        {
            int PatientID = -1;
            int DoctorID = -1;
            DateTime AppointmentDateTime = DateTime.Now;
            byte AppointmentStatus = 0;
            int? MedicalRecordID = null;
            int? PaymentID = null;
            if (clsAppointmentData.GetByID(AppointmentID, ref PatientID, ref DoctorID, ref AppointmentDateTime, ref AppointmentStatus, ref MedicalRecordID, ref PaymentID))
            {
                return new clsAppointment(AppointmentID, PatientID, DoctorID, AppointmentDateTime, AppointmentStatus, MedicalRecordID, PaymentID);
            }
            return null;
        }
    }
}
