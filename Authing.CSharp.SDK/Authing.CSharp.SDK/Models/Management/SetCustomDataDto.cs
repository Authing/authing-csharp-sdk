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
    /// SetCustomDataDto 的模型
    /// </summary>
    public partial class SetCustomDataDto
    {
        /// <summary>
        ///  字段 key，不能和内置字段的 key 冲突
        /// </summary>
        [JsonProperty("key")]
        public    string   Key    {get;set;}
        /// <summary>
        ///  自定义数据，可以为任意类型，但是必须和创建时定义的自定义字段类型匹配，否则将设置失败。
        /// </summary>
        [JsonProperty("value")]
        public    string   Value    {get;set;}
    }
}