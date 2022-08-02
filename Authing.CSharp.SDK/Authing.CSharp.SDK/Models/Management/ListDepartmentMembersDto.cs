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
    /// ListDepartmentMembersDto 的模型
    /// </summary>
    public partial class ListDepartmentMembersDto
    {
        /// <summary>
        ///  组织 code
        /// </summary>
        [JsonProperty("organizationCode")]
        public    object   OrganizationCode    {get;set;}
        /// <summary>
        ///  部门 id，根部门传 `root`
        /// </summary>
        [JsonProperty("departmentId")]
        public    object   DepartmentId    {get;set;}
        /// <summary>
        ///  此次调用中使用的部门 ID 的类型
        /// </summary>
        [JsonProperty("departmentIdType")]
        public    object   DepartmentIdType    {get;set;}
        /// <summary>
        ///  是否包含子部门的成员
        /// </summary>
        [JsonProperty("includeChildrenDepartments")]
        public    object   IncludeChildrenDepartments    {get;set;}
        /// <summary>
        ///  当前页数，从 1 开始
        /// </summary>
        [JsonProperty("page")]
        public    object   Page    {get;set;}
        /// <summary>
        ///  每页数目，最大不能超过 50，默认为 10
        /// </summary>
        [JsonProperty("limit")]
        public    object   Limit    {get;set;}
        /// <summary>
        ///  是否获取自定义数据
        /// </summary>
        [JsonProperty("withCustomData")]
        public    object   WithCustomData    {get;set;}
        /// <summary>
        ///  是否获取 identities
        /// </summary>
        [JsonProperty("withIdentities")]
        public    object   WithIdentities    {get;set;}
        /// <summary>
        ///  是否获取部门 ID 列表
        /// </summary>
        [JsonProperty("withDepartmentIds")]
        public    object   WithDepartmentIds    {get;set;}
    }
}