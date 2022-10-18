using System.Threading.Tasks;
using Authing.CSharp.SDK.Models;
using NUnit.Framework;

namespace Authing.CSharp.SDK.Framework.Test.AuthenticationClientTest
{
    public partial class AuthenticationClientAuthTest : AuthenticationClientTestBase
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
        /// 2022-10-18 测试失败
        /// 获取用户登录日志
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetUserLogs()
        {
            var res = await client.DecryptWechatMiniProgramData1();
            Assert.AreEqual(200, res.StatusCode);
        }

        /// <summary>
        /// 2022-10-18 测试成功
        /// 获取用户登录的应用
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetLoggedInAppsTest()
        {
            var res = await client.GetLoggedInApps();
            Assert.AreEqual(200, res.StatusCode);
        }

        /// <summary>
        /// 2022-10-18 测试成功
        /// 获取用户可访问的应用
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetAccessibleAppsTest()
        {
            var res = await client.GetAccessibleApps();
            Assert.AreEqual(200, res.StatusCode);
        }

        /// <summary>
        /// 2022-10-18 测试成功
        /// 获取用户的部门列表
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetDepartmentListTest()
        {
            var res = await client.GetDepartmentList();
            Assert.AreEqual(200, res.StatusCode);
        }

        /// <summary>
        /// 2022-10-18 测试失败
        /// 获取用户被授权的资源列表
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetAuthorizedResourcesTest()
        {
            var res = await client.GetAuthorizedResources("DATA","iQpUp84lsd3rKcVXOcnfbofBiOrVB2");
            Assert.AreEqual(200, res.StatusCode);
        }
    }
}
