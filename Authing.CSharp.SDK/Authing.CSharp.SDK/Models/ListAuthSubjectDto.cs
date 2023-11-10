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
    /// ListAuthSubjectDto 的模型
    /// </summary>
    public partial class ListAuthSubjectDto
    {
        /// <summary>
        ///  主体类型
        /// </summary>
        [JsonProperty("targetType")]
        public targetType  TargetType {get;set;}
        /// <summary>
        ///  主体 id
        /// </summary>
        [JsonProperty("targetId")]
        public string  TargetId {get;set;}
        /// <summary>
        ///  应用名称
        /// </summary>
        [JsonProperty("appName")]
        public string  AppName {get;set;}
        /// <summary>
        ///  应用类型列表
        /// </summary>
        [JsonProperty("appTypeList")]
        public List<string>  AppTypeList {get;set;}
        /// <summary>
        ///  操作类型列表
        /// </summary>
        [JsonProperty("effect")]
        public List<string>  Effect {get;set;}
        /// <summary>
        ///  开关
        /// </summary>
        [JsonProperty("enabled")]
        public bool  Enabled {get;set;}
    }
    public partial class ListAuthSubjectDto
    {
        /// <summary>
        ///  主体类型
        /// </summary>
        public enum targetType
        {
            [EnumMember(Value="USER")]
            USER,
            [EnumMember(Value="ROLE")]
            ROLE,
            [EnumMember(Value="GROUP")]
            GROUP,
            [EnumMember(Value="ORG")]
            ORG,
            [EnumMember(Value="AK_SK")]
            AK_SK,
        }
    }
}