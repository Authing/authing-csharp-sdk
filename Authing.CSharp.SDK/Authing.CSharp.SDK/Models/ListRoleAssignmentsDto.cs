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
    /// ListRoleAssignmentsDto 的模型
    /// </summary>
    public partial class ListRoleAssignmentsDto
    {
        /// <summary>
        ///  角色 code,只能使用字母、数字和 -_，最多 50 字符
        /// </summary>
        [JsonProperty("roleCode")]
        public string  RoleCode {get;set;} 
        /// <summary>
        ///  当前页数，从 1 开始
        /// </summary>
        [JsonProperty("page")]
        public long  Page {get;set;} =1;
        /// <summary>
        ///  每页数目，最大不能超过 50，默认为 10
        /// </summary>
        [JsonProperty("limit")]
        public long  Limit {get;set;} =10;
        /// <summary>
        ///  按角色 Code 或者角色名称查询
        /// </summary>
        [JsonProperty("query")]
        public string  Query {get;set;} 
        /// <summary>
        ///  权限空间code
        /// </summary>
        [JsonProperty("namespaceCode")]
        public string  NamespaceCode {get;set;} 
        /// <summary>
        ///  目标类型，接受用户，部门
        /// </summary>
        [JsonProperty("targetType")]
        public string  TargetType {get;set;} 
    }
}