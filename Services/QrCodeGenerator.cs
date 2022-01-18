using Microsoft.Extensions.Logging;
using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceGenerator.Services
{
    public class QrCodeGenerator : IQrCodeGenerator
    {
        private readonly ILogger<QrCodeGenerator> logger;

        public QrCodeGenerator(ILogger<QrCodeGenerator> logger)
        {
            this.logger = logger;
        }
        public Task<string> GenerateQRCode(string qrCodeText)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    //Initialize the QR code generator class
                    QRCodeGenerator qrGenerator = new QRCodeGenerator();
                    //Q(25 %)  percentage represents the hidden portion of the QR-code    
                    QRCodeData qrCodeData = qrGenerator.CreateQrCode(qrCodeText, QRCodeGenerator.ECCLevel.Q);
                    //    create the QR - code
                    QRCode qrCode = new QRCode(qrCodeData);
                    // QR code into a graphical image
                    //GetGraphic method return image in the form of Bitmap by default.
                    using (Bitmap bitMap = qrCode.GetGraphic(20))
                    {
                        bitMap.Save(ms, ImageFormat.Png);

                        return Task.FromResult(string.Join("", "data:image/png;base64,", Convert.ToBase64String(ms.ToArray())));

                    }
                }
            }
            catch (Exception e)
            {
                logger?.LogError(e, e?.Message, qrCodeText);
            }

            return Task.FromResult(string.Empty);

        }
    }
}
