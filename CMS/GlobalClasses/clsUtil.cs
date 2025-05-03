using CMS.GlobalClasses;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Utility
{
    public static class clsUtil
    {
        
        public static void ShowUserControl(UserControl userControl,Panel panelContainer)
        {
            panelContainer.Controls.Clear(); // Optional: clear previous controls
            userControl.Dock = DockStyle.Fill; // Optional: fill the panel
            panelContainer.Controls.Add(userControl);
        }
        public static string GenerateGUID()
        {

            // Generate a new GUID
            Guid newGuid = Guid.NewGuid();

            // convert the GUID to a string
            return newGuid.ToString();

        }
        public static bool CreateFolderIfDoesNotExist(string FolderPath)
        {

            // Check if the folder exists
            if (!Directory.Exists(FolderPath))
            {
                try
                {
                    // If it doesn't exist, create the folder
                    Directory.CreateDirectory(FolderPath);
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error creating folder: " + ex.Message);
                    return false;
                }
            }

            return true;

        }
        public static string ReplaceFileNameWithGUID(string sourceFile)
        {
            // Full file name. Change your file name   
            string fileName = sourceFile;
            FileInfo fi = new FileInfo(fileName);
            string extn = fi.Extension;
            return GenerateGUID() + extn;

        }
        public static bool CopyImageToProjectImagesFolder(ref string sourceFile)
        {
            // this funciton will copy the image to the
            // project images foldr after renaming it
            // with GUID with the same extention, then it will update the sourceFileName with the new name.

            
            if (!CreateFolderIfDoesNotExist(clsAppDetails.ImageFolderPath))
            {
                return false;
            }

            string destinationFile = clsAppDetails.ImageFolderPath + ReplaceFileNameWithGUID(sourceFile);
            try
            {
                File.Copy(sourceFile, destinationFile, true);

            }
            catch (IOException iox)
            {
                MessageBox.Show(iox.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            sourceFile = destinationFile;
            return true;
        }
        public static bool RememberUsernameAndPassword(string Username, string Password)
        {

            string keyPath = $@"HKEY_CURRENT_USER\Software\{clsAppDetails.ApplicationName}";
            string UserName_ValueName = "UserName";
            string Password_ValueName = "Password";


            try
            {
                // Write the value to the Registry
                Registry.SetValue(keyPath, UserName_ValueName, Username, RegistryValueKind.String);
                Registry.SetValue(keyPath, Password_ValueName, Password, RegistryValueKind.String);
            }
            catch (Exception ex)
            {
                // Console.WriteLine($"An error occurred: {ex.Message}");
                return false;
            }
            return true;
        }

        public static bool GetStoredCredential(ref string Username, ref string Password)
        {
            string keyPath = $@"HKEY_CURRENT_USER\Software\{clsAppDetails.ApplicationName}";
            string UserName_ValueName = "UserName";
            string Password_ValueName = "Password";

            try
            {
                // Read the value from the Registry
                Password = Registry.GetValue(keyPath, Password_ValueName, null) as string;
                Username = Registry.GetValue(keyPath, UserName_ValueName, null) as string;


                if (Username == null || Password == null)
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                Logger.clsLogger.LogError(ex);
                return false;
            }
            return true;

        }
    }
}
