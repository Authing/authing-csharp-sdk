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
    /// GetUserResourceStructDto 的模型
    /// </summary>
    public partial class GetUserResourceStructDto
    {
        /// <summary>
        ///  数据资源 Code
        /// </summary>
        [JsonProperty("resourceCode")]
        public string  ResourceCode {get;set;}
        /// <summary>
        ///  用户 ID 
        /// </summary>
        [JsonProperty("userId")]
        public string  UserId {get;set;}
        /// <summary>
        ///  权限空间 Code
        /// </summary>
        [JsonProperty("namespaceCode")]
        public string  NamespaceCode {get;set;}
    }
}