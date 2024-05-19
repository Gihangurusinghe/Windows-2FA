using System.Security.Cryptography;
using OtpNet;

namespace Windows_2FA
{
    public class SecretKeyGenerator
    {

        private static readonly RandomNumberGenerator rng = new RNGCryptoServiceProvider();

        // Length of the secret key (in bytes)
        private const int KeyLength = 32; // You can adjust this as per your requirements

        // Method to generate a secret key
        public static string GenerateSecretKey()
        {
            try
            {
                byte[] keyBytes = new byte[KeyLength];
                rng.GetBytes(keyBytes);

                // Convert the byte array to Base32 string
                return Base32Encoding.ToString(keyBytes);
            }
            catch (Exception ex)
            {
                // Handle error
                MessageBox.Show("Error generating secret key: " + ex.Message);
                return null; // Or throw an exception
            }
        }
    }
}

