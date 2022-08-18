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
    class LoginAuthenticationClientTest : AuthenticationClientTestBase
    {
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
