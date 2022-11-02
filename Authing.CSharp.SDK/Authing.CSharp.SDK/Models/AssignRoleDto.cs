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
    /// AssignRoleDto 的模型
    /// </summary>
    public partial class AssignRoleDto
    {
        /// <summary>
        ///  目标对象
        /// </summary>
        [JsonProperty("targets")]
        public List<TargetDto>  Targets {get;set;}
        /// <summary>
        ///  权限分组内角色的唯一标识符
        /// </summary>
        [JsonProperty("code")]
        public string  Code {get;set;}
        /// <summary>
        ///  所属权限分组的 code
        /// </summary>
        [JsonProperty("namespace")]
        public string  Namespace {get;set;}
    }
}