using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Authing.CSharp.SDK.Models
{
    /// <summary>
    /// GetWechatAccessTokenDataDto 的模型
    /// </summary>
    public partial class GetWechatAccessTokenDataDto
    {
        /// <summary>
        ///  Authing 服务器缓存的微信 Access Token
        /// </summary>
        [JsonProperty("accessToken")]
        public    string   AccessToken    {get;set;}
        /// <summary>
        ///  Access Token 到期时间，为单位为秒的时间戳
        /// </summary>
        [JsonProperty("expiresAt")]
        public    long   ExpiresAt    {get;set;}
    }
}