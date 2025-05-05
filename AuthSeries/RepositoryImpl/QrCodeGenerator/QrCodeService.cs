using QRCoder;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.RepositoryImpl.QrCodeGenerator
{
    public class QrCodeService
    {

        public string GenerateQrCode(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return "";
            }

            using (var qrGenerator = new QRCodeGenerator())
            {
                var qrCodeData = qrGenerator.CreateQrCode(value, QRCodeGenerator.ECCLevel.Q);
                using (var qrCode = new QRCode(qrCodeData))
                {
                    using (var bitmap = qrCode.GetGraphic(20))
                    {
                        using (var ms = new MemoryStream())
                        {
                            bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                            var byteArray = ms.ToArray();
                            var base64String = Convert.ToBase64String(byteArray);
                            return base64String;
                        }
                    }
                }
            }
        }

    }
}
