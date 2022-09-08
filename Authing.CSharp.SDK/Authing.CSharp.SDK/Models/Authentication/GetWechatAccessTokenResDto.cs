using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Authing.CSharp.SDK.Models.Authentication
{
    /// <summary>
    /// 获取 Authing 服务器缓存的微信小程序、公众号 Access Token 结果类
    /// </summary>
    public class GetWechatAccessTokenResDto
    {
        /// <summary>
        /// 业务状态码，可以通过此状态码判断操作是否成功，200 表示成功。
        /// </summary>
        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        /// <summary>
        /// 描述信息
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        /// 细分错误码，可通过此错误码得到具体的错误类型。
        /// </summary>
        [JsonProperty("apiCode")]
        public int ApiCode { get; set; }

        /// <summary>
        /// 响应数据
        /// </summary>
        [JsonProperty("data")]
        public WechatTokenRes Data { get; set; }
    }

    public class WechatTokenRes
    {
        /// <summary>
        /// Authing 服务器缓存的微信 Access Token
        /// </summary>
        [JsonProperty("accessToken")]
        public string AccessToken { get; set; }

        /// <summary>
        /// Access Token 到期时间，为单位为秒的时间戳
        /// </summary>
        [JsonProperty("expiresAt")]
        public int expiresAt { get; set; }
    }

}
