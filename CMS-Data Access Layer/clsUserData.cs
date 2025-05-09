using System;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
namespace DataLayer
{
    public static class clsUserData
    {
        public static bool GetByUserID(int UserId, ref string Username, ref string Password, ref int RoleId, ref bool IsActive, ref int PersonID)
        {
            bool isFound = false;
            using (SqlConnection connection = new SqlConnection(clsDataAccessUtil.GetConnectionString()))
            using (SqlCommand command = new SqlCommand("sp_GetUserByUserID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@UserId", UserId);
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isFound = true;
                            Username = reader["Username"].ToString();
                            Password = reader["Password"].ToString();
                            RoleId = Convert.ToInt32(reader["RoleId"]);
                            IsActive = Convert.ToBoolean(reader["IsActive"]);
                            PersonID = Convert.ToInt32(reader["PersonID"]);
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
        public static bool Delete(int UserId)
        {
            int result = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessUtil.GetConnectionString()))
            using (SqlCommand command = new SqlCommand("sp_DeleteUser", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@UserId", UserId);
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
            using (SqlCommand command = new SqlCommand("sp_GetAllUsers", connection))
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
                string Email, string Address, string ImagePath, int NationalityID, string NationalNo
            )

        {
            int newUserId = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessUtil.GetConnectionString()))
            using (SqlCommand command = new SqlCommand("sp_AddPersonAndUser", connection))
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

                // Output parameter
                SqlParameter outputParam = new SqlParameter("@NewUserId", SqlDbType.Int)
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
                string Email, string Address, string ImagePath, int NationalityID, string NationalNo
            )

        {
            int result = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessUtil.GetConnectionString()))
            using (SqlCommand command = new SqlCommand("sp_UpdatePersonAndUser", connection))
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
                command.Parameters.AddWithValue("@Gender",  Gender);
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
        public static bool isUserExistsByUserName(string UserName)
        {
            using (var conn = new SqlConnection(clsDataAccessUtil.GetConnectionString()))
            using (var cmd = new SqlCommand("sp_isUserExistsByUserName", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserName", UserName);

                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    bool res = reader.HasRows;
                    return res;
                }
            }
        }

        public static bool LogIn(ref int UserId,string Username,string Password, ref int RoleId, ref bool IsActive, ref int PersonID)
        {
            bool isFound = false;
            using (SqlConnection connection = new SqlConnection(clsDataAccessUtil.GetConnectionString()))
            using (SqlCommand command = new SqlCommand("sp_LogIn", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@UserName", Username);
                command.Parameters.AddWithValue("@Password", Password);
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Username = reader["Username"].ToString();
                            Password = reader["Password"].ToString();
                            RoleId = Convert.ToInt32(reader["RoleId"]);
                            IsActive = Convert.ToBoolean(reader["IsActive"]);
                            PersonID = Convert.ToInt32(reader["PersonID"]);
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
        public static bool GetByUsername(string UsernameToFind, ref int UserId, ref string Password, ref int RoleId, ref bool IsActive, ref int PersonID)
        {
            bool isFound = false;
            using (SqlConnection connection = new SqlConnection(clsDataAccessUtil.GetConnectionString()))
            using (SqlCommand command = new SqlCommand("sp_GetUserByUsername", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Username", UsernameToFind);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isFound = true;
                            UserId = Convert.ToInt32(reader["UserId"]);
                            Password = reader["Password"].ToString();
                            RoleId = Convert.ToInt32(reader["RoleId"]);
                            IsActive = Convert.ToBoolean(reader["IsActive"]);
                            PersonID = Convert.ToInt32(reader["PersonID"]);
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
        public static bool ChangePassword(int userId, string hashedPassword)
        {
            using (SqlConnection conn = new SqlConnection(clsDataAccessUtil.GetConnectionString()))
            using (SqlCommand cmd = new SqlCommand("sp_ChangeUserPassword", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserId", userId);
                cmd.Parameters.AddWithValue("@HashedPassword", hashedPassword);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        public static bool ChangeUserStatus(string username, bool isActive)
        {
            using (SqlConnection conn = new SqlConnection(clsDataAccessUtil.GetConnectionString()))
            using (SqlCommand cmd = new SqlCommand("sp_ChangeUserStatus", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@IsActive", isActive);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        public static bool? GetUserStatus(string username)
        {
            using (SqlConnection conn = new SqlConnection(clsDataAccessUtil.GetConnectionString()))
            using (SqlCommand cmd = new SqlCommand("sp_GetUserStatusByUsername", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Username", username);

                conn.Open();
                object result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    return Convert.ToBoolean(result);
                }

                return null; // ???????? ??? ?????
            }
        }
        public static bool isDoctor(string Username)
        {
            bool isDoctor = false;
            using (SqlConnection connection = new SqlConnection(clsDataAccessUtil.GetConnectionString()))
            using (SqlCommand command = new SqlCommand("isUserADoctor", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@username", Username);
                try
                {
                    connection.Open();
                    isDoctor = command.ExecuteReader().HasRows;
                }
                catch (Exception ex)
                {
                    clsDataAccessUtil.LogError(ex);
                }
            }
            return isDoctor;
        }
    }
}
