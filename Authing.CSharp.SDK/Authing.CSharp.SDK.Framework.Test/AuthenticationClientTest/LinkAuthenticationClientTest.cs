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
    public class LinkAuthenticationClientTest: AuthenticationClientTestBase
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
        /// TODO:该接口是个 302 跳转
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task LinkExtIdpTest()
        {
            LoginByCredentialsDto dto = new LoginByCredentialsDto { };
            dto.Connection = Connection.PASSWORD;
            dto.PasswordPayload = new PasswordPayload
            {
                Email = "test@test.com",
                Password = "88886666"
            };

            LoginTokenRespDto loginTokenRespDto = await client.Signin(dto);
            var param = new LinkExtIdpParams() { AppId = "61c2d04b36324259776af784",
                ExtIdpConnIdentifier = "github" , IdToken = loginTokenRespDto.Data.IdToken};

            var res = await client.LinkExtIdp(param);
        }

        /// <summary>
        /// 2022-8-22 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task ULinkExtIdpTest()
        {
            var res = await client.ULinkExtIdp("62f209327xxxxcc10d966ee5");
            Assert.IsTrue(res.StatusCode == 200);
        }

        /// <summary>
        /// 2022-8-22 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetIdentitiesTest()
        {
            var res = await client.GetIdentities();
            Assert.IsNotEmpty(res.Data);
        }

        /// <summary>
        /// 2022-8-22 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetExtIdpsTest()
        {
            var res = await client.GetExtIdps();
            Assert.IsNotEmpty(res.Data);
        }
    }
}
