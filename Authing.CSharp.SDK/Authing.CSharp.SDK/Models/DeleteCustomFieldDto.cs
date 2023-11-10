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
    /// DeleteCustomFieldDto 的模型
    /// </summary>
    public partial class DeleteCustomFieldDto
    {
        /// <summary>
        ///  主体类型，目前支持用户、角色、分组和部门
        /// </summary>
        [JsonProperty("targetType")]
        public targetType  TargetType {get;set;}
        /// <summary>
        ///  字段 key，不能和内置字段的 key 冲突，**设置之后将不能进行修改**。
        /// </summary>
        [JsonProperty("key")]
        public string  Key {get;set;}
    }
    public partial class DeleteCustomFieldDto
    {
        /// <summary>
        ///  主体类型，目前支持用户、角色、分组和部门
        /// </summary>
        public enum targetType
        {
            [EnumMember(Value="USER")]
            USER,
            [EnumMember(Value="ROLE")]
            ROLE,
            [EnumMember(Value="GROUP")]
            GROUP,
            [EnumMember(Value="DEPARTMENT")]
            DEPARTMENT,
        }
    }
}