using System;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
namespace DataLayer
{
    public static class clsPaymentData
    {
        public static bool GetByID(int PaymentID, ref DateTime PaymentDate, ref string PaymentMethod, ref decimal AmountPaid, ref string AdditionalNotes)
        {
            bool isFound = false;
            using (SqlConnection connection = new SqlConnection(clsDataAccessUtil.GetConnectionString()))
            using (SqlCommand command = new SqlCommand("sp_GetPaymentByID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PaymentID", PaymentID);
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            PaymentDate = Convert.ToDateTime(reader["PaymentDate"]);
                            PaymentMethod = reader["PaymentMethod"].ToString();
                            AmountPaid = Convert.ToDecimal(reader["AmountPaid"]);
                            AdditionalNotes = reader["AdditionalNotes"].ToString();
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
        public static bool Delete(int PaymentID)
        {
            int result = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessUtil.GetConnectionString()))
            using (SqlCommand command = new SqlCommand("sp_DeletePayment", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PaymentID", PaymentID);
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
            using (SqlCommand command = new SqlCommand("sp_GetAllPayments", connection))
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
        public static int AddNew(DateTime PaymentDate, string PaymentMethod, decimal AmountPaid, string AdditionalNotes)
        {
            int newID = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessUtil.GetConnectionString()))
            using (SqlCommand command = new SqlCommand("sp_AddNewPayment", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PaymentDate", PaymentDate);
                command.Parameters.AddWithValue("@PaymentMethod", PaymentMethod);
                command.Parameters.AddWithValue("@AmountPaid", AmountPaid);
                command.Parameters.AddWithValue("@AdditionalNotes", AdditionalNotes);
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
        public static bool Update(int PaymentID, DateTime PaymentDate, string PaymentMethod, decimal AmountPaid, string AdditionalNotes)
        {
            int result = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessUtil.GetConnectionString()))
            using (SqlCommand command = new SqlCommand("sp_UpdatePayment", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PaymentID", PaymentID);
                command.Parameters.AddWithValue("@PaymentDate", PaymentDate);
                command.Parameters.AddWithValue("@PaymentMethod", PaymentMethod);
                command.Parameters.AddWithValue("@AmountPaid", AmountPaid);
                command.Parameters.AddWithValue("@AdditionalNotes", AdditionalNotes);
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
