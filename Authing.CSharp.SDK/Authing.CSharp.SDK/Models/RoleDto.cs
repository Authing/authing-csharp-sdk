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
    /// RoleDto 的模型
    /// </summary>
    public partial class RoleDto
    {
        /// <summary>
        ///  权限分组(权限空间)内角色的唯一标识符 Code
        /// </summary>
        [JsonProperty("code")]
        public string  Code {get;set;}
        /// <summary>
        ///  权限分组(权限空间)内角色名称
        /// </summary>
        [JsonProperty("name")]
        public string  Name {get;set;}
        /// <summary>
        ///  角色描述
        /// </summary>
        [JsonProperty("description")]
        public string  Description {get;set;}
        /// <summary>
        ///  所属权限分组(权限空间)的 Code
        /// </summary>
        [JsonProperty("namespace")]
        public string  Namespace {get;set;}
        /// <summary>
        ///  所属权限分组(权限空间)的名称
        /// </summary>
        [JsonProperty("namespaceName")]
        public string  NamespaceName {get;set;}
    }
}