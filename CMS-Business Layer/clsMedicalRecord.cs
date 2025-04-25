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

        public clsMedicalRecord()
        {
            Mode = enMode.AddNew;
            MedicalRecordID = -1;
            VisitDescription = null;
            Diagnosis = null;
            AdditionalNotes = null;
        }
        private clsMedicalRecord(int MedicalRecordID, string VisitDescription, string Diagnosis, string AdditionalNotes)
        {
            this.MedicalRecordID = MedicalRecordID;
            this.VisitDescription = VisitDescription;
            this.Diagnosis = Diagnosis;
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
            this.MedicalRecordID = clsMedicalRecordData.AddNew(this.VisitDescription, this.Diagnosis, this.AdditionalNotes);
             return this.MedicalRecordID != 0;
        }
        private bool _update()
        {
            return clsMedicalRecordData.Update(MedicalRecordID, VisitDescription, Diagnosis, AdditionalNotes);
        }
        public bool Delete()
        {
            return clsMedicalRecordData.Delete(this.MedicalRecordID);
        }
        public static DataTable GetAllMedicalRecordsTable()
        {
            return clsMedicalRecordData.GetAll();
        }
        public static clsMedicalRecord Find(int MedicalRecordID)
        {
            string VisitDescription = null;
            string Diagnosis = null;
            string AdditionalNotes = null;
            if (clsMedicalRecordData.GetByID(MedicalRecordID, ref VisitDescription, ref Diagnosis, ref AdditionalNotes))
            {
                return new clsMedicalRecord(MedicalRecordID, VisitDescription, Diagnosis, AdditionalNotes);
            }
            return null;
        }
    }
}
