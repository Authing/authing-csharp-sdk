using Authing.CSharp.SDK.Models;
using Authing.CSharp.SDK.Models.Authentication;
using Authing.CSharp.SDK.Services;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authing.CSharp.SDK.Framework.Test.AuthenticationClientTest
{
    class LoginAuthenticationClientTest
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
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task LoginTest()
        {
            //SignupDto

            //LoginByCredentialsDto loginByCredentialsDto = new LoginByCredentialsDto() { };
            //loginByCredentialsDto.Connection = Connection.PASSWORD;
            //loginByCredentialsDto.PasswordPayload = new PasswordPayload() 
            //{
            //    Password="12345678",
            //    Email="2481452007@qq.com",
            //};


            //UserSingleRespDto dto = await client.Signin(signupDto);
        }
    }
}
