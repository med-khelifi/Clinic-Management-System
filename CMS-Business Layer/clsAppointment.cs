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
            MedicalRecordInfo = new clsMedicalRecord();
        }
        private clsAppointment(int AppointmentID, int PatientID, int DoctorID, DateTime AppointmentDateTime, enAppointmentStatus AppointmentStatus)
        {
            this.AppointmentID = AppointmentID;
            this.PatientID = PatientID;
            this.PatientInfo = clsPatient.Find(PatientID);
            this.DoctorID = DoctorID;
            DoctorInfo = clsDoctor.Find(DoctorID);
            this.AppointmentDateTime = AppointmentDateTime;
            this.AppointmentStatus = AppointmentStatus;
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
            this.AppointmentID = clsAppointmentData.AddNew(this.PatientID, this.DoctorID, this.AppointmentDateTime, (byte)this.AppointmentStatus);
             return this.AppointmentID != 0;
        }
        private bool _update()
        {
            return clsAppointmentData.Update(AppointmentID, PatientID, DoctorID, AppointmentDateTime,(byte) AppointmentStatus);
        }
        public bool Delete()
        {
            return clsAppointmentData.Delete(this.AppointmentID);
        }
        public static DataTable GetAllAppointmentsTable()
        {
            return clsAppointmentData.GetAll();
        } 
        public static DataTable GetAllAppointmentsTableByDoctorID(int doctorID)
        {
            return clsAppointmentData.GetAll(doctorID);
        }
        public static clsAppointment Find(int AppointmentID)
        {
            int PatientID = -1;
            int DoctorID = -1;
            DateTime AppointmentDateTime = DateTime.Now;
            byte AppointmentStatus = 0;

            if (clsAppointmentData.GetByID(AppointmentID, ref PatientID, ref DoctorID, ref AppointmentDateTime, ref AppointmentStatus))
            {
                return new clsAppointment(AppointmentID, PatientID, DoctorID, AppointmentDateTime, (enAppointmentStatus)AppointmentStatus);
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
        public static int GetAppointmentsCount() 
        {
            return clsAppointmentData.GetAppointmentsCount();
        }
        public static DataTable GetAppointmentsByDate(DateTime Date)
        {
            return clsAppointmentData.GetAppointmentsByDate(Date);
        }

        public static DataTable GetAllAppointmentsTableByDoctorIDAndDate(int doctorID,DateTime Date)
        {
            return clsAppointmentData.GetAllAppointmentsTableByDoctorIDAndDate(doctorID,Date);
        }
    }
}
