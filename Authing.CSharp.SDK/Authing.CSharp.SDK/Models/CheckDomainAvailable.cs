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
    /// CheckDomainAvailable 的模型
    /// </summary>
    public partial class CheckDomainAvailable
    {
        /// <summary>
        ///  域名
        /// </summary>
        [JsonProperty("domain")]
        public string  Domain {get;set;}
    }
}