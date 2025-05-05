using DataLayer;
using System;
using System.Data;
namespace BusinessLayer
{
    public class clsPerson
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int PersonID { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string ImagePath { get; set; }
        public int NationalityID { get; set; }
        public string NationalNo { get; set; }

        public clsPerson()
        {
            Mode = enMode.AddNew;
            PersonID = -1;
            Name = "";
            DateOfBirth = DateTime.Now;
            Gender = false;
            PhoneNumber = "";
            Email = "";
            Address = "";
            ImagePath = null;
            NationalityID = -1;
            NationalNo = null;
        }
        private clsPerson(int PersonID, string Name, DateTime DateOfBirth, bool Gender, string PhoneNumber, string Email, string Address, string ImagePath, int NationalityID, string NationalNo)
        {
            this.PersonID = PersonID;
            this.Name = Name;
            this.DateOfBirth = DateOfBirth;
            this.Gender = Gender;
            this.PhoneNumber = PhoneNumber;
            this.Email = Email;
            this.Address = Address;
            this.ImagePath = ImagePath;
            this.NationalityID = NationalityID;
            this.NationalNo = NationalNo;
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
            this.PersonID = clsPersonData.AddNew(this.Name, this.DateOfBirth, this.Gender, this.PhoneNumber, this.Email, this.Address, this.ImagePath, this.NationalityID, this.NationalNo);
             return this.PersonID != 0;
        }
        private bool _update()
        {
            return clsPersonData.Update(PersonID, Name, DateOfBirth, Gender, PhoneNumber, Email, Address, ImagePath, NationalityID, NationalNo);
        }
        public bool Delete()
        {
            return clsPersonData.Delete(this.PersonID);
        }
        public static DataTable GetAllPersonsTable()
        {
            return clsPersonData.GetAll();
        }
        public static clsPerson Find(int PersonID)
        {
            string Name = "";
            DateTime DateOfBirth = DateTime.Now;
            bool Gender = false;
            string PhoneNumber = "";
            string Email = "";
            string Address = "";
            string ImagePath = null;
            int NationalityID = -1;
            string NationalNo = null;
            if (clsPersonData.GetByID(PersonID, ref Name, ref DateOfBirth, ref Gender, ref PhoneNumber, ref Email, ref Address, ref ImagePath, ref NationalityID, ref NationalNo))
            {
                return new clsPerson(PersonID, Name, DateOfBirth, Gender, PhoneNumber, Email, Address, ImagePath, NationalityID, NationalNo);
            }
            return null;
        }
        public static clsPerson Find(string NationalNo)
        {
            string Name = "";
            DateTime DateOfBirth = DateTime.Now;
            bool Gender = false;
            string PhoneNumber = "";
            string Email = "";
            string Address = "";
            string ImagePath = null;
            int NationalityID = -1;
            int PersonID = -1;
            if (clsPersonData.GetByNationalNo(ref PersonID, ref Name, ref DateOfBirth, ref Gender, ref PhoneNumber, ref Email, ref Address, ref ImagePath,ref NationalityID, NationalNo))
            {
                return new clsPerson(PersonID, Name, DateOfBirth, Gender, PhoneNumber, Email, Address, ImagePath, NationalityID, NationalNo);
            }
            return null;
        }
        public static bool isPersonExistsByNationalNo(string NationalNo)
        {
            return clsPersonData.IsNationalNoExists(NationalNo);
        }   
    }
}
