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
        /// 登出
        /// 此端点用于用户在浏览器端主动登出，如果想要强制下线用户，请使用 Authing Management API (v3) 的强制下线接口。
        /// 如果设置了登出后的回调地址，用户登出之后浏览器 302 跳转到该地址，否则将会渲染一个提示用于已经登出的页面。
        /// </summary>
        /// <param name="idTokenHint">用户的 id_token</param>
        /// <param name="postLogoutRedirectUri">登出后的回调地址，此地址必须要在应用配置中的登出回调 URL中进行配置</param>
        /// <param name="state">自定义中间状态，为任意随机字符串，用户登出之后回调到你配置的回调地址时，会同时携带此 state。</param>
        /// <returns></returns>
        public async Task End(string idTokenHint, string postLogoutRedirectUri, string state)
        {
            string json = await GetAsync("/oidc/session/end", m_JsonService.SerializeObject(new { id_token_hint =idTokenHint, post_logout_redirect_uri =postLogoutRedirectUri,state=state}));
        }
    }
}
