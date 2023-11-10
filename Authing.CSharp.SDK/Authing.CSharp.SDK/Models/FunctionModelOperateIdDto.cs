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
    /// FunctionModelOperateIdDto 的模型
    /// </summary>
    public partial class FunctionModelOperateIdDto
    {
        /// <summary>
        ///  执行时自定义参数
        /// </summary>
        [JsonProperty("customConfig")]
        public object  CustomConfig {get;set;}
        /// <summary>
        ///  功能 id
        /// </summary>
        [JsonProperty("modelId")]
        public string  ModelId {get;set;}
        /// <summary>
        ///  自定义操作 id
        /// </summary>
        [JsonProperty("id")]
        public string  Id {get;set;}
    }
}