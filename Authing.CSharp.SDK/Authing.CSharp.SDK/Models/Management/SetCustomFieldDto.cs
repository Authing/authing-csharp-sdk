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
    /// SetCustomFieldDto 的模型
    /// </summary>
    public partial class SetCustomFieldDto
    {
        /// <summary>
        ///  主体类型，目前支持用户、角色、分组和部门
        /// </summary>
        [JsonProperty("targetType")]
        public    targetType   TargetType    {get;set;}
        /// <summary>
        ///  数据类型
        /// </summary>
        [JsonProperty("dataType")]
        public    dataType   DataType    {get;set;}
        /// <summary>
        ///  字段 key，不能和内置字段的 key 冲突
        /// </summary>
        [JsonProperty("key")]
        public    string   Key    {get;set;}
        /// <summary>
        ///  前端表单展示名称
        /// </summary>
        [JsonProperty("label")]
        public    string   Label    {get;set;}
        /// <summary>
        ///  详细描述信息
        /// </summary>
        [JsonProperty("description")]
        public    string   Description    {get;set;}
        /// <summary>
        ///  是否加密存储
        /// </summary>
        [JsonProperty("encrypted")]
        public    bool   Encrypted    {get;set;}
        /// <summary>
        ///  多语言设置
        /// </summary>
        [JsonProperty("i18n")]
        public    CustomFieldI18n   I18n    {get;set;}
        /// <summary>
        ///  枚举值类型选择项
        /// </summary>
        [JsonProperty("options")]
        public    List<CustomFieldSelectOption>   Options    {get;set;}
    }
    public partial class SetCustomFieldDto
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
        /// <summary>
        ///  数据类型
        /// </summary>
        public enum dataType
        {
            [EnumMember(Value="STRING")]
            STRING,
            [EnumMember(Value="NUMBER")]
            NUMBER,
            [EnumMember(Value="DATETIME")]
            DATETIME,
            [EnumMember(Value="BOOLEAN")]
            BOOLEAN,
            [EnumMember(Value="SELECT")]
            SELECT,
        }
    }
}