using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authing.CSharp.SDK.Models.Authentication
{
    public class LogoutURLParams
    {
        [JsonProperty("post_logout_redirect_uri")]
        public string PostLogoutRedirectUri { get; set; }

        [JsonProperty("id_token_hint")]
        public string IdTokenHint { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }
    }
}
