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
    /// GetTenantByCodeDto 的模型
    /// </summary>
    public partial class GetTenantByCodeDto
    {
        /// <summary>
        ///  租户 Code
        /// </summary>
        [JsonProperty("code")]
        public string  Code {get;set;} 
    }
}