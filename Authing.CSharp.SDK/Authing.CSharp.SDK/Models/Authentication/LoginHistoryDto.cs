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
    /// LoginHistoryDto 的模型
    /// </summary>
    public partial class LoginHistoryDto
    {
        /// <summary>
        ///  用户 ID
        /// </summary>
        [JsonProperty("userId")]
        public string UserId { get; set; }
        /// <summary>
        ///  应用 ID
        /// </summary>
        [JsonProperty("appId")]
        public string AppId { get; set; }
        /// <summary>
        ///  应用名称
        /// </summary>
        [JsonProperty("appName")]
        public string AppName { get; set; }
        /// <summary>
        ///  应用登录地址
        /// </summary>
        [JsonProperty("appLoginUrl")]
        public string AppLoginUrl { get; set; }
        /// <summary>
        ///  应用 Logo
        /// </summary>
        [JsonProperty("appLogo")]
        public string AppLogo { get; set; }
        /// <summary>
        ///  登录时间
        /// </summary>
        [JsonProperty("loginAt")]
        public string LoginAt { get; set; }
        /// <summary>
        ///  登录时使用的客户端 IP
        /// </summary>
        [JsonProperty("clientIp")]
        public string ClientIp { get; set; }
        /// <summary>
        ///  是否登录成功
        /// </summary>
        [JsonProperty("success")]
        public bool Success { get; set; }
        /// <summary>
        ///  登录失败时的具体错误信息
        /// </summary>
        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }
        /// <summary>
        ///  User Agent
        /// </summary>
        [JsonProperty("userAgent")]
        public string UserAgent { get; set; }
        /// <summary>
        ///  解析过后的 User Agent
        /// </summary>
        [JsonProperty("parsedUserAgent")]
        public ParsedUserAgent ParsedUserAgent { get; set; }
        /// <summary>
        ///  使用的登录方式
        /// </summary>
        [JsonProperty("loginMethod")]
        public string LoginMethod { get; set; }
        /// <summary>
        ///  地理位置
        /// </summary>
        [JsonProperty("geoip")]
        public GeoIp Geoip { get; set; }
    }
}