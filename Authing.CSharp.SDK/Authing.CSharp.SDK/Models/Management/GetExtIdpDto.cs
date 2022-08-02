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
    /// GetExtIdpDto 的模型
    /// </summary>
    public partial class GetExtIdpDto
    {
        /// <summary>
        ///  身份源 id
        /// </summary>
        [JsonProperty("id")]
        public    object   Id    {get;set;}
        /// <summary>
        ///  租户 ID
        /// </summary>
        [JsonProperty("tenantId")]
        public    object   TenantId    {get;set;}
    }
}