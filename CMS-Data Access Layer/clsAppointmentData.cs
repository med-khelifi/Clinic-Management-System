using System;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
namespace DataLayer
{
    public static class clsAppointmentData
    {
        public static bool GetByID(int AppointmentID, ref int PatientID, ref int DoctorID, ref DateTime AppointmentDateTime, ref byte AppointmentStatus, ref int? MedicalRecordID)
        {
            bool isFound = false;
            using (SqlConnection connection = new SqlConnection(clsDataAccessUtil.GetConnectionString()))
            using (SqlCommand command = new SqlCommand("sp_GetAppointmentByID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@AppointmentID", AppointmentID);
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isFound = true;
                            PatientID = Convert.ToInt32(reader["PatientID"]);
                            DoctorID = Convert.ToInt32(reader["DoctorID"]);
                            AppointmentDateTime = Convert.ToDateTime(reader["AppointmentDateTime"]);
                            AppointmentStatus = Convert.ToByte(reader["AppointmentStatus"]);
                            MedicalRecordID = reader["MedicalRecordID"] == DBNull.Value ? (int?)null : Convert.ToInt32(reader["MedicalRecordID"]);

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
        public static bool Delete(int AppointmentID)
        {
            int result = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessUtil.GetConnectionString()))
            using (SqlCommand command = new SqlCommand("sp_DeleteAppointment", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@AppointmentID", AppointmentID);
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
            using (SqlCommand command = new SqlCommand("sp_GetAllAppointments", connection))
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
        public static int AddNew(int PatientID, int DoctorID, DateTime AppointmentDateTime, byte AppointmentStatus, int? MedicalRecordID)
        {
            int newID = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessUtil.GetConnectionString()))
            using (SqlCommand command = new SqlCommand("sp_AddNewAppointment", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PatientID", PatientID);
                command.Parameters.AddWithValue("@DoctorID", DoctorID);
                command.Parameters.AddWithValue("@AppointmentDateTime", AppointmentDateTime);
                command.Parameters.AddWithValue("@AppointmentStatus", AppointmentStatus);
                command.Parameters.AddWithValue("@MedicalRecordID", MedicalRecordID is null ? (object)DBNull.Value : MedicalRecordID);
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
        public static bool Update(int AppointmentID, int PatientID, int DoctorID, DateTime AppointmentDateTime, byte AppointmentStatus, int? MedicalRecordID)
        {
            int result = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessUtil.GetConnectionString()))
            using (SqlCommand command = new SqlCommand("sp_UpdateAppointment", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@AppointmentID", AppointmentID);
                command.Parameters.AddWithValue("@PatientID", PatientID);
                command.Parameters.AddWithValue("@DoctorID", DoctorID);
                command.Parameters.AddWithValue("@AppointmentDateTime", AppointmentDateTime);
                command.Parameters.AddWithValue("@AppointmentStatus", AppointmentStatus);
                command.Parameters.AddWithValue("@MedicalRecordID", MedicalRecordID is null ? (object)DBNull.Value : MedicalRecordID);
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
        public static sbyte GetAppointmentStatus(int appointmentID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessUtil.GetConnectionString()))
                using (SqlCommand command = new SqlCommand("sp_GetAppointmentStatus", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@AppointmentID", appointmentID);

                    connection.Open();
                    object value = command.ExecuteScalar();

                    if (value != null && sbyte.TryParse(value.ToString(), out sbyte result))
                    {
                        return result;
                    }
                }
            }
            catch (Exception ex)
            {
                clsDataAccessUtil.LogError(ex);
            }

            return -1; // Indicates an error or invalid value
        }

        public static bool ChangeStatus(int AppointmentID, byte NewStatus) 
        {
            int result = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessUtil.GetConnectionString()))
            using (SqlCommand command = new SqlCommand("sp_ChangeAppointmentStatus", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@AppointmentID", AppointmentID);
                command.Parameters.AddWithValue("@NewStatus", NewStatus);
       
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
