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
    /// ListResourcesDto 的模型
    /// </summary>
    public partial class ListResourcesDto
    {
        /// <summary>
        ///  所属权限分组(权限空间)的 Code
        /// </summary>
        [JsonProperty("namespace")]
        public string  Namespace {get;set;} 
        /// <summary>
        ///  资源类型
        /// </summary>
        [JsonProperty("type")]
        public string  Type {get;set;} 
        /// <summary>
        ///  当前页数，从 1 开始
        /// </summary>
        [JsonProperty("page")]
        public long  Page {get;set;} =1;
        /// <summary>
        ///  每页数目，最大不能超过 50，默认为 10
        /// </summary>
        [JsonProperty("limit")]
        public long  Limit {get;set;} =10;
    }
}