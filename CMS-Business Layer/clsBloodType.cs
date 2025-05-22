using DataLayer;
using System;
using System.Data;
namespace BusinessLayer
{
    public class clsBloodType
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int BloodTypeID { get; set; }
        public string BloodTypeName { get; set; }

        public clsBloodType()
        {
            Mode = enMode.AddNew;
            BloodTypeID = -1;
            BloodTypeName = "";
        }
        private clsBloodType(int BloodTypeID, string BloodTypeName)
        {
            this.BloodTypeID = BloodTypeID;
            this.BloodTypeName = BloodTypeName;
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
            this.BloodTypeID = clsBloodTypeData.AddNew(this.BloodTypeName);
             return this.BloodTypeID != 0;
        }
        private bool _update()
        {
            return clsBloodTypeData.Update(BloodTypeID, BloodTypeName);
        }
        public bool Delete()
        {
            return clsBloodTypeData.Delete(this.BloodTypeID);
        }
        public static DataTable GetAllBloodTypesTable()
        {
            return clsBloodTypeData.GetAll();
        }
        public static clsBloodType Find(int BloodTypeID)
        {
            string BloodTypeName = "";
            if (clsBloodTypeData.GetByID(BloodTypeID, ref BloodTypeName))
            {
                return new clsBloodType(BloodTypeID, BloodTypeName);
            }
            return null;
        }       
        public static clsBloodType Find(string BloodTypeName)
        {
            int BloodTypeID = -1;
            if (clsBloodTypeData.GetByName(ref BloodTypeID, BloodTypeName))
            {
                return new clsBloodType(BloodTypeID, BloodTypeName);
            }
            return null;
        }
    }
}
