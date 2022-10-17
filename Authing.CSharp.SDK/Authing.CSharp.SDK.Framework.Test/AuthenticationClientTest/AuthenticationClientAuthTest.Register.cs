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
        public async Task RegisterByEmailAndPassword()
        {
            var res = await client.SignUpByEmailPassword("574378328@qq.com", "88886666");
            Assert.AreEqual(res.StatusCode, 200);
        }
    }
}
