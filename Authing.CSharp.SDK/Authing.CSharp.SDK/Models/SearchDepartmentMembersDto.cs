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
    /// SearchDepartmentMembersDto 的模型
    /// </summary>
    public partial class SearchDepartmentMembersDto
    {
        /// <summary>
        ///  组织 code
        /// </summary>
        [JsonProperty("organizationCode")]
        public string  OrganizationCode {get;set;} 
        /// <summary>
        ///  部门 ID，根部门传 `root`
        /// </summary>
        [JsonProperty("departmentId")]
        public string  DepartmentId {get;set;} 
        /// <summary>
        ///  搜索关键词，如成员名称
        /// </summary>
        [JsonProperty("keywords")]
        public string  Keywords {get;set;} 
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
        ///  此次调用中使用的部门 ID 的类型
        /// </summary>
        [JsonProperty("departmentIdType")]
        public string  DepartmentIdType {get;set;} 
        /// <summary>
        ///  是否包含子部门的成员
        /// </summary>
        [JsonProperty("includeChildrenDepartments")]
        public bool  IncludeChildrenDepartments {get;set;} 
        /// <summary>
        ///  是否获取自定义数据
        /// </summary>
        [JsonProperty("withCustomData")]
        public bool  WithCustomData {get;set;} 
        /// <summary>
        ///  是否获取 identities
        /// </summary>
        [JsonProperty("withIdentities")]
        public bool  WithIdentities {get;set;} 
        /// <summary>
        ///  是否获取部门 ID 列表
        /// </summary>
        [JsonProperty("withDepartmentIds")]
        public bool  WithDepartmentIds {get;set;} 
        /// <summary>
        ///  租户 ID
        /// </summary>
        [JsonProperty("tenantId")]
        public string  TenantId {get;set;} 
    }
}