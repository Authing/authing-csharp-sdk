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
    /// DeleteResourceDto 的模型
    /// </summary>
    public partial class DeleteResourceDto
    {
        /// <summary>
        ///  资源唯一标志符
        /// </summary>
        [JsonProperty("code")]
        public string  Code {get;set;}
        /// <summary>
        ///  所属权限分组(权限空间)的 Code
        /// </summary>
        [JsonProperty("namespace")]
        public string  Namespace {get;set;}
    }
}