using System;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
namespace DataLayer
{
    public static class clsPersonData
    {
        public static bool GetByID(int PersonID, ref string Name, ref DateTime DateOfBirth, ref bool Gender, ref string PhoneNumber, ref string Email, ref string Address, ref string ImagePath, ref int NationalityID, ref string NationalNo)
        {
            bool isFound = false;
            using (SqlConnection connection = new SqlConnection(clsDataAccessUtil.GetConnectionString()))
            using (SqlCommand command = new SqlCommand("sp_GetPersonByID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PersonID", PersonID);
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Name = reader["Name"].ToString();
                            DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]);
                            Gender = Convert.ToBoolean(reader["Gender"]);
                            PhoneNumber = reader["PhoneNumber"].ToString();
                            Email = reader["Email"].ToString();
                            Address = reader["Address"].ToString();
                            ImagePath = reader["ImagePath"].ToString();
                            NationalityID = Convert.ToInt32(reader["NationalityID"]);
                            NationalNo = reader["NationalNo"].ToString();

                            isFound = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    clsDataAccessUtil.LogError(ex);
                }
            }
            return isFound;
        }

        public static bool GetByNationalNo(ref int PersonID, ref string Name, ref DateTime DateOfBirth, ref bool Gender, ref string PhoneNumber, ref string Email, ref string Address, ref string ImagePath, ref int NationalityID,string NationalNo)
        {
            bool isFound = false;
            using (SqlConnection connection = new SqlConnection(clsDataAccessUtil.GetConnectionString()))
            using (SqlCommand command = new SqlCommand("sp_GetPersonByNationalNo", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@NationalNo", NationalNo);
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Name = reader["Name"].ToString();
                            DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]);
                            Gender = Convert.ToBoolean(reader["Gender"]);
                            PhoneNumber = reader["PhoneNumber"].ToString();
                            Email = reader["Email"].ToString();
                            Address = reader["Address"].ToString();
                            ImagePath = reader["ImagePath"].ToString();
                            NationalityID = Convert.ToInt32(reader["NationalityID"]);
                            PersonID = Convert.ToInt32(reader["PersonID"]);

                            isFound = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    clsDataAccessUtil.LogError(ex);
                }
            }
            return isFound;
        }

        public static bool Delete(int PersonID)
        {
            int result = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessUtil.GetConnectionString()))
            using (SqlCommand command = new SqlCommand("sp_DeletePerson", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PersonID", PersonID);
                try
                {
                    connection.Open();
                    result = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    clsDataAccessUtil.LogError(ex);
                }
            }
            return result > 0;
        }
        public static DataTable GetAll()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsDataAccessUtil.GetConnectionString()))
            using (SqlCommand command = new SqlCommand("sp_GetAllPersons", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    dt.Load(reader);
                }
                catch (Exception ex)
                {
                    clsDataAccessUtil.LogError(ex);
                }
            }
            return dt;
        }
        public static int AddNew(string Name, DateTime DateOfBirth, bool Gender, string PhoneNumber, string Email, string Address, string ImagePath, int NationalityID, string NationalNo)
        {
            int newID = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessUtil.GetConnectionString()))
            using (SqlCommand command = new SqlCommand("sp_AddNewPerson", connection))
            {
                
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Name", Name);
                command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                command.Parameters.AddWithValue("@Gender", Gender);
                command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                command.Parameters.AddWithValue("@Email", Email);
                command.Parameters.AddWithValue("@Address", Address);
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
                command.Parameters.AddWithValue("@NationalityID", NationalityID);
                command.Parameters.AddWithValue("@NationalNo", NationalNo);
                try
                {
                    connection.Open();
                    newID = Convert.ToInt32(command.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    clsDataAccessUtil.LogError(ex);
                }
            }
            return newID;
        }
        public static bool Update(int PersonID, string Name, DateTime DateOfBirth, bool Gender, string PhoneNumber, string Email, string Address, string ImagePath, int NationalityID, string NationalNo)
        {
            int result = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessUtil.GetConnectionString()))
            using (SqlCommand command = new SqlCommand("sp_UpdatePerson", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PersonID", PersonID);
                command.Parameters.AddWithValue("@Name", Name);
                command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                command.Parameters.AddWithValue("@Gender", Gender);
                command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                command.Parameters.AddWithValue("@Email", Email);
                command.Parameters.AddWithValue("@Address", Address);
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
                command.Parameters.AddWithValue("@NationalityID", NationalityID);
                command.Parameters.AddWithValue("@NationalNo", NationalNo);
                try
                {
                    connection.Open();
                    result = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    clsDataAccessUtil.LogError(ex);
                }
            }
            return result > 0;
        }
        public static bool IsNationalNoExists(string nationalNo)
        {
            using (var conn = new SqlConnection(clsDataAccessUtil.GetConnectionString()))
            using (var cmd = new SqlCommand("sp_isNationalNoExists", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NationalNo", nationalNo);

                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    return reader.HasRows;
                }
            }
        }

    }
}
