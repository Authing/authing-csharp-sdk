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
    /// ListUserBaseFieldsDto 的模型
    /// </summary>
    public partial class ListUserBaseFieldsDto
    {
        /// <summary>
        ///  目标对象类型：
/// - `USER`: 用户
/// - `ROLE`: 角色
/// - `GROUP`: 分组
/// - `DEPARTMENT`: 部门
/// ;该接口暂不支持分组(GROUP)
        /// </summary>
        [JsonProperty("targetType")]
        public string  TargetType {get;set;} 
        /// <summary>
        ///  字段类型
        /// </summary>
        [JsonProperty("dataType")]
        public string  DataType {get;set;} 
        /// <summary>
        ///  租户 ID
        /// </summary>
        [JsonProperty("tenantId")]
        public string  TenantId {get;set;} 
        /// <summary>
        ///  当前页数，从 1 开始
        /// </summary>
        [JsonProperty("page")]
        public long  Page {get;set;} =1;
        /// <summary>
        ///  每页数目，最大不能超过 50，默认为 10
        /// </summary>
        [JsonProperty("limit")]
        public long  Limit {get;set;} =10;
        /// <summary>
        ///  用户是否可见
        /// </summary>
        [JsonProperty("userVisible")]
        public bool  UserVisible {get;set;} 
        /// <summary>
        ///  管理员是否可见
        /// </summary>
        [JsonProperty("adminVisible")]
        public bool  AdminVisible {get;set;} 
        /// <summary>
        ///  访问控制
        /// </summary>
        [JsonProperty("accessControl")]
        public bool  AccessControl {get;set;} 
        /// <summary>
        ///  搜索关键词
        /// </summary>
        [JsonProperty("keyword")]
        public string  Keyword {get;set;} 
        /// <summary>
        ///  搜索语言
        /// </summary>
        [JsonProperty("lang")]
        public string  Lang {get;set;} 
    }
}