using DataLayer;
using System;
using System.Data;
namespace BusinessLayer
{
    public class clsMedicalRecord
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int MedicalRecordID { get; set; }
        public string VisitDescription { get; set; }
        public string Diagnosis { get; set; }
        public string AdditionalNotes { get; set; }
        public int AppointmentID { get; set; }
        public clsAppointment AppointmentInfo { get; set; }
        public clsMedicalRecord()
        {
            Mode = enMode.AddNew;
            MedicalRecordID = -1;
            VisitDescription = null;
            Diagnosis = null;
            AdditionalNotes = null;
            AppointmentID = -1;
            AppointmentInfo = null;
        }
        private clsMedicalRecord(int MedicalRecordID, string VisitDescription, string Diagnosis, string AdditionalNotes, int AppointmentID)
        {
            this.MedicalRecordID = MedicalRecordID;
            this.VisitDescription = VisitDescription;
            this.Diagnosis = Diagnosis;
            this.AdditionalNotes = AdditionalNotes;
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
            this.MedicalRecordID = clsMedicalRecordData.AddNew(this.VisitDescription, this.Diagnosis, this.AdditionalNotes, this.AppointmentID);
             return this.MedicalRecordID != 0;
        }
        private bool _update()
        {
            return clsMedicalRecordData.Update(MedicalRecordID, VisitDescription, Diagnosis, AdditionalNotes, AppointmentID);
        }
        public bool Delete()
        {
            return clsMedicalRecordData.Delete(this.MedicalRecordID);
        }
        public static DataTable GetAllMedicalRecordsTable()
        {
            return clsMedicalRecordData.GetAll();
        } 
        public static DataTable GetAllMedicalRecordsTableByDoctorNationalNo(string nationalNo)
        {
            return clsMedicalRecordData.GetAllByDoctorNationalNo(nationalNo);
        }
        public static clsMedicalRecord Find(int MedicalRecordID)
        {
            string VisitDescription = null;
            string Diagnosis = null;
            string AdditionalNotes = null;
            int AppointmentID = -1;
            if (clsMedicalRecordData.GetByID(MedicalRecordID, ref VisitDescription, ref Diagnosis, ref AdditionalNotes, ref AppointmentID))
            {
                return new clsMedicalRecord(MedicalRecordID, VisitDescription, Diagnosis, AdditionalNotes, AppointmentID);
            }
            return null;
        }

        public static bool HasPrescription(int MedicalRecordID)
        {
            return clsMedicalRecordData.HasPrescription(MedicalRecordID);
        }
        public  bool HasPrescription()
        {
            return HasPrescription(this.MedicalRecordID);
        }
    }
}
