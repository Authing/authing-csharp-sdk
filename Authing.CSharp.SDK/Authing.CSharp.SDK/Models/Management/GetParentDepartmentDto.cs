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
    /// GetParentDepartmentDto 的模型
    /// </summary>
    public partial class GetParentDepartmentDto
    {
        /// <summary>
        ///  组织 code
        /// </summary>
        [JsonProperty("organizationCode")]
        public object OrganizationCode { get; set; }
        /// <summary>
        ///  部门 ID
        /// </summary>
        [JsonProperty("departmentId")]
        public object DepartmentId { get; set; }
        /// <summary>
        ///  此次调用中使用的部门 ID 的类型
        /// </summary>
        [JsonProperty("departmentIdType")]
        public object DepartmentIdType { get; set; }
        /// <summary>
        ///  是否获取自定义数据
        /// </summary>
        [JsonProperty("withCustomData")]
        public object WithCustomData { get; set; }
    }
}