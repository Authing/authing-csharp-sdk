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
    /// ListApplicationAuthDataDto 的模型
    /// </summary>
    public partial class ListApplicationAuthDataDto
    {
        /// <summary>
        ///  授权 id
        /// </summary>
        [JsonProperty("id")]
        public string  Id {get;set;}
        /// <summary>
        ///  主体 id
        /// </summary>
        [JsonProperty("targetId")]
        public string  TargetId {get;set;}
        /// <summary>
        ///  主体名称
        /// </summary>
        [JsonProperty("targetName")]
        public string  TargetName {get;set;}
        /// <summary>
        ///  主体类型，USER/ORG/GROUP/ROLE
        /// </summary>
        [JsonProperty("targetType")]
        public targetType  TargetType {get;set;}
        /// <summary>
        ///  主体类型，ALLOW/DENY
        /// </summary>
        [JsonProperty("effect")]
        public effect  Effect {get;set;}
        /// <summary>
        ///  授权开关
        /// </summary>
        [JsonProperty("enabled")]
        public bool  Enabled {get;set;}
        /// <summary>
        ///  授权类型, ALL:所有人 SUBJECT:主体
        /// </summary>
        [JsonProperty("permissionType")]
        public permissionType  PermissionType {get;set;}
    }
    public partial class ListApplicationAuthDataDto
    {
        /// <summary>
        ///  主体类型，USER/ORG/GROUP/ROLE
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
        /// <summary>
        ///  主体类型，ALLOW/DENY
        /// </summary>
        public enum effect
        {
            [EnumMember(Value="ALLOW")]
            ALLOW,
            [EnumMember(Value="DENY")]
            DENY,
        }
        /// <summary>
        ///  授权类型, ALL:所有人 SUBJECT:主体
        /// </summary>
        public enum permissionType
        {
            [EnumMember(Value="ALL")]
            ALL,
            [EnumMember(Value="SUBJECT")]
            SUBJECT,
        }
    }
}