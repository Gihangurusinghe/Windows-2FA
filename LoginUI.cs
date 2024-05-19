
namespace Windows_2FA
{
    public partial class LoginUI : Form

    {
        private OTPTimer otpTimer;
        private string SecretKey;
        private string enteredOTP;
        private string enteredbackupcode;
        private string OTP;

        public static bool LoggedInWithBackupCode { get; set; }


        public LoginUI()
        {
            InitializeComponent();

            // Create an instance of SecretKeyManager
            SecretKeyManager secretKeyManager = new SecretKeyManager();

            // Load the secret key
            secretKeyManager.LoadSecretKey();

            // Retrieve the secret key 
            SecretKey = secretKeyManager.GetSecretKey();

            // Event handler for the OTPCodeGenerated event
            void OtpTimer_OTPCodeGenerated(object sender, string newOTP)
            {
                OTP = newOTP;

            }

            // Create an instance of OTPTimer
            otpTimer = new OTPTimer();

            // Subscribe to the OTPCodeGenerated event
            otpTimer.OTPCodeGenerated += OtpTimer_OTPCodeGenerated;

            // Start the timer
            otpTimer.StartTimer(SecretKey);

            KeyboardHook keyboard = new KeyboardHook();
            keyboard.InstallHook();

            // Set the AcceptButton property to the Login button
            this.AcceptButton = Login;

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Alt | Keys.F4)) // Check if Alt + F4 is pressed
            {

                MessageBox.Show("Please enter the OTP", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Return true to indicate that the key combination was handled
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Logout lg = new Logout();
            lg.LogoutUser();
        }

        private void LoginTOTP_TextChanged(object sender, EventArgs e)
        {
            enteredOTP = LoginTOTP.Text;
        }

        private void Login_Click(object sender, EventArgs e)
        {
            // Get the OTP entered by the user from the text box
            string enteredOTP = LoginTOTP.Text.Trim(); // Trim any leading or trailing whitespace

            // Get the backup code entered by the user from the text box
            string enteredBackupCode = BackupLogin.Text.Trim(); // Trim any leading or trailing whitespace

            // Check if both OTP and backup code are empty
            if (string.IsNullOrEmpty(enteredOTP) && string.IsNullOrEmpty(enteredBackupCode))
            {
                // Prompt the user to enter either OTP or backup code
                MessageBox.Show("Please enter either OTP or backup code before login.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method without attempting verification
            }

            // If OTP is provided, verify it
            if (!string.IsNullOrEmpty(enteredOTP))
            {
                // Verify the OTP using OTPVerification class
                bool isOTPValid = OTPVerification.VerifyOTP(enteredOTP, OTP);

                // Display message to the user based on OTP verification result
                if (isOTPValid)
                {
                    this.Close(); // Close the login form if OTP is valid
                    return;
                }
                else
                {
                    MessageBox.Show("Invalid OTP. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // If backup code is provided, verify it
            if (!string.IsNullOrEmpty(enteredBackupCode))
            {
                // Verify the backup code using BackupCodeVerification class
                bool isBackupCodeValid = BackupCodeVerification.VerifyBackupCode(enteredBackupCode);

                // Display message to the user based on backup code verification result
                if (isBackupCodeValid)
                {
                    // Set the flag indicating the user logged in with a backup code
                    LoginUI.LoggedInWithBackupCode = true;

                    this.Close(); // Close the login form if backup code is valid
                    return;
                }
                else
                {
                    MessageBox.Show("Invalid backup code. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void BackupLogin_TextChanged(object sender, EventArgs e)
        {
            enteredbackupcode = LoginTOTP.Text;
        }

    }
}