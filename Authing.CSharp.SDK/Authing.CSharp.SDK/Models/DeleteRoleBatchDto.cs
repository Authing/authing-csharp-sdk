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
    /// DeleteRoleBatchDto 的模型
    /// </summary>
    public partial class DeleteRoleBatchDto
    {
        /// <summary>
        ///  角色 Code 和 namespace 列表
        /// </summary>
        [JsonProperty("roleList")]
        public List<RoleCodeAndNamespaceDto>  RoleList {get;set;}
    }
}