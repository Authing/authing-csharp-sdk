using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Authing.CSharp.SDK.Models
{
    public class IntrospectTokenRes
    {
        [JsonProperty("active")]
        public bool Active { get; set; }
        [JsonProperty("sub")]
        public string Sub { get; set; }
        [JsonProperty("client_id")]
        public string ClientId { get; set; }
        [JsonProperty("exp")]
        public int Exp { get; set; }
        [JsonProperty("iat")]
        public int Iat { get; set; }
        [JsonProperty("iss")]
        public string Iss { get; set; }
        [JsonProperty("jti")]
        public string Jti { get; set; }
        [JsonProperty("scope")]
        public string Scope { get; set; }
        [JsonProperty("token_type")]
        public string TokenType { get; set; }
    }
}
