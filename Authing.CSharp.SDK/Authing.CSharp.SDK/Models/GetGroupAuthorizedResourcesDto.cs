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
    /// GetGroupAuthorizedResourcesDto 的模型
    /// </summary>
    public partial class GetGroupAuthorizedResourcesDto
    {
        /// <summary>
        ///  分组 code
        /// </summary>
        [JsonProperty("code")]
        public string  Code {get;set;} 
        /// <summary>
        ///  所属权限分组的 code
        /// </summary>
        [JsonProperty("namespace")]
        public string  Namespace {get;set;} 
        /// <summary>
        ///  资源类型
        /// </summary>
        [JsonProperty("resourceType")]
        public string  ResourceType {get;set;} 
    }
}