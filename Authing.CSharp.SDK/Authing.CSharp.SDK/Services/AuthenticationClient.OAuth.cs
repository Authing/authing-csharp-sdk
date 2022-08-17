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
        /// OAuth 获取用户信息
        /// </summary>
        /// <returns></returns>
        public async Task UserInfo()
        {
            string json = await GetAsync("/oauth/user/userinfo");
        }

        public async Task Token()
        {
            string json = await PostAsync<object>("/oauth/token",null);
        }

        public async Task Introspection()
        {
            string json = await PostAsync<object>("/oauth/token/introspection", null);
        }

        public async Task Revocation()
        {
            string json = await PostAsync<object>("/oauth/token/revocation", null);
        }

        public async Task Authenticate()
        {
            string json = await GetAsync("/authenticate");
        }

        public async Task Auth()
        {
            string json = await GetAsync("/oauth/auth");
        }

        public async Task Login()
        {
            string json = await PostAsync<object>("/interaction/oauth/login",null);
        }

        public async Task Confirm()
        {
            string json = await PostAsync<object>("/interaction/oauth/confirm", null);
        }
    }
}
