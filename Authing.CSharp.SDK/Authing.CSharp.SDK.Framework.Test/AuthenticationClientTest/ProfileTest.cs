using Authing.CSharp.SDK.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authing.CSharp.SDK.Framework.Test.AuthenticationClientTest
{
    public class ProfileTest : AuthenticationClientTestBase
    {
        private async Task<LoginTokenRespDto> Login()
        {
            LoginByCredentialsDto loginDto = new LoginByCredentialsDto { };
            loginDto.Connection = Connection.PASSWORD;
            loginDto.PasswordPayload = new PasswordPayload
            {
                UserName = "qidong1122",
                Password = "12345678"
            };

            LoginTokenRespDto loginTokenRespDto = await client.Signin(loginDto);

            return loginTokenRespDto;
        }

        /// <summary>
        /// 测试获取用户信息
        /// 2022-8-19 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetProfileTest()
        {
            await Login();

            var result = await client.GetProfile();

            Assert.IsTrue(result.StatusCode == 200);
        }

        /// <summary>
        /// 测试更新用户信息
        /// 2022-8-19 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task UpdateProfileTest()
        {
            await Login();

            UpdateUserReqDto updateUserReqDto = new UpdateUserReqDto();
            updateUserReqDto.Address = "sichuan chengdu huayang";

            var result = await client.UpdateProfile(updateUserReqDto);

            Assert.IsTrue(result.StatusCode == 200);

        }

        /// <summary>
        /// 测试绑定邮箱
        /// 2022-08-19
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task BindEmailTest()
        {
            await Login();

            SendEmailDto sendEmailDto = new SendEmailDto();
            sendEmailDto.Email = "qidong5566@outlook.com";
            sendEmailDto.Channel = EmailChannel.CHANNEL_BIND_EMAIL;

            var result = await client.SendEmail(sendEmailDto);

            Assert.IsTrue(result.StatusCode == 200);

            //需要收到邮箱验证码手，填入到下面

            BindEmailDto bindEmailDto = new BindEmailDto();
            bindEmailDto.Email = "qidong5566@outlook.com";
            bindEmailDto.PassCode = "2092";

            var bindResult = await client.BindEmail(bindEmailDto);

            Assert.IsTrue(bindResult.StatusCode == 200);
        }

        /// <summary>
        /// 绑定手机号测试
        /// 2022-8-19 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task BindPhoneTest()
        {
            await Login();

            SendSMSDto sendSMSDto = new SendSMSDto();
            sendSMSDto.PhoneNumber = "13348926753";
            sendSMSDto.Channel = SmsChannel.CHANNEL_BIND_PHONE;

            var result = await client.SendSms(sendSMSDto);

            Assert.IsTrue(result.StatusCode == 200);

            //需要收到短信验证码手，填入到下面

            BindPhoneDto bindPhoneDto = new BindPhoneDto();
            bindPhoneDto.PhoneNumber = "13348926753";
            bindPhoneDto.PassCode = "9857";

            var bindResult = await client.BindPhone(bindPhoneDto);

            Assert.IsTrue(bindResult.StatusCode == 200);

        }

        /// <summary>
        /// 获取安全等级测试
        /// 2022-08-19 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetSecurityInfoTest()
        {
            await Login();

            var result = await client.GetSecurityInfo();

            Assert.IsTrue(result.StatusCode == 200);
        }

        /// <summary>
        /// 更新密码测试
        /// 2022-08-19 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task UpdatePasswordTest()
        {
            await Login();

            UpdatePasswordDto updatePasswordDto = new UpdatePasswordDto();
            updatePasswordDto.OldPassword = "3866364";
            updatePasswordDto.NewPassword = "12345678";

            var result = await client.UpdatePassword(updatePasswordDto);

            Assert.IsTrue(result.StatusCode == 200);
        }

        /// <summary>
        /// 发起修改邮箱请求
        /// 2022-08-22 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task UpdateEmailRequestTest()
        {
            var loginResult = await Login();

            Assert.IsTrue(loginResult.StatusCode == 200);

            SendEmailDto sendEmailDto = new SendEmailDto()
            {
                Email = "qidong5566@outlook.com",
                Channel = EmailChannel.CHANNEL_UNBIND_EMAIL,
            };

            var unBindResult = await client.SendEmail(sendEmailDto);

            Assert.IsTrue(unBindResult.StatusCode == 200);

            SendEmailDto bindEmailDt = new SendEmailDto()
            {
                Email = "635877990@qq.com",
                Channel = EmailChannel.CHANNEL_BIND_EMAIL
            };

            var bindResult = await client.SendEmail(bindEmailDt);

            Assert.IsTrue(bindResult.StatusCode == 200);


            UpdateEmailVerifyDto updateEmailVerifyDto = new UpdateEmailVerifyDto();
            updateEmailVerifyDto.VerifyMethod = VerifyMethod.EMAIL_PASSCODE;
            updateEmailVerifyDto.EmailPasscodePayload = new EmailPasscodePayload
            {
                OldEmail = "qidong5566@outlook.com",
                OldEmailPassCode = "1758",
                NewEmail = "635877990@qq.com",
                NewEmailPassCode = "2553",
            };

            var verifyEmailResult = await client.VerifyUpdateEmailRequest(updateEmailVerifyDto);

            Assert.IsTrue(verifyEmailResult.StatusCode == 200);

            UpdateEmailDto updateEmailDto = new UpdateEmailDto();
            updateEmailDto.UpdateEmailToken = verifyEmailResult.Data.UpdateEmailToken;

            var updateEmailResult = await client.UpdateEmail(updateEmailDto);

            Assert.IsTrue(updateEmailResult.StatusCode == 200);
        }

        public async Task UpdatePhoneRequestTest()
        { 
            
        }

    }
}
