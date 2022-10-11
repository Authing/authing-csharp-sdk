using Authing.CSharp.SDK.Framework.Test.AuthenticationClientTest;
using Authing.CSharp.SDK.Models;
using Authing.CSharp.SDK.Models.Authentication;
using Authing.CSharp.SDK.Services;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authing.CSharp.SDK.Framework.Test
{
    public class SignupTest: AuthenticationClientTestBase
    {
        /// <summary>
        /// 邮箱和密码注册
        /// 2022-8-18 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task PasswordPayloadSignupTest()
        {
            try
            {
                SignupDto signupDto = new SignupDto() { };
                signupDto.Connection = SignupConnection.PASSWORD;
                signupDto.PasswordPayload = new SignupPasswordPayload
                {

                    Email = "2481452007@qq.com",
                    Password = "12345678"
                };


                UserSingleRespDto dto = await client.Signup(signupDto);

                Assert.IsTrue(dto.StatusCode== 200);
            }
            catch (Exception exp)
            { 
            
            }
        }

        /// <summary>
        /// 邮箱和密码注册，添加用户名
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task PasswordPayloadSignup_With_Username_Test()
        {
            SignupDto signupDto = new SignupDto { };
            signupDto.Connection = SignupConnection.PASSWORD;
            signupDto.PasswordPayload = new SignupPasswordPayload
            {
                Email = "2481452007@qq.com",
                Password="12345678 "
            };

            signupDto.Profile = new SignupProfile 
            {
                Name="qidong"
            };

            UserSingleRespDto dto = await client.Signup(signupDto);

            Assert.IsTrue(dto.StatusCode == 200);
        }

        /// <summary>
        /// 邮箱验证码注册单元测试
        /// 2022-8-18 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task PasscodePayload_Email_SignupTest()
        {
            try
            {
                SendEmailDto sendEmailDto = new SendEmailDto()
                {
                    Email = "2481452007@qq.com",
                    Channel = EmailChannel.CHANNEL_REGISTER
                };

                await client.SendEmail(sendEmailDto);

                SignupDto signupDto = new SignupDto() { };
                signupDto.Connection = SignupConnection.PASSCODE;
                signupDto.PassCodePayload = new SignupPassCodePayload
                {

                    Email = "2481452007@qq.com",
                    PassCode = "9788"
                };


                UserSingleRespDto dto = await client.Signup(signupDto);

                Assert.IsTrue(dto.StatusCode == 200);
            }
            catch (Exception exp)
            { 
                
            }
        }

        /// <summary>
        /// 手机验证码注册单元测试
        /// 2022-8-18 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task PasscodePayload_Phone_SignupTest()
        {
            try
            {
                SendSMSDto sendSMSDto = new SendSMSDto()
                {
                    PhoneNumber = "13348926753",
                    Channel=SmsChannel.CHANNEL_REGISTER,
                };

                await client.SendSms(sendSMSDto);

                SignupDto signupDto = new SignupDto() { };
                signupDto.Connection = SignupConnection.PASSCODE;
                signupDto.PassCodePayload = new SignupPassCodePayload
                {

                    Phone = "13348926753",
                    PassCode = "4396"
                };


                UserSingleRespDto dto = await client.Signup(signupDto);

                Assert.IsTrue(dto.StatusCode == 200);
            }
            catch (Exception exp)
            {

            }
        }
    }
}
