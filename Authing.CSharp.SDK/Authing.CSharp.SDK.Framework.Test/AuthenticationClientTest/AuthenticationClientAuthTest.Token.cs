using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Authing.CSharp.SDK.Models;
using NUnit.Framework;

namespace Authing.CSharp.SDK.Framework.Test
{
    public partial class AuthenticationClientAuthTest
    {
        [Test]
        public async Task introspectionTokenTest()
        {
            var res = await client.IntrospectToken(AccessToken);
            Assert.IsTrue(res.Active);
        }
        [Test]
        public async Task revocationTest()
        {
            var res = await client.RevokeToken(AccessToken);
        }
    }
}
