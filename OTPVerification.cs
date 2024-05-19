namespace Windows_2FA
{
    internal class OTPVerification
    {
        public static bool VerifyOTP(string enteredOTP, string OTP)
        {

            // Compare the entered OTP with the generated OTP
            if (enteredOTP == OTP)
            {
                // OTP verification successful
                return true;
            }
            else
            {
                // OTP verification failed
                return false;
            }
        }
    }
}
