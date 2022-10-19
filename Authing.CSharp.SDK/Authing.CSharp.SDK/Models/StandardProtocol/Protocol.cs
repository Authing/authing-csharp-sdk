using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Authing.CSharp.SDK.Models
{
    public enum Protocol
    {
        [Description("oidc")]
        OIDC,
        [Description("oauth")]
        OAUTH,
        [Description("saml")]
        SAML,
        [Description("cas")]
        CAS,
        [Description("azure-ad")]
        AZURE_AD
    }
}
