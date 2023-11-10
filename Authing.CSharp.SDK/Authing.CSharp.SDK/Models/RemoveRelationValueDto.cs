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
    /// RemoveRelationValueDto 的模型
    /// </summary>
    public partial class RemoveRelationValueDto
    {
        /// <summary>
        ///  关联数据
        /// </summary>
        [JsonProperty("value")]
        public string  Value {get;set;}
        /// <summary>
        ///  字段 id
        /// </summary>
        [JsonProperty("fieldIds")]
        public List<string>  FieldIds {get;set;}
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
    }
}