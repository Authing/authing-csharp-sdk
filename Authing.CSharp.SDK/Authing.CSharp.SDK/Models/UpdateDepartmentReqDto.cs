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
    /// UpdateDepartmentReqDto 的模型
    /// </summary>
    public partial class UpdateDepartmentReqDto
    {
        /// <summary>
        ///  组织 Code（organizationCode）
        /// </summary>
        [JsonProperty("organizationCode")]
        public string  OrganizationCode {get;set;}
        /// <summary>
        ///  部门系统 ID（为 Authing 系统自动生成，不可修改）
        /// </summary>
        [JsonProperty("departmentId")]
        public string  DepartmentId {get;set;}
        /// <summary>
        ///  元数据信息
        /// </summary>
        [JsonProperty("metadata")]
        public object  Metadata {get;set;}
        /// <summary>
        ///  部门负责人 ID
        /// </summary>
        [JsonProperty("leaderUserIds")]
        public List<string>  LeaderUserIds {get;set;}
        /// <summary>
        ///  部门描述
        /// </summary>
        [JsonProperty("description")]
        public string  Description {get;set;}
        /// <summary>
        ///  部门识别码
        /// </summary>
        [JsonProperty("code")]
        public string  Code {get;set;}
        /// <summary>
        ///  多语言设置
        /// </summary>
        [JsonProperty("i18n")]
        public DepartmentI18nDto  I18n {get;set;}
        /// <summary>
        ///  部门状态
        /// </summary>
        [JsonProperty("status")]
        public bool  Status {get;set;}
        /// <summary>
        ///  部门名称
        /// </summary>
        [JsonProperty("name")]
        public string  Name {get;set;}
        /// <summary>
        ///  此次调用中使用的部门 ID 的类型
        /// </summary>
        [JsonProperty("departmentIdType")]
        public departmentIdType  DepartmentIdType {get;set;}
        /// <summary>
        ///  父部门 ID
        /// </summary>
        [JsonProperty("parentDepartmentId")]
        public string  ParentDepartmentId {get;set;}
        /// <summary>
        ///  自定义数据，传入的对象中的 key 必须先在用户池定义相关自定义字段
        /// </summary>
        [JsonProperty("customData")]
        public object  CustomData {get;set;}
        /// <summary>
        ///  岗位 id 列表
        /// </summary>
        [JsonProperty("postIdList")]
        public List<string>  PostIdList {get;set;}
        /// <summary>
        ///  租户 ID
        /// </summary>
        [JsonProperty("tenantId")]
        public string  TenantId {get;set;}
    }
    public partial class UpdateDepartmentReqDto
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