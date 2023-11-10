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
    /// ListTenantUserDto 的模型
    /// </summary>
    public partial class ListTenantUserDto
    {
        /// <summary>
        ///  租户 ID
        /// </summary>
        [JsonProperty("tenantId")]
        public string  TenantId {get;set;}
        /// <summary>
        ///  搜索关键字
        /// </summary>
        [JsonProperty("keywords")]
        public string  Keywords {get;set;}
        /// <summary>
        ///  可选项
        /// </summary>
        [JsonProperty("options")]
        public ListTenantUsersOptionsDto  Options {get;set;}
    }
}