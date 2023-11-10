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
    /// DefineEventDto 的模型
    /// </summary>
    public partial class DefineEventDto
    {
        /// <summary>
        ///  事件描述
        /// </summary>
        [JsonProperty("eventDescription")]
        public string  EventDescription {get;set;}
        /// <summary>
        ///  事件类型
        /// </summary>
        [JsonProperty("eventType")]
        public string  EventType {get;set;}
    }
}