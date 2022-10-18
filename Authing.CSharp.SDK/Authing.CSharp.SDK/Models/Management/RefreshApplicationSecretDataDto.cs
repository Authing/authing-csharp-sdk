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
    /// RefreshApplicationSecretDataDto 的模型
    /// </summary>
    public partial class RefreshApplicationSecretDataDto
    {
        /// <summary>
        ///  新的应用密钥
        /// </summary>
        [JsonProperty("secret")]
        public string Secret { get; set; }
    }
}