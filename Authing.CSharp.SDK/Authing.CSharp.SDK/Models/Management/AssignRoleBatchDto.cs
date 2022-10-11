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
    /// AssignRoleBatchDto 的模型
    /// </summary>
    public partial class AssignRoleBatchDto
    {
        /// <summary>
        ///  分配角色的目标列表
        /// </summary>
        [JsonProperty("targets")]
        public List<TargetDto> Targets { get; set; }
        /// <summary>
        ///  角色信息列表
        /// </summary>
        [JsonProperty("roles")]
        public List<RoleCodeDto> Roles { get; set; }
    }
}