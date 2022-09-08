using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Authing.CSharp.SDK.Models.Authentication
{
    /// <summary>
    /// 获取 Authing 服务器缓存的微信小程序、公众号 Access Token 参数类
    /// </summary>
    public class GetWechatAccessTokenDto
    {
        /// <summary>
        /// 微信小程序或微信公众号的 AppId
        /// </summary>
        [JsonProperty("appId")]
        public string AppId { get; set; }

        /// <summary>
        /// 微信小程序或微信公众号的 AppSecret
        /// </summary>
        [JsonProperty("appSecret")]
        public string AppSecret { get; set; }
    }
}
