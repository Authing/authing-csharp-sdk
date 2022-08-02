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
    public class AuthenticationClientTest
    {
        string loginCallbackUrl = @"https://console.authing.cn/console/get-started/62e73520801b92ac74752791";
        AuthenticationClient client;
        string code = @"P-kFRuV2oDgN9CfaBQLTmewv-XOQNKlpGHGfrP2Ugq7";

        [SetUp]
        public void TestGetJWKS()
        {
            client = new AuthenticationClient(new AuthenticationClientInitOptions
            {
                //AppId = "61e5157ea18c245048770546",
                //AppSecret = "325d96c907a989b9f6b67584e1632909",
                //Domain = @"https://authinglogindemo.authing.cn",
                //RediretUri = loginCallbackUrl,
                AppId = "62e73520801b92ac74752791",
                AppSecret = "1d332f59c61745fbfaa321ba3c600b0d",
                Domain = @"https://4399.authing.cn",
                RediretUri = "https://console.authing.cn/console/get-started/62e73520801b92ac74752791",
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
            var loginState = await client.GetLoginStateByAuthCode(@"AJ87C_3gvFuc6tiDpUZPd-ABj7RHuNUaflZeS-FYEYu", loginCallbackUrl);

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
            IDToken iDToken = client.ParseIDToken(loginState.IdToken);
            Assert.IsNotNull(iDToken);
        }

        [Test]
        public async Task ParseAccessToenTest()
        {
            var loginState = await client.GetLoginStateByAuthCode(@"SaJq1XVhhc_8RHm9sES3tsPpdPG-HHExczMHfttXPgB", loginCallbackUrl);
            AccessToken accessToken = client.ParseAccessToken(loginState.AccessToken);
            Assert.IsNotNull(accessToken);
        }

    }
}
