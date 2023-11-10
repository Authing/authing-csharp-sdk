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
    /// ListApplicationAuthDto 的模型
    /// </summary>
    public partial class ListApplicationAuthDto
    {
        /// <summary>
        ///  应用 ID
        /// </summary>
        [JsonProperty("appId")]
        public string  AppId {get;set;}
        /// <summary>
        ///  当前页数，从 1 开始
        /// </summary>
        [JsonProperty("page")]
        public long  Page {get;set;}
        /// <summary>
        ///  每页数目，最大不能超过 50，默认为 10
        /// </summary>
        [JsonProperty("limit")]
        public long  Limit {get;set;}
        /// <summary>
        ///  主体名称
        /// </summary>
        [JsonProperty("targetName")]
        public string  TargetName {get;set;}
        /// <summary>
        ///  主体类型列表, USER/ORG/ROLE/GROUP
        /// </summary>
        [JsonProperty("targetTypeList")]
        public List<string>  TargetTypeList {get;set;}
        /// <summary>
        ///  操作，ALLOW/DENY
        /// </summary>
        [JsonProperty("effect")]
        public effect  Effect {get;set;}
        /// <summary>
        ///  授权是否生效开关,
        /// </summary>
        [JsonProperty("enabled")]
        public bool  Enabled {get;set;}
    }
    public partial class ListApplicationAuthDto
    {
        /// <summary>
        ///  操作，ALLOW/DENY
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