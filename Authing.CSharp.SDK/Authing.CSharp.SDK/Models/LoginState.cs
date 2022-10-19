using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authing.CSharp.SDK.Models.Authentication
{
    /// <summary>
    /// 登录状态
    /// </summary>
    public class LoginState
    {
        /// <summary>
        /// Access token，Authing 颁发的 Access token
        /// </summary>
        [JsonProperty("accessToken")]
        public string AccessToken { get; set; }

        /// <summary>
        /// ID token，Authing 颁发的用户的身份凭证，通过解密，可以获取到一部分用户信息
        /// </summary>
        [JsonProperty("idToken")]
        public string IdToken { get; set; }

        /// <summary>
        /// 用来刷新用户的登录态，延长过期时间
        /// </summary>
        [JsonProperty("refreshToken")]
        public string RefreshToken { get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        [JsonProperty("expireAt")]
        public long ExpireAt { get; set; }

        /// <summary>
        /// 解析 id token 的结果，具体字段在下面有解释
        /// </summary>
        [JsonProperty("parsedIDToken")]
        public IDToken ParsedIDToken { get; set; }

        /// <summary>
        /// 解析 access token 的结果，具体字段在下面有解释
        /// </summary>
        [JsonProperty("parsedAccessToken")]
        public AccessToken ParsedAccessToken { get; set; }
    }
}
