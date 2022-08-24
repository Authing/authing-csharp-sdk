using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Authing.CSharp.SDK.Models
{
    public enum ValidateTicketFormat
    {
        [JsonProperty("XML")]
        XML,
        [JsonProperty("JSON")]
        JSON
    }
}
