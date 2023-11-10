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
    /// UpdateRowDto 的模型
    /// </summary>
    public partial class UpdateRowDto
    {
        /// <summary>
        ///  数据内容
        /// </summary>
        [JsonProperty("data")]
        public object  Data {get;set;}
        /// <summary>
        ///  行 id
        /// </summary>
        [JsonProperty("rowId")]
        public string  RowId {get;set;}
        /// <summary>
        ///  功能 id
        /// </summary>
        [JsonProperty("modelId")]
        public string  ModelId {get;set;}
        /// <summary>
        ///  响应中键是否为 FieldId
        /// </summary>
        [JsonProperty("showFieldId")]
        public bool  ShowFieldId {get;set;}
    }
}