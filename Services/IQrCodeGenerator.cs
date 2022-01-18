using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceGenerator.Services
{
    public interface IQrCodeGenerator
    {
        public Task<string> GenerateQRCode(string qrCodeText);
    }
}
