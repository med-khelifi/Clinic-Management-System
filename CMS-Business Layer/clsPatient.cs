using DataLayer;
using System;
using System.Data;
namespace BusinessLayer
{
    public class clsPatient
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int PatientID { get; set; }
        public int PersonID { get; set; }

        public clsPatient()
        {
            Mode = enMode.AddNew;
            PatientID = -1;
            PersonID = -1;
        }
        private clsPatient(int PatientID, int PersonID)
        {
            this.PatientID = PatientID;
            this.PersonID = PersonID;
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
            this.PatientID = clsPatientData.AddNew(this.PersonID);
             return this.PatientID != 0;
        }
        private bool _update()
        {
            return clsPatientData.Update(PatientID, PersonID);
        }
        public bool Delete()
        {
            return clsPatientData.Delete(this.PatientID);
        }
        public static DataTable GetAllPatientsTable()
        {
            return clsPatientData.GetAll();
        }
        public static clsPatient Find(int PatientID)
        {
            int PersonID = -1;
            if (clsPatientData.GetByID(PatientID, ref PersonID))
            {
                return new clsPatient(PatientID, PersonID);
            }
            return null;
        }
    }
}
