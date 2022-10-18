using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Authing.CSharp.SDK.Models;

namespace Authing.CSharp.SDK.Framework.Test.AuthenticationClientTest
{
    public class WechatAuthenticationClientTest : AuthenticationClientTestBase
    {
        [SetUp]
        public async Task LoginTemp()
        {
            LoginTokenRespDto loginTokenRespDto = await client.SignInByAccountPassword("tmgg", "88886666");
            Assert.IsNotNull(loginTokenRespDto);
            client.setAccessToken(loginTokenRespDto.Data.Access_token);
        }

        /// <summary>
        /// 2022-10-18 测试不通过
        /// 无法确定测试流程
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task DecryptWechatMiniprogramDataTest()
        {
            var param = new DecryptWechatMiniProgramDataDto();
            var res = await client.DecryptWechatMiniProgramData(param);
            Assert.NotNull(res);
        }

        /// <summary>
        /// 2022-10-18 测试不通过
        /// 无法确定测试流程
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetWechatMiniprogramPhoneTest()
        {
            var param = new GetWechatMiniProgramPhoneDto();
            var res = await client.GetWechatMiniprogramPhone(param);
            Assert.NotNull(res);
        }

        /// <summary>
        /// 2022-10-18 测试不通过
        /// 无法确定测试流程
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetWechatAccessTokenTest()
        {
            var param = new GetWechatAccessTokenDto();
            var res = await client.GetWechatMpAccessToken(param);
            Assert.IsTrue(res.StatusCode == 200);
        }
    }
}
