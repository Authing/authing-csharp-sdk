using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authing.CSharp.SDK.Models.Authentication
{
    public class LoginTransaction
    {
        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("nonce")]
        public string Nonce { get; set; }

        [JsonProperty("redirectUri")]
        public string RedirectUri { get; set; }
    }
}
