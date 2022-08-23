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

        /// <summary>
        /// 发起修改手机号请求
        /// 2022-08-22 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task UpdatePhoneRequestTest()
        {
            var loginResult = await Login();

            Assert.IsTrue(loginResult.StatusCode == 200);

            SendSMSDto unbinddto = new SendSMSDto
            {
                Channel = SmsChannel.CHANNEL_UNBIND_PHONE,
                PhoneNumber = "13348926753"
            };

            var unbindResult = await client.SendSms(unbinddto);

            Assert.IsTrue(unbindResult.StatusCode == 200);

            SendSMSDto binddto = new SendSMSDto
            {
                Channel = SmsChannel.CHANNEL_BIND_PHONE,
                PhoneNumber = "13734908267"
            };

            var bindResult = await client.SendSms(binddto);

            Assert.IsTrue(bindResult.StatusCode == 200);

            UpdatePhoneVerifyDto updatePhoneVerifyDto = new UpdatePhoneVerifyDto();
            updatePhoneVerifyDto.VerifyMethod = VerifyMethod.PHONE_PASSCODE;
            updatePhoneVerifyDto.PhonePassCodePayload = new PhonePassCodePayload
            {
                OldPhoneNumber = "13348926753",
                OldPhonePassCode = "1811",
                NewPhoneNumber = "13734908267",
                NewPhonePassCode = "1301"
            };


            var result = await client.VerifyUpdatePhoneRequest(updatePhoneVerifyDto);

            Assert.IsTrue(result.StatusCode == 200);

            UpdatePhoneDto updatePhoneDto = new UpdatePhoneDto
            {
                UpdatePhoneToken = result.Data.UpdatePhoneToken
            };

            var updateResult = await client.UpdatePhone(updatePhoneDto);

            Assert.IsTrue(updateResult.StatusCode == 200);
        }

        /// <summary>
        /// 重置密码请求测试,通过邮箱验证码进行重置
        /// 2022-08-22 测试未通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task ResetPasswordRequest_EmailPasscode_Test()
        {
            var loginResult = await Login();

            Assert.IsTrue(loginResult.StatusCode == 200);

            SendEmailDto sendEmailDto = new SendEmailDto()
            {
                Email = "635877990@qq.com",
                Channel = EmailChannel.CHANNEL_RESET_PASSWORD
            };

            var sendEmailResult = await client.SendEmail(sendEmailDto);
            Assert.IsTrue(sendEmailResult.StatusCode == 200);

            ResetPasswordVerifyDto resetPasswordVerifyDto = new ResetPasswordVerifyDto();
            resetPasswordVerifyDto.VerifyMethod = VerifyMethod.EMAIL_PASSCODE;
            resetPasswordVerifyDto.EmailPassCodePayload = new ResetPasswordEmailPassCodePayload
            {
                Email = "635877990@qq.com",
                PassCode = "8007",
            };

            var result = await client.VerifyResetPasswordRequest(resetPasswordVerifyDto);
            Assert.IsTrue(result.StatusCode == 200);

            ResetPasswordDto resetPasswordDto = new ResetPasswordDto();
            resetPasswordDto.Password = "3866364";
            resetPasswordDto.PasswordResetToken = result.Data.PasswordResetToken;

            var resetResult = await client.ResetPassword(resetPasswordDto);

            Assert.IsTrue(resetResult.StatusCode == 200);
        }

        /// <summary>
        /// 重置密码请求测试,通过手机验证码进行重置
        /// 2022-08-22 测试未通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task ResetPasswordRequest_PhonePassCode_Test()
        {
            var loginResult = await Login();

            Assert.IsTrue(loginResult.StatusCode == 200);

            SendSMSDto sendSMSDto = new SendSMSDto()
            {
                PhoneNumber = "13734908267",
                Channel = SmsChannel.CHANNEL_RESET_PASSWORD
            };

            var sendEmailResult = await client.SendSms(sendSMSDto);
            Assert.IsTrue(sendEmailResult.StatusCode == 200);

            ResetPasswordVerifyDto resetPasswordVerifyDto = new ResetPasswordVerifyDto();
            resetPasswordVerifyDto.VerifyMethod = VerifyMethod.PHONE_PASSCODE;
            resetPasswordVerifyDto.PhonePassCodePayload = new ResetPasswordPhonePassCodePayload
            {
                PhoneNumber = "13734908267",
                PassCode = "1956",
            };

            var result = await client.VerifyResetPasswordRequest(resetPasswordVerifyDto);
            Assert.IsTrue(result.StatusCode == 200);

            ResetPasswordDto resetPasswordDto = new ResetPasswordDto();
            resetPasswordDto.Password = "3866364";
            resetPasswordDto.PasswordResetToken = result.Data.PasswordResetToken;

            var resetResult = await client.ResetPassword(resetPasswordDto);

            Assert.IsTrue(resetResult.StatusCode == 200);
        }

        /// <summary>
        /// 注销账户测试，邮箱验证码
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task DeleteAccountTest()
        {
            var loginResult = await Login();

            Assert.IsTrue(loginResult.StatusCode == 200);

            SendEmailDto sendEmailDto = new SendEmailDto() 
            {
                Email="635877990@qq.com",
                Channel=EmailChannel.CHANNEL_DELETE_ACCOUNT
            };
            var sendEmailResult = await client.SendEmail(sendEmailDto);

            Assert.IsTrue(sendEmailResult.StatusCode == 200);


            DeleteAccountVerifyDto deleteAccountVerifyDto = new DeleteAccountVerifyDto();
            deleteAccountVerifyDto.VerifyMethod = VerifyMethod.EMAIL_PASSCODE;
            deleteAccountVerifyDto.EmailPassCodePayload = new DeleteAccountEmailPassCodePayload()
            {
                Email = "635877990@qq.com",
                PassCode = "",
            };


            var requestResult = await client.VerifyDeleteAccountRequest(deleteAccountVerifyDto);

            Assert.IsTrue(requestResult.StatusCode == 200);

            DeleteAccountDto deleteAccountDto = new DeleteAccountDto { DeleteAccountToken = requestResult.Data.deleteAccountToken };

            var result = await client.DeleteAccount(deleteAccountDto);

            Assert.IsTrue(requestResult.StatusCode == 200);
        }

        /// <summary>
        /// 注销账户测试,手机号验证码
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task DeleteAccount_Phone_PassCode_Test()
        {
            var loginResult = await Login();

            Assert.IsTrue(loginResult.StatusCode == 200);

            SendSMSDto  sendSMSDto= new SendSMSDto()
            {
                PhoneNumber = "13348926753",
                Channel =SmsChannel.CHANNEL_DELETE_ACCOUNT
            };
            var sendEmailResult = await client.SendSms(sendSMSDto);

            Assert.IsTrue(sendEmailResult.StatusCode == 200);


            DeleteAccountVerifyDto deleteAccountVerifyDto = new DeleteAccountVerifyDto();
            deleteAccountVerifyDto.VerifyMethod = VerifyMethod.PHONE_PASSCODE;
            deleteAccountVerifyDto.PhonePassCodePayload = new DeleteAccountPhonePassCodePayload()
            {
                PhoneNumber = "13348926753",
                PassCode = "8092",
            };


            var requestResult = await client.VerifyDeleteAccountRequest(deleteAccountVerifyDto);

            Assert.IsTrue(requestResult.StatusCode == 200);

            DeleteAccountDto deleteAccountDto = new DeleteAccountDto { DeleteAccountToken = requestResult.Data.deleteAccountToken };

            var result = await client.DeleteAccount(deleteAccountDto);

            Assert.IsTrue(requestResult.StatusCode == 200);
        }

        /// <summary>
        /// 注销账户测试,手机号验证码
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task DeleteAccount_Password_Test()
        {
            var loginResult = await Login();

            Assert.IsTrue(loginResult.StatusCode == 200);

            DeleteAccountVerifyDto deleteAccountVerifyDto = new DeleteAccountVerifyDto();
            deleteAccountVerifyDto.VerifyMethod = VerifyMethod.PASSWORD;
            deleteAccountVerifyDto.PasswordPayload = new DeleteAccountPasswordPayload()
            {
                Password = "12345678",
            };


            var requestResult = await client.VerifyDeleteAccountRequest(deleteAccountVerifyDto);

            Assert.IsTrue(requestResult.StatusCode == 200);

            DeleteAccountDto deleteAccountDto = new DeleteAccountDto { DeleteAccountToken = requestResult.Data.deleteAccountToken };

            var result = await client.DeleteAccount(deleteAccountDto);

            Assert.IsTrue(requestResult.StatusCode == 200);
        }
    }
}
