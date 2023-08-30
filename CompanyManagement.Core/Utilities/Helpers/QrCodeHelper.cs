using QRCoder;
using System.Drawing.Imaging;

namespace CompanyManagement.Core.Utilities.Helpers
{
    public static class QrCodeHelper
    {
        //public static byte[] Create(string data)
        //{
        //    QRCodeGenerator qrGenerator = new QRCodeGenerator();
        //    QRCodeData qrCodeData = qrGenerator.CreateQrCode(data, QRCodeGenerator.ECCLevel.Q);
        //    var qrCode = new PngByteQRCode(qrCodeData);
        //    byte[] qrCodeImage = qrCode.GetGraphic(10);
        //    return qrCodeImage;
        //}

        public static byte[] Create(string data)
        {
            data = $"https://localhost:7233/api/Product/GetById?productId={data}";
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(data, QRCodeGenerator.ECCLevel.Q);
            var qrCode = new PngByteQRCode(qrCodeData);
            byte[] qrCodeImage = qrCode.GetGraphic(10);
            return qrCodeImage;
        }
    }
}
