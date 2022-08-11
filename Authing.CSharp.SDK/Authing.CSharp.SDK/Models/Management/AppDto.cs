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
    /// AppDto 的模型
    /// </summary>
    public partial class AppDto
    {
        /// <summary>
        ///  App ID
        /// </summary>
        [JsonProperty("appId")]
        public string AppId { get; set; }
        /// <summary>
        ///  App 名称
        /// </summary>
        [JsonProperty("appName")]
        public string AppName { get; set; }
        /// <summary>
        ///  App Logo
        /// </summary>
        [JsonProperty("appLogo")]
        public string AppLogo { get; set; }
        /// <summary>
        ///  App 登录地址
        /// </summary>
        [JsonProperty("appLoginUrl")]
        public string AppLoginUrl { get; set; }
        /// <summary>
        ///  App 默认的登录策略
        /// </summary>
        [JsonProperty("appDefaultLoginStrategy")]
        public appDefaultLoginStrategy AppDefaultLoginStrategy { get; set; }
    }
    public partial class AppDto
    {
        /// <summary>
        ///  App 默认的登录策略
        /// </summary>
        public enum appDefaultLoginStrategy
        {
            [EnumMember(Value = "ALLOW_ALL")]
            ALLOW_ALL,
            [EnumMember(Value = "DENY_ALL")]
            DENY_ALL,
        }
    }
}