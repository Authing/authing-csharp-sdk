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
    /// GetSubjectAuthDataDto 的模型
    /// </summary>
    public partial class GetSubjectAuthDataDto
    {
        /// <summary>
        ///  应用 ID
        /// </summary>
        [JsonProperty("appId")]
        public string  AppId {get;set;}
        /// <summary>
        ///  应用名称
        /// </summary>
        [JsonProperty("appName")]
        public string  AppName {get;set;}
        /// <summary>
        ///  请求的主体id
        /// </summary>
        [JsonProperty("reqTargetId")]
        public string  ReqTargetId {get;set;}
        /// <summary>
        ///  请求的主体名称
        /// </summary>
        [JsonProperty("reqTargetName")]
        public string  ReqTargetName {get;set;}
        /// <summary>
        ///  请求的主体类型
        /// </summary>
        [JsonProperty("reqTargetType")]
        public reqTargetType  ReqTargetType {get;set;}
        /// <summary>
        ///  目标主体类型
        /// </summary>
        [JsonProperty("targetType")]
        public targetType  TargetType {get;set;}
        /// <summary>
        ///  目标主体名称
        /// </summary>
        [JsonProperty("targetName")]
        public string  TargetName {get;set;}
        /// <summary>
        ///  授权类型
        /// </summary>
        [JsonProperty("authType")]
        public authType  AuthType {get;set;}
    }
    public partial class GetSubjectAuthDataDto
    {
        /// <summary>
        ///  请求的主体类型
        /// </summary>
        public enum reqTargetType
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
        ///  目标主体类型
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
        ///  授权类型
        /// </summary>
        public enum authType
        {
            [EnumMember(Value="DEFAULT")]
            DEFAULT,
            [EnumMember(Value="ALL")]
            ALL,
            [EnumMember(Value="SELF")]
            SELF,
            [EnumMember(Value="SUBJECT")]
            SUBJECT,
        }
    }
}