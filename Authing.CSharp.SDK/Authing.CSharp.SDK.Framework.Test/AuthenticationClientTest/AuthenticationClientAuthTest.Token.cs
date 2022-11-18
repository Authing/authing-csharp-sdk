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
        /// <summary>
        /// 2022-11-17 测试通过
        /// 检查 Access token 或 Refresh token 的状态
        /// </summary>
        /// <returns></returns>
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
