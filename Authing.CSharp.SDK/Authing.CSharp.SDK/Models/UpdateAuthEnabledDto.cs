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
    /// UpdateAuthEnabledDto 的模型
    /// </summary>
    public partial class UpdateAuthEnabledDto
    {
        /// <summary>
        ///  授权是否生效开关,
        /// </summary>
        [JsonProperty("enabled")]
        public bool  Enabled {get;set;}
        /// <summary>
        ///  授权 ID
        /// </summary>
        [JsonProperty("id")]
        public string  Id {get;set;}
    }
}