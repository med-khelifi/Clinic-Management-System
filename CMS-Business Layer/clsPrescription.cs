using DataLayer;
using System;
using System.Data;
namespace BusinessLayer
{
    public class clsPrescription
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int PrescriptionID { get; set; }
        public int MedicalRecordID { get; set; }
        public string MedicationName { get; set; }
        public string Dosage { get; set; }
        public string Frequency { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string SpecialInstructions { get; set; }

        public clsPrescription()
        {
            Mode = enMode.AddNew;
            PrescriptionID = -1;
            MedicalRecordID = -1;
            MedicationName = "";
            Dosage = "";
            Frequency = "";
            StartDate = DateTime.Now;
            EndDate = DateTime.Now;
            SpecialInstructions = null;
        }
        private clsPrescription(int PrescriptionID, int MedicalRecordID, string MedicationName, string Dosage, string Frequency, DateTime StartDate, DateTime EndDate, string SpecialInstructions)
        {
            this.PrescriptionID = PrescriptionID;
            this.MedicalRecordID = MedicalRecordID;
            this.MedicationName = MedicationName;
            this.Dosage = Dosage;
            this.Frequency = Frequency;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.SpecialInstructions = SpecialInstructions;
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
            this.PrescriptionID = clsPrescriptionData.AddNew(this.MedicalRecordID, this.MedicationName, this.Dosage, this.Frequency, this.StartDate, this.EndDate, this.SpecialInstructions);
             return this.PrescriptionID != 0;
        }
        private bool _update()
        {
            return clsPrescriptionData.Update(PrescriptionID, MedicalRecordID, MedicationName, Dosage, Frequency, StartDate, EndDate, SpecialInstructions);
        }
        public bool Delete()
        {
            return clsPrescriptionData.Delete(this.PrescriptionID);
        }
        public static DataTable GetAllPrescriptionsTable()
        {
            return clsPrescriptionData.GetAll();
        }
        public static clsPrescription Find(int PrescriptionID)
        {
            int MedicalRecordID = -1;
            string MedicationName = "";
            string Dosage = "";
            string Frequency = "";
            DateTime StartDate = DateTime.Now;
            DateTime EndDate = DateTime.Now;
            string SpecialInstructions = null;
            if (clsPrescriptionData.GetByID(PrescriptionID, ref MedicalRecordID, ref MedicationName, ref Dosage, ref Frequency, ref StartDate, ref EndDate, ref SpecialInstructions))
            {
                return new clsPrescription(PrescriptionID, MedicalRecordID, MedicationName, Dosage, Frequency, StartDate, EndDate, SpecialInstructions);
            }
            return null;
        }
    }
}
