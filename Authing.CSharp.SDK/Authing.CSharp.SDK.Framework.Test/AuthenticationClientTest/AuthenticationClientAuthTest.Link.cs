using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Authing.CSharp.SDK.Models;
using Authing.CSharp.SDK.Models.Authentication;

namespace Authing.CSharp.SDK.Framework.Test.AuthenticationClientTest
{
    public class LinkTest : AuthenticationClientTestBase
    {
        public string IdToken { get; set; }
        [SetUp]
        public async Task LoginTemp()
        {
            LoginTokenRespDto loginTokenRespDto = await client.SignInByAccountPassword("tmgg", "88886666");
            Assert.IsNotNull(loginTokenRespDto);
            client.setAccessToken(loginTokenRespDto.Data.Access_token);
            IdToken = loginTokenRespDto.Data.Id_token;
        }

        /// <summary>
        /// 2022-10-18 测试不通过
        /// TODO:该接口是个 302 跳转
        /// 绑定外部身份源
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task LinkExtIdpTest()
        {
            var res = await client.LinkExtIdp("github", "61c2d04b36324259776af784", IdToken);
        }

        /// <summary>
        /// 2022-10-18 测试通过
        /// 解绑外部身份源
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task ULinkExtIdpTest()
        {
            var res = await client.UnbindExtIdp(
                new UnbindExtIdpDto()
                {
                    ExtIdpId = "62f209327xxxxcc10d966ee5"
                });
            Assert.IsTrue(res.StatusCode == 200);
        }

        /// <summary>
        /// 2022-10-18 测试通过
        /// 获取绑定的身份源
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetIdentitiesTest()
        {
            var res = await client.GetIdentities();
            Assert.IsNotEmpty(res.Data);
        }

        /// <summary>
        /// 2022-10-18 测试通过
        /// 获取应用已开启的外部身份源
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetExtIdpsTest()
        {
            var res = await client.GetExtIdps();
            Assert.IsNotEmpty(res.Data);
        }

        /// <summary>
        /// 生成绑定外部身份源的链接
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GenerateLinkExtIdpUrlTest()
        {
            var res = await client.GenerateLinkExtIdpUrl("github", "634cf413700f1170a31a0f77", IdToken);
            Assert.AreEqual(404, res.StatusCode);
        }
    }
}
