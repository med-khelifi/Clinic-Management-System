using System;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
namespace DataLayer
{
    public static class clsDoctorData
    {
        public static bool GetByID(int DoctorID, ref int PersonID, ref string Specialization)
        {
            bool isFound = false;
            using (SqlConnection connection = new SqlConnection(clsDataAccessUtil.GetConnectionString()))
            using (SqlCommand command = new SqlCommand("sp_GetDoctorByID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@DoctorID", DoctorID);
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isFound = true;
                            PersonID = Convert.ToInt32(reader["PersonID"]);
                            Specialization = reader["Specialization"].ToString();
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
        public static bool GetByUsername(ref int DoctorID, ref int PersonID, ref string Specialization,string username)
        {
            bool isFound = false;
            using (SqlConnection connection = new SqlConnection(clsDataAccessUtil.GetConnectionString()))
            using (SqlCommand command = new SqlCommand("sp_GetDoctorByUsername", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Username", username);
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isFound = true;
                            DoctorID = Convert.ToInt32(reader["DoctorID"]);
                            PersonID = Convert.ToInt32(reader["PersonID"]);
                            Specialization = reader["Specialization"].ToString();
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
        public static bool Delete(int DoctorID)
        {
            int result = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessUtil.GetConnectionString()))
            using (SqlCommand command = new SqlCommand("sp_DeleteDoctor", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@DoctorID", DoctorID);
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
            using (SqlCommand command = new SqlCommand("sp_GetAllDoctors", connection))
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
        public static int AddNew(
                string Username, string Password, int RoleId, bool IsActive,
                string Name, DateTime DateOfBirth, bool Gender, string PhoneNumber,
                string Email, string Address, string ImagePath, int NationalityID, string NationalNo,
                string Specialization
            )

        {
            int newUserId = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessUtil.GetConnectionString()))
            using (SqlCommand command = new SqlCommand("sp_AddNewDoctor", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Person parameters
                command.Parameters.AddWithValue("@Name", Name);
                command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                command.Parameters.AddWithValue("@Gender", Gender);
                command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                command.Parameters.AddWithValue("@Email", Email);
                command.Parameters.AddWithValue("@Address", Address);
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
                command.Parameters.AddWithValue("@NationalityID", NationalityID);
                command.Parameters.AddWithValue("@NationalNo", NationalNo);

                // User parameters
                command.Parameters.AddWithValue("@Username", Username);
                command.Parameters.AddWithValue("@Password", Password);
                command.Parameters.AddWithValue("@RoleId", RoleId);
                command.Parameters.AddWithValue("@IsActive", IsActive);
                // Doctor parameters
                command.Parameters.AddWithValue("@Specialization", Specialization); // Assuming specialization is not needed here
                // Output parameter
                SqlParameter outputParam = new SqlParameter("@NewDoctorID", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(outputParam);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    newUserId = Convert.ToInt32(outputParam.Value);
                }
                catch (Exception ex)
                {
                    clsDataAccessUtil.LogError(ex);
                }
            }

            return newUserId;
        }
        public static bool Update(
                int UserId, string Username, string Password, int RoleId, bool IsActive,
                int PersonID, string Name, DateTime DateOfBirth, bool Gender, string PhoneNumber,
                string Email, string Address, string ImagePath, int NationalityID, string NationalNo,
                int DoctorID ,string Specialization
            )

        {
            int result = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessUtil.GetConnectionString()))
            using (SqlCommand command = new SqlCommand("sp_UpdateDoctor", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                // User parameters
                command.Parameters.AddWithValue("@UserId", UserId);
                command.Parameters.AddWithValue("@Username", Username);
                command.Parameters.AddWithValue("@Password", Password);
                command.Parameters.AddWithValue("@RoleId", RoleId);
                command.Parameters.AddWithValue("@IsActive", IsActive);

                // Person parameters
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
                // Doctor parameters
                command.Parameters.AddWithValue("@Specialization", Specialization);
                command.Parameters.AddWithValue("@DoctorID", DoctorID);
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
    }
}
