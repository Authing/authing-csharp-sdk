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
    /// UpdateDepartmentStatusReqDto 的模型
    /// </summary>
    public partial class UpdateDepartmentStatusReqDto
    {
        /// <summary>
        ///  部门状态
        /// </summary>
        [JsonProperty("status")]
        public bool  Status {get;set;}
        /// <summary>
        ///  需要获取的部门 ID
        /// </summary>
        [JsonProperty("departmentId")]
        public string  DepartmentId {get;set;}
    }
}