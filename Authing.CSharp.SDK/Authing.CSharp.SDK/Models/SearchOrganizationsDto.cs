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
    /// SearchOrganizationsDto 的模型
    /// </summary>
    public partial class SearchOrganizationsDto
    {
        /// <summary>
        ///  搜索关键词，如组织机构名称
        /// </summary>
        [JsonProperty("keywords")]
        public string  Keywords {get;set;} 
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
        ///  是否获取自定义数据
        /// </summary>
        [JsonProperty("withCustomData")]
        public bool  WithCustomData {get;set;} 
        /// <summary>
        ///  租户 ID
        /// </summary>
        [JsonProperty("tenantId")]
        public string  TenantId {get;set;} 
    }
}