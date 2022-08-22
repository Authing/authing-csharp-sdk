using Authing.CSharp.SDK.Models;
using Authing.CSharp.SDK.Services;
using Authing.CSharp.SDK.Utils;
using Authing.CSharp.SDK.UtilsImpl;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Authing.CSharp.SDK.Framework.Test
{
    class ExternalIdentifyProviderManagementTest : ManagementClientBaseTest
    {
        [Test]
        public async Task ListExtIdpTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                ExtIdpListPaginatedRespDto dto = await managementClient.ListExtIdp();

                Assert.IsTrue(dto.Data.List.Count > 0);
            }
        }

        [Test]
        public async Task GetExtIdpTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                ExtIdpDetailSingleRespDto dto = await managementClient.GetExtIdp("62982b6aedad16dc3cbafad4", "62987fc95fdc00c85410105f");

                Assert.IsTrue(dto.Data.Id == "62982b6aedad16dc3cbafad4");
            }
        }

        [Test]
        public async Task CreaeteExtIdpTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                CreateExtIdpDto createExtIdpDto = new CreateExtIdpDto()
                {
                    Name = "1111111111",
                    TenantId = "62987fc95fdc00c85410105f",
                    Type = CreateExtIdpDto.type.AD

                };

                ExtIdpSingleRespDto dto = await managementClient.CreateExtIdp(createExtIdpDto);

                Assert.IsTrue(dto.Data.Name == "exampleName");
            }
        }

        [Test]
        public async Task UpdateExtIdpTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                UpdateExtIdpDto updateExtIdpDto = new UpdateExtIdpDto()
                {
                    Name = "exampleNameUpdate",
                    Id = "629881be0953a5fee9057154",
                };

                ExtIdpSingleRespDto dto = await managementClient.UpdateExtIdp(updateExtIdpDto);

                Assert.IsTrue(dto.Data.Name == "exampleNameUpdate");
            }
        }

        [Test]
        public async Task DeleteExtIdpTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                DeleteExtIdpDto deleteExtIdpDto = new DeleteExtIdpDto()
                {
                    Id = "629881be0953a5fee9057154"
                };

                IsSuccessRespDto dto = await managementClient.DeleteExtIdp(deleteExtIdpDto);

                Assert.IsTrue(dto.Data.Success);
            }
        }

        [Test]
        public async Task CreateExtIdpConnTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                CreateExtIdpConnDto createExtIdpConnDto = new CreateExtIdpConnDto()
                {
                    ExtIdpId = "62988bbe50d0bec8b2eaf055",
                    DisplayName = "AuthingV3TestConn",
                    Identifier = "62988bbe826931c2a6f03add",
                    LoginOnly = false,
                    Logo = "https://files.authing.co/authing-console/social-connections/icon_xiaochengxu@2x.png",
                    Type = CreateExtIdpConnDto.type.AD,
                    Fields = new { clientId = "619dffb8406749dd88491111", clientSecret = "2222222 " }
                };
                ExtIdpConnDetailSingleRespDto dto = await managementClient.CreateExtIdpConn(createExtIdpConnDto);
                Assert.IsTrue(dto.Data.DisplayName == "AuthingV3TestConn");
            }
        }

        [Test]
        public void UpdateExtIdpConnTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                UpdateExtIdpConnDto createExtIdpConnDto = new UpdateExtIdpConnDto()
                {
                    DisplayName = "AuthingV3TestConnUpdate",
                    LoginOnly = false,
                    Fields = new { clientId = "619dffb8406749dd88491111", clientSecret = "4444444 " },
                    Logo = "https://files.authing.co/authing-console/social-connections/icon_xiaochengxu@2x.png",
                    Id = "62988de9f76fe95fc6ad0074",
                };

                ExtIdpConnDetailSingleRespDto dto = managementClient.UpdateExtIdpConn(createExtIdpConnDto).Result;

                Assert.IsTrue(dto.Data.DisplayName == "AuthingV3TestConnUpdate");
            }
        }

        [Test]
        public void EnableExtIdpConnTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                EnableExtIdpConnDto enableExtIdpConnDto = new EnableExtIdpConnDto()
                {
                    Id = "62988ec7bcac758beea4006f",
                    AppId = "6215dd9277d6ef55dfab41f8",
                    TenantId = "62987fc95fdc00c85410105f",
                    Enabled = true
                };

                IsSuccessRespDto dto = managementClient.ChangeConnState(enableExtIdpConnDto).Result;

                Assert.IsTrue(dto.Data.Success);
            }
        }

        [Test]
        public void DeleteExtIdpConnTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                DeleteExtIdpConnDto enableExtIdpConnDto = new DeleteExtIdpConnDto()
                {
                    Id = "62988de9f76fe95fc6ad0074",
                };

                IsSuccessRespDto dto = managementClient.DeleteExtIdpConn(enableExtIdpConnDto).Result;

                Assert.IsTrue(dto.Data.Success);
            }
        }
    }
}
