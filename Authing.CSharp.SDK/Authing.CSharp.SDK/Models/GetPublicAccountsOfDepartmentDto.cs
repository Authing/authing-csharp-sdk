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
    /// GetPublicAccountsOfDepartmentDto 的模型
    /// </summary>
    public partial class GetPublicAccountsOfDepartmentDto
    {
        /// <summary>
        ///  部门 ID
        /// </summary>
        [JsonProperty("departmentId")]
        public string  DepartmentId {get;set;} 
    }
}