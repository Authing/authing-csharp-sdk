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
            var res = await client.GetAuthorizedResources("DATA", "iQpUp84lsd3rKcVXOcnfbofBiOrVB2");
            Assert.AreEqual(200, res.StatusCode);
        }

        /// <summary>
        /// 2022-10-18 测试成功
        /// 获取用户资料
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetProfileTest()
        {
            var res = await client.GetProfile();
            Assert.AreEqual(200, res.StatusCode);
        }

        /// <summary>
        /// 2022-10-18 测试成功
        /// 更新用户资料
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task UpdateProfileTest()
        {
            var res = await client.UpdateProfile(new UpdateUserProfileDto()
            {
                Gender = UpdateUserProfileDto.gender.M
            });
            Assert.AreEqual(200, res.StatusCode);
        }

        /// <summary>
        /// 2022-10-18 测试成功
        /// 绑定邮箱
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task BindEmailTest()
        {
            var res1 = await client.SendEmail(new SendEmailDto()
            {
                Email = "574378328@qq.com",
                Channel = SendEmailDto.channel.CHANNEL_BIND_EMAIL
            });
            Assert.AreEqual(200, res1.StatusCode);
            var res2 = await client.BindEmail(new BindEmailDto()
            {
                Email = "574378328@qq.com",
                PassCode = "1787",
            });
            Assert.AreEqual(200, res2.StatusCode);
        }

        /// <summary>
        /// 2022-10-18 测试成功
        /// 解绑邮箱
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task UnBindEmailTest()
        {
            var res = await client.UnbindEmail();
            Assert.AreEqual(200, res.StatusCode);
        }

        /// <summary>
        /// TODO:绑定手机
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task BindPhoneTest()
        {
            var res1 = await client.SendSms(new SendSMSDto()
            {
                PhoneNumber = "17665662048",
                Channel = SendSMSDto.channel.CHANNEL_BIND_PHONE
            });
            Assert.AreEqual(200, res1.StatusCode);
            var res2 = await client.BindPhone(new BindPhoneDto()
            {
                PhoneNumber = "17665662048",
                PassCode = "1787",
            });
            Assert.AreEqual(200, res2.StatusCode);
        }

        /// <summary>
        /// TODO:解绑手机
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task UnBindPhoneTest()
        {
            var res = await client.UnbindPhone();
            Assert.AreEqual(200, res.StatusCode);
        }

    }
}
