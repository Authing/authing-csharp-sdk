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
    /// ImportTenantHistoryDto 的模型
    /// </summary>
    public partial class ImportTenantHistoryDto
    {
        /// <summary>
        ///  页码
        /// </summary>
        [JsonProperty("page")]
        public long  Page {get;set;} =1;
        /// <summary>
        ///  每页获取的数据量
        /// </summary>
        [JsonProperty("limit")]
        public long  Limit {get;set;} =10;
    }
}