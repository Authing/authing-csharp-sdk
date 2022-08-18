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
    class SigninAuthenticationClientTest
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
                Domain = @"https://ehjnacmkjhjj-demo.mysql.authing-inc.co",
                Host = @"https://console.test.authing-inc.co",
                RediretUri = "https://console.mysql.authing-inc.co/console/get-started/62fca2e367113211c9a310a7",
            });
        }

        /// <summary>
        /// 登录测试
        /// 2022-8-18 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task Signin_Email_Password_Test()
        {
            SignupDto signupDto = new SignupDto() { };
            signupDto.Connection = SignupConnection.PASSWORD;
            signupDto.PasswordPayload = new SignupPasswordPayload
            {

                Email = "2481452007@qq.com",
                Password = "12345678"
            };


            UserSingleRespDto dto = await client.Signup(signupDto);

            Assert.IsTrue(dto.StatusCode == 200);

            LoginByCredentialsDto loginDto = new LoginByCredentialsDto { };
            loginDto.Connection = Connection.PASSWORD;
            loginDto.PasswordPayload = new PasswordPayload
            {
                Email = "2481452007@qq.com",
                Password = "12345678"
            };

            LoginTokenRespDto loginTokenRespDto = await client.Signin(loginDto);

            Assert.IsNotEmpty(loginTokenRespDto.Data.AccessToken);

            signupDto = new SignupDto() { };
            signupDto.Connection = SignupConnection.PASSWORD;
            signupDto.PasswordPayload = new SignupPasswordPayload
            {

                Email = "2481452007@qq.com",
                Password = "12345678"
            };
        }

        /// <summary>
        /// 账号密码登录测试
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task Signin_Account_Password_Test()
        {
            LoginByCredentialsDto loginDto = new LoginByCredentialsDto { };
            loginDto.Connection = Connection.PASSWORD;
            loginDto.PasswordPayload = new PasswordPayload 
            {
                Account="qidong1122",
                Password="3866364"
            };

            LoginTokenRespDto loginTokenRespDto = await client.Signin(loginDto);

            Assert.IsNotEmpty(loginTokenRespDto.Data.AccessToken);
        }

        /// <summary>
        /// 用户名密码登录测试
        /// 2022-8-18 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task Signin_Username_Password_Test()
        {
            LoginByCredentialsDto loginDto = new LoginByCredentialsDto { };
            loginDto.Connection = Connection.PASSWORD;
            loginDto.PasswordPayload = new PasswordPayload
            {
                UserName = "qidong1122",
                Password = "3866364"
            };

            LoginTokenRespDto loginTokenRespDto = await client.Signin(loginDto);

            Assert.IsNotEmpty(loginTokenRespDto.Data.AccessToken);
        }
    }
}
