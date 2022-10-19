using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Authing.CSharp.SDK.Models
{
    public class ValidateTicketV1Response
    {
        public bool Valid { get; set; }
        public string Username { get; set; }
        public string Message { get; set; }

    }
}
