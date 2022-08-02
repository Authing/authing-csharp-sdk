using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authing.CSharp.SDK.Models.Authentication
{
    public class IDToken : UserInfo
    {
        //[JsonProperty("sub")]
        //public string Sub { get; set; }
        [JsonProperty("aud")]
        public string Aud { get; set; }
        [JsonProperty("exp")]
        public long Exp { get; set; }
        [JsonProperty("iat")]
        public long Iat { get; set; }
        [JsonProperty("iss")]
        public string Iss { get; set; }
        [JsonProperty("nonce")]
        public string Nonce { get; set; }
        [JsonProperty("at_hash")]
        public string AtHase { get; set; }
        [JsonProperty("s_hash")]
        public string SHash { get; set; }
    }
}
