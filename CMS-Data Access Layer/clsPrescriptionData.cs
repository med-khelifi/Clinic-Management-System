using System;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
namespace DataLayer
{
    public static class clsPrescriptionData
    {
        public static bool GetByID(int PrescriptionID, ref int MedicalRecordID, ref string MedicationName, ref string Dosage, ref string Frequency, ref DateTime StartDate, ref DateTime EndDate, ref string SpecialInstructions)
        {
            bool isFound = false;
            using (SqlConnection connection = new SqlConnection(clsDataAccessUtil.GetConnectionString()))
            using (SqlCommand command = new SqlCommand("sp_GetPrescriptionByID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PrescriptionID", PrescriptionID);
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            MedicalRecordID = Convert.ToInt32(reader["MedicalRecordID"]);
                            MedicationName = reader["MedicationName"].ToString();
                            Dosage = reader["Dosage"].ToString();
                            Frequency = reader["Frequency"].ToString();
                            StartDate = Convert.ToDateTime(reader["StartDate"]);
                            EndDate = Convert.ToDateTime(reader["EndDate"]);
                            SpecialInstructions = reader["SpecialInstructions"].ToString();
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
        public static bool Delete(int PrescriptionID)
        {
            int result = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessUtil.GetConnectionString()))
            using (SqlCommand command = new SqlCommand("sp_DeletePrescription", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PrescriptionID", PrescriptionID);
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
            using (SqlCommand command = new SqlCommand("sp_GetAllPrescriptions", connection))
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
        public static int AddNew(int MedicalRecordID, string MedicationName, string Dosage, string Frequency, DateTime StartDate, DateTime EndDate, string SpecialInstructions)
        {
            int newID = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessUtil.GetConnectionString()))
            using (SqlCommand command = new SqlCommand("sp_AddNewPrescription", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@MedicalRecordID", MedicalRecordID);
                command.Parameters.AddWithValue("@MedicationName", MedicationName);
                command.Parameters.AddWithValue("@Dosage", Dosage);
                command.Parameters.AddWithValue("@Frequency", Frequency);
                command.Parameters.AddWithValue("@StartDate", StartDate);
                command.Parameters.AddWithValue("@EndDate", EndDate);
                command.Parameters.AddWithValue("@SpecialInstructions", SpecialInstructions);
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
        public static bool Update(int PrescriptionID, int MedicalRecordID, string MedicationName, string Dosage, string Frequency, DateTime StartDate, DateTime EndDate, string SpecialInstructions)
        {
            int result = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessUtil.GetConnectionString()))
            using (SqlCommand command = new SqlCommand("sp_UpdatePrescription", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PrescriptionID", PrescriptionID);
                command.Parameters.AddWithValue("@MedicalRecordID", MedicalRecordID);
                command.Parameters.AddWithValue("@MedicationName", MedicationName);
                command.Parameters.AddWithValue("@Dosage", Dosage);
                command.Parameters.AddWithValue("@Frequency", Frequency);
                command.Parameters.AddWithValue("@StartDate", StartDate);
                command.Parameters.AddWithValue("@EndDate", EndDate);
                command.Parameters.AddWithValue("@SpecialInstructions", SpecialInstructions);
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
