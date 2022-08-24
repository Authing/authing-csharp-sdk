using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Authing.CSharp.SDK.Models
{
    public class LogoutParams
    {
        public bool? Expert { get; set; } = null;
#nullable enable
        public string? RedirectUri { get; set; }
        public string? IdToken { get; set; }
#nullable disable
    }
}
