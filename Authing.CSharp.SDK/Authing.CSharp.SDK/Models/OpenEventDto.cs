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
    /// OpenEventDto 的模型
    /// </summary>
    public partial class OpenEventDto
    {
        /// <summary>
        ///  事件 ID
        /// </summary>
        [JsonProperty("id")]
        public string  Id {get;set;}
        /// <summary>
        ///  事件标志
        /// </summary>
        [JsonProperty("code")]
        public string  Code {get;set;}
        /// <summary>
        ///  事件 Topic
        /// </summary>
        [JsonProperty("topic")]
        public string  Topic {get;set;}
        /// <summary>
        ///  事件名称
        /// </summary>
        [JsonProperty("name")]
        public string  Name {get;set;}
        /// <summary>
        ///  事件描述
        /// </summary>
        [JsonProperty("desc")]
        public string  Desc {get;set;}
    }
}