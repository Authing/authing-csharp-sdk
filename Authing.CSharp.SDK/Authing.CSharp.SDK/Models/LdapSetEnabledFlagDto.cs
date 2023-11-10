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
    /// LdapSetEnabledFlagDto 的模型
    /// </summary>
    public partial class LdapSetEnabledFlagDto
    {
        /// <summary>
        ///  开关是否开启
        /// </summary>
        [JsonProperty("enabled")]
        public bool  Enabled {get;set;}
    }
}