using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Authing.CSharp.SDK.Models
{
    public class ValidateTokenResponse
    {
        [JsonProperty("jti")]
        public string jti { get; set; }
        [JsonProperty("sub")]
        public string sub { get; set; }
        [JsonProperty("iat")]
        public int iat { get; set; }
        [JsonProperty("exp")]
        public int exp { get; set; }
        [JsonProperty("scope")]
        public string scope { get; set; }
        [JsonProperty("iss")]
        public string iss { get; set; }
        [JsonProperty("aud")]
        public string aud { get; set; }
    }
}
