using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authing.CSharp.SDK.Models.Authentication
{
    public class AccessToken
    {
        /// <summary>
        /// 令牌标识符声明
        /// </summary>
        [JsonProperty("jti")]
        public string Jti { get; set; }

        /// <summary>
        /// subject 的缩写，唯一标识，一般为用户 ID
        /// </summary>
        [JsonProperty("sub")]
        public string Sub { get; set; }

        /// <summary>
        /// “Issued At”表示针对此令牌进行身份验证的时间。
        /// </summary>
        [JsonProperty("iat")]
        public long Iat { get; set; }

        /// <summary>
        /// “exp”（过期时间）声明指定只能在哪个时间（含）之前接受 JWT 的处理。
        /// </summary>
        [JsonProperty("exp")]
        public long Exp { get; set; }

        /// <summary>
        /// 应用侧向 Authing 请求的权限
        /// </summary>
        [JsonProperty("scope")]
        public string Scope { get; set; }

        /// <summary>
        /// 标识构造并返回令牌的安全令牌服务 (STS)。
        /// </summary>
        [JsonProperty("iss")]
        public string Iss { get; set; }

        /// <summary>
        /// 标识令牌的目标接收方
        /// </summary>
        [JsonProperty("aud")]
        public string Aud { get; set; }
    }



    public class JoseKey
    {
        public List<Dictionary<string, string>> keys { get; set; }
    }

    public class Key
    {
        public string e { get; set; }
        public string n { get; set; }
        public string kty { get; set; }
        public string alg { get; set; }
        public string use { get; set; }
        public string kid { get; set; }
    }

}
