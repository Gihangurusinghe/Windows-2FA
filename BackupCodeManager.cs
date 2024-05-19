using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Windows_2FA
{
    public class BackupCodeManager
    {
        private const string BackupCodeFileName = "backup.code";
        private string backupCode; 

        public string GenerateBackupCode()
        {
            string backupCode = GenerateRandomCode();
            SaveBackupCode(backupCode);
            return backupCode;
        }

        public string BackupCode
        {
            get { return backupCode; }
            set { backupCode = value; }
        }

        private string GenerateRandomCode()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            StringBuilder sb = new StringBuilder();
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                sb.Append(chars[random.Next(chars.Length)]);
            }
            return sb.ToString();
        }

        private byte[] ProtectData(byte[] data)
        {
            return ProtectedData.Protect(data, null, DataProtectionScope.CurrentUser);
        }

        private byte[] UnprotectData(byte[] encryptedData)
        {
            return ProtectedData.Unprotect(encryptedData, null, DataProtectionScope.CurrentUser);
        }

        // Define GetBackupCodeFilePath method
        public string GetBackupCodeFilePath()
        {
            string appDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            return Path.Combine(appDataFolder, BackupCodeFileName);
        }

        private void SaveBackupCode(string backupCode)
        {
            try
            {
                byte[] encryptedBackupCode = ProtectData(Encoding.UTF8.GetBytes(backupCode));
                File.WriteAllBytes(GetBackupCodeFilePath(), encryptedBackupCode);
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to save backup code.", ex);
            }
        }

        public string LoadBackupCode()
        {
            try
            {
                if (File.Exists(GetBackupCodeFilePath()))
                {
                    byte[] encryptedBackupCode = File.ReadAllBytes(GetBackupCodeFilePath());
                    byte[] decryptedBackupCode = UnprotectData(encryptedBackupCode);
                    backupCode = Encoding.UTF8.GetString(decryptedBackupCode);
                    return Encoding.UTF8.GetString(decryptedBackupCode);
                }
                else
                {
                    throw new FileNotFoundException("Backup code file not found.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to load backup code.", ex);
            }
        }

        // Define DeleteBackupCode method
        public void DeleteBackupCode()
        {
            try
            {
                if (File.Exists(GetBackupCodeFilePath()))
                {
                    File.Delete(GetBackupCodeFilePath());
                }
                else
                {
                    throw new FileNotFoundException("Backup code file not found.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to delete backup code.", ex);
            }
        }

       

    }

}
