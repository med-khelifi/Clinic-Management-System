using System;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
namespace DataLayer
{
    public static class clsMessageData
    {
        public static bool GetByID(int MessageID, ref int? SenderID, ref int? ReceiverID, ref string Subject, ref string Body, ref DateTime? SentAt, ref bool? IsRead, ref bool? IsDeletedBySender, ref bool? IsDeletedByReceiver)
        {
            bool isFound = false;
            using (SqlConnection connection = new SqlConnection(clsDataAccessUtil.GetConnectionString()))
            using (SqlCommand command = new SqlCommand("sp_GetMessageByID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@MessageID", MessageID);
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            SenderID =Convert.ToInt32(reader["SenderID"]);
                            ReceiverID = Convert.ToInt32(reader["ReceiverID"]);
                            Subject = reader["Subject"].ToString();
                            Body = reader["Body"].ToString();
                            SentAt = Convert.ToDateTime(reader["SentAt"]);
                            IsRead = Convert.ToBoolean(reader["IsRead"]);
                            IsDeletedBySender = Convert.ToBoolean(reader["IsDeletedBySender"]);
                            IsDeletedByReceiver = Convert.ToBoolean(reader["IsDeletedByReceiver"]);
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
        public static bool Delete(int MessageID)
        {
            int result = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessUtil.GetConnectionString()))
            using (SqlCommand command = new SqlCommand("sp_DeleteMessage", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@MessageID", MessageID);
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
            using (SqlCommand command = new SqlCommand("sp_GetAllMessages", connection))
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
        public static int AddNew(int? SenderID, int? ReceiverID, string Subject, string Body, DateTime? SentAt, bool? IsRead, bool? IsDeletedBySender, bool? IsDeletedByReceiver)
        {
            int newID = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessUtil.GetConnectionString()))
            using (SqlCommand command = new SqlCommand("sp_AddNewMessage", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@SenderID", SenderID);
                command.Parameters.AddWithValue("@ReceiverID", ReceiverID);
                command.Parameters.AddWithValue("@Subject", Subject);
                command.Parameters.AddWithValue("@Body", Body);
                command.Parameters.AddWithValue("@SentAt", SentAt);
                command.Parameters.AddWithValue("@IsRead", IsRead);
                command.Parameters.AddWithValue("@IsDeletedBySender", IsDeletedBySender);
                command.Parameters.AddWithValue("@IsDeletedByReceiver", IsDeletedByReceiver);
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
        public static bool Update(int MessageID, int? SenderID, int? ReceiverID, string Subject, string Body, DateTime? SentAt, bool? IsRead, bool? IsDeletedBySender, bool? IsDeletedByReceiver)
        {
            int result = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessUtil.GetConnectionString()))
            using (SqlCommand command = new SqlCommand("sp_UpdateMessage", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@MessageID", MessageID);
                command.Parameters.AddWithValue("@SenderID", SenderID);
                command.Parameters.AddWithValue("@ReceiverID", ReceiverID);
                command.Parameters.AddWithValue("@Subject", Subject);
                command.Parameters.AddWithValue("@Body", Body);
                command.Parameters.AddWithValue("@SentAt", SentAt);
                command.Parameters.AddWithValue("@IsRead", IsRead);
                command.Parameters.AddWithValue("@IsDeletedBySender", IsDeletedBySender);
                command.Parameters.AddWithValue("@IsDeletedByReceiver", IsDeletedByReceiver);
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
