using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Authing.CSharp.SDK.Models;
using Authing.CSharp.SDK.Models.Authentication;
using Authing.CSharp.SDK.Services;
using NUnit.Framework;

namespace Authing.CSharp.SDK.Framework.Test.AuthenticationClientTest
{
    public class MfaAuthenticationClientTest:TestBase
    {
        [Test]
        public async Task SendEnroolFactorRequestTest()
        {
            LoginByCredentialsDto dto = new LoginByCredentialsDto { };
            dto.Connection = Connection.PASSWORD;
            dto.PasswordPayload = new PasswordPayload
            {
                Email = "test@test.com",
                Password= "88886666"
            };

            LoginTokenRespDto loginTokenRespDto=  await client.Signin(dto);

            Assert.IsNotNull(loginTokenRespDto);

            client.AccessToken = loginTokenRespDto.Data.AccessToken;

            var res = await client.SendEnroolFactorRequest(new SendEnrollFactorRequestDto()
            {
                FactorType = FactorType.SMS,
                Profile = new SendEnrollFactorProfileDto()
                {
                    PhoneCountryCode = "+86",
                    PhoneNumber = "17665662048",
                }
            });
        }
    }
}
