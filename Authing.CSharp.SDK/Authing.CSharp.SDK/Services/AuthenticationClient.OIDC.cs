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
        /// OIDC 获取用户信息接口
        /// </summary>
        /// <returns></returns>
        public async Task MeGet()
        {
            string json = await GetAsync("/oidc/me", "");
        }

        /// <summary>
        /// OIDC 获取用户信息接口 （POST）
        /// </summary>
        /// <returns></returns>
        public async Task MePost()
        {
            string json = await PostAsync("/oidc/me", "");
        }

        /// <summary>
        /// OIDC 服务发现接口
        /// </summary>
        /// <returns></returns>
        public async Task<OidcDiscoveryMetadata> OpenIdConfiguration()
        {
            string json = await GetAsync("/oidc/.well-known/openid-configuration","");

            OidcDiscoveryMetadata result = m_JsonService.DeserializeObject<OidcDiscoveryMetadata>(json);
            return result;
        }

        /// <summary>
        /// OIDC JWKs 接口
        /// </summary>
        /// <returns></returns>
        public async Task JWKS()
        {
            string json = await GetAsync("/oidc/.well-known/jwks.json", "");
        }
    }
}
