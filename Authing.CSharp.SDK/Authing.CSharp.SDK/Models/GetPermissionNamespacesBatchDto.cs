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
    /// GetPermissionNamespacesBatchDto 的模型
    /// </summary>
    public partial class GetPermissionNamespacesBatchDto
    {
        /// <summary>
        ///  权限空间 code 列表，批量可以使用逗号分隔
        /// </summary>
        [JsonProperty("codes")]
        public string  Codes {get;set;} 
    }
}