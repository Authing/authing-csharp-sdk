using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authing.CSharp.SDK.Models.Authentication
{
    public class RefreshTokenParams
    {
        public string GrantType { get; set; } = "refresh_token";
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public string RefreshToken { get; set; }
    }
}
