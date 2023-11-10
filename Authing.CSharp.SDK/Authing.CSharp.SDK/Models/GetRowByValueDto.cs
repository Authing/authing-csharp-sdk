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
    /// GetRowByValueDto 的模型
    /// </summary>
    public partial class GetRowByValueDto
    {
        /// <summary>
        ///  功能 id
        /// </summary>
        [JsonProperty("modelId")]
        public string  ModelId {get;set;} 
        /// <summary>
        ///  字段 key
        /// </summary>
        [JsonProperty("key")]
        public string  Key {get;set;} 
        /// <summary>
        ///  字段值
        /// </summary>
        [JsonProperty("value")]
        public string  Value {get;set;} 
        /// <summary>
        ///  返回结果中是否使用字段 id 作为 key
        /// </summary>
        [JsonProperty("showFieldId")]
        public string  ShowFieldId {get;set;} 
    }
}