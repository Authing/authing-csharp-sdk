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
    /// GetDepartmentByIdDto 的模型
    /// </summary>
    public partial class GetDepartmentByIdDto
    {
        /// <summary>
        ///  部门 ID
        /// </summary>
        [JsonProperty("departmentId")]
        public string  DepartmentId {get;set;} 
        /// <summary>
        ///  租户 ID
        /// </summary>
        [JsonProperty("tenantId")]
        public string  TenantId {get;set;} 
        /// <summary>
        ///  是否获取自定义数据
        /// </summary>
        [JsonProperty("withCustomData")]
        public bool  WithCustomData {get;set;} 
    }
}