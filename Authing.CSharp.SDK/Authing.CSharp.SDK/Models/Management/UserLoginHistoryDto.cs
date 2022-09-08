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
    /// UserLoginHistoryDto 的模型
    /// </summary>
    public partial class UserLoginHistoryDto
    {
        /// <summary>
        ///  App ID
        /// </summary>
        [JsonProperty("appId")]
        public    string   AppId    {get;set;}
        /// <summary>
        ///  App 名称
        /// </summary>
        [JsonProperty("appName")]
        public    string   AppName    {get;set;}
        /// <summary>
        ///  App Logo
        /// </summary>
        [JsonProperty("appLogo")]
        public    string   AppLogo    {get;set;}
        /// <summary>
        ///  App 登录地址
        /// </summary>
        [JsonProperty("appLoginUrl")]
        public    string   AppLoginUrl    {get;set;}
        /// <summary>
        ///  客户端 IP
        /// </summary>
        [JsonProperty("clientIp")]
        public    string   ClientIp    {get;set;}
        /// <summary>
        ///  登录时使用的 user agent
        /// </summary>
        [JsonProperty("userAgent")]
        public    string   UserAgent    {get;set;}
        /// <summary>
        ///  登录时间
        /// </summary>
        [JsonProperty("time")]
        public    string   Time    {get;set;}
    }
}