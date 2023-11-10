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
    /// CreateAccessKeyDto 的模型
    /// </summary>
    public partial class CreateAccessKeyDto
    {
        /// <summary>
        ///  密钥类型
        /// </summary>
        [JsonProperty("type")]
        public string  Type {get;set;}
        /// <summary>
        ///  密钥所属用户 ID
        /// </summary>
        [JsonProperty("userId")]
        public string  UserId {get;set;}
        /// <summary>
        ///  密钥所属租户 ID
        /// </summary>
        [JsonProperty("tenantId")]
        public string  TenantId {get;set;}
    }
}