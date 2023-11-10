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
    /// Condition 的模型
    /// </summary>
    public partial class Condition
    {
        /// <summary>
        ///  搜索字段的 key
        /// </summary>
        [JsonProperty("key")]
        public string  Key {get;set;}
        /// <summary>
        ///  搜索值
        /// </summary>
        [JsonProperty("value")]
        public object  Value {get;set;}
        /// <summary>
        ///  操作类型：
/// - eq: 等于
/// - ne: 不等于
/// - co: 包含
/// - gt: 大于
/// - lt: 小于
/// - lte: 小于等于
/// - gte: 大于等于
/// - in: 数组包含
/// 
        /// </summary>
        [JsonProperty("operator")]
        public string  Operator {get;set;}
    }
}