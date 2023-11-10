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
    /// GetRowBatchDto 的模型
    /// </summary>
    public partial class GetRowBatchDto
    {
        /// <summary>
        ///  行 id 列表
        /// </summary>
        [JsonProperty("rowIds")]
        public List<string>  RowIds {get;set;}
        /// <summary>
        ///  功能 id
        /// </summary>
        [JsonProperty("modelId")]
        public string  ModelId {get;set;}
    }
}