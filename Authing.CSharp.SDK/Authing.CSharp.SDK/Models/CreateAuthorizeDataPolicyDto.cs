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
    /// CreateAuthorizeDataPolicyDto 的模型
    /// </summary>
    public partial class CreateAuthorizeDataPolicyDto
    {
        /// <summary>
        ///  数据权限列表，每个策略下所有的数据权限
        /// </summary>
        [JsonProperty("targetList")]
        public List<SubjectDto>  TargetList  {get;set;}
        /// <summary>
        ///  数据策略 id 列表
        /// </summary>
        [JsonProperty("policyIds")]
        public List<string>  PolicyIds  {get;set;}
    }
}