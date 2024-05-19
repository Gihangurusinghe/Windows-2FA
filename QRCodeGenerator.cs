using ZXing;
using ZXing.Common;
using ZXing.Windows.Compatibility;

namespace Windows_2FA
{
    public class QRCodeGenerator
    {
        public static Bitmap GenerateQRCode(string data, int width = 300, int height = 300)
        {
            try
            {
                // Create QR code writer
                BarcodeWriter<Bitmap> barcodeWriter = new BarcodeWriter<Bitmap>
                {
                    Format = BarcodeFormat.QR_CODE,
                    Options = new EncodingOptions
                    {
                        Width = width,
                        Height = height
                    },
                    Renderer = new BitmapRenderer()
                };

                // Generate QR code bitmap
                return barcodeWriter.Write(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating QR code: " + ex.Message);
                throw; // Rethrow the exception for better error handling
            }
        }
     }
 }
