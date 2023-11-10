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
    /// ListTenantAdminDto 的模型
    /// </summary>
    public partial class ListTenantAdminDto
    {
        /// <summary>
        ///  租户 ID
        /// </summary>
        [JsonProperty("tenantId")]
        public string  TenantId {get;set;}
        /// <summary>
        ///  搜索关键字
        /// </summary>
        [JsonProperty("keywords")]
        public string  Keywords {get;set;}
        /// <summary>
        ///  页码
        /// </summary>
        [JsonProperty("page")]
        public string  Page {get;set;}
        /// <summary>
        ///  每页获取的数据量
        /// </summary>
        [JsonProperty("limit")]
        public string  Limit {get;set;}
    }
}