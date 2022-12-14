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
    /// GetNamespacesBatchDto 的模型
    /// </summary>
    public partial class GetNamespacesBatchDto
    {
        /// <summary>
        ///  权限分组 code 列表，批量可以使用逗号分隔
        /// </summary>
        [JsonProperty("codeList")]
        public string  CodeList {get;set;} 
    }
}