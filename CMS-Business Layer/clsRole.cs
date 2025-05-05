using DataLayer;
using System;
using System.Data;
namespace BusinessLayer
{
    public class clsRole
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public enum enRole { eAdmin = 1, eDoctor = 2, eSimpleUser = 3 }; 
        public enRole RoleId { get; set; }
        public string RoleName { get; set; }

        public clsRole()
        {
            Mode = enMode.AddNew;
            RoleId = enRole.eSimpleUser;
            RoleName = "";
        }
        private clsRole(int RoleId, string RoleName)
        {
            this.RoleId = (enRole)RoleId;
            this.RoleName = RoleName;
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
            this.RoleId = (enRole)clsRoleData.AddNew(this.RoleName);
             return this.RoleId != 0;
        }
        private bool _update()
        {
            return clsRoleData.Update(Convert.ToInt32( RoleId), RoleName);
        }
        public bool Delete()
        {
            return clsRoleData.Delete(Convert.ToInt32(RoleId));
        }
        public static DataTable GetAllRolesTable()
        {
            return clsRoleData.GetAll();
        }
        public static clsRole Find(int RoleId)
        {
            string RoleName = "";
            if (clsRoleData.GetByID(RoleId, ref RoleName))
            {
                return new clsRole(RoleId, RoleName);
            }
            return null;
        }
        public static string GetRoleNameString(enRole RoleId)
        {
            switch(RoleId)
            {
                case enRole.eAdmin:
                    return "Administrator";
                case enRole.eDoctor:
                    return "Doctor";
                case enRole.eSimpleUser:
                    return "Simple User";
                default:
                    return "";
            }
        }
    }
}
