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
    /// SendTenantEmailDto 的模型
    /// </summary>
    public partial class SendTenantEmailDto
    {
        /// <summary>
        ///  管理员名字
        /// </summary>
        [JsonProperty("adminName")]
        public string  AdminName {get;set;}
        /// <summary>
        ///  用户名
        /// </summary>
        [JsonProperty("userName")]
        public string  UserName {get;set;}
        /// <summary>
        ///  管理员邮箱
        /// </summary>
        [JsonProperty("email")]
        public string  Email {get;set;}
        /// <summary>
        ///  租户域名
        /// </summary>
        [JsonProperty("identifier")]
        public string  Identifier {get;set;}
        /// <summary>
        ///  租户 id
        /// </summary>
        [JsonProperty("tenantId")]
        public string  TenantId {get;set;}
        /// <summary>
        ///  租户名
        /// </summary>
        [JsonProperty("tenantName")]
        public string  TenantName {get;set;}
    }
}