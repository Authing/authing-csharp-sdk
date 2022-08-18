using Authing.CSharp.SDK.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authing.CSharp.SDK.Framework.Test.AuthenticationClientTest
{
    public class ProfileTest:AuthenticationClientTestBase
    {
        [Test]
        public async Task GetProfileTest()
        {
            LoginByCredentialsDto loginDto = new LoginByCredentialsDto { };
            loginDto.Connection = Connection.PASSWORD;
            loginDto.PasswordPayload = new PasswordPayload
            {
                UserName = "qidong1122",
                Password = "3866364"
            };

            LoginTokenRespDto loginTokenRespDto = await client.Signin(loginDto);

            await client.GetProfile();
        }
    }
}
