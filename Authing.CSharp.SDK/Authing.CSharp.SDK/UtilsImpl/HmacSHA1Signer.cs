using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace Authing.CSharp.SDK.UtilsImpl
{
    public class HmacSHA1Signer
    {
        private const string ALGORITHM_NAME = "HmacSHA1";
        public const string ENCODING = "UTF-8";

        public static string SignString(string stringToSign, string accessKeySecret)
        {
            using (var hmac = new HMACSHA1(Encoding.UTF8.GetBytes(accessKeySecret)))
            {
                var hashValue = hmac.ComputeHash(Encoding.UTF8.GetBytes(stringToSign));
                return Convert.ToBase64String(hashValue);
            }
        }

        public string GetSignerName()
        {
            return "HMAC-SHA1";
        }

        public string GetSignerVersion()
        {
            return "1.0";
        }

        public string GetSignerType()
        {
            return null;
        }
    }
}
