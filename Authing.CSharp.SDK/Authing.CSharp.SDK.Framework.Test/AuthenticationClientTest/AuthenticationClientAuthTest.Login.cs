using System.Threading.Tasks;
using Authing.CSharp.SDK.Framework.Test.AuthenticationClientTest;
using Authing.CSharp.SDK.Models;
using NUnit.Framework;

namespace Authing.CSharp.SDK.Framework.Test
{
    public partial class AuthenticationClientAuthTest
    {
        [Test]
        public async Task LoginByAccountPassword_Normal()
        {
            var res = await client.SignInByAccountPassword("qidong5566", "3866364");

            Assert.AreEqual(200, res.StatusCode);
        }

        [Test]
        public async Task LoginByAccountPassword_With_Options()
        {
            SignInOptionsDto option = new SignInOptionsDto();
            option.PasswordEncryptType = SignInOptionsDto.passwordEncryptType.NONE;

            var res = await client.SignInByUsernamePassword("qidong88999", "3866364");

            Assert.AreEqual(200, res.StatusCode);

        }

        [Test]
        public async Task LoginByUsernamePassword_With_Options()
        {
            SignInOptionsDto option = new SignInOptionsDto();
            option.PasswordEncryptType = SignInOptionsDto.passwordEncryptType.NONE;
            option.AutoRegister = true;

            var res = await client.SignInByUsernamePassword("qidong8898899", "3866364",option);

            Assert.AreEqual(200, res.StatusCode);

        }

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
        /// 2022-11-1 测试通过
        /// 通过手机验证码登录
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task LoginByPhoneWithCode()
        {
            var res1 = await client.SendSms(new SendSMSDto()
            {
                PhoneNumber = "13348926753",
                Channel = SendSMSDto.channel.CHANNEL_LOGIN
            });
            Assert.AreEqual(200, res1.StatusCode);
            var res2 = await client.SignInByPhonePassCode("13348926753", "8341");
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
            var res2 = await client.SignInByUsernamePassword("tmgg", "88886666",new SignInOptionsDto { AutoRegister=true,PasswordEncryptType=SignInOptionsDto.passwordEncryptType.NONE});
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
        /// 2022-11-1 测试成功
        /// 使用 AD 账户密码登录
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task LoginByAD()
        {
            var res2 = await client.SignInByAD("authingtest", "88886666");
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

        /// <summary>
        /// 2022-10-18 测试通过
        /// 获取图形验证码
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GeneCaptchaCodeTest()
        {
            var res = await client.GeneQrCode(new GenerateQrcodeDto()
            {
                Type = GenerateQrcodeDto.type.MOBILE_APP
            });

            Assert.Equals(200, res.StatusCode);
        }

        /// <summary>
        /// TODO:用于获取发起支付宝认证需要的初始化参数 AuthInfo
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetAlipayAuthInfoTest()
        {
            var res = await client.GetAlipayAuthInfo("1660291866076");
        }

        /// <summary>
        /// 2022-10-18 测试成功
        /// 生成登录二维码测试
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GeneQrCodeTest()
        {
            var res = await client.GeneQrCode(new GenerateQrcodeDto()
            {
                Type = GenerateQrcodeDto.type.MOBILE_APP
            });
            Assert.AreEqual(200, res.StatusCode);
        }

        /// <summary>
        /// 2022-10-18 测试失败
        /// 查询二维码扫码状态
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task CheckQrCodeStatusTest()
        {
            var res = await client.GeneQrCode(new GenerateQrcodeDto()
            {
                Type = GenerateQrcodeDto.type.MOBILE_APP
            });
            Assert.AreEqual(200, res.StatusCode);
            var res2 = await client.CheckQrCodeStatus(res.Data.QrcodeId);
            Assert.AreEqual(200, res2.StatusCode);
        }

        /// <summary>
        /// 2022-10-18 测试失败
        /// 使用二维码 ticket 换取 TokenSet
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task ExchangeTokenSetWithQrCodeTicketTest()
        {
            var res = await client.GeneQrCode(new GenerateQrcodeDto()
            {
                Type = GenerateQrcodeDto.type.MOBILE_APP
            });
            Assert.AreEqual(200, res.StatusCode);
            var res2 = await client.CheckQrCodeStatus(res.Data.QrcodeId);
            Assert.AreEqual(200, res2.StatusCode);
            var res3 = await client.ExchangeTokenSetWithQrCodeTicket(new ExchangeTokenSetWithQRcodeTicketDto()
            {
                Ticket = res2.Data.Ticket
            });
            Assert.AreEqual(200, res2.StatusCode);
        }

        /// <summary>
        /// 2022-10-18 测试失败
        /// 自建 APP 扫码登录：修改二维码状态测试
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task ChangeQrCodeStatusTest()
        {
            var res = await client.GeneQrCode(new GenerateQrcodeDto()
            {
                Type = GenerateQrcodeDto.type.MOBILE_APP
            });
            Assert.AreEqual(200, res.StatusCode);
            var res2 = await client.ChangeQrCodeStatus(new ChangeQRCodeStatusDto()
            {
                QrcodeId = res.Data.QrcodeId,
                Action = ChangeQRCodeStatusDto.action.SCAN
            });
            var res3 = await client.CheckQrCodeStatus(res.Data.QrcodeId);
            Assert.AreEqual(200, res2.StatusCode);
        }

        /// <summary>
        /// 2022-10-18
        /// TODO:使用移动端社会化登录
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task SignInByMobileTest()
        {
            var res = await client.SignInByMobile(new SigninByMobileDto()
            {
                Connection = SigninByMobileDto.connection.WECHAT,
                ExtIdpConnidentifier = "xxxxxx",
            });
        }
    }
}
