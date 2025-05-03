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
            this.UserId = clsUserData.AddNew(this.Username, this.Password, this.RoleId, this.IsActive, this.PersonID);
            return this.UserId != 0;
        }
        private bool _update()
        {
            return clsUserData.Update(UserId, Username, Password, RoleId, IsActive, PersonID);
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
            if (clsUserData.GetByID(UserId, ref Username, ref Password, ref RoleId, ref IsActive, ref PersonID))
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
    }
}