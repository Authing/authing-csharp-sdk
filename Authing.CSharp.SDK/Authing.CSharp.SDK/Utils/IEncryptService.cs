using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Authing.CSharp.SDK.Utils
{
    public interface IEncryptService
    {
        string SHA256Hash(string str);
    }
}
