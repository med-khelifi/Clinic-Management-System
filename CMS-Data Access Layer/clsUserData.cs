using System;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
namespace DataLayer
{
    public static class clsUserData
    {
        public static bool GetByID(int UserId, ref string Username, ref string Password, ref int RoleId, ref bool IsActive, ref int PersonID)
        {
            bool isFound = false;
            using (SqlConnection connection = new SqlConnection(clsDataAccessUtil.GetConnectionString()))
            using (SqlCommand command = new SqlCommand("sp_GetUserByID", connection))
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
        public static int AddNew(string Username, string Password, int RoleId, bool IsActive, int PersonID)
        {
            int newID = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessUtil.GetConnectionString()))
            using (SqlCommand command = new SqlCommand("sp_AddNewUser", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Username", Username);
                command.Parameters.AddWithValue("@Password", Password);
                command.Parameters.AddWithValue("@RoleId", RoleId);
                command.Parameters.AddWithValue("@IsActive", IsActive);
                command.Parameters.AddWithValue("@PersonID", PersonID);
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
        public static bool Update(int UserId, string Username, string Password, int RoleId, bool IsActive, int PersonID)
        {
            int result = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessUtil.GetConnectionString()))
            using (SqlCommand command = new SqlCommand("sp_UpdateUser", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@UserId", UserId);
                command.Parameters.AddWithValue("@Username", Username);
                command.Parameters.AddWithValue("@Password", Password);
                command.Parameters.AddWithValue("@RoleId", RoleId);
                command.Parameters.AddWithValue("@IsActive", IsActive);
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
        public static bool isUserExistsByUserName(string UserName)
        {
            using (var conn = new SqlConnection(clsDataAccessUtil.GetConnectionString()))
            using (var cmd = new SqlCommand("sp_isPersonExistsByUserName", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserName", UserName);

                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    return reader.HasRows;
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
        
    }
}
