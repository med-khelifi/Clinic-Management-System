using System;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
namespace DataLayer
{
    public static class clsMedicalRecordData
    {
        public static bool GetByID(int MedicalRecordID, ref string VisitDescription, ref string Diagnosis, ref string AdditionalNotes, ref int AppointmentID)
        {
            bool isFound = false;
            using (SqlConnection connection = new SqlConnection(clsDataAccessUtil.GetConnectionString()))
            using (SqlCommand command = new SqlCommand("sp_GetMedicalRecordByID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@MedicalRecordID", MedicalRecordID);
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isFound = true;
                            VisitDescription = reader["VisitDescription"].ToString();
                            Diagnosis = reader["Diagnosis"].ToString();
                            AdditionalNotes = reader["AdditionalNotes"].ToString();
                            AppointmentID = Convert.ToInt32(reader["AppointmentID"]);
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
        public static bool Delete(int MedicalRecordID)
        {
            int result = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessUtil.GetConnectionString()))
            using (SqlCommand command = new SqlCommand("sp_DeleteMedicalRecord", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@MedicalRecordID", MedicalRecordID);
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
            using (SqlCommand command = new SqlCommand("sp_GetAllMedicalRecords", connection))
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
        public static DataTable GetAllByDoctorNationalNo(string doctorNationalNo)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsDataAccessUtil.GetConnectionString()))
            using (SqlCommand command = new SqlCommand("sp_GetAllMedicalRecordsByDoctorNationalNo", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@NationalNo", doctorNationalNo);
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
        public static int AddNew(string VisitDescription, string Diagnosis, string AdditionalNotes, int AppointmentID)
        {
            int newID = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessUtil.GetConnectionString()))
            using (SqlCommand command = new SqlCommand("sp_AddNewMedicalRecord", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@VisitDescription", string.IsNullOrEmpty(VisitDescription) ? (object)DBNull.Value : VisitDescription);
                command.Parameters.AddWithValue("@Diagnosis", string.IsNullOrEmpty(Diagnosis)  ? (object)DBNull.Value : Diagnosis);
                command.Parameters.AddWithValue("@AdditionalNotes", string.IsNullOrEmpty(AdditionalNotes) ? (object)DBNull.Value : AdditionalNotes);
                command.Parameters.AddWithValue("@AppointmentID", AppointmentID);
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
        public static bool Update(int MedicalRecordID, string VisitDescription, string Diagnosis, string AdditionalNotes, int? AppointmentID)
        {
            int result = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessUtil.GetConnectionString()))
            using (SqlCommand command = new SqlCommand("sp_UpdateMedicalRecord", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@MedicalRecordID", MedicalRecordID);
                command.Parameters.AddWithValue("@VisitDescription", VisitDescription);
                command.Parameters.AddWithValue("@Diagnosis", Diagnosis);
                command.Parameters.AddWithValue("@AdditionalNotes", AdditionalNotes);
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
        public static bool HasPrescription(int MedicalRecordID)
        {
            bool result = false;
            using (SqlConnection connection = new SqlConnection(clsDataAccessUtil.GetConnectionString()))
            using (SqlCommand command = new SqlCommand("sp_isMedicalRecordHasPrescriptionByID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@MedicalRecordID", MedicalRecordID);
               
                try
                {
                    connection.Open();
                    result = command.ExecuteReader().HasRows;
                }
                catch (Exception ex)
                {
                    clsDataAccessUtil.LogError(ex);
                }
            }
            return result;
        }
    }
}
