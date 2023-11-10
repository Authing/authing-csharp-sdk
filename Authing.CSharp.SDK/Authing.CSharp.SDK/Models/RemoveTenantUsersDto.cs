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
    /// RemoveTenantUsersDto 的模型
    /// </summary>
    public partial class RemoveTenantUsersDto
    {
        /// <summary>
        ///  租户 ID
        /// </summary>
        [JsonProperty("tenantId")]
        public string  TenantId {get;set;}
        /// <summary>
        ///  关联的用户池级别的用户 ID
        /// </summary>
        [JsonProperty("linkUserIds")]
        public List<string>  LinkUserIds {get;set;}
        /// <summary>
        ///  租户成员 ID
        /// </summary>
        [JsonProperty("memberIds")]
        public List<string>  MemberIds {get;set;}
    }
}