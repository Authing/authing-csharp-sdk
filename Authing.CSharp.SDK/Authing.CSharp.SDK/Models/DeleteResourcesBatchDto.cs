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
    /// DeleteResourcesBatchDto 的模型
    /// </summary>
    public partial class DeleteResourcesBatchDto
    {
        /// <summary>
        ///  所属权限分组(权限空间)的 Code
        /// </summary>
        [JsonProperty("namespace")]
        public string  Namespace {get;set;}
        /// <summary>
        ///  资源 Code 列表
        /// </summary>
        [JsonProperty("codeList")]
        public List<string>  CodeList {get;set;}
        /// <summary>
        ///  资源 Id 列表
        /// </summary>
        [JsonProperty("ids")]
        public List<string>  Ids {get;set;}
    }
}