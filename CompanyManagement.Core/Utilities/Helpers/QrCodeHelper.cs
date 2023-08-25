using QRCoder;
using System.Drawing.Imaging;

namespace CompanyManagement.Core.Utilities.Helpers
{
    public static class QrCodeHelper
    {
        public static System.Drawing.Image Create(string data)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(data, QRCodeGenerator.ECCLevel.Q);
            var qrCode = new PngByteQRCode(qrCodeData);
            byte[] qrCodeImage = qrCode.GetGraphic(20);

            MemoryStream qrCodeStream = new MemoryStream();
            qrCodeStream.Write(qrCodeImage, 0, qrCodeImage.Length);

            // Byte dizisini bir MemoryStream'e kopyalayın
            using (MemoryStream stream = new MemoryStream(qrCodeImage))
            {
                // MemoryStream'den bir Image (resim) nesnesi oluşturun
                System.Drawing.Image image = System.Drawing.Image.FromStream(stream);

                image.Save("yeni_resim.png", ImageFormat.Png);
                return image;
            }
        }
    }
}
