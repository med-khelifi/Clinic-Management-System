using DataLayer;
using System;
using System.Data;
namespace BusinessLayer
{
    public class clsDoctor
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int DoctorID { get; set; }
        public int PersonID { get; set; }
        public string Specialization { get; set; }

        public clsDoctor()
        {
            Mode = enMode.AddNew;
            DoctorID = -1;
            PersonID = -1;
            Specialization = null;
        }
        private clsDoctor(int DoctorID, int PersonID, string Specialization)
        {
            this.DoctorID = DoctorID;
            this.PersonID = PersonID;
            this.Specialization = Specialization;
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
            this.DoctorID = clsDoctorData.AddNew(this.PersonID, this.Specialization);
             return this.DoctorID != 0;
        }
        private bool _update()
        {
            return clsDoctorData.Update(DoctorID, PersonID, Specialization);
        }
        public bool Delete()
        {
            return clsDoctorData.Delete(this.DoctorID);
        }
        public static DataTable GetAllDoctorsTable()
        {
            return clsDoctorData.GetAll();
        }
        public static clsDoctor Find(int DoctorID)
        {
            int PersonID = -1;
            string Specialization = null;
            if (clsDoctorData.GetByID(DoctorID, ref PersonID, ref Specialization))
            {
                return new clsDoctor(DoctorID, PersonID, Specialization);
            }
            return null;
        }
    }
}
