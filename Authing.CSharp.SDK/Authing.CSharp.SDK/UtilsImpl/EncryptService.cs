using Authing.CSharp.SDK.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Authing.CSharp.SDK.UtilsImpl
{
    public class EncryptService : IEncryptService
    {
        public string SHA256Hash(string str)
        {
            byte[] data = Encoding.UTF8.GetBytes(str);
            SHA256 shaM = new SHA256Managed();
            var hashBytes = shaM.ComputeHash(data);
            return Convert.ToBase64String(hashBytes);
        }
    }
}
