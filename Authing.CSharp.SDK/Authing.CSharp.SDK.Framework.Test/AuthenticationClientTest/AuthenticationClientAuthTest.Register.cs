using System.Threading.Tasks;
using Authing.CSharp.SDK.Models;
using NUnit.Framework;

namespace Authing.CSharp.SDK.Framework.Test
{
    public partial class AuthenticationClientAuthTest
    {
        /// <summary>
        /// 2022-10-17 测试通过
        /// 使用邮箱密码注册
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task RegisterByEmailAndPassword()
        {
            var res = await client.SignUpByEmailPassword("574378328@qq.com", "88886666",
                profile: new SignUpProfileDto()
                {
                    Gender = SignUpProfileDto.gender.M
                });
            Assert.AreEqual(200, res.StatusCode);
        }

        /// <summary>
        /// 2022-11-1 测试通过
        /// 使用邮箱验证码注册
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task RegisterByEmailAndCode()
        {
            var res1 = await client.SendEmail(new SendEmailDto()
            {
                Email = "2481452007@qq.com",
                Channel = SendEmailDto.channel.CHANNEL_REGISTER
            });
            Assert.AreEqual(200, res1.StatusCode);
            var res2 = await client.SignUpByEmailCode("2481452007@qq.com", "8115",
                profile: new SignUpProfileDto()
                {
                    Gender = SignUpProfileDto.gender.M
                });
            Assert.AreEqual(200, res2.StatusCode);
        }

        /// <summary>
        /// 2022-11-1 测试通过
        /// 使用手机验证码注册
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task RegisterByPhoneAndCode()
        {
            var res1 = await client.SendSms(new SendSMSDto()
            {
                PhoneNumber = "17620671314",
                Channel = SendSMSDto.channel.CHANNEL_REGISTER
            });
            Assert.AreEqual(200, res1.StatusCode);
            var res2 = await client.SignUpByPhoneCode("17620671314", "6825",
                profile: new SignUpProfileDto()
                {
                    Gender = SignUpProfileDto.gender.M
                });
            Assert.AreEqual(200, res2.StatusCode);
        }

        /// <summary>
        /// 2022-10-21 测试成功
        /// 使用用户名密码注册
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task RegisterByUserNameAndPassword()
        {
            var res = await client.signUpByUsernamePassword("test", "88886666",
                profile: new SignUpProfileDto()
                {
                    Gender = SignUpProfileDto.gender.M
                });
            Assert.AreEqual(200, res.StatusCode);
        }

    }
}
