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
    /// SearchDepartmentsFilterItemDto 的模型
    /// </summary>
    public partial class SearchDepartmentsFilterItemDto
    {
        /// <summary>
        ///  高级搜索指定的部门字段：
/// - `updatedAt`: 更新时间，高级搜索请用时间戳
/// - `createdAt`: 创建时间，高级搜索请用时间戳
/// - `name`: 部门名称
/// 
        /// </summary>
        [JsonProperty("field")]
        public string  Field  {get;set;}
        /// <summary>
        ///  运算符，可选值为：
/// - `EQUAL`: 全等，适用于数字和字符串的全等匹配
/// - `IN`: 为某个数组中的元素
/// - `GREATER`: 大于或等于，适用于数字、日期类型数据的比较
/// - `LESSER`: 小于或等于，适用于数字、日期类型数据的比较
/// - `BETWEEN`: 介于什么什么之间，适用于数字、日期类型数据的比较
/// - `CONTAINS`: 字符串包含
/// 
        /// </summary>
        [JsonProperty("operator")]
        public @operator  Operator  {get;set;}
        /// <summary>
        ///  搜索值，不同的 `field` 对应的 `value` 类型可能不一样
        /// </summary>
        [JsonProperty("value")]
        public object  Value  {get;set;}
    }
    public partial class SearchDepartmentsFilterItemDto
    {
        /// <summary>
        ///  运算符，可选值为：
/// - `EQUAL`: 全等，适用于数字和字符串的全等匹配
/// - `IN`: 为某个数组中的元素
/// - `GREATER`: 大于或等于，适用于数字、日期类型数据的比较
/// - `LESSER`: 小于或等于，适用于数字、日期类型数据的比较
/// - `BETWEEN`: 介于什么什么之间，适用于数字、日期类型数据的比较
/// - `CONTAINS`: 字符串包含
/// 
        /// </summary>
        public enum @operator
        {
            [EnumMember(Value="BETWEEN")]
            BETWEEN,
            [EnumMember(Value="EQUAL")]
            EQUAL,
            [EnumMember(Value="IN")]
            IN,
            [EnumMember(Value="LESSER")]
            LESSER,
            [EnumMember(Value="GREATER")]
            GREATER,
            [EnumMember(Value="CONTAINS")]
            CONTAINS,
        }
    }
}