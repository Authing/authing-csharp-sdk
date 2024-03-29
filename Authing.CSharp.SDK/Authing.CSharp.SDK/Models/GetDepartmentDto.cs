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
    /// GetDepartmentDto 的模型
    /// </summary>
    public partial class GetDepartmentDto
    {
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
        ///  部门 code。departmentId 和 departmentCode 必传其一。
        /// </summary>
        [JsonProperty("departmentCode")]
        public string  DepartmentCode {get;set;} 
        /// <summary>
        ///  此次调用中使用的部门 ID 的类型
        /// </summary>
        [JsonProperty("departmentIdType")]
        public string  DepartmentIdType {get;set;} 
        /// <summary>
        ///  是否获取自定义数据
        /// </summary>
        [JsonProperty("withCustomData")]
        public bool  WithCustomData {get;set;} 
        /// <summary>
        ///  是否拍平扩展字段
        /// </summary>
        [JsonProperty("flatCustomData")]
        public bool  FlatCustomData {get;set;} 
        /// <summary>
        ///  租户 ID
        /// </summary>
        [JsonProperty("tenantId")]
        public string  TenantId {get;set;} 
    }
}