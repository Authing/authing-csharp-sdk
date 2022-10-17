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
    public class AuthenticationClientAuthTest
    {
        string loginCallbackUrl = @"https://www.baidu.com";
        AuthenticationClient client;
        string code = @"Vg-wCoxIcCWroW18sSB0E0JWwsKsFfeOBMDy0j4SUAD";

        [SetUp]
        public void TestGetJWKS()
        {
            client = new AuthenticationClient(new AuthenticationClientInitOptions
            {
                //AppId = "61e5157ea18c245048770546",
                //AppSecret = "325d96c907a989b9f6b67584e1632909",
                //Domain = @"https://authinglogindemo.authing.cn",
                //RediretUri = loginCallbackUrl,
                AppId = "6343bb084f16915f1becc730",
                AppSecret = "8ebe5abcc740f3bde1ba29621557675c",
                AppHost = @"https://dwsfwf.cj.mereith.com",
                Host = @"http://8.142.39.176:3000",
                RedirectUri = loginCallbackUrl,
            }); 
        }

        [Test]
        public void LoginWithRedirectTest()
        {
            var loginUrl = client.BuildAuthUrl(scope: "openid profile offline_access");
            Assert.IsNotNull(loginUrl);
        }

        [Test]
        [Description("填入登录成功后的 code 的值")]
        public async Task GetAuthLoginStateTest()
        {
            var loginState = await client.GetLoginStateByAuthCode(code, loginCallbackUrl);

            Assert.IsTrue(loginState.AccessToken != null);
        }

        [Test]
        [Description("填入登录成功后的 code 的值")]
        public async Task GetUserInfoTest()
        {
            var loginState = await client.GetLoginStateByAuthCode(code, loginCallbackUrl);

            var userInfo = await client.GetUserInfo(loginState.AccessToken);

            Assert.IsTrue(userInfo != null);
        }

        [Test]
        [Description("填入登录成功后的 code 的值")]
        public async Task BuildLogoutUrlTest()
        {
            var loginState = await client.GetLoginStateByAuthCode(@"kAI7xa2xDSWCSoqIn7UfaeHMh_t06kGLGtdj8qrvFTB", loginCallbackUrl);
            var logoutUrl = client.BuildLogoutUrl(loginState.IdToken, @"https://www.baidu.com", "2321SDAD");

            Assert.IsTrue(!string.IsNullOrWhiteSpace(logoutUrl));
        }


        [Test]
        [Description("填入登录成功后的 code 的值")]
        public async Task RefreshLoginState()
        {
            var loginState = await client.GetLoginStateByAuthCode(@"T6nHvt_L45sYogMJNCgvQSLmd8xyZkRqXq0iXwI7rrO", loginCallbackUrl);

            loginState = await client.RefreshLoginState(loginState.RefreshToken);

            Assert.IsNotNull(loginState);
        }

        [Test]
        public async Task ParseIDTokenTest()
        {
            var loginState = await client.GetLoginStateByAuthCode(@"f75v3xsbO5cOoEeY_emQPbEqPPTNzj8TEN_y4Tyxg5S", loginCallbackUrl);
            IDToken iDToken =await client.ParseIDToken(loginState.IdToken);
            Assert.IsNotNull(iDToken);
        }

        [Test]
        public async Task ParseAccessToenTest()
        {
            var loginState = await client.GetLoginStateByAuthCode(@"SaJq1XVhhc_8RHm9sES3tsPpdPG-HHExczMHfttXPgB", loginCallbackUrl);
            AccessToken accessToken =await client.ParseAccessToken(loginState.AccessToken);
            Assert.IsNotNull(accessToken);
        }

        [Test]
        public async Task GetCountryListTest()
        {
            var result = await client.SignInByCredentials(new Models.SigninByCredentialsDto 
            { 
                Client_id= "6343bb084f16915f1becc730",
                Client_secret= "8ebe5abcc740f3bde1ba29621557675c",
                Connection=Models.SigninByCredentialsDto.connection.PASSWORD ,
                PasswordPayload=new Models.AuthenticateByPasswordDto { Username="test",Password="test"}
            });
        }

    }
}
