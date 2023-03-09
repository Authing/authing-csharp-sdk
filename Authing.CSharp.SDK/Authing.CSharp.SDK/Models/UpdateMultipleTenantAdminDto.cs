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
    /// UpdateMultipleTenantAdminDto 的模型
    /// </summary>
    public partial class UpdateMultipleTenantAdminDto
    {
        /// <summary>
        ///  租户 ID
        /// </summary>
        [JsonProperty("tenantIds")]
        public List<string>  TenantIds  {get;set;}
        /// <summary>
        ///  是否授权
        /// </summary>
        [JsonProperty("apiAuthorized")]
        public bool  ApiAuthorized  {get;set;}
    }
}