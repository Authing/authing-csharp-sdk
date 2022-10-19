using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Authing.CSharp.SDK.Models
{
    public class OauthOption : IProtocolInterface
    {
        public string AppId { get; set; }
        public string RedirectUri { get; set; }
        public OauthResponseType? ResponseType { get; set; }
        public string State { get; set; }
        public string Scope { get; set; }
    }
}
