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
    /// GetDataPolicyDto 的模型
    /// </summary>
    public partial class GetDataPolicyDto
    {
        /// <summary>
        ///  数据策略 ID
        /// </summary>
        [JsonProperty("policyId")]
        public string  PolicyId {get;set;} 
    }
}