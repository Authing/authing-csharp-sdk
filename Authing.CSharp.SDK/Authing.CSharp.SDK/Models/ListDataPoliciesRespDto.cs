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
    /// ListDataPoliciesRespDto 的模型
    /// </summary>
    public partial class ListDataPoliciesRespDto
    {
        /// <summary>
        ///  数据策略名称，用户池唯一
        /// </summary>
        [JsonProperty("policyName")]
        public string  PolicyName  {get;set;}
        /// <summary>
        ///  数据策略描述
        /// </summary>
        [JsonProperty("description")]
        public string  Description  {get;set;}
        /// <summary>
        ///  数据权限列表，每个策略下所有的数据资源 ID 和名称
        /// </summary>
        [JsonProperty("resourceList")]
        public List<DataResourceSimpleRespDto>  ResourceList  {get;set;}
        /// <summary>
        ///  数据策略 ID
        /// </summary>
        [JsonProperty("policyId")]
        public string  PolicyId  {get;set;}
        /// <summary>
        ///  主体对象列表,包含数据策略下所有的主体对象,包括 USER、GROUP、ROLE、ORG
        /// </summary>
        [JsonProperty("targetList")]
        public List<SubjectRespDto>  TargetList  {get;set;}
        /// <summary>
        ///  数据策略更新时间
        /// </summary>
        [JsonProperty("updatedAt")]
        public string  UpdatedAt  {get;set;}
    }
}