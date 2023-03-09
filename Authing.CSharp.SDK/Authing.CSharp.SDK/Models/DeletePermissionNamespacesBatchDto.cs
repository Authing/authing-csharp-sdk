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
    /// DeletePermissionNamespacesBatchDto 的模型
    /// </summary>
    public partial class DeletePermissionNamespacesBatchDto
    {
        /// <summary>
        ///  权限分组 code 列表
        /// </summary>
        [JsonProperty("codes")]
        public List<string>  Codes  {get;set;}
    }
}