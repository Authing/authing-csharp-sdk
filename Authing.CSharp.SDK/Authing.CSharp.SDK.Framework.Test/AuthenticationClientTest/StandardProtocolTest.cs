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
    internal class StandardProtocolTest:AuthenticationClientTestBase
    {
        [SetUp]
        public void SetupClient()
        {
            
        }

        /// <summary>
        /// 生成 SAML 登录地址
        /// 2022-08-24 测试通过
        /// </summary>
        [Test]
        public void BuildSAMLAuthorizeUrlTest()
        {

            string smalUrl = client.BuildAuthorizeUrl(new SamlOption());

            Assert.IsTrue(!string.IsNullOrWhiteSpace(smalUrl));
        }

        /// <summary>
        /// 生成 OIDC 登录地址
        /// 2022-08-24 测试通过
        /// </summary>
        [Test]
        public void BuildOIDCAuthorizeUrlTest()
        {

            string oidcUrl = client.BuildAuthorizeUrl(new OidcOption() { RedirectUri="https://localhost:5566", Scope = "openid profile email phone address offline_access" });

            Assert.IsTrue(!string.IsNullOrWhiteSpace(oidcUrl));
        }

        /// <summary>
        /// 生成 OIDC 登出地址
        /// 2022-08-24 测试通过
        /// </summary>
        [Test]
        public async Task BuildOIDCLogoutUrl()
        {
            string oidcUrl = client.BuildAuthorizeUrl(new OidcOption() { RedirectUri = "https://www.baidu.com", Scope = "openid profile email phone address offline_access" });

            Assert.NotNull(oidcUrl);

            //先在浏览器访问 oidcurl ，填入登录成功后的 code
            var res = await client.GetAccessTokenByCode("MKWavWxCw-DQqhfZhxJ4ZniwIODrnjXZ0n8fuK1_xbx");

            string oidcLogoutUrl = client.BuildLogoutUrl(new LogoutParams {RedirectUri= "https://gitee.com/", IdToken=res.IdToken,Expert=true });
        }

        /// <summary>
        /// 通过 accessToken 获取用户信息
        /// 2022-08-24 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetUserInfoByAccessToken_OIDC_Test()
        {
            string oidcUrl = client.BuildAuthorizeUrl(new OidcOption() { RedirectUri = "https://www.baidu.com", Scope = "openid profile email phone address offline_access" });

            Assert.NotNull(oidcUrl);

            //先在浏览器访问 oidcurl ，填入登录成功后的 code
            var res = await client.GetAccessTokenByCode("zK-AdMW1wF0EZissZUuf0lmYDdemdE6ymGoCwsm0DSC");


            var userInfo = await client.GetUserInfoByAccessToken(res.AccessToken);

            Assert.NotNull(userInfo);
        }

        /// <summary>
        /// 获取新的 accesstoken
        /// 2022-08-24 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetNewAccessTokenByRefreshToken_OIDC_Test()
        {
            string oidcUrl = client.BuildAuthorizeUrl(new OidcOption() { RedirectUri = "https://www.baidu.com", Scope = "openid profile email phone address offline_access" });

            Assert.NotNull(oidcUrl);

            //先在浏览器访问 oidcurl ，填入登录成功后的 code
            var res = await client.GetAccessTokenByCode("rU5NppqPaNICRwYs0aWgplxwAksxJb_zvzkOZFw1Fop");

            var newAccessToken = await client.GetNewAccessTokenByRefreshToken(res.RefreshToken);

            Assert.NotNull(newAccessToken);

        }

        /// <summary>
        /// 生成 OAuth 登录地址
        /// 2022-08-24 测试通过
        /// </summary>
        [Test]
        public void BuildOAuthAuthorizeUrlTest()
        {

            string oauthUrl = client.BuildAuthorizeUrl(new OauthOption() { RedirectUri = "https://localhost:5566", Scope = "openid profile email phone address offline_access" });

            Assert.IsTrue(!string.IsNullOrWhiteSpace(oauthUrl));
        }

        /// <summary>
        /// 生成 Oauth 登出链接
        /// 2022-08-24 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task BuildOauthLogoutUrl()
        {
            string oauth = client.BuildAuthorizeUrl(new OauthOption() { RedirectUri = "https://www.baidu.com", Scope = "openid profile email phone address offline_access" });

            var res = await client.GetAccessTokenByCode("83bf223c9798fa71b47dc947c4787ff9f326a439");

            string oauthLogoutUrl = client.BuildLogoutUrl(new LogoutParams { RedirectUri = "https://www.gitee.com/", IdToken = res.IdToken, Expert = true });
        }

        /// <summary>
        /// 通过 accessToken 获取用户信息
        /// 2022-08-24 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetUserInfoByAccessToken_Oauth_Test()
        {
            string oidcUrl = client.BuildAuthorizeUrl(new OauthOption() { RedirectUri = "https://www.baidu.com", Scope = "openid profile email phone address offline_access" });

            Assert.NotNull(oidcUrl);

            //先在浏览器访问 oidcurl ，填入登录成功后的 code
            var res = await client.GetAccessTokenByCode("b71ef8270d6e92deca8289c7040eeed1db6b188b");


            var userInfo = await client.GetUserInfoByAccessToken(res.AccessToken);

            Assert.NotNull(userInfo);
        }

        /// <summary>
        /// 获取新的 accesstoken
        /// 2022-08-24 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetNewAccessTokenByRefreshToken_Oauth_Test()
        {
            string oidcUrl = client.BuildAuthorizeUrl(new OauthOption() { RedirectUri = "https://www.baidu.com", Scope = "openid profile email phone address offline_access" });

            Assert.NotNull(oidcUrl);

            //先在浏览器访问 oidcurl ，填入登录成功后的 code
            var res = await client.GetAccessTokenByCode("bd7ed1b966a72795ff921e16e4cac1694125db93");

            var newAccessToken = await client.GetNewAccessTokenByRefreshToken(res.RefreshToken);

            Assert.NotNull(newAccessToken);

        }
    }
}
