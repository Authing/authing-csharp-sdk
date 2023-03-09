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
    /// GenerateInviteTenantUserLink 的模型
    /// </summary>
    public partial class GenerateInviteTenantUserLink
    {
        /// <summary>
        ///  链接有效期
        /// </summary>
        [JsonProperty("validityTerm")]
        public string  ValidityTerm  {get;set;}
        /// <summary>
        ///  要邀请的用户邮箱
        /// </summary>
        [JsonProperty("emails")]
        public List<string>  Emails  {get;set;}
        /// <summary>
        ///  应用 ID
        /// </summary>
        [JsonProperty("appId")]
        public string  AppId  {get;set;}
        /// <summary>
        ///  租户 ID
        /// </summary>
        [JsonProperty("tenantId")]
        public string  TenantId  {get;set;}
    }
}