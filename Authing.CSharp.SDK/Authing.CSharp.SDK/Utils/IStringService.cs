using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authing.CSharp.SDK.Utils
{
    public interface IStringService
    {
        /// <summary>
        /// b64 解码
        /// </summary>
        /// <param name="s"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        string B64Decode(string s, Encoding encoding=null);

        /// <summary>
        ///  b46 编码
        /// </summary>
        /// <param name="s"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        string B64Encode(string s, Encoding encoding=null);
    }
}
