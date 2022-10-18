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
    /// UserLoggedInIdentitiesDto 的模型
    /// </summary>
    public partial class UserLoggedInIdentitiesDto
    {
        /// <summary>
        ///  Identity ID
        /// </summary>
        [JsonProperty("identityId")]
        public string IdentityId { get; set; }
        /// <summary>
        ///  身份源名称
        /// </summary>
        [JsonProperty("idpName")]
        public string IdpName { get; set; }
        /// <summary>
        ///  Identity provider name
        /// </summary>
        [JsonProperty("idpNameEn")]
        public string IdpNameEn { get; set; }
        /// <summary>
        ///  身份源 logo
        /// </summary>
        [JsonProperty("idpLogo")]
        public string IdpLogo { get; set; }
    }
}