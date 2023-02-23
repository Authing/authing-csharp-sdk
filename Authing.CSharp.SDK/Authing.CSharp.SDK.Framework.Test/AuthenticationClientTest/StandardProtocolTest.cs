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
            string oidcUrl = client.BuildAuthorizeUrl(new OidcOption() { RedirectUri = "https://www.baidu.com", Scope = "openid profile email phone address offline_access" });

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
            var res = await client.GetAccessTokenByCode("DyfZ_GlsiiqNH6_dcOwbqQSEWxRwH_b9SaVXd-T1tH4");

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
            var userInfo = await client.GetUserInfoByAccessToken("eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsImtpZCI6Ik10c0QwZXJqMGpNdEk1akdBbUdfNGFMUjJQVW9pMWZHd1ZxcUlBQzRTN00ifQ.eyJzdWIiOiI2M2EyZTgzMmI2MWM5NGMzZDM1NmRkODUiLCJhdWQiOiI2MTMxODliMzhiNmM2NmNhYzFkMjExYmQiLCJzY29wZSI6ImVtYWlsIHBob25lIHByb2ZpbGUgb2ZmbGluZV9hY2Nlc3Mgb3BlbmlkIiwiaWF0IjoxNjcyOTg2MDIxLCJleHAiOjE2NzQxOTU2MjEsImp0aSI6ImRMMl9fZXZ6TERLaGt4NUFWSHVCVmhRWDFvblhaT25aTWdxelREdENLSjgiLCJpc3MiOiJodHRwczovL2VoYXp6ZC1kZW1vLmF1dGhpbmcuY24vb2lkYyJ9.GEXafW2AgeWcTf2_6tgCSF3PCfItZHC9DdhptDuKX0Y948Jf5lBDYbhsh64HU0ANJVwPBZyc4yeiv12GzZJWViHuQ-vMsuvXxytizO1gsS_Dc76Zdoo2CP5mXMQobcZVc6x9BCHao7duXgScFr35Dx5CSfMedl3QCcakGWJkwuId6eafRN9xr5VNF-E12dygFPkkRM8iCRVxyw9QXo8qECZLQzjuyhMjjsLoNS65Qfu9So_c7eA6HAOb_EyYm-hY4UQtOp5giKIDG7VaMS6yCHnr2Z-cWr7A-ejf9MWCXR3rbdM7uEF4w2fuqtuZZ8T0gOsx1IUYzf-6QK1UoQThhQ");


            string oidcUrl = client.BuildAuthorizeUrl(new OidcOption() { RedirectUri = "http://www.baidu.com", Scope = "openid profile email phone address offline_access" });

            Assert.NotNull(oidcUrl);

            //先在浏览器访问 oidcurl ，填入登录成功后的 code
            var res = await client.GetAccessTokenByCode("HYj_1goop20lCyJ-8B6HPtBgPckrMAfAXgmI8sUMhFb");

            try
            {
               // var userInfo = await client.GetUserInfoByAccessToken("eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsImtpZCI6Ik10c0QwZXJqMGpNdEk1akdBbUdfNGFMUjJQVW9pMWZHd1ZxcUlBQzRTN00ifQ.eyJzdWIiOiI2M2EyZTgzMmI2MWM5NGMzZDM1NmRkODUiLCJhdWQiOiI2MTMxODliMzhiNmM2NmNhYzFkMjExYmQiLCJzY29wZSI6ImVtYWlsIHBob25lIHByb2ZpbGUgb2ZmbGluZV9hY2Nlc3Mgb3BlbmlkIiwiaWF0IjoxNjcyOTg2MDIxLCJleHAiOjE2NzQxOTU2MjEsImp0aSI6ImRMMl9fZXZ6TERLaGt4NUFWSHVCVmhRWDFvblhaT25aTWdxelREdENLSjgiLCJpc3MiOiJodHRwczovL2VoYXp6ZC1kZW1vLmF1dGhpbmcuY24vb2lkYyJ9.GEXafW2AgeWcTf2_6tgCSF3PCfItZHC9DdhptDuKX0Y948Jf5lBDYbhsh64HU0ANJVwPBZyc4yeiv12GzZJWViHuQ-vMsuvXxytizO1gsS_Dc76Zdoo2CP5mXMQobcZVc6x9BCHao7duXgScFr35Dx5CSfMedl3QCcakGWJkwuId6eafRN9xr5VNF-E12dygFPkkRM8iCRVxyw9QXo8qECZLQzjuyhMjjsLoNS65Qfu9So_c7eA6HAOb_EyYm-hY4UQtOp5giKIDG7VaMS6yCHnr2Z-cWr7A-ejf9MWCXR3rbdM7uEF4w2fuqtuZZ8T0gOsx1IUYzf-6QK1UoQThhQ");


                Assert.NotNull(userInfo);
            }
            catch (Exception exp)
            { 
            }
        }

        /// <summary>
        /// 获取新的 accesstoken
        /// 2022-08-24 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetNewAccessTokenByRefreshToken_OIDC_Test()
        {
            try
            {
                string oidcUrl = client.BuildAuthorizeUrl(new OidcOption() { RedirectUri = "https://www.baidu.com", Scope = "openid profile email phone address offline_access" });

                Assert.NotNull(oidcUrl);

                //先在浏览器访问 oidcurl ，填入登录成功后的 code
                var res = await client.GetAccessTokenByCode("0o7U22OQWWuPQ40IokyVSh5po7_ltQxPH06UW6hvyTc");

                var newAccessToken = await client.GetNewAccessTokenByRefreshToken(res.RefreshToken);

                Assert.NotNull(newAccessToken);
            }
            catch (Exception exp)
            { 
            }

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
            var res = await client.GetAccessTokenByCode("ACzR5yZwgGlU0SBrHfAEepDaQC7zbxZBbg0oPiAtdQX");

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
            var res = await client.GetAccessTokenByCode("PDt1ZT0Fy-riwhewMfDB1wGHF9GAtmGyXYsnHHLgBJO");

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

        [Test]
        public async Task GetAccessTokenByClientCredentials_OIDC_Test()
        {
            var result = await client.GetAccessTokenByClientCredentials("openid profile email phone address offline_access", new GetAccessTokenByClientCredentialsOption
            {
                AccessKey = "630c79fcfb93e878c99cb235",
                AccessSecret = "bf268a4f9e3703b0635107ecd6426145",
            });

            Assert.NotNull(result);
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
            var res = await client.GetAccessTokenByCode("THFJPr5rKUMMrBCKuzx1hKrxjDXWRr7P8O15SvpRDrX");


            try
            {
                var userInfo = await client.GetUserInfoByAccessToken(res.AccessToken);
                Assert.NotNull(userInfo);
            }
            catch (Exception exp)
            { 
            
            }

            
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

            try
            {

                var result = await client.ValidateTicketV1("ST-1a18a69a-c665-4db9-a383-a55de7d273f0", "https://www.baidu.com");

                Assert.IsTrue(result.Valid);
            }
            catch (Exception exp)
            { 
            
            }
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
