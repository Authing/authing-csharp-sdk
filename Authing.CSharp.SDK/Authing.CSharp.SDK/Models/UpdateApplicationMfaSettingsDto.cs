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
    /// UpdateApplicationMfaSettingsDto 的模型
    /// </summary>
    public partial class UpdateApplicationMfaSettingsDto
    {
        /// <summary>
        ///  所属应用 ID
        /// </summary>
        [JsonProperty("appId")]
        public string  AppId {get;set;}
        /// <summary>
        ///  开启的 MFA 认证因素列表
        /// </summary>
        [JsonProperty("enabledFactors")]
        public List<string>  EnabledFactors {get;set;}
        /// <summary>
        ///  关闭的 MFA 认证因素列表
        /// </summary>
        [JsonProperty("disabledFactors")]
        public List<string>  DisabledFactors {get;set;}
    }
}