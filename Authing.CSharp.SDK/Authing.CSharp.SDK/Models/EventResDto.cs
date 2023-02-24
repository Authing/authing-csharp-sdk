using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Authing.CSharp.SDK.Models
{
   public class EventRequestDto

    {
        [JsonProperty("eventType")]
        public string EventType { get; set; }
        [JsonProperty("eventData")]
        public string EventData { get; set; }
    }
}
