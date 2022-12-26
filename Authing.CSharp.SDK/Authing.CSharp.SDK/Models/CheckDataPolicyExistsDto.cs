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
    /// CheckDataPolicyExistsDto 的模型
    /// </summary>
    public partial class CheckDataPolicyExistsDto
    {
        /// <summary>
        ///  数据策略名称，用户池唯一
        /// </summary>
        [JsonProperty("policyName")]
        public string  PolicyName {get;set;} 
    }
}