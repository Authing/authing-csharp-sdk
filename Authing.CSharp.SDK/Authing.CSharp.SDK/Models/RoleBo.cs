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
    /// RoleBo 的模型
    /// </summary>
    public partial class RoleBo
    {
        /// <summary>
        ///  角色 id
        /// </summary>
        [JsonProperty("roleId")]
        public string  RoleId {get;set;}
        /// <summary>
        ///  角色名称
        /// </summary>
        [JsonProperty("roleName")]
        public string  RoleName {get;set;}
        /// <summary>
        ///  角色 Code
        /// </summary>
        [JsonProperty("roleCode")]
        public string  RoleCode {get;set;}
    }
}