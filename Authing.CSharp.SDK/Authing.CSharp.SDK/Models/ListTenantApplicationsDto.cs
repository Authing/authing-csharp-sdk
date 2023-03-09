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
    /// ListTenantApplicationsDto 的模型
    /// </summary>
    public partial class ListTenantApplicationsDto
    {
        /// <summary>
        ///  获取应用列表的页码
        /// </summary>
        [JsonProperty("page")]
        public int  Page {get;set;} =1;
        /// <summary>
        ///  每页获取的应用数量
        /// </summary>
        [JsonProperty("limit")]
        public int  Limit {get;set;} =10;
        /// <summary>
        ///  搜索关键字
        /// </summary>
        [JsonProperty("keywords")]
        public string  Keywords {get;set;} 
        /// <summary>
        ///  应用是否加入单点登录
        /// </summary>
        [JsonProperty("sso_enabled")]
        public bool  SsoEnabled {get;set;} 
    }
}