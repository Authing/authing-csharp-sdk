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
    /// AuthorizeResourceItem 的模型
    /// </summary>
    public partial class AuthorizeResourceItem
    {
        /// <summary>
        ///  目标对象类型
        /// </summary>
        [JsonProperty("targetType")]
        public targetType TargetType { get; set; }
        /// <summary>
        ///  目标对象唯一标志符
        /// </summary>
        [JsonProperty("targetIdentifiers")]
        public List<string> TargetIdentifiers { get; set; }
        /// <summary>
        ///  授权的资源列表
        /// </summary>
        [JsonProperty("resources")]
        public List<ResourceItemDto> Resources { get; set; }
    }
    public partial class AuthorizeResourceItem
    {
        /// <summary>
        ///  目标对象类型
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