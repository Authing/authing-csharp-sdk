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
    /// PubEventDto 的模型
    /// </summary>
    public partial class PubEventDto
    {
        /// <summary>
        ///  事件类型
        /// </summary>
        [JsonProperty("eventType")]
        public string  EventType {get;set;}
        /// <summary>
        ///  事件体
        /// </summary>
        [JsonProperty("eventData")]
        public object  EventData {get;set;}
    }
}