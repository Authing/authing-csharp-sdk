using Authing.CSharp.SDK.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authing.CSharp.SDK.UtilsImpl
{
    public class StringService : IStringService
    {
        public string B64Decode(string s, Encoding encoding = null)
        {
            if (encoding == null)
            {
                encoding = Encoding.Default;
            }

            byte[] bytes = Convert.FromBase64String(s);
            return encoding.GetString(bytes);
        }

        public string B64Encode(string s, Encoding encoding = null)
        {
            if (encoding == null)
            {
                encoding = Encoding.Default;
            }

            byte[] bytes = encoding.GetBytes(s);
            return Convert.ToBase64String(bytes, 0, bytes.Length);
        }

        public string GenerateRandomString(int length = 30)
        {
            var rd = new Random((int)DateTime.Now.Ticks);
            var strAtt = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var resAtt = new Char[length];

            rd.Next(0, 35);

            var resStr = String.Join("", resAtt.Select(p => strAtt[rd.Next(0, 35)]).ToArray());
            return resStr;
        }
    }
}
