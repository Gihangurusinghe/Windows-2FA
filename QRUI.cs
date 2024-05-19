using System.Text;

namespace Windows_2FA
{
    public partial class QRUI : Form
    {

        private OTPTimer otpTimer;
        private SecretKeyManager SecretKeyManager; // Declare SecretKeyManager as a class-level variable
        private RegisterUI registerForm; // Add a reference to the RegisterUI form

        private string secretKey;
        private string enteredOTP;
        private string OTP;



        public QRUI(RegisterUI registerForm)
        {

            InitializeComponent();

            // Set the start position to center on the screen
            this.StartPosition = FormStartPosition.CenterScreen;

            // Set the reference to the RegisterUI form
            this.registerForm = registerForm;


            // Set the AcceptButton property to the Verify button
            this.AcceptButton = RegVerify;           

            // Generate the QR code using the same code as before
            string secretKey = SecretKeyGenerator.GenerateSecretKey();
            string otpUrl = $"otpauth://totp/Windows%202FA?secret={secretKey}";
            Bitmap qrCodeBitmap = QRCodeGenerator.GenerateQRCode(otpUrl);

            // Create an instance of SecretKeyManager and assign it to the class-level variable
            SecretKeyManager = new SecretKeyManager();

            // Event handler for the OTPCodeGenerated event
            void OtpTimer_OTPCodeGenerated(object sender, string newOTP)
            {
                OTP = newOTP;
            }

            try
            {
                // Check if any of the inputs are null
                if (qrCodeBitmap == null || string.IsNullOrEmpty(otpUrl) || string.IsNullOrEmpty(secretKey))
                {
                    throw new ArgumentNullException(nameof(qrCodeBitmap), "The QR code bitmap is null.");
                    throw new ArgumentNullException(nameof(otpUrl), "The OTP URL is null or empty.");
                    throw new ArgumentNullException(nameof(secretKey), "The secret key is null or empty.");

                }

                // Set the QR code bitmap as the image of the PictureBox
                QRCode.Image = qrCodeBitmap;

                // Store the secret key for OTP generation
                this.secretKey = secretKey;

                // Create an instance of OTPTimer
                otpTimer = new OTPTimer();

                // Subscribe to the OTPCodeGenerated event
                otpTimer.OTPCodeGenerated += OtpTimer_OTPCodeGenerated;

                // Start the timer
                otpTimer.StartTimer(secretKey);
            }
            catch (Exception ex)
            {
                // Display error message in a MessageBox
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Close the form
                this.Close();
            }
        }
 
        private void RegTOTP_TextChanged(object sender, EventArgs e)
        {
            enteredOTP = RegTOTP.Text;

        }

        private void RegVerify_Click(object sender, EventArgs e)
        {

            // Get the OTP entered by the user 
            string enteredOTP = RegTOTP.Text.Trim(); // Trim whitespace

            // Check if the entered OTP is empty
            if (string.IsNullOrEmpty(enteredOTP))
            {
                // Prompt the user to enter the OTP
                MessageBox.Show("Please enter the OTP before verifying.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            // Verify the OTP using OTPVerification class
            bool isOTPValid = OTPVerification.VerifyOTP(enteredOTP, OTP);

            // Display message to the user based on verification result
            if (isOTPValid)
            {

                // Store the secret key if OTP verification is successful
                SecretKeyManager.SaveSecretKey(Encoding.UTF8.GetBytes(secretKey));

                // Update the UI of the Register form
                registerForm.SecretKeyExists(); // Check if the secret key exists or not

                registerForm.GetSecretKeyFilePath(); // Search key in it's path 

                registerForm.UpdateUI(); // Call the UpdateUI method in the Register form

                this.Close();

            }
            else
            {
                MessageBox.Show("Invalid OTP. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void QRCode_Click(object sender, EventArgs e)
        {

        }

        private void QRUI_Load(object sender, EventArgs e)
        {

        }
    }
}
