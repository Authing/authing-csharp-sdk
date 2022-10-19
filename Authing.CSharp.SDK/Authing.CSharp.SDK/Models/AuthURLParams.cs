using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authing.CSharp.SDK.Models.Authentication
{
    public class AuthURLParams
    {
        [JsonProperty("redirect_uri")]
        public string RedirectUri { get; set; }

        [JsonProperty("response_type")]
        public string ResponseType { get; set; }

        [JsonProperty("response_mode")]
        public string ResponseMode { get; set; }

        [JsonProperty("client_id")]
        public string ClientId { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("nonce")]
        public string Nonce { get; set; }

        [JsonProperty("scope")]
        public string Scope { get; set; }

        [JsonProperty("prompt")]
        public string Propmpt { get; set; }
    }
}
