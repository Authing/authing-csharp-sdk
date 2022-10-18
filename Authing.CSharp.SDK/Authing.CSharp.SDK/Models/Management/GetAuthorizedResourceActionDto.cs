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
    /// GetAuthorizedResourceActionDto 的模型
    /// </summary>
    public partial class GetAuthorizedResourceActionDto
    {
        /// <summary>
        ///  AND or OR
        /// </summary>
        [JsonProperty("op")]
        public op Op { get; set; }
        /// <summary>
        ///  Action 列表
        /// </summary>
        [JsonProperty("list")]
        public List<string> List { get; set; }
    }
    public partial class GetAuthorizedResourceActionDto
    {
        /// <summary>
        ///  AND or OR
        /// </summary>
        public enum op
        {
            [EnumMember(Value = "AND")]
            AND,
            [EnumMember(Value = "OR")]
            OR,
        }
    }
}