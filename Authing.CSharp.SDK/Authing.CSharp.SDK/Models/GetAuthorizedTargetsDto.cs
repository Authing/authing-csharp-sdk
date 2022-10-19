using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Authing.CSharp.SDK.Models.Management;

namespace Authing.CSharp.SDK.Models.Management
{
    /// <summary>
    /// GetAuthorizedTargetsDto 的模型
    /// </summary>
    public partial class GetAuthorizedTargetsDto
    {
        /// <summary>
        ///  资源
        /// </summary>
        [JsonProperty("resource")]
        public string Resource { get; set; }
        /// <summary>
        ///  权限分组
        /// </summary>
        [JsonProperty("namespace")]
        public string Namespace { get; set; }
        /// <summary>
        ///  资源类型
        /// </summary>
        [JsonProperty("resourceType")]
        public resourceType ResourceType { get; set; }
        /// <summary>
        ///  主体类型
        /// </summary>
        [JsonProperty("targetType")]
        public targetType TargetType { get; set; }
        /// <summary>
        ///  Action 列表
        /// </summary>
        [JsonProperty("actions")]
        public GetAuthorizedResourceActionDto Actions { get; set; }
    }
    public partial class GetAuthorizedTargetsDto
    {
        /// <summary>
        ///  资源类型
        /// </summary>
        public enum resourceType
        {
            [EnumMember(Value = "DATA")]
            DATA,
            [EnumMember(Value = "API")]
            API,
            [EnumMember(Value = "MENU")]
            MENU,
            [EnumMember(Value = "BUTTON")]
            BUTTON,
            [EnumMember(Value = "UI")]
            UI,
        }
        /// <summary>
        ///  主体类型
        /// </summary>
        public enum targetType
        {
            [EnumMember(Value = "USER")]
            USER,
            [EnumMember(Value = "ROLE")]
            ROLE,
            [EnumMember(Value = "GROUP")]
            GROUP,
            [EnumMember(Value = "DEPARTMENT")]
            DEPARTMENT,
        }
    }
}