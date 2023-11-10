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
    /// PolicyBo 的模型
    /// </summary>
    public partial class PolicyBo
    {
        /// <summary>
        ///  数据策略 id
        /// </summary>
        [JsonProperty("dataPolicyId")]
        public string  DataPolicyId {get;set;}
        /// <summary>
        ///  数据策略名称名称
        /// </summary>
        [JsonProperty("dataPolicyName")]
        public string  DataPolicyName {get;set;}
    }
}