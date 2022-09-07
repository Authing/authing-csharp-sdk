using Authing.CSharp.SDK.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authing.CSharp.SDK.Services
{
    public partial class AuthenticationClient
    {
        /// <summary>
        /// 可获取服务器的公开信息，如 RSA256 公钥、SM2 公钥、Authing 服务版本号等。
        /// </summary>
        /// <returns></returns>
        public async Task<SystemInformation> System()
        {
            string json = await GetAsync("/api/v3/system", "", AccessToken);

            SystemInformation result = m_JsonService.DeserializeObject<SystemInformation>(json);

            return result;
        }
    }
}
