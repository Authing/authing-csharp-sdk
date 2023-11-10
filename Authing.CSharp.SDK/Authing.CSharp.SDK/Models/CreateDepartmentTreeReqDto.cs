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
    /// CreateDepartmentTreeReqDto 的模型
    /// </summary>
    public partial class CreateDepartmentTreeReqDto
    {
        /// <summary>
        ///  部门名称
        /// </summary>
        [JsonProperty("name")]
        public string  Name {get;set;}
        /// <summary>
        ///  子部门
        /// </summary>
        [JsonProperty("children")]
        public List<string>  Children {get;set;}
        /// <summary>
        ///  部门成员
        /// </summary>
        [JsonProperty("members")]
        public UserInfoDto  Members {get;set;}
        /// <summary>
        ///  租户 ID
        /// </summary>
        [JsonProperty("tenantId")]
        public string  TenantId {get;set;}
    }
}