using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Authing.CSharp.SDK.Models.Management;

namespace Authing.CSharp.SDK.Models.Management
{
    /// <summary>
    /// AssociationResourceDto 的模型
    /// </summary>
    public partial class AssociationResourceDto
    {
        /// <summary>
        ///  应用 ID
        /// </summary>
        [JsonProperty("appId")]
        public string AppId { get; set; }
        /// <summary>
        ///  是否关联应用资源
        /// </summary>
        [JsonProperty("association")]
        public bool Association { get; set; }
        /// <summary>
        ///  资源 Code
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }
        /// <summary>
        ///  租户 ID
        /// </summary>
        [JsonProperty("tenantId")]
        public string TenantId { get; set; }
    }
}