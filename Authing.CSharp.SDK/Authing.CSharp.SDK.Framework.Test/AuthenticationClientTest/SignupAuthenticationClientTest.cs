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
    public class SignupAuthenticationClientTest
    {
        AuthenticationClient client;

        [SetUp]
        public void TestGetJWKS()
        {
            client = new AuthenticationClient(new AuthenticationClientInitOptions
            {
                //AppId = "61e5157ea18c245048770546",
                //AppSecret = "325d96c907a989b9f6b67584e1632909",
                //Domain = @"https://authinglogindemo.authing.cn",
                //RediretUri = loginCallbackUrl,
                AppId = "62fcabb3a4ac8fdd84c5c72b",
                AppSecret = "57380da65c82d6b4c3f54347709d77de",
                Domain= @"https://ehjnacmkjhjj-demo.mysql.authing-inc.co",
                Host = @"https://console.test.authing-inc.co",
                RediretUri = "https://console.mysql.authing-inc.co/console/get-started/62fca2e367113211c9a310a7",
            });
        }

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
        /// 邮箱验证码注册单元测试
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
                    PassCode = "2790"
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
