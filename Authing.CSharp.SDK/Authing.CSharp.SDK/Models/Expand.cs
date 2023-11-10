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
    /// Expand 的模型
    /// </summary>
    public partial class Expand
    {
        /// <summary>
        ///  关联的字段 key
        /// </summary>
        [JsonProperty("field")]
        public string  Field {get;set;}
        /// <summary>
        ///  展开哪些关联字段
        /// </summary>
        [JsonProperty("select")]
        public List<string>  Select {get;set;}
    }
}