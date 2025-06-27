using System;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
namespace DataLayer
{
    public static class clsAppointmentData
    {
        public static bool GetByID(int AppointmentID, ref int PatientID, ref int DoctorID, ref DateTime AppointmentDateTime, ref byte AppointmentStatus)
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
        public static DataTable GetAll(int doctorID)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsDataAccessUtil.GetConnectionString()))
            using (SqlCommand command = new SqlCommand("sp_GetAllAppointmentsByDoctorID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@DoctorID", doctorID);
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
        public static int AddNew(int PatientID, int DoctorID, DateTime AppointmentDateTime, byte AppointmentStatus)
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
        public static bool Update(int AppointmentID, int PatientID, int DoctorID, DateTime AppointmentDateTime, byte AppointmentStatus)
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
        public static int GetAppointmentsCount()
        {
            int AppointmentsCount = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessUtil.GetConnectionString()))
            using (SqlCommand command = new SqlCommand("sp_GetAppointmentsCount", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Person parameters

                SqlParameter outputParam = new SqlParameter("@AppointmentsCount", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(outputParam);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    AppointmentsCount = Convert.ToInt32(outputParam.Value);
                }
                catch (Exception ex)
                {
                    clsDataAccessUtil.LogError(ex);
                }
            }

            return AppointmentsCount;
        }

        public static DataTable GetAppointmentsByDate(DateTime Date)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsDataAccessUtil.GetConnectionString()))
            using (SqlCommand command = new SqlCommand("sp_GetAppointmentsByDate", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Date", Date.Date);
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

        public static DataTable GetAllAppointmentsTableByDoctorIDAndDate(int doctorID, DateTime date)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsDataAccessUtil.GetConnectionString()))
            using (SqlCommand command = new SqlCommand("sp_GetAllAppointmentsByDoctorIDAndDate", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@DoctorID", doctorID);
                command.Parameters.AddWithValue("@Date", date);
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
    }
}
