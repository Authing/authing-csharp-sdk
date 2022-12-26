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
    /// UpdateDataPolicyRespDto 的模型
    /// </summary>
    public partial class UpdateDataPolicyRespDto
    {
        /// <summary>
        ///  数据策略 ID
        /// </summary>
        [JsonProperty("policyId")]
        public string  PolicyId {get;set;}
        /// <summary>
        ///  数据策略名称，用户池唯一
        /// </summary>
        [JsonProperty("policyName")]
        public string  PolicyName {get;set;}
        /// <summary>
        ///  数据策略描述
        /// </summary>
        [JsonProperty("description")]
        public string  Description {get;set;}
        /// <summary>
        ///  数据策略创建时间
        /// </summary>
        [JsonProperty("createdAt")]
        public string  CreatedAt {get;set;}
        /// <summary>
        ///  数据策略更新时间
        /// </summary>
        [JsonProperty("updatedAt")]
        public string  UpdatedAt {get;set;}
    }
}