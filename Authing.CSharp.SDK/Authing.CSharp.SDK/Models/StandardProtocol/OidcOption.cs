using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Authing.CSharp.SDK.Models
{
    public class OidcOption : IProtocolInterface
    {
        public string AppId { get; set; }
        public string RedirectUri { get; set; }

        public ResponseType? ResponseType { get; set; } = null;
        public ResponseMode? ResponseMode { get; set; } = null;

        public string State { get; set; }
        public string Nonce { get; set; }
        public string Scope { get; set; }
        public CodeChallengeDigestMethod? CodeChallengeMethod { get; set; }
        public string CodeChallenge { get; set; }
    }
}
