using CMS.GlobalClasses;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Logger
{
    static class clsLogger
    {
        public static void LogError(Exception ex)
        {
            try
            {
                // Check if the Event Log source exists, if not, create it
                if (!EventLog.SourceExists(clsAppDetails.ApplicationName))
                {
                    EventLog.CreateEventSource("MyApp", "Application");
                }

                // Write the error message to the Windows Event Log
                EventLog.WriteEntry(clsAppDetails.ApplicationName, $"Error: {ex.Message}\nStackTrace: {ex.StackTrace}", EventLogEntryType.Error);
            }
            catch (Exception logEx)
            {
                // If logging fails, write the error to the console (as a fallback)
                Console.WriteLine("Logging failed: " + logEx.Message);
            }
        }
    }
}
