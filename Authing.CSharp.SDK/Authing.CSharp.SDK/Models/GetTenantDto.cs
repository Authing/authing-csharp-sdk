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
    /// GetTenantDto 的模型
    /// </summary>
    public partial class GetTenantDto
    {
        /// <summary>
        ///  租户 ID
        /// </summary>
        [JsonProperty("tenantId")]
        public string  TenantId {get;set;} 
        /// <summary>
        ///  是否增加返回租户成员统计
        /// </summary>
        [JsonProperty("withMembersCount")]
        public bool  WithMembersCount {get;set;} 
        /// <summary>
        ///  增加返回租户关联应用简单信息
        /// </summary>
        [JsonProperty("withAppDetail")]
        public bool  WithAppDetail {get;set;} 
        /// <summary>
        ///  增加返回租户下创建者简单信息
        /// </summary>
        [JsonProperty("withCreatorDetail")]
        public bool  WithCreatorDetail {get;set;} 
        /// <summary>
        ///  增加返回租户来源应用简单信息
        /// </summary>
        [JsonProperty("withSourceAppDetail")]
        public bool  WithSourceAppDetail {get;set;} 
    }
}