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
    /// UpdateFunctionModelFieldDto 的模型
    /// </summary>
    public partial class UpdateFunctionModelFieldDto
    {
        /// <summary>
        ///  用户中心是否显示，仅在 user 模块下有意义:
/// - true: 用户中心展示
/// - false: 用户中心不展示
/// 
        /// </summary>
        [JsonProperty("userVisible")]
        public bool  UserVisible {get;set;}
        /// <summary>
        ///  关联数据可选范围
        /// </summary>
        [JsonProperty("relationOptionalRange")]
        public RelationOptionalRange  RelationOptionalRange {get;set;}
        /// <summary>
        ///  关联数据要展示的属性
        /// </summary>
        [JsonProperty("relationShowKey")]
        public string  RelationShowKey {get;set;}
        /// <summary>
        ///  是否可用于登录，仅在 user 模块下有意义:
/// - true: 用于登录
/// - false: 不用于登录
/// 
        /// </summary>
        [JsonProperty("forLogin")]
        public bool  ForLogin {get;set;}
        /// <summary>
        ///  是否支持模糊搜索:
/// - true: 支持模糊搜索
/// - false: 不支持模糊搜索
/// 
        /// </summary>
        [JsonProperty("fuzzySearch")]
        public bool  FuzzySearch {get;set;}
        /// <summary>
        ///  下拉菜单选项
        /// </summary>
        [JsonProperty("dropDown")]
        public List<string>  DropDown {get;set;}
        /// <summary>
        ///  前端格式化规则
        /// </summary>
        [JsonProperty("format")]
        public long  Format {get;set;}
        /// <summary>
        ///  字符串的校验匹配规则
        /// </summary>
        [JsonProperty("regexp")]
        public string  Regexp {get;set;}
        /// <summary>
        ///  如果类型是数字表示数字下限，如果类型是日期表示开始日期
        /// </summary>
        [JsonProperty("min")]
        public long  Min {get;set;}
        /// <summary>
        ///  如果类型是数字表示数字上限，如果类型是日期表示结束日期
        /// </summary>
        [JsonProperty("max")]
        public long  Max {get;set;}
        /// <summary>
        ///  字符串长度限制
        /// </summary>
        [JsonProperty("maxLength")]
        public long  MaxLength {get;set;}
        /// <summary>
        ///  是否唯一:
/// - true: 唯一
/// - false: 不唯一
/// 
        /// </summary>
        [JsonProperty("unique")]
        public bool  Unique {get;set;}
        /// <summary>
        ///  是否必填:
/// - true: 必填
/// - false: 不必填
/// 
        /// </summary>
        [JsonProperty("require")]
        public bool  Require {get;set;}
        /// <summary>
        ///  默认值
        /// </summary>
        [JsonProperty("default")]
        public object  Default {get;set;}
        /// <summary>
        ///  帮助说明
        /// </summary>
        [JsonProperty("help")]
        public string  Help {get;set;}
        /// <summary>
        ///  是否可编辑:
/// - true: 可编辑
/// - false: 不可编辑
/// 
        /// </summary>
        [JsonProperty("editable")]
        public bool  Editable {get;set;}
        /// <summary>
        ///  是否展示:
/// - true: 展示
/// - false: 不展示
/// 
        /// </summary>
        [JsonProperty("show")]
        public bool  Show {get;set;}
        /// <summary>
        ///  字段名称
        /// </summary>
        [JsonProperty("name")]
        public string  Name {get;set;}
        /// <summary>
        ///  功能 id
        /// </summary>
        [JsonProperty("modelId")]
        public string  ModelId {get;set;}
        /// <summary>
        ///  字段 id
        /// </summary>
        [JsonProperty("id")]
        public string  Id {get;set;}
    }
}