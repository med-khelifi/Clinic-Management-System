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
        public clsPerson PersonInfo { get; set; }   
        public int? BloodTypeID { get; set; }

        public clsBloodType BloodTypeInfo;

        public clsPatient()
        {
            Mode = enMode.AddNew;
            PatientID = -1;
            PersonID = -1;
            BloodTypeID = null;
            BloodTypeInfo = new clsBloodType();
            PersonInfo = new clsPerson();
        }
        private clsPatient(int PatientID, int PersonID, int? BloodTypeID)
        {
            this.PatientID = PatientID;
            this.PersonID = PersonID;
            this.BloodTypeID = BloodTypeID;
            this.BloodTypeInfo = clsBloodType.Find(BloodTypeID.Value);
            this.PersonInfo = clsPerson.Find(PersonID);
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
            this.PatientID = clsPatientData.AddNew
                (
                this.BloodTypeID.Value,
                this.PersonInfo.Name,
                this.PersonInfo.DateOfBirth,
                this.PersonInfo.Gender,
                this.PersonInfo.PhoneNumber,
                this.PersonInfo.Email,
                this.PersonInfo.Address,
                this.PersonInfo.ImagePath,
                this.PersonInfo.NationalityID,
                this.PersonInfo.NationalNo
                );
             return this.PatientID != 0;
        }
        private bool _update()
        {
            return clsPatientData.Update
                (
                PatientID, PersonID, BloodTypeID, PersonInfo.Name,PersonInfo.DateOfBirth,
                PersonInfo.Gender, PersonInfo.PhoneNumber,PersonInfo.Email,
                PersonInfo.Address, PersonInfo.ImagePath, PersonInfo.NationalityID,
                PersonInfo.NationalNo
                );
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
            int? BloodTypeID = null;
            if (clsPatientData.GetByID(PatientID, ref PersonID, ref BloodTypeID))
            {
                return new clsPatient(PatientID, PersonID, BloodTypeID);
            }
            return null;
        }
        public static clsPatient FindByNationalNo(string NationalNo)
        {
            int PersonID = -1;
            int? BloodTypeID = null;
            int PatientID = -1;
            if (clsPatientData.GetByNationalNo(ref PatientID, ref PersonID, ref BloodTypeID,NationalNo))
            {
                return new clsPatient(PatientID, PersonID, BloodTypeID);
            }
            return null;
        }
    }
}
