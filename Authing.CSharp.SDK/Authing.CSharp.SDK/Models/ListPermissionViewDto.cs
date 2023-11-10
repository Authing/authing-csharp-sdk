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
    /// ListPermissionViewDto 的模型
    /// </summary>
    public partial class ListPermissionViewDto
    {
        /// <summary>
        ///  当前页数，从 1 开始
        /// </summary>
        [JsonProperty("page")]
        public long  Page {get;set;}
        /// <summary>
        ///  每页数目，最大不能超过 50，默认为 10
        /// </summary>
        [JsonProperty("limit")]
        public long  Limit {get;set;}
        /// <summary>
        ///  关键字搜索,可以支持 userName 搜索
        /// </summary>
        [JsonProperty("keyword")]
        public string  Keyword {get;set;}
    }
}