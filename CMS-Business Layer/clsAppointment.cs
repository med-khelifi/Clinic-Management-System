using DataLayer;
using System;
using System.Data;
namespace BusinessLayer
{
    public class clsAppointment
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public enum enAppointmentStatus
        {
            NotConfirmed = 0,
            Scheduled = 1,
            Completed = 2, 
            Cancelled = 3,
            NoShow = 4, 
            Rescheduled = 5, 
            FollowUpNeeded = 6
        }

        public int AppointmentID { get; set; }
        public int PatientID { get; set; }
        public clsPatient PatientInfo { get; set; }
        public int DoctorID { get; set; }
        public clsDoctor DoctorInfo { get; set; }   
        public DateTime AppointmentDateTime { get; set; }
        public enAppointmentStatus AppointmentStatus { get; set; }
        public int? MedicalRecordID { get; set; }
        public clsMedicalRecord MedicalRecordInfo { get; set; }

        public clsAppointment()
        {
            Mode = enMode.AddNew;
            AppointmentID = -1;
            PatientID = -1;
            PatientInfo = new clsPatient();
            DoctorID = -1;
            DoctorInfo = new clsDoctor();
            AppointmentDateTime = DateTime.Now;
            AppointmentStatus = 0;
            MedicalRecordID = null;
            MedicalRecordInfo = new clsMedicalRecord();
        }
        private clsAppointment(int AppointmentID, int PatientID, int DoctorID, DateTime AppointmentDateTime, enAppointmentStatus AppointmentStatus, int? MedicalRecordID)
        {
            this.AppointmentID = AppointmentID;
            this.PatientID = PatientID;
            this.PatientInfo = clsPatient.Find(PatientID);
            this.DoctorID = DoctorID;
            DoctorInfo = clsDoctor.Find(DoctorID);
            this.AppointmentDateTime = AppointmentDateTime;
            this.AppointmentStatus = AppointmentStatus;
            this.MedicalRecordID = MedicalRecordID;
            MedicalRecordInfo = MedicalRecordID.HasValue ? clsMedicalRecord.Find(MedicalRecordID.Value) : null;
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
            this.AppointmentID = clsAppointmentData.AddNew(this.PatientID, this.DoctorID, this.AppointmentDateTime, (byte)this.AppointmentStatus, this.MedicalRecordID);
             return this.AppointmentID != 0;
        }
        private bool _update()
        {
            return clsAppointmentData.Update(AppointmentID, PatientID, DoctorID, AppointmentDateTime,(byte) AppointmentStatus, MedicalRecordID);
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
            if (clsAppointmentData.GetByID(AppointmentID, ref PatientID, ref DoctorID, ref AppointmentDateTime, ref AppointmentStatus, ref MedicalRecordID))
            {
                return new clsAppointment(AppointmentID, PatientID, DoctorID, AppointmentDateTime, (enAppointmentStatus)AppointmentStatus, MedicalRecordID);
            }
            return null;
        }
        public string GetStatusString()
        {
            switch (AppointmentStatus)
            {
                case enAppointmentStatus.NotConfirmed: return "Not Confirmed";
                case enAppointmentStatus.Scheduled: return "Scheduled";
                case enAppointmentStatus.Completed: return "Completed";
                case enAppointmentStatus.Cancelled: return "Cancelled";
                case enAppointmentStatus.NoShow: return "Not Shown";
                case enAppointmentStatus.Rescheduled: return "Rescheduled";
                case enAppointmentStatus.FollowUpNeeded: return "Follow Up Needed";
                
                default: return "Unknown";
            }
        }
        public static enAppointmentStatus? GetAppointmentStatus(int appointmentID)
        {
            var res = clsAppointmentData.GetAppointmentStatus(appointmentID);
            if (res == -1) return null;
            return (enAppointmentStatus)res;
        }
        public static bool ChangeAppointmentStatus(int appointmentID,enAppointmentStatus newStatus)
        {
            return clsAppointmentData.ChangeStatus(appointmentID,(byte)newStatus);
        } 
        public bool ChangeStatus(enAppointmentStatus newStatus)
        {
            return ChangeAppointmentStatus(this.AppointmentID,newStatus);
        }
        public static bool CancelAppointment(int appointmentID)
        {
            return clsAppointmentData.ChangeStatus(appointmentID, (byte)enAppointmentStatus.Cancelled);
        }
        public bool Cancel()
        {
            return CancelAppointment(AppointmentID);
        }
       
    }
}
