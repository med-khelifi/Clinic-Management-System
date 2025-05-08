using DataLayer;
using System;
using System.Data;
namespace BusinessLayer
{
    public class clsUser
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        public bool IsActive { get; set; }
        public int PersonID { get; set; }
        public clsPerson PersonInfo { get; set; }
        public clsRole RoleInfo { get; set; } // Added RoleInfo property
        public clsUser()
        {
            Mode = enMode.AddNew;
            UserId = -1;
            Username = "";
            Password = "";
            RoleId = -1;
            IsActive = false;
            PersonID = -1;
            PersonInfo = new clsPerson();
        }
        private clsUser(int UserId, string Username, string Password, int RoleId, bool IsActive, int PersonID)
        {
            this.UserId = UserId;
            this.Username = Username;
            this.Password = Password;
            this.RoleId = RoleId;
            this.IsActive = IsActive;
            this.PersonID = PersonID;
            Mode = enMode.Update;
            PersonInfo = clsPerson.Find(PersonID);
            RoleInfo = clsRole.Find(RoleId);
        }

        //// Constructor to initialize all properties including PersonInfo that will be used in transactions add user and person
        //private clsUser(int UserId, string Username, string Password, int RoleId, bool IsActive, int PersonID , 
        //    string Name, DateTime DateOfBirth, bool Gender, string PhoneNumber, string Email, string Address, 
        //    string ImagePath, int NationalityID, string NationalNo)
        //{
        //    this.UserId = UserId;
        //    this.Username = Username;
        //    this.Password = Password;
        //    this.RoleId = RoleId;
        //    this.IsActive = IsActive;
        //    this.PersonID = PersonID;
        //    // Initialize PersonInfo
        //    PersonInfo.PersonID = PersonID;
        //    PersonInfo.Name = Name;
        //    PersonInfo.DateOfBirth = DateOfBirth;
        //    PersonInfo.Gender = Gender;
        //    PersonInfo.PhoneNumber = PhoneNumber;
        //    PersonInfo.Email = Email;
        //    PersonInfo.Address = Address;
        //    PersonInfo.ImagePath = ImagePath;
        //    PersonInfo.NationalityID = NationalityID;
        //    PersonInfo.NationalNo = NationalNo;


        //    Mode = enMode.Update;
            
        //}

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
            this.UserId = clsUserData.AddNew
                (
                this.Username, clsPasswordHasher.Hash(this.Password), this.RoleId, this.IsActive,
                PersonInfo.Name, PersonInfo.DateOfBirth, PersonInfo.Gender,
                PersonInfo.PhoneNumber, PersonInfo.Email, PersonInfo.Address,
                PersonInfo.ImagePath, PersonInfo.NationalityID, PersonInfo.NationalNo
                );
            return this.UserId != 0;
        }
        private bool _update()
        {
            return clsUserData.Update
                (
                this.UserId, this.Username, clsPasswordHasher.Hash(this.Password), this.RoleId, this.IsActive,
                this.PersonInfo.PersonID, this.PersonInfo.Name, this.PersonInfo.DateOfBirth,
                this.PersonInfo.Gender, this.PersonInfo.PhoneNumber, this.PersonInfo.Email,
                this.PersonInfo.Address, this.PersonInfo.ImagePath, this.PersonInfo.NationalityID,
                this.PersonInfo.NationalNo
                );
        }
        public bool Delete()
        {
            return clsUserData.Delete(this.UserId);
        }
        public static DataTable GetAllUsersTable()
        {
            return clsUserData.GetAll();
        }
        public static clsUser Find(int UserId)
        {
            string Username = "";
            string Password = "";
            int RoleId = -1;
            bool IsActive = false;
            int PersonID = -1;
            if (clsUserData.GetByUserID(UserId, ref Username, ref Password, ref RoleId, ref IsActive, ref PersonID))
            {
                return new clsUser(UserId, Username, Password, RoleId, IsActive, PersonID);
            }
            return null;
        }
        public static clsUser FindByUserID(int PersonID)
        {
            string Username = "";
            string Password = "";
            int RoleId = -1;
            bool IsActive = false;
            int UserId = -1;
            if (clsUserData.GetByUserID(UserId, ref Username, ref Password, ref RoleId, ref IsActive,ref PersonID))
            {
                return new clsUser(UserId, Username, Password, RoleId, IsActive, PersonID);
            }
            return null;
        }
        public static clsUser Find(string Username)
        {
            int UserId = 0;
            string Password = "";
            int RoleId = -1;
            bool IsActive = false;
            int PersonID = -1;
            if (clsUserData.GetByUsername(Username, ref UserId,ref Password, ref RoleId, ref IsActive, ref PersonID))
            {
                return new clsUser(UserId, Username, Password, RoleId, IsActive, PersonID);
            }
            return null;
        }
        public static bool isUserExistsByUserName(string UserName)
        {
            return clsUserData.isUserExistsByUserName(UserName);
        }
        public static clsUser LogIn(string UserName, string Password)
        {
            int UserId = -1;
            string HashedPassword = clsPasswordHasher.Hash(Password);
            int RoleId = -1;
            bool IsActive = false;
            int PersonID = -1;
            if (clsUserData.LogIn(ref UserId,UserName,HashedPassword, ref RoleId, ref IsActive, ref PersonID))
            {
                return new clsUser(UserId, UserName, HashedPassword, RoleId, IsActive, PersonID);
            }
            return null;
        }
        public bool ChangePassword(string NewPassword)
        {
            string HashedNewPassword = clsPasswordHasher.Hash(NewPassword);
            return clsUserData.ChangePassword(this.UserId, HashedNewPassword);
        }
        public static bool? ChangeUserStatus(string username, bool newStatus)
        {
            return clsUserData.ChangeUserStatus(username, newStatus);
        }
        public static bool? getUserStatus(string username)
        {
            return clsUserData.GetUserStatus(username);
        }
        public bool? getUserStatus()
        {
            return clsUserData.GetUserStatus(this.Username);
        }
    }
}