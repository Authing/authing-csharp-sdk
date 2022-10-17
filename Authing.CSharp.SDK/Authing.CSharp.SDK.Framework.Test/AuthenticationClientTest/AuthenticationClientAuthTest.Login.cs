using System.Threading.Tasks;
using Authing.CSharp.SDK.Framework.Test.AuthenticationClientTest;
using Authing.CSharp.SDK.Models;
using NUnit.Framework;

namespace Authing.CSharp.SDK.Framework.Test
{
    public partial class AuthenticationClientAuthTest : AuthenticationClientTestBase
    {
        /// <summary>
        /// 2022-10-17 测试通过
        /// 通过邮箱密码登录
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task LoginByEmailWithPassword()
        {
            var res = await client.SignInByEmailPassword("574378328@qq.com", "88886666");
            Assert.AreEqual(200, res.StatusCode);
        }

        /// <summary>
        /// 2022-10-17 测试失败
        /// 通过手机验证码登录
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task LoginByPhoneWithCode()
        {
            var res1 = await client.SendSms(new SendSMSDto()
            {
                PhoneNumber = "17665662048",
                Channel = SendSMSDto.channel.CHANNEL_LOGIN
            });
            Assert.AreEqual(200, res1.StatusCode);
            var res2 = await client.SignInByPhonePassCode("17665662048", "88886666");
            Assert.AreEqual(200, res2.StatusCode);
        }

        /// <summary>
        /// 2022-10-17 测试成功
        /// 通过手机密码登录
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task LoginByPhoneWithPassword()
        {
            var res2 = await client.SignInByPhonePassword("17665662048", "88886666");
            Assert.AreEqual(200, res2.StatusCode);
        }

        /// <summary>
        /// 2022-10-17 测试成功
        /// 通过用户名密码登录
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task LoginByUserNameWithPassword()
        {
            var res2 = await client.SignInByUsernamePassword("tmgg", "88886666");
            Assert.AreEqual(200, res2.StatusCode);
        }

        /// <summary>
        /// 2022-10-17 测试成功
        /// 通过三合一登录方式登录
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task LoginByUserAccountWithPassword()
        {
            var res2 = await client.SignInByAccountPassword("tmgg", "88886666");
            Assert.AreEqual(200, res2.StatusCode);
        }

        /// <summary>
        /// 2022-10-17 测试成功
        /// 通过邮箱验证码登录
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task LoginByMailWithCode()
        {
            var res1 = await client.SendEmail(new SendEmailDto()
            {
                Email = "574378328@qq.com",
                Channel = SendEmailDto.channel.CHANNEL_LOGIN
            });
            Assert.AreEqual(200, res1.StatusCode);
            var res2 = await client.SignInByEmailPassCode("574378328@qq.com", "9562");
            Assert.AreEqual(200, res2.StatusCode);
        }

        /// <summary>
        /// TODO:通过 AD 账号密码登录
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task LoginByAD()
        {
            var res2 = await client.SignInByAD("Administrator", "1234");
            Assert.AreEqual(200, res2.StatusCode);
        }

        /// <summary>
        /// TODO:通过 LDAP 账号密码登录
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task LoginByLDAP()
        {
            var res2 = await client.signInByLDAP("Administrator", "1234");
            Assert.AreEqual(200, res2.StatusCode);
        }
    }
}
