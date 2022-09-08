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
    /// GetNamespaceDto 的模型
    /// </summary>
    public partial class GetNamespaceDto
    {
        /// <summary>
        ///  权限分组唯一标志符
        /// </summary>
        [JsonProperty("code")]
        public    object   Code    {get;set;}
    }
}