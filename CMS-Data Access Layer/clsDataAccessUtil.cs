using System;
using System.Diagnostics;
using System.Configuration;

     /*
     ***  YOU HAVE TO ADD ADD A FRERANCE TO DATA ACCESS LAYER TO USE - Configuration Manager -  ***
                    Go To Reeferences and Add "System.Configuration"
     */
namespace DataLayer
{
    public static class clsDataAccessUtil
    {
        // Put here your connection string name
        private static string ConnectionStringName = "MyDatabaseConnection";
        static private string ApplicationName = "CMS";
        // Method to log error messages to the Windows Event Log
        public static void LogError(Exception ex)
        {
            try
            {
                // Check if the Event Log source exists, if not, create it
                if (!EventLog.SourceExists(ApplicationName))
                {
                    EventLog.CreateEventSource("MyApp", "Application");
                }

                // Write the error message to the Windows Event Log
                EventLog.WriteEntry("MyApp", $"Error: {ex.Message}\nStackTrace: {ex.StackTrace}", EventLogEntryType.Error);
            }
            catch (Exception logEx)
            {
                // If logging fails, write the error to the console (as a fallback)
                Console.WriteLine("Logging failed: " + logEx.Message);
            }
        }

         // Get Connection String From App.config File
         public static string GetConnectionString()
         {
             return ConfigurationManager.ConnectionStrings[ConnectionStringName]?.ConnectionString ?? string.Empty;
         }
    }
}
