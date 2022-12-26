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
    /// ListDataResourcesDto 的模型
    /// </summary>
    public partial class ListDataResourcesDto
    {
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
        /// <summary>
        ///  关键字搜索，可以是数据资源名称或者数据资源 Code
        /// </summary>
        [JsonProperty("query")]
        public string  Query {get;set;} 
        /// <summary>
        ///  权限数据所属权限空间 Code 列表
        /// </summary>
        [JsonProperty("namespaceCodes")]
        public string  NamespaceCodes {get;set;} 
    }
}