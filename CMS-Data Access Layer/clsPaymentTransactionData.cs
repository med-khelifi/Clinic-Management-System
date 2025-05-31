using System;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
namespace DataLayer
{
    public static class clsPaymentTransactionData
    {
        public static bool GetByID(int PaymentTransactionID, ref int PaymentID, ref double Amount, ref DateTime PaymentDate, ref int PaymentType, ref string PaymentMethod)
        {
            bool isFound = false;
            using (SqlConnection connection = new SqlConnection(clsDataAccessUtil.GetConnectionString()))
            using (SqlCommand command = new SqlCommand("sp_GetPaymentTransactionByID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PaymentTransactionID", PaymentTransactionID);
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isFound = true;
                            PaymentID = Convert.ToInt32(reader["PaymentID"]);
                            Amount = Convert.ToDouble(reader["Amount"]);
                            PaymentDate = Convert.ToDateTime(reader["PaymentDate"]);
                            PaymentType = Convert.ToInt32(reader["PaymentType"]);
                            PaymentMethod = reader["PaymentMethod"].ToString();
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
        public static bool Delete(int PaymentTransactionID)
        {
            int result = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessUtil.GetConnectionString()))
            using (SqlCommand command = new SqlCommand("sp_DeletePaymentTransaction", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PaymentTransactionID", PaymentTransactionID);
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
            using (SqlCommand command = new SqlCommand("sp_GetAllPaymentTransactions", connection))
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
        public static int AddNew(int PaymentID, double Amount, DateTime PaymentDate, int PaymentType, string PaymentMethod)
        {
            int newID = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessUtil.GetConnectionString()))
            using (SqlCommand command = new SqlCommand("sp_AddNewPaymentTransaction", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PaymentID", PaymentID);
                command.Parameters.AddWithValue("@Amount", Amount);
                command.Parameters.AddWithValue("@PaymentDate", PaymentDate);
                command.Parameters.AddWithValue("@PaymentType", PaymentType);
                command.Parameters.AddWithValue("@PaymentMethod", PaymentMethod);
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
        public static bool Update(int PaymentTransactionID, int PaymentID, double Amount, DateTime PaymentDate, int PaymentType, string PaymentMethod)
        {
            int result = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessUtil.GetConnectionString()))
            using (SqlCommand command = new SqlCommand("sp_UpdatePaymentTransaction", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PaymentTransactionID", PaymentTransactionID);
                command.Parameters.AddWithValue("@PaymentID", PaymentID);
                command.Parameters.AddWithValue("@Amount", Amount);
                command.Parameters.AddWithValue("@PaymentDate", PaymentDate);
                command.Parameters.AddWithValue("@PaymentType", PaymentType);
                command.Parameters.AddWithValue("@PaymentMethod", PaymentMethod);
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
