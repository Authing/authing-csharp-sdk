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
    /// ListTenantCooperatorsDto 的模型
    /// </summary>
    public partial class ListTenantCooperatorsDto
    {
        /// <summary>
        ///  搜索关键字
        /// </summary>
        [JsonProperty("keywords")]
        public string  Keywords {get;set;} 
        /// <summary>
        ///  是否外部
        /// </summary>
        [JsonProperty("external")]
        public bool  External {get;set;} 
        /// <summary>
        ///  页码
        /// </summary>
        [JsonProperty("page")]
        public int  Page {get;set;} =1;
        /// <summary>
        ///  每页获取的数据量
        /// </summary>
        [JsonProperty("limit")]
        public int  Limit {get;set;} =10;
    }
}