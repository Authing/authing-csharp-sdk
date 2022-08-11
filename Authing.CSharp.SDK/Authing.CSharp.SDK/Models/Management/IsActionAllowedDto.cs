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
    /// IsActionAllowedDto 的模型
    /// </summary>
    public partial class IsActionAllowedDto
    {
        /// <summary>
        ///  资源对应的操作
        /// </summary>
        [JsonProperty("action")]
        public string Action { get; set; }
        /// <summary>
        ///  资源标识符
        /// </summary>
        [JsonProperty("resource")]
        public string Resource { get; set; }
        /// <summary>
        ///  用户 ID
        /// </summary>
        [JsonProperty("userId")]
        public string UserId { get; set; }
        /// <summary>
        ///  所属权限分组的 code
        /// </summary>
        [JsonProperty("namespace")]
        public string Namespace { get; set; }
    }
}