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
    /// DeleteNamespaceDto 的模型
    /// </summary>
    public partial class DeleteNamespaceDto
    {
        /// <summary>
        ///  权限分组唯一标志符
        /// </summary>
        [JsonProperty("code")]
        public string  Code  {get;set;}
    }
}