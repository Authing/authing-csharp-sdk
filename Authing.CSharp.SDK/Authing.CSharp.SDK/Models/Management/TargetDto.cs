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
    /// TargetDto 的模型
    /// </summary>
    public partial class TargetDto
    {
        /// <summary>
        ///  目标类型，接受用户，部门
        /// </summary>
        [JsonProperty("targetType")]
        public targetType TargetType { get; set; }
        /// <summary>
        ///  目标的 ID
        /// </summary>
        [JsonProperty("targetIdentifier")]
        public string TargetIdentifier { get; set; }
    }
    public partial class TargetDto
    {
        /// <summary>
        ///  目标类型，接受用户，部门
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