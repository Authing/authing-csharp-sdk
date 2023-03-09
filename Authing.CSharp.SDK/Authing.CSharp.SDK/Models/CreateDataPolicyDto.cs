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
    /// CreateDataPolicyDto 的模型
    /// </summary>
    public partial class CreateDataPolicyDto
    {
        /// <summary>
        ///  数据权限列表，策略下数据资源权限列表
        /// </summary>
        [JsonProperty("statementList")]
        public List<DataStatementPermissionDto>  StatementList  {get;set;}
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
    }
}