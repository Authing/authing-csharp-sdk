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
    /// RolesDto 的模型
    /// </summary>
    public partial class RolesDto
    {
        /// <summary>
        ///  用户描述
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
        /// <summary>
        ///  用户识别码，权限组下唯一
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }
        /// <summary>
        ///  权限分组
        /// </summary>
        [JsonProperty("namespace")]
        public string Namespace { get; set; }
    }
}