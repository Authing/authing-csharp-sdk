using Authing.CSharp.SDK.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace Authing.CSharp.SDK.Framework.Test.Management
{
    /// <summary>
    /// 单个应用测试
    /// </summary>
    class ApplicationManagement_Test : ManagementClientBaseTest
    {
        private ApplicationDto app;
        private string appName;
        private string appIdentifier;

        private string appId = "637c7118432f13b6e6738ea7";

        private List<UserDto> users;

        public ApplicationManagement_Test()
        {
            appName = "newV3Test";
            appName = "newV3Test";
        }

   
        public async Task GetUserList()
        {

           var user= await managementClient.ListUsers(new ListUsersRequestDto 
            {
                
            });

            users = user.Data.List;
        }

        /// <summary>
        /// 2022-10-20 测试失败  创建应用成功后，会返回位置错误
        /// 2022-11-21 测试失败，报场景值错误 showChangeLanguageButton
        /// 创建应用
        /// </summary>
        /// <returns></returns>
        [Test, Order(1),Ignore("报场景值错误 showChangeLanguageButton")]
        public async Task CreateApplicationTest()
        {
            ApplicationPaginatedRespDto dto = await managementClient.CreateApplication(new CreateApplicationDto
            {
                AppName = appName,
                AppIdentifier = appIdentifier,
                SsoEnabled = false,
                AppType = CreateApplicationDto.appType.WEB,
                BrandingConfig = new ApplicationBrandingConfigInputDto
                {
                    CustomCSSEnabled=false,
                    CustomCSS= ".authing-guard-layout {\r\n  background: black !important;\r\n}",
                    CustomLoadingImage= "https://files.authing.co/user-contents/photos/cbd51df7-efb1-4b50-b38c-d8e5a04b1830.png",
                    CustomBackground= "https://files.authing.co/user-contents/photos/cbd51df7-efb1-4b50-b38c-d8e5a04b1830.png",
                    ShowChangeLanguageButton = false,
                    ShowForgetPasswordButton=true,
                    ShowEnterpriseConnections=true,
                    ShowSocialConnections=true
                }
            });

            app = dto.Data.List.FirstOrDefault();

            Assert.NotNull(dto);
        }

        /// <summary>
        /// 2022-10-20 测试通过 
        /// 获取应用密钥
        /// </summary>
        /// <returns></returns>
        [Test, Order(2)]
        public async Task GetApplicationSecretTest()
        {
            var dto = await managementClient.GetApplicationSecret(new GetApplicationSecretDto { AppId = appId });
            Assert.NotNull(dto.Data.Secret);
        }

        /// <summary>
        /// 2022-10-20 测试通过 
        /// 刷新密钥
        /// </summary>
        /// <returns></returns>
        [Test, Order(3)]
        public async Task RefreshApplicationSecretTest()
        {
            var dto = await managementClient.RefreshApplicationSecret(new RefreshApplicationSecretDto { AppId = appId });
            Assert.NotNull(dto.Data.Secret);
        }

        /// <summary>
        /// 2022-10-20 测试通过 
        /// 获取应用当前登录用户
        /// </summary>
        /// <returns></returns>
        [Test, Order(4)]
        public async Task ListApplicationActiveUsersTest()
        {
            var dto = await managementClient.ListApplicationActiveUsers(new ListApplicationActiveUsersDto { AppId = appId });
            Assert.NotNull(dto);
        }

        /// <summary>
        /// 2022-10-20 测试通过 
        /// 获取应用默认访问策略
        /// </summary>
        /// <returns></returns>
        [Test, Order(5)]
        public async Task GetApplicationPermissionStrategyTest()
        {
            var dto = await managementClient.GetApplicationPermissionStrategy(new GetApplicationPermissionStrategyDto { AppId = appId });
            Assert.NotNull(dto);
        }


        /// <summary>
        /// 2022-10-20 测试通过 
        /// 获取应用默认访问策略
        /// </summary>
        /// <returns></returns>
        [Test, Order(6)]
        public async Task UpdateApplicationPermissionStrategyTest()
        {
            var dto = await managementClient.UpdateApplicationPermissionStrategy(new UpdateApplicationPermissionStrategyDataDto
            {
                AppId = appId,
                PermissionStrategy = UpdateApplicationPermissionStrategyDataDto.permissionStrategy.DENY_ALL
            });
            Assert.IsTrue(dto.Data.Success);
        }

        /// <summary>
        /// 2022-10-20 测试通过
        /// 获取应用详情
        /// </summary>
        /// <returns></returns>
        [Test,Order(7)]
        public async Task GetApplicationTest()
        {
            var dto = await managementClient.GetApplication(new GetApplicationDto { AppId = appId });
            Assert.NotNull(dto.Data);
        }

        /// <summary>
        /// 2022-10-20 测试通过
        /// 获取应用简单信息
        /// </summary>
        /// <returns></returns>
        [Test,Order(8)]
        public async Task GetApplicationSimpleInfoTest()
        {
            var dto = await managementClient.GetApplicationSimpleInfo(new GetApplicationSimpleInfoDto { AppId = appId });
            Assert.NotNull(dto.Data);
        }

        /// <summary>
        /// 2022-10-20 测试通过 
        /// 授权应用访问
        /// </summary>
        /// <returns></returns>
        [Test,Order(9)]
        public async Task AuthorizeApplicationAccessTest()
        {
            var dto = await managementClient.AuthorizeApplicationAccess(new AuthorizeApplicationAccessDto
            {
                AppId = appId,
                List = new List<ApplicationPermissionRecordItem>
            {
               new ApplicationPermissionRecordItem
               {
                   Effect=ApplicationPermissionRecordItem.effect.ALLOW,
                   TargetType=ApplicationPermissionRecordItem.targetType.USER,
                   TargetIdentifier=users.Select(p=>p.UserId).ToList()
               }
            }
            }) ;
            Assert.IsTrue(dto.Data.Success);
        }

        /// <summary>
        /// 2022-10-20 测试通过 
        /// 删除授权应用访问
        /// </summary>
        /// <returns></returns>
        [Test,Order(10)]
        public async Task RevokeApplicationAccessTest()
        {
            var dto = await managementClient.RevokeApplicationAccess(new RevokeApplicationAccessDto
            {
                AppId = appId,
                List = new List<DeleteApplicationPermissionRecordItem>
                {
                    new DeleteApplicationPermissionRecordItem
                    {
                        TargetIdentifier=users.Select(p=>p.UserId).ToList(),
                        TargetType=DeleteApplicationPermissionRecordItem.targetType.USER
                    }
                }
            });
            Assert.IsTrue(dto.Data.Success);
        }

        /// <summary>
        /// 2022-10-20 测试通过 
        /// 检测域名是否可用
        /// </summary>
        /// <returns></returns>
        [Test,Order(11)]
        public async Task CheckDomainAvailableTest()
        {
            var dto = await managementClient.CheckDomainAvailable(new CheckDomainAvailable
            {
                Domain = "qidongtest"
            });
            Assert.IsFalse(dto.Data.Available);
        }

        /// <summary>
        /// 2022-10-20 测试通过 
        /// 删除应用
        /// </summary>
        /// <returns></returns>
        [Test, Order(12),Ignore("接口没问题，先忽略，以免删除正在使用的应用")]
        public async Task DeleteApplicationTest()
        {
            var dto = await managementClient.DeleteApplication(new DeleteApplicationDto { AppId = appId });
            Assert.IsTrue(dto.Data.Success);
        }
    }

    class ApplicationManagementTest : ManagementClientBaseTest
    {
        /// <summary>
        /// 2022-10-20 测试通过
        /// 获取应用列表
        /// </summary>
        /// <returns></returns>
        [Test]
        [TestCase("test")]
        public async Task ListApplicationsTest(string appName)
        {
            var dto = await managementClient.ListApplications(new ListApplicationsDto { Keywords = appName, IsSelfBuiltApp = true });
            Assert.NotNull(dto);
        }

        /// <summary>
        /// 2022-10-20 测试失败  自动生成的返回信息有错
        /// 获取应用简单信息
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task ListApplicationSimpleInfoTest()
        {
            var dto = await managementClient.ListApplicationSimpleInfo(new ListApplicationSimpleInfoDto { IsSelfBuiltApp = true });
            Assert.NotNull(dto);
        }
    }
}
