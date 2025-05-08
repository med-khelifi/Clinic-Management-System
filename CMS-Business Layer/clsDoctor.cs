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
        public int UserID { get; set; }
        public clsUser UserInfo { get; set; }
        public string Specialization { get; set; }

        public clsDoctor()
        {
            Mode = enMode.AddNew;
            DoctorID = -1;
            UserID = -1;
            Specialization = null;
            UserInfo = new clsUser();
        }
        private clsDoctor(int DoctorID, int PersonID, string Specialization)
        {
            this.DoctorID = DoctorID;
            this.UserID = PersonID;
            this.Specialization = Specialization;
            this.UserInfo = clsUser.Find(UserID);
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
            this.DoctorID = clsDoctorData.AddNew
                (
                this.UserInfo.Username, clsPasswordHasher.Hash(this.UserInfo.Password), this.UserInfo.RoleId, 
                this.UserInfo.IsActive,this.UserInfo.PersonInfo.Name, this.UserInfo.PersonInfo.DateOfBirth, 
                this.UserInfo.PersonInfo.Gender,this.UserInfo.PersonInfo.PhoneNumber, this.UserInfo.PersonInfo.Email,
                this.UserInfo.PersonInfo.Address,this.UserInfo.PersonInfo.ImagePath, this.UserInfo.PersonInfo.NationalityID,
                this.UserInfo.PersonInfo.NationalNo,this.Specialization
                );
            return this.DoctorID != 0;
        }
        private bool _update()
        {
            return clsDoctorData.Update(
                this.UserInfo.UserId,
                this.UserInfo.Username,
                clsPasswordHasher.Hash(this.UserInfo.Password),
                this.UserInfo.RoleId,
                this.UserInfo.IsActive,
                this.UserInfo.PersonInfo.PersonID,
                this.UserInfo.PersonInfo.Name,
                this.UserInfo.PersonInfo.DateOfBirth,
                this.UserInfo.PersonInfo.Gender,
                this.UserInfo.PersonInfo.PhoneNumber,
                this.UserInfo.PersonInfo.Email,
                this.UserInfo.PersonInfo.Address,
                this.UserInfo.PersonInfo.ImagePath,
                this.UserInfo.PersonInfo.NationalityID,
                this.UserInfo.PersonInfo.NationalNo,
                this.DoctorID,
                this.Specialization
            );
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
        public static clsDoctor FindByUsername(string username)
        {
            int PersonID = -1;
            int DoctorID = -1;  
            string Specialization = null;
            if (clsDoctorData.GetByUsername(ref DoctorID, ref PersonID, ref Specialization, username))
            {
                return new clsDoctor(DoctorID, PersonID, Specialization);
            }
            return null;
        }
    }
}
