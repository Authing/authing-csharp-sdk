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
    /// IsUserInDepartmentDto 的模型
    /// </summary>
    public partial class IsUserInDepartmentDto
    {
        /// <summary>
        ///  用户的唯一标志，可以是用户 ID、用户名、邮箱、手机号、externalId、在外部身份源的 ID，详情见 userIdType 字段的说明。默认为用户 id 。
        /// </summary>
        [JsonProperty("userId")]
        public string  UserId {get;set;} 
        /// <summary>
        ///  组织 code
        /// </summary>
        [JsonProperty("organizationCode")]
        public string  OrganizationCode {get;set;} 
        /// <summary>
        ///  部门 ID，根部门传 `root`。departmentId 和 departmentCode 必传其一。
        /// </summary>
        [JsonProperty("departmentId")]
        public string  DepartmentId {get;set;} 
        /// <summary>
        ///  此次调用中使用的部门 ID 的类型
        /// </summary>
        [JsonProperty("departmentIdType")]
        public string  DepartmentIdType {get;set;} 
        /// <summary>
        ///  是否包含子部门
        /// </summary>
        [JsonProperty("includeChildrenDepartments")]
        public bool  IncludeChildrenDepartments {get;set;} 
        /// <summary>
        ///  租户 ID
        /// </summary>
        [JsonProperty("tenantId")]
        public string  TenantId {get;set;} 
    }
}