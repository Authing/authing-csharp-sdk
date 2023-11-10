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
    /// CreateRowDto 的模型
    /// </summary>
    public partial class CreateRowDto
    {
        /// <summary>
        ///  数据内容
        /// </summary>
        [JsonProperty("data")]
        public object  Data {get;set;}
        /// <summary>
        ///  功能 id
        /// </summary>
        [JsonProperty("modelId")]
        public string  ModelId {get;set;}
        /// <summary>
        ///  自定义行 id，默认自动生成。最长只允许 32 位。
        /// </summary>
        [JsonProperty("rowId")]
        public string  RowId {get;set;}
    }
}