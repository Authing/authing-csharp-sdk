using Authing.CSharp.SDK.Models;
using Authing.CSharp.SDK.Services;
using Authing.CSharp.SDK.Utils;
using Authing.CSharp.SDK.UtilsImpl;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Authing.CSharp.SDK.Framework.Test
{
    class ExternalIdentifyProviderManagementTest : ManagementClientBaseTest
    {
        /// <summary>
        /// 2022-10-20 测试成功
        /// 获取身份源列表
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task ListExtIdpTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                ExtIdpListPaginatedRespDto dto = await managementClient.ListExtIdp(new ListExtIdpDto
                {
                    AppId = "dc10086b85f2635d3246",

                });

                Assert.IsTrue(dto.Data.List.Count > 0);
            }
        }

        /// <summary>
        /// 2022-10-20 测试失败 未知错误
        /// 获取身份源详情
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetExtIdpTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                //"","","62982b6aedad16dc3cbafad4", "62987fc95fdc00c85410105f"
                ExtIdpDetailSingleRespDto dto = await managementClient.GetExtIdp(new GetExtIdpDto
                {
                    Id = "6350faefc21d95530e369948",
                    AppId = "634e5637ea7c7e0e817ddfc7"
                });

                Assert.IsTrue(dto.Data.Id == "62982b6aedad16dc3cbafad4");
            }
        }

        /// <summary>
        /// 2022-10-20 测试成功
        /// 创建身份源
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task CreaeteExtIdpTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                CreateExtIdpDto createExtIdpDto = new CreateExtIdpDto()
                {
                    Name = "newAdd",
                    TenantId = "634fe4ef9369a20077044c2d",
                    Type = CreateExtIdpDto.type.AD

                };

                ExtIdpSingleRespDto dto = await managementClient.CreateExtIdp(createExtIdpDto);

                Assert.IsTrue(dto.Data.Name == "newAdd");
            }
        }

        /// <summary>
        /// 2022-10-20 测试通过
        /// 更新身份源
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task UpdateExtIdpTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                ExtIdpListPaginatedRespDto dto = await managementClient.ListExtIdp(new ListExtIdpDto
                {
                    AppId = "dc10086b85f2635d3246",

                });

                UpdateExtIdpDto updateExtIdpDto = new UpdateExtIdpDto()
                {
                    Name = "exampleNameUpdate",
                    Id = dto.Data.List.First().Id,
                };

                ExtIdpSingleRespDto result = await managementClient.UpdateExtIdp(updateExtIdpDto);

                Assert.IsTrue(result.Data.Name == "exampleNameUpdate");
            }
        }

        /// <summary>
        /// 2022-10-20 测试通过
        /// 删除身份源
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task DeleteExtIdpTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {

                ExtIdpListPaginatedRespDto dto = await managementClient.ListExtIdp(new ListExtIdpDto
                {
                    TenantId = "634fe4ef9369a20077044c2d",

                });

                DeleteExtIdpDto deleteExtIdpDto = new DeleteExtIdpDto()
                {
                    Id = dto.Data.List.First().Id
                };

                IsSuccessRespDto result = await managementClient.DeleteExtIdp(deleteExtIdpDto);

                Assert.IsTrue(result.Data.Success);
            }
        }

        /// <summary>
        /// 2022-10-20 测试通过
        /// 建立身份源连接
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task CreateExtIdpConnTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                CreateExtIdpConnDto createExtIdpConnDto = new CreateExtIdpConnDto()
                {
                    ExtIdpId = "6350faefc21d95530e369948",
                    DisplayName = "AuthingV3TestConn",
                    Identifier = "6350faefcd688eac1c7c446e",
                    LoginOnly = false,
                    Logo = "https://files.authing.co/authing-console/social-connections/icon_xiaochengxu@2x.png",
                    Type = CreateExtIdpConnDto.type.GITHUB,
                    Fields = new { clientId = "619dffb8406749dd88491111", clientSecret = "2222222 " }
                };
                ExtIdpConnDetailSingleRespDto dto = await managementClient.CreateExtIdpConn(createExtIdpConnDto);
                Assert.IsTrue(dto.Data.DisplayName == "AuthingV3TestConn");
            }
        }

        [Test]
        public async Task UpdateExtIdpConnTest()
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

                ExtIdpConnDetailSingleRespDto dto = await managementClient.UpdateExtIdpConn(createExtIdpConnDto);

                Assert.IsTrue(dto.Data.DisplayName == "AuthingV3TestConnUpdate");
            }
        }

        [Test]
        public async Task EnableExtIdpConnTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                ChangeExtIdpAssociationStateDto enableExtIdpConnDto = new ChangeExtIdpAssociationStateDto()
                {
                    Id = "62988ec7bcac758beea4006f",
                    TenantId = "62987fc95fdc00c85410105f",
                };

                IsSuccessRespDto dto = await managementClient.ChangeExtIdpConnAssociationState(enableExtIdpConnDto);

                Assert.IsTrue(dto.Data.Success);
            }
        }

        [Test]
        public async Task DeleteExtIdpConnTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                DeleteExtIdpConnDto enableExtIdpConnDto = new DeleteExtIdpConnDto()
                {
                    Id = "62988de9f76fe95fc6ad0074",
                };

                IsSuccessRespDto dto = await managementClient.DeleteExtIdpConn(enableExtIdpConnDto);

                Assert.IsTrue(dto.Data.Success);
            }
        }

        [Test]
        public async Task ChangeAssociationStateTest()
        {
            var dto = await managementClient.ChangeExtIdpConnState(new ChangeExtIdpConnStateDto
            {
                Id = "AUTHING_IDP_CONN_ID",
                Enabled = true,
                TenantId = "AUTHING_TENANT_ID"
            });
            Assert.NotNull(dto);
        }

        [Test]
        public async Task ListTenantExtIdpTest()
        {
            var dto = await managementClient.ListTenantExtIdp(new ListTenantExtIdpDto
            {
                AppId = "AUTHING_APPID",
                TenantId = "AUTHING_TENANT_ID",
                Type = "Github"
            });
            Assert.NotNull(dto);
        }

        [Test]
        public async Task ExtIdpConnStateByAppsTest()
        {
            var dto = await managementClient.ExtIdpConnStateByApps(new ExtIdpConnAppsDto 
            {
                AppId="AUTHING_ID",
                Id="AUTHING_IDP_CONN_ID",
                TenantId="AUTHING_TENENT_ID",
                Type="Github"
            });
            Assert.NotNull(dto);
        }
    }
}
