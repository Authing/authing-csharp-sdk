using Authing.CSharp.SDK.Infrastructure;
using Authing.CSharp.SDK.IServices;
using Authing.CSharp.SDK.Models.Management;
using Authing.CSharp.SDK.Services;
using Authing.CSharp.SDK.Utils;
using NUnit.Framework;
using System.Threading;

namespace Authing.CSharp.SDK.Framework.Test
{
    public class BaseTest
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void TestHttpPost()
        {
            IHttpService httpService = HttpServiceFactory.Get(new JsonService(), Enums.HttpServiceType.HTTPCLIENT);

            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                string s = httpService.PostAsync("http://8.142.39.176:3000/api/v3", "/get-management-token", new System.Collections.Generic.Dictionary<string, string>()
                {
                    { "accessKeyId","6343b98b7cf019a9366e9b7c"},
                    { "accessKeySecret","fb0cefa691df76920a1611b9dec38120"}
                }, cts.Token).Result;

                Assert.IsFalse(string.IsNullOrWhiteSpace(s));
            }
        }

        [Test]
        public void TestHttpWebPost()
        {
            IHttpService httpService = HttpServiceFactory.Get(new JsonService(), Enums.HttpServiceType.HTTPWEBREQUEST);

            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                string s = httpService.PostAsync("https://core.authing.cn/api/v3", "/get-management-token", new System.Collections.Generic.Dictionary<string, string>()
                {
                    { "accessKeyId","613189b2eed393affbbf396e"},
                    { "accessKeySecret","ccf4951a33e5d54d64e145782a65f0a7"}
                }, cts.Token).Result;

                Assert.IsFalse(string.IsNullOrWhiteSpace(s));
            }
        }

        [Test]
        public void TestManagementGetToken()
        {
            ManagementClientOptions options = new ManagementClientOptions()
            {
                AccessKeyId = "613189b2eed393affbbf396e",
                AccessKeySecret = "ccf4951a33e5d54d64e145782a65f0a7"
            };

            ManagementClient managementClient = new ManagementClient(options);

            GetManagementAccessTokenDto dto = new GetManagementAccessTokenDto()
            {
                AccessKeyId = "613189b2eed393affbbf396e",
                AccessKeySecret = "ccf4951a33e5d54d64e145782a65f0a7"
            };

            GetManagementTokenRespDto getManagementTokenRespDto = managementClient.GetManagementToken(dto).Result;

            Assert.IsFalse(string.IsNullOrWhiteSpace(getManagementTokenRespDto.Data.Access_token));

        }

        [Test]
        public void TestManagementGetUser()
        {
            ManagementClientOptions options = new ManagementClientOptions()
            {
                AccessKeyId = "613189b2eed393affbbf396e",
                AccessKeySecret = "ccf4951a33e5d54d64e145782a65f0a7"
            };

            ManagementClient managementClient = new ManagementClient(options);
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {


                UserSingleRespDto userSingleRespDto = managementClient.GetUser(new GetUserDto { UserId= "61c188ccfff26fef0ca6880d" }).Result;

                Assert.IsFalse(string.IsNullOrWhiteSpace(userSingleRespDto.Data.UserId));
            }
        }

        [Test]
        public void TestKickUser()
        {
            ManagementClientOptions options = new ManagementClientOptions()
            {
                AccessKeyId = "613189b2eed393affbbf396e",
                AccessKeySecret = "ccf4951a33e5d54d64e145782a65f0a7"
            };

            ManagementClient managementClient = new ManagementClient(options);
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                System.Collections.Generic.List<string> appList = new System.Collections.Generic.List<string>();
                appList.Add("6215dd9277d6ef55dfab41f8");

                KickUsersDto updateUserReqDto = new KickUsersDto()
                {
                    AppIds = appList,
                    UserId = "61c17bd024917805ae85e397"
                };

                IsSuccessRespDto isSuccessRespDto = managementClient.KickUsers(updateUserReqDto).Result;

                Assert.True(isSuccessRespDto.Data.Success);
            }
        }
    }
}