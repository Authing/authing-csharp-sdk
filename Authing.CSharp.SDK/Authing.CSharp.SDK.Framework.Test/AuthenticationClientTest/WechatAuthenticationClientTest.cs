using Authing.CSharp.SDK.Models;
using Authing.CSharp.SDK.Models.Authentication;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authing.CSharp.SDK.Framework.Test.AuthenticationClientTest
{
    public class WechatAuthenticationClientTest : AuthenticationClientTestBase
    {
        [SetUp]
        public async Task LoginTemp()
        {
            LoginByCredentialsDto dto = new LoginByCredentialsDto { };
            dto.Connection = Connection.PASSWORD;
            dto.PasswordPayload = new PasswordPayload
            {
                Email = "test@test.com",
                Password = "88886666"
            };

            LoginTokenRespDto loginTokenRespDto = await client.Signin(dto);

            Assert.IsNotNull(loginTokenRespDto);
        }

        /// <summary>
        /// 2022-8-22 测试不通过
        /// 无法确定测试流程
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task DecryptWechatMiniprogramDataTest()
        {
            var param = new DecryptWechatMiniProgramDataDto();
            var res = await client.DecryptWechatMiniprogramData(param);
            Assert.IsTrue(res.StatusCode == 200);
        }
    }
}
