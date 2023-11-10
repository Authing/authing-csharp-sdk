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
    /// DeleteAdminRoleDto 的模型
    /// </summary>
    public partial class DeleteAdminRoleDto
    {
        /// <summary>
        ///  角色 code 列表
        /// </summary>
        [JsonProperty("codeList")]
        public List<string>  CodeList {get;set;}
    }
}