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
    /// UpdateExtIdpDto 的模型
    /// </summary>
    public partial class UpdateExtIdpDto
    {
        /// <summary>
        ///  身份源 ID
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
        /// <summary>
        ///  名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}