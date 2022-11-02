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
    /// SetUserDepartmentDto 的模型
    /// </summary>
    public partial class SetUserDepartmentDto
    {
        /// <summary>
        ///  部门 id
        /// </summary>
        [JsonProperty("departmentId")]
        public string  DepartmentId {get;set;}
        /// <summary>
        ///  是否是部门 leader
        /// </summary>
        [JsonProperty("isLeader")]
        public bool  IsLeader {get;set;}
        /// <summary>
        ///  是否是主部门
        /// </summary>
        [JsonProperty("isMainDepartment")]
        public bool  IsMainDepartment {get;set;}
    }
}