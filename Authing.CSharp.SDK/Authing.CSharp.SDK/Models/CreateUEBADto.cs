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
    /// CreateUEBADto 的模型
    /// </summary>
    public partial class CreateUEBADto
    {
        /// <summary>
        ///  数据内容
        /// </summary>
        [JsonProperty("data")]
        public object  Data {get;set;}
        /// <summary>
        ///  功能 id，如果不存在则会使用数据库中查到的第一个 type 为 ueba 的功能
        /// </summary>
        [JsonProperty("modelId")]
        public string  ModelId {get;set;}
    }
}