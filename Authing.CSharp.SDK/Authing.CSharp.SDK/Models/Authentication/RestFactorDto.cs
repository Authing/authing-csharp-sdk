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
    /// RestFactorDto 的模型
    /// </summary>
    public partial class RestFactorDto
    {
        /// <summary>
        ///  MFA 认证要素 ID
        /// </summary>
        [JsonProperty("factorId")]
        public    string   FactorId    {get;set;}
    }
}