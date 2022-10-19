using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Authing.CSharp.SDK.Models
{
    public class CodeChallengeDigestOption
    {
        public string CodeChallenge { get; set; }
        public CodeChallengeDigestMethod Method { get; set; } = CodeChallengeDigestMethod.S256;
    }
}
