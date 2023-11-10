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
    /// GetPublicAccountsOfRoleDto 的模型
    /// </summary>
    public partial class GetPublicAccountsOfRoleDto
    {
        /// <summary>
        ///  角色 ID
        /// </summary>
        [JsonProperty("roleId")]
        public string  RoleId {get;set;} 
    }
}