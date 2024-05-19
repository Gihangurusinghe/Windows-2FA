namespace Windows_2FA
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Check if the secret key file exists
            string secretKeyFilePath = new SecretKeyManager().GetSecretKeyFilePath();
            bool secretKeyExists = File.Exists(secretKeyFilePath);

            // Decide which form to open based on the existence of the secret key file
            if (secretKeyExists)
            {
                Application.Run(new LoginUI());
            }
            else
            {
                Application.Run(new RegisterUI());
            }

            // Check the flag from the LoginUI form
            if (LoginUI.LoggedInWithBackupCode)
            {
                // If the user logged in with a backup code, load the RegisterUI form
                Application.Run(new RegisterUI());
            }
            else
            {
                // If the user logged in with OTP, exit the application
                return;
            }

        }
    }
}
