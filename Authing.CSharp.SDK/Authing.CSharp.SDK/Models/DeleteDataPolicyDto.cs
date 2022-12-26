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
    /// DeleteDataPolicyDto 的模型
    /// </summary>
    public partial class DeleteDataPolicyDto
    {
        /// <summary>
        ///  数据策略 ID
        /// </summary>
        [JsonProperty("policyId")]
        public string  PolicyId {get;set;}
    }
}