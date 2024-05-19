using OtpNet;

namespace Windows_2FA
{

    internal class OTPGenerator
    {
        private const int TimeStepSeconds = 30;
        private const OtpHashMode HashMode = OtpHashMode.Sha1;
        private const int OtpCodeLength = 6;

        // Method to generate OTP codes
        public static string GenerateOTP(string secretKey)
        {
            try
            {
                // Parse the secret key from Base32 string
                var secret = Base32Encoding.ToBytes(secretKey);

                // Create an instance of Totp
                var otpGenerator = new Totp(secret, TimeStepSeconds, HashMode, OtpCodeLength);

                // Generate OTP code
                var otpCode = otpGenerator.ComputeTotp();

                return otpCode;
            }
            catch (Exception ex)
            {
                // Handle error
                MessageBox.Show("Error generating OTP: " + ex.Message);
                return null; // Or throw an exception
            }
        }
    }
}

