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
    /// GetExternalUserResourceStructDto 的模型
    /// </summary>
    public partial class GetExternalUserResourceStructDto
    {
        /// <summary>
        ///  资源 Code
        /// </summary>
        [JsonProperty("resourceCode")]
        public string  ResourceCode  {get;set;}
        /// <summary>
        ///  外部用户 ID
        /// </summary>
        [JsonProperty("externalId")]
        public string  ExternalId  {get;set;}
        /// <summary>
        ///  权限空间 Code
        /// </summary>
        [JsonProperty("namespaceCode")]
        public string  NamespaceCode  {get;set;}
    }
}