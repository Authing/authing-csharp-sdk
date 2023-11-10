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
    /// DeleteDepartmentSyncRelationReqDto 的模型
    /// </summary>
    public partial class DeleteDepartmentSyncRelationReqDto
    {
        /// <summary>
        ///  外部身份源类型，如：
/// - `wechatwork`: 企业微信
/// - `dingtalk`: 钉钉
/// - `lark`: 飞书
/// - `welink`: Welink
/// - `ldap`: LDAP
/// - `active-directory`: Windows AD
/// - `italent`: 北森
/// - `xiaoshouyi`: 销售易
/// - `maycur`: 每刻报销
/// - `scim`: SCIM
/// - `moka`: Moka HR
/// 
        /// </summary>
        [JsonProperty("provider")]
        public string  Provider {get;set;}
        /// <summary>
        ///  部门 ID，根部门传 `root`
        /// </summary>
        [JsonProperty("departmentId")]
        public string  DepartmentId {get;set;}
        /// <summary>
        ///  组织 code
        /// </summary>
        [JsonProperty("organizationCode")]
        public string  OrganizationCode {get;set;}
        /// <summary>
        ///  此次调用中使用的部门 ID 的类型
        /// </summary>
        [JsonProperty("departmentIdType")]
        public departmentIdType  DepartmentIdType {get;set;}
    }
    public partial class DeleteDepartmentSyncRelationReqDto
    {
        /// <summary>
        ///  此次调用中使用的部门 ID 的类型
        /// </summary>
        public enum departmentIdType
        {
            [EnumMember(Value="department_id")]
            DEPARTMENT_ID,
            [EnumMember(Value="open_department_id")]
            OPEN_DEPARTMENT_ID,
            [EnumMember(Value="sync_relation")]
            SYNC_RELATION,
            [EnumMember(Value="custom_field")]
            CUSTOM_FIELD,
            [EnumMember(Value="code")]
            CODE,
        }
    }
}