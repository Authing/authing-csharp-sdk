using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Authing.CSharp.SDK.Models.Management;

namespace Authing.CSharp.SDK.Models.Management
{
    /// <summary>
    /// UserDepartmentRespDto 的模型
    /// </summary>
    public partial class UserDepartmentRespDto
    {
        /// <summary>
        ///  组织 Code（organizationCode）
        /// </summary>
        [JsonProperty("organizationCode")]
        public string OrganizationCode { get; set; }
        /// <summary>
        ///  部门 ID
        /// </summary>
        [JsonProperty("departmentId")]
        public string DepartmentId { get; set; }
        /// <summary>
        ///  部门创建时间
        /// </summary>
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }
        /// <summary>
        ///  部门名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        /// <summary>
        ///  部门描述
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
        /// <summary>
        ///  自定义部门 ID，用于存储自定义的 ID
        /// </summary>
        [JsonProperty("openDepartmentId")]
        public string OpenDepartmentId { get; set; }
        /// <summary>
        ///  是否是部门 Leader
        /// </summary>
        [JsonProperty("isLeader")]
        public bool IsLeader { get; set; }
        /// <summary>
        ///  部门识别码
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }
        /// <summary>
        ///  是否是主部门
        /// </summary>
        [JsonProperty("isMainDepartment")]
        public bool IsMainDepartment { get; set; }
        /// <summary>
        ///  加入部门时间
        /// </summary>
        [JsonProperty("joinedAt")]
        public string JoinedAt { get; set; }
        /// <summary>
        ///  是否是虚拟部门
        /// </summary>
        [JsonProperty("isVirtualNode")]
        public bool IsVirtualNode { get; set; }
        /// <summary>
        ///  多语言设置
        /// </summary>
        [JsonProperty("i18n")]
        public DepartmentI18nDto I18n { get; set; }
        /// <summary>
        ///  部门的扩展字段数据
        /// </summary>
        [JsonProperty("customData")]
        public object CustomData { get; set; }
    }
}