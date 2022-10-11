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
    public class MfaTest : AuthenticationClientTestBase
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
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task SendEnroolFactorRequestTest()
        {
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

        /// <summary>
        /// 2022-8-22 测试不通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task EnrollFactorTest()
        {
            var res = await client.SendEnroolFactorRequest(new SendEnrollFactorRequestDto()
            {
                FactorType = FactorType.SMS,
                Profile = new SendEnrollFactorProfileDto()
                {
                    PhoneCountryCode = "+86",
                    PhoneNumber = "17665662048",
                }
            });

            EnrollFactorDto param = new EnrollFactorDto
            {
                EnrollmentToken = res.Data.EnrollmentToken,
                FactorType = FactorType.SMS,
                EnrollmentData = new EnrollmentData
                {
                    PassCode = "1234"
                }
            };
            var result = await client.EnrollFactor(param);
            Assert.IsTrue(result.StatusCode == 200);
        }

        /// <summary>
        /// 2022-8-22 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task ResetFactorTest()
        {

            var lists = await client.ListEnrolledFactors();
            var target = lists.Data.FirstOrDefault(i => i.FactorId.Contains("email"));
            var res = await client.ResetFactor(new RestFactorDto { FactorId = target.FactorId });
            Assert.IsTrue(res.StatusCode == 200);
        }

        /// <summary>
        /// 2022-8-22 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetFactorTest()
        {
            var lists = await client.ListEnrolledFactors();
            var res = await client.GetFactor(lists.Data.First().FactorId);
            Assert.NotNull(res.Data);
        }

        /// <summary>
        /// 2022-8-22 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task ListFactorsToEnrollTest()
        {
            var lists = await client.ListFactorsToEnroll();
            Assert.NotNull(lists.Data);
        }
    }
}
