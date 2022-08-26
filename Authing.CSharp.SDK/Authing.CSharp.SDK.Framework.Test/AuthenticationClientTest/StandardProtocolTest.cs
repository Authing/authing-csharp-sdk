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
    internal class StandardProtocolTest : AuthenticationClientTestBase
    {

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
        /// 生成 SAML 登出地址
        /// 2022-08-24 测试通过
        /// </summary>
        [Test]
        public void BuildSAMLLogoutUrlTest()
        {
            string samlLogoutUrl = client.BuildLogoutUrl(new LogoutParams { });

            Assert.NotNull(samlLogoutUrl);
        }

        /// <summary>
        /// 生成 OIDC 登录地址
        /// 2022-08-24 测试通过
        /// </summary>
        [Test]
        public void BuildOIDCAuthorizeUrlTest()
        {

            string oidcUrl = client.BuildAuthorizeUrl(new OidcOption() { RedirectUri = "https://localhost:5566", Scope = "openid profile email phone address offline_access" });

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

            string oidcLogoutUrl = client.BuildLogoutUrl(new LogoutParams { RedirectUri = "https://gitee.com/", IdToken = res.IdToken, Expert = true });
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
        /// 检查 AccessToken 状态 
        /// 2022-08-25 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task IntrospectToken_OIDC_Test()
        {
            string oidcUrl = client.BuildAuthorizeUrl(new OidcOption() { RedirectUri = "https://www.baidu.com", Scope = "openid profile email phone address offline_access" });

            Assert.NotNull(oidcUrl);

            //先在浏览器访问 oidcurl ，填入登录成功后的 code
            var res = await client.GetAccessTokenByCode("0dizONAuiUDO8tP95q2VMIDRDCeeYhhdWfIdfusTOFf");

            var tokenStatus = await client.IntrospectToken(res.AccessToken);

            Assert.IsTrue(tokenStatus.Active);
        }

        /// <summary>
        /// 校验 Token 合法性
        /// 2022-08-25 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task ValidateToken_OIDC_Test()
        {
            string oidcUrl = client.BuildAuthorizeUrl(new OidcOption() { RedirectUri = "https://www.baidu.com", Scope = "openid profile email phone address offline_access" });

            Assert.NotNull(oidcUrl);

            //先在浏览器访问 oidcurl ，填入登录成功后的 code
            var res = await client.GetAccessTokenByCode("KZlp639B5bGzXx9yrVGfVeDb-MHGHmwq4oF1PpOh_Hf");

            var checkResult = await client.ValidateToken(new ValidateTokenParams { AccessToken = res.AccessToken });

            Assert.NotNull(checkResult);
        }

        /// <summary>
        /// 撤回 token
        /// 2022-08-25 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task RevokeToken_OIDC_Test()
        {
            string oidcUrl = client.BuildAuthorizeUrl(new OidcOption() { RedirectUri = "https://www.baidu.com", Scope = "openid profile email phone address offline_access" });

            Assert.NotNull(oidcUrl);

            //先在浏览器访问 oidcurl ，填入登录成功后的 code
            var res = await client.GetAccessTokenByCode("zFV9QYAQJq5mbg8aUoPoWNRHOPIO9-k4h-trTWR6iDo");

            var checkResult = await client.IntrospectToken(res.AccessToken);

            Assert.True(checkResult.Active);

            var result = await client.RevokeToken(res.AccessToken);

            Assert.NotNull(result);


            var isValidToken = await client.IntrospectToken(res.AccessToken);

            Assert.IsFalse(isValidToken.Active);
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
            string oauthUrl = client.BuildAuthorizeUrl(new OauthOption() { RedirectUri = "https://www.baidu.com", Scope = "openid profile email phone address offline_access" });

            Assert.NotNull(oauthUrl);

            //先在浏览器访问 oidcurl ，填入登录成功后的 code
            var res = await client.GetAccessTokenByCode("bd7ed1b966a72795ff921e16e4cac1694125db93");

            var newAccessToken = await client.GetNewAccessTokenByRefreshToken(res.RefreshToken);

            Assert.NotNull(newAccessToken);

        }

        /// <summary>
        /// 检查 AccessToken 状态 
        /// 2022-08-25 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task IntrospectToken_Oauth_Test()
        {
            string oauthUrl = client.BuildAuthorizeUrl(new OauthOption() { RedirectUri = "https://www.baidu.com", Scope = "openid profile email phone address offline_access" });

            Assert.NotNull(oauthUrl);

            //先在浏览器访问 oidcurl ，填入登录成功后的 code
            var res = await client.GetAccessTokenByCode("d9b6317789ae68b8418197eeddf35f62ea6cc823");

            var tokenStatus = await client.IntrospectToken(res.AccessToken);

            Assert.IsTrue(tokenStatus.Active);
        }

        /// <summary>
        /// 撤回 token
        /// 2022-08-25 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task RevokeToken_Oauth_Test()
        {
            string oauthUrl = client.BuildAuthorizeUrl(new OauthOption() { RedirectUri = "https://www.baidu.com", Scope = "openid profile email phone address offline_access" });

            Assert.NotNull(oauthUrl);

            //先在浏览器访问 oidcurl ，填入登录成功后的 code
            var res = await client.GetAccessTokenByCode("1e2f23b632b331e701056609ba5d8f0ccaf928f3");

            var checkResult = await client.IntrospectToken(res.AccessToken);

            Assert.True(checkResult.Active);

            var result = await client.RevokeToken(res.AccessToken);

            Assert.NotNull(result);


            var isValidToken = await client.IntrospectToken(res.AccessToken);

            Assert.IsFalse(isValidToken.Active);
        }

        /// <summary>
        /// 生成 saml 协议登录 Url
        /// 2022-08-25 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public void BuildAuthorizeUrl_SAML_Test()
        {
            string samlUrl = client.BuildAuthorizeUrl(new SamlOption { });

            Assert.NotNull(samlUrl);
        }

        /// <summary>
        /// 生成 saml 登出链接
        /// 2022-08-25 测试通过
        /// </summary>
        [Test]
        public void BuildLogoutUrl_SAML_Test()
        {
            string samlLogoutUrl = client.BuildLogoutUrl(new LogoutParams { RedirectUri = "https://www.baidu.com" });

            Assert.NotNull(samlLogoutUrl);
        }

        /// <summary>
        /// 生成 cas 协议登录 Url
        /// 2022-08-25 测试通过
        /// </summary>
        [Test]
        public void BuildAuthorizeUrl_CAS_Test()
        {
            string casUrl = client.BuildAuthorizeUrl(new CasOption { Service = "https://www.baidu.com" });

            Assert.NotNull(casUrl);
        }

        /// <summary>
        /// 验证 CAS 登录 Ticket
        /// 2022-08-25 测试通过
        /// </summary>
        [Test]
        public async Task CAS_Ticket_ValidateV1_Test()
        {
            string casUrl = client.BuildAuthorizeUrl(new CasOption { Service = "https://www.baidu.com" });

            Assert.NotNull(casUrl);

            var result = await client.ValidateTicketV1("ST-ec19e981-57fa-43ca-b105-68ccf01d8038", "https://www.baidu.com");

            Assert.IsTrue(result.Valid);
        }

        /// <summary>
        /// 验证 CAS 登录 Ticket
        /// 2022-08-26 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task CAS_Ticket_ValidateV2_JSON_Test()
        {
            string casUrl = client.BuildAuthorizeUrl(new CasOption { Service = "https://www.baidu.com" });

            Assert.NotNull(casUrl);

            var result = await client.ValidateTicketV2Json("ST-0faa3fce-570e-43f8-b4bb-52280c0b0827", "https://www.baidu.com");

            Assert.NotNull(result.ServiceResponse.AuthenticationSuccess);
        }

        /// <summary>
        /// 验证 CAS 登录 Ticket
        /// 2022-08-26 未知错误，已在飞书项目上提缺陷
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task CAS_Ticket_ValidateV2_XML_Test()
        {
            string casUrl = client.BuildAuthorizeUrl(new CasOption { Service = "https://www.baidu.com" });

            Assert.NotNull(casUrl);

            var result = await client.ValidateTicketV2XML("ST-ef7d9c5d-2dc9-4010-be80-dad603398f65", "https://www.baidu.com");

            Assert.NotNull(result);
        }

        /// <summary>
        /// 生成 CAS 登出链接
        /// 2022-08-26
        /// </summary>
        /// <returns></returns>
        [Test]
        public void CAS_LogoutUrl_Test()
        {
            string casUrl = client.BuildAuthorizeUrl(new CasOption { Service = "https://www.baidu.com" });

            Assert.NotNull(casUrl);

            string logoutUrl = client.BuildLogoutUrl(new LogoutParams { RedirectUri = "https://www.baidu.com" });

            Assert.NotNull(logoutUrl);
        }

    }
}
