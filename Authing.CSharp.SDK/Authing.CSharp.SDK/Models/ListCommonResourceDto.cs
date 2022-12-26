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
    /// ListCommonResourceDto 的模型
    /// </summary>
    public partial class ListCommonResourceDto
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
        ///  查询条件
        /// </summary>
        [JsonProperty("keyword")]
        public string  Keyword {get;set;} 
        /// <summary>
        ///  权限空间列表
        /// </summary>
        [JsonProperty("namespaceCodeList")]
        public string  NamespaceCodeList {get;set;} 
    }
}