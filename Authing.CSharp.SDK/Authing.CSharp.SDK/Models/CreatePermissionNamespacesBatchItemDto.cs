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
    /// CreatePermissionNamespacesBatchItemDto 的模型
    /// </summary>
    public partial class CreatePermissionNamespacesBatchItemDto
    {
        /// <summary>
        ///  权限空间 Code
        /// </summary>
        [JsonProperty("code")]
        public string  Code {get;set;}
        /// <summary>
        ///  权限空间名称
        /// </summary>
        [JsonProperty("name")]
        public string  Name {get;set;}
        /// <summary>
        ///  权限空间描述
        /// </summary>
        [JsonProperty("description")]
        public string  Description {get;set;}
    }
}