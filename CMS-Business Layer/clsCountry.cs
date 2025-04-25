using DataLayer;
using System;
using System.Data;
namespace BusinessLayer
{
    public class clsCountry
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int CountryID { get; set; }
        public string CountryName { get; set; }

        public clsCountry()
        {
            Mode = enMode.AddNew;
            CountryID = -1;
            CountryName = "";
        }
        private clsCountry(int CountryID, string CountryName)
        {
            this.CountryID = CountryID;
            this.CountryName = CountryName;
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
            this.CountryID = clsCountryData.AddNew(this.CountryName);
             return this.CountryID != 0;
        }
        private bool _update()
        {
            return clsCountryData.Update(CountryID, CountryName);
        }
        public bool Delete()
        {
            return clsCountryData.Delete(this.CountryID);
        }
        public static DataTable GetAllCountriesTable()
        {
            return clsCountryData.GetAll();
        }
        public static clsCountry Find(int CountryID)
        {
            string CountryName = "";
            if (clsCountryData.GetByID(CountryID, ref CountryName))
            {
                return new clsCountry(CountryID, CountryName);
            }
            return null;
        }
        public static clsCountry Find(string CountryName)
        {
            int CountryID = -1;
            if (clsCountryData.GetByName(ref CountryID,CountryName))
            {
                return new clsCountry(CountryID, CountryName);
            }
            return null;
        }
    }
}
