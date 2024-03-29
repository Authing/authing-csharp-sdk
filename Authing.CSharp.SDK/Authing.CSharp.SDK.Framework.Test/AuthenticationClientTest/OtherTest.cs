﻿using Authing.CSharp.SDK.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authing.CSharp.SDK.Framework.Test.AuthenticationClientTest
{
    public class OtherTest : AuthenticationClientTestBase
    {
        private async Task<LoginTokenRespDto> Login()
        {
            LoginByCredentialsDto loginDto = new LoginByCredentialsDto { };
            loginDto.Connection = Connection.PASSWORD;
            loginDto.PasswordPayload = new PasswordPayload
            {
                UserName = "qidong1122",
                Password = "3866364"
            };

            LoginTokenRespDto loginTokenRespDto = await client.Signin(loginDto);

            return loginTokenRespDto;
        }

        /// <summary>
        /// 获取系统信息
        /// 2022-09-08 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetSystemInfoTest()
        {
            var result = await Login();

            Assert.NotNull(result);

            var systemInfo = await client.System();

            Assert.NotNull(systemInfo);
        }

    }
}
