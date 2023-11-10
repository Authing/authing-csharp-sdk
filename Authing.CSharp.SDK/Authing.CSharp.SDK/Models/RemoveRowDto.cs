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
    /// RemoveRowDto 的模型
    /// </summary>
    public partial class RemoveRowDto
    {
        /// <summary>
        ///  行 id
        /// </summary>
        [JsonProperty("rowIdList")]
        public List<string>  RowIdList {get;set;}
        /// <summary>
        ///  功能 id
        /// </summary>
        [JsonProperty("modelId")]
        public string  ModelId {get;set;}
        /// <summary>
        ///  如果当前行有子节点，是否递归删除，默认为 false。当为 false 时，如果有子节点，会提示错误。
        /// </summary>
        [JsonProperty("recursive")]
        public bool  Recursive {get;set;}
    }
}