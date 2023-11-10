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
    /// CreateAdminRoleDto 的模型
    /// </summary>
    public partial class CreateAdminRoleDto
    {
        /// <summary>
        ///  管理员角色名称
        /// </summary>
        [JsonProperty("name")]
        public string  Name {get;set;}
        /// <summary>
        ///  管理员角色的唯一标识符
        /// </summary>
        [JsonProperty("code")]
        public string  Code {get;set;}
        /// <summary>
        ///  角色描述
        /// </summary>
        [JsonProperty("description")]
        public string  Description {get;set;}
    }
}