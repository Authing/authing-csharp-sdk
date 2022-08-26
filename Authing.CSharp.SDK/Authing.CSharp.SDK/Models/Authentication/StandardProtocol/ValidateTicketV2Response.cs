using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Authing.CSharp.SDK.Models
{
    public class ValidateTicketV2Response
    {
        public Serviceresponse ServiceResponse { get; set; }
    }

    public class Serviceresponse
    {
        public Authenticationsuccess AuthenticationSuccess { get; set; }

        public AuthenticationFailure AuthenticationFailure { get; set; }
    }

    public class Authenticationsuccess
    {
        public string user { get; set; }
        public dynamic attributes { get; set; }
    }

    public class AuthenticationFailure
    {
        public string Code { get; set; }
        public string Description { get; set; }
    }
}
