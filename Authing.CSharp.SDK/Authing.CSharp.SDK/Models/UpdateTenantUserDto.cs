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
    /// UpdateTenantUserDto 的模型
    /// </summary>
    public partial class UpdateTenantUserDto
    {
        /// <summary>
        ///  要更新的租户成员信息
        /// </summary>
        [JsonProperty("updates")]
        public object  Updates {get;set;}
        /// <summary>
        ///  租户 ID
        /// </summary>
        [JsonProperty("tenantId")]
        public string  TenantId {get;set;}
        /// <summary>
        ///  关联的用户池级别的用户 ID
        /// </summary>
        [JsonProperty("linkUserId")]
        public string  LinkUserId {get;set;}
        /// <summary>
        ///  租户成员 ID
        /// </summary>
        [JsonProperty("memberId")]
        public string  MemberId {get;set;}
    }
}