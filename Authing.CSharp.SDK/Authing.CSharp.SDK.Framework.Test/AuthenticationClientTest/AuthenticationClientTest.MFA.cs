using NUnit.Framework;
using System.Linq;
using System.Threading.Tasks;
using Authing.CSharp.SDK.Models;

namespace Authing.CSharp.SDK.Framework.Test.AuthenticationClientTest
{
    public class MfaTest : AuthenticationClientTestBase
    {
        [SetUp]
        public async Task LoginTemp()
        {
            LoginTokenRespDto loginTokenRespDto = await client.SignInByAccountPassword("tmgg", "88886666");
            Assert.IsNotNull(loginTokenRespDto);
            client.setAccessToken(loginTokenRespDto.Data.Access_token);
        }

        /// <summary>
        /// 2022-10-18 测试通过
        /// 发起 MFA 绑定
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task SendEnroolFactorRequestTest()
        {
            var res = await client.SendEnrollFactorRequest(new SendEnrollFactorRequestDto()
            {
                FactorType = SendEnrollFactorRequestDto.factorType.SMS,
                Profile = new FactorProfile()
                {
                    PhoneCountryCode = "+86",
                    PhoneNumber = "17665662048",
                }
            });
            Assert.AreEqual(422,res.StatusCode);
        }

        /// <summary>
        /// 2022-10-18 测试通过
        /// 绑定 MFA
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task EnrollFactorTest()
        {
            var res = await client.SendEnrollFactorRequest(new SendEnrollFactorRequestDto()
            {
                FactorType = SendEnrollFactorRequestDto.factorType.EMAIL,
                Profile = new FactorProfile()
                {
                    Email = "574378328@qq.com",
                }
            });

            Assert.AreEqual(200,res.StatusCode);

            EnrollFactorDto param = new EnrollFactorDto
            {
                EnrollmentToken = res.Data.EnrollmentToken,
                FactorType = EnrollFactorDto.factorType.EMAIL,
                EnrollmentData = new EnrollFactorEnrollmentDataDto()
                {
                    PassCode = "2883"
                }
            };
            var result = await client.EnrollFactor(param);
            Assert.IsTrue(result.StatusCode == 200);
        }

        /// <summary>
        /// 2022-10-22 测试通过
        /// 解绑 MFA
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task ResetFactorTest()
        {

            var lists = await client.ListEnrolledFactors();
            var target = lists.Data.FirstOrDefault(i => i.FactorId.Contains("email"));
            var res = await client.ResetFactor(new ResetFactorDto { FactorId = target.FactorId });
            Assert.IsTrue(res.StatusCode == 200);
        }

        /// <summary>
        /// 2022-10-18 测试通过
        /// 获取某个已绑定的 MFA
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
        /// 2022-10-18 测试通过
        /// 获取可绑定的 MFA
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
