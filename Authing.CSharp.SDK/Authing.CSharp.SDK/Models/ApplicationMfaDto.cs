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
    /// ApplicationMfaDto 的模型
    /// </summary>
    public partial class ApplicationMfaDto
    {
        /// <summary>
        ///  MFA 类型
        /// </summary>
        [JsonProperty("mfaPolicy")]
        public string  MfaPolicy {get;set;}
        /// <summary>
        ///  MFA 状态
        /// </summary>
        [JsonProperty("status")]
        public long  Status {get;set;}
        /// <summary>
        ///  MFA 排序
        /// </summary>
        [JsonProperty("sort")]
        public long  Sort {get;set;}
    }
}