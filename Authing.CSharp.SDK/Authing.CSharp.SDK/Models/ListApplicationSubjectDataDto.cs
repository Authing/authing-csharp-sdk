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
    /// ListApplicationSubjectDataDto 的模型
    /// </summary>
    public partial class ListApplicationSubjectDataDto
    {
        /// <summary>
        ///  应用 ID
        /// </summary>
        [JsonProperty("appId")]
        public string  AppId {get;set;}
        /// <summary>
        ///  应用 logo
        /// </summary>
        [JsonProperty("logo")]
        public string  Logo {get;set;}
        [JsonProperty("ext")]
        public string  Ext {get;set;}
        [JsonProperty("template")]
        public string  Template {get;set;}
        /// <summary>
        ///  应用类型：集成应用/自建应用
        /// </summary>
        [JsonProperty("appType")]
        public appType  AppType {get;set;}
        /// <summary>
        ///  允许/拒绝
        /// </summary>
        [JsonProperty("effect")]
        public effect  Effect {get;set;}
    }
    public partial class ListApplicationSubjectDataDto
    {
        /// <summary>
        ///  应用类型：集成应用/自建应用
        /// </summary>
        public enum appType
        {
            [EnumMember(Value="INTEGRATED")]
            INTEGRATED,
            [EnumMember(Value="SELFBUILT")]
            SELFBUILT,
        }
        /// <summary>
        ///  允许/拒绝
        /// </summary>
        public enum effect
        {
            [EnumMember(Value="ALLOW")]
            ALLOW,
            [EnumMember(Value="DENY")]
            DENY,
        }
    }
}