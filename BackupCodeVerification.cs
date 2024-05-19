
namespace Windows_2FA
{
    internal class BackupCodeVerification
    {
        public static bool VerifyBackupCode(string enteredBackupCode)
        {
            try
            {
                // Create an instance of BackupCodeManager to access the backup code
                BackupCodeManager backupCodeManager = new BackupCodeManager();

                // Load the stored backup code
                string storedBackupCode = backupCodeManager.LoadBackupCode();

                // Compare the entered backup code with the stored backup code
                if (enteredBackupCode == storedBackupCode)
                {
                    // Backup Code verification successful

                    // Delete the existing backup code file
                    backupCodeManager.DeleteBackupCode();

                    // Generate a new backup code
                    string newBackupCode = backupCodeManager.GenerateBackupCode();

                    // Display the new backup code to the user
                    MessageBox.Show($"Your new backup code is: {newBackupCode}", "Backup Code Generated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return true;
                }
                else
                {
                    // Backup Code verification failed
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions here
                MessageBox.Show("Error verifying backup code: " + ex.Message);
                return false;
            }
        }
    }
}
