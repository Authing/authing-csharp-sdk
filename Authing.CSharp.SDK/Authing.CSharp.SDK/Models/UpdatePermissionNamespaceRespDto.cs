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
    /// UpdatePermissionNamespaceRespDto 的模型
    /// </summary>
    public partial class UpdatePermissionNamespaceRespDto
    {
        /// <summary>
        ///  权限空间唯一标志符
        /// </summary>
        [JsonProperty("code")]
        public string  Code {get;set;}
        /// <summary>
        ///  权限空间名称
        /// </summary>
        [JsonProperty("name")]
        public string  Name {get;set;}
        /// <summary>
        ///  权限空间描述信息
        /// </summary>
        [JsonProperty("description")]
        public string  Description {get;set;}
    }
}