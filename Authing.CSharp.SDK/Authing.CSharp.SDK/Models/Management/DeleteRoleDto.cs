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
    /// DeleteRoleDto 的模型
    /// </summary>
    public partial class DeleteRoleDto
    {
        /// <summary>
        ///  角色 code 集合
        /// </summary>
        [JsonProperty("codeList")]
        public    List<string>   CodeList    {get;set;}
        /// <summary>
        ///  所属权限分组的 code
        /// </summary>
        [JsonProperty("namespace")]
        public    string   Namespace    {get;set;}
    }
}