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
    /// RoleAuthorizedResourcesRespDto 的模型
    /// </summary>
    public partial class RoleAuthorizedResourcesRespDto
    {
        /// <summary>
        ///  资源描述符
        /// </summary>
        [JsonProperty("resourceCode")]
        public string ResourceCode { get; set; }
        /// <summary>
        ///  资源类型
        /// </summary>
        [JsonProperty("resourceType")]
        public resourceType ResourceType { get; set; }
        /// <summary>
        ///  被授权的操作列表
        /// </summary>
        [JsonProperty("actions")]
        public List<string> Actions { get; set; }
        /// <summary>
        ///  资源对应的 API Identifier
        /// </summary>
        [JsonProperty("apiIdentifier")]
        public string ApiIdentifier { get; set; }
    }
    public partial class RoleAuthorizedResourcesRespDto
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
    }
}