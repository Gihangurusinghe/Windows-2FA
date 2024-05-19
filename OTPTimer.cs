
namespace Windows_2FA
{
    internal class OTPTimer
    {
        private System.Windows.Forms.Timer timer; // Specify the namespace for Timer
        public event EventHandler<string> OTPCodeGenerated; // Event to notify when a new OTP code is generated
        public string newOTP;
        private string secretKey;

        public void StartTimer(string secretKey)
        {
            this.secretKey = secretKey;
            // Start a timer to update the OTP code periodically
            timer = new System.Windows.Forms.Timer(); 
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        // Event handler for the timer tick event
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Create an instance of OTPGenerator
            OTPGenerator otpGenerator = new OTPGenerator();

            // Generate a new OTP code
             newOTP = OTPGenerator.GenerateOTP(secretKey);

            // Raise the OTPCodeGenerated event with the new OTP code
            OTPCodeGenerated?.Invoke(this, newOTP);

        }

    }

}

