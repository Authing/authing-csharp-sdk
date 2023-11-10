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
    /// GetOrganizationDto 的模型
    /// </summary>
    public partial class GetOrganizationDto
    {
        /// <summary>
        ///  组织 Code（organizationCode）
        /// </summary>
        [JsonProperty("organizationCode")]
        public string  OrganizationCode {get;set;} 
        /// <summary>
        ///  是否获取自定义数据
        /// </summary>
        [JsonProperty("withCustomData")]
        public bool  WithCustomData {get;set;} 
        /// <summary>
        ///  是否获取 部门信息
        /// </summary>
        [JsonProperty("withPost")]
        public bool  WithPost {get;set;} 
        /// <summary>
        ///  租户 ID
        /// </summary>
        [JsonProperty("tenantId")]
        public string  TenantId {get;set;} 
    }
}