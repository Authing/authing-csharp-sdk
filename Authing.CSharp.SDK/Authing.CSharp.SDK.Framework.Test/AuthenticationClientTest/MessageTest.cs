using Authing.CSharp.SDK.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authing.CSharp.SDK.Framework.Test.AuthenticationClientTest
{
    public class MessageTest : AuthenticationClientTestBase
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
        /// 2022-8-22 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task SendSmsTest()
        {
            var param = new SendSMSDto { Channel = SmsChannel.CHANNEL_BIND_MFA, PhoneNumber = "17665662048" };
            var res = await client.SendSms(param);
            Assert.IsTrue(res.StatusCode == 200);
        }

        /// <summary>
        /// 2022-8-22 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task SendEmail()
        {
            var param = new SendEmailDto { Channel = EmailChannel.CHANNEL_BIND_EMAIL, Email = "574378328@qq.com" };
            var res = await client.SendEmail(param);
            Assert.IsTrue(res.StatusCode == 200);
        }
    }
}
