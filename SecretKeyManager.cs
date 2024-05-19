using System.Security.Cryptography;

namespace Windows_2FA
{
    internal class SecretKeyManager
    {
        private const string SecretKeyFileName = "secret.key";
        private string SecretKey; // Store the secret key

        public void SaveSecretKey(byte[] secretKey)
        {
            byte[] encryptedSecretKey = ProtectData(secretKey);
            string secretKeyFilePath = GetSecretKeyFilePath();

            try
            {
                File.WriteAllBytes(secretKeyFilePath, encryptedSecretKey);
                MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Registration failed. Please try again.\nError: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadSecretKey()
        {
            string secretKeyFilePath = GetSecretKeyFilePath();
                                        
            try
            {
                if (File.Exists(secretKeyFilePath))
                {
                    byte[] encryptedSecretKey = File.ReadAllBytes(secretKeyFilePath);
                    byte[] decryptedSecretKey = UnprotectData(encryptedSecretKey);
                    SecretKey = System.Text.Encoding.UTF8.GetString(decryptedSecretKey);
                }
                else
                {
                    // Handle case where secret key file doesn't exist
                    MessageBox.Show("Secret key file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading secret key.\nError: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private byte[] ProtectData(byte[] data)
        {
            return ProtectedData.Protect(data, null, DataProtectionScope.CurrentUser);
        }

        private byte[] UnprotectData(byte[] encryptedData)
        {
            return ProtectedData.Unprotect(encryptedData, null, DataProtectionScope.CurrentUser);
        }
        
        public string GetSecretKeyFilePath()
        {
            string appDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            return Path.Combine(appDataFolder, SecretKeyFileName);
        }

        public string GetSecretKey()
        {         
            return SecretKey;
        }
    }
}
