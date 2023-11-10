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
    /// ExportModelDto 的模型
    /// </summary>
    public partial class ExportModelDto
    {
        /// <summary>
        ///  导出范围
        /// </summary>
        [JsonProperty("idList")]
        public List<string>  IdList {get;set;}
        /// <summary>
        ///  功能 id
        /// </summary>
        [JsonProperty("modelId")]
        public string  ModelId {get;set;}
    }
}