using Authing.CSharp.SDK.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authing.CSharp.SDK.Framework.Test.Management
{
    class ApplicationManagementTest : ManagementClientBaseTest
    {
        /// <summary>
        /// 2022-10-20 测试通过
        /// 设置自定义字段的值
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetApplicationTest()
        {
            var dto = await managementClient.GetApplication(new GetApplicationDto { AppId = "634cf98aa5b1455a52949d33" });
            Assert.NotNull(dto.Data);
        }


        /// <summary>
        /// 2022-10-20 测试通过
        /// 获取应用列表
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task ListApplicationsTest()
        {
            var dto = await managementClient.ListApplications(new ListApplicationsDto { Keyword = "qidongtest", IsSelfBuiltApp = true });
            Assert.NotNull(dto);
        }

        /// <summary>
        /// 2022-10-20 测试通过
        /// 获取应用简单信息
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetApplicationSimpleInfoTest()
        {
            var dto = await managementClient.GetApplicationSimpleInfo(new GetApplicationSimpleInfoDto { AppId = "634cf98aa5b1455a52949d33" });
            Assert.NotNull(dto.Data);
        }

        /// <summary>
        /// 2022-10-20 测试失败  自动生成的返回信心有错
        /// 获取应用简单信息
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task ListApplicationSimpleInfoTest()
        {
            var dto = await managementClient.ListApplicationSimpleInfo(new ListApplicationSimpleInfoDto { IsSelfBuiltApp = true });
            Assert.NotNull(dto);
        }

        /// <summary>
        /// 2022-10-20 测试失败  创建应用成功后，会返回位置错误
        /// 创建应用
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task CreateApplicationTest()
        {
            var dto = await managementClient.CreateApplication(new CreateApplicationDto
            {
                AppName = "qidongnewtest",
                AppIdentifier = "qidongnewtest",
                SsoEnabled = false,
            });
            Assert.NotNull(dto);
        }

        /// <summary>
        /// 2022-10-20 测试通过 
        /// 删除应用
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task DeleteApplicationTest()
        {
            var dto = await managementClient.DeleteApplication(new DeleteApplicationDto { AppId = "6350f2ef373206b7a53ee886" });
            Assert.IsTrue(dto.Data.Success);
        }

        /// <summary>
        /// 2022-10-20 测试通过 
        /// 获取应用密钥
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetApplicationSecretTest()
        {
            var dto = await managementClient.GetApplicationSecret(new GetApplicationSecretDto { AppId = "634e5637ea7c7e0e817ddfc7" });
            Assert.NotNull(dto.Data.Secret);
        }

        /// <summary>
        /// 2022-10-20 测试通过 
        /// 刷新密钥
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task RefreshApplicationSecretTest()
        {
            var dto = await managementClient.RefreshApplicationSecret(new RefreshApplicationSecretDto { AppId = "634e5637ea7c7e0e817ddfc7" });
            Assert.NotNull(dto.Data.Secret);
        }

        /// <summary>
        /// 2022-10-20 测试通过 
        /// 获取应用当前登录用户
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task ListApplicationActiveUsersTest()
        {
            var dto = await managementClient.ListApplicationActiveUsers(new ListApplicationActiveUsersDto { AppId = "634e5637ea7c7e0e817ddfc7" });
            Assert.NotNull(dto);
        }

        /// <summary>
        /// 2022-10-20 测试通过 
        /// 获取应用默认访问策略
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetApplicationPermissionStrategyTest()
        {
            var dto = await managementClient.GetApplicationPermissionStrategy(new GetApplicationPermissionStrategyDto { AppId = "634e5637ea7c7e0e817ddfc7" });
            Assert.NotNull(dto);
        }


        /// <summary>
        /// 2022-10-20 测试通过 
        /// 获取应用默认访问策略
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task UpdateApplicationPermissionStrategyTest()
        {
            var dto = await managementClient.UpdateApplicationPermissionStrategy(new UpdateApplicationPermissionStrategyDataDto
            {
                AppId = "634e5637ea7c7e0e817ddfc7",
                PermissionStrategy = UpdateApplicationPermissionStrategyDataDto.permissionStrategy.DENY_ALL
            });
            Assert.IsTrue(dto.Data.Success);
        }

        /// <summary>
        /// 2022-10-20 测试通过 
        /// 授权应用访问
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task AuthorizeApplicationAccessTest()
        {
            var dto = await managementClient.AuthorizeApplicationAccess(new AddApplicationPermissionRecord
            {
                AppId = "634e5637ea7c7e0e817ddfc7",
                List = new List<ApplicationPermissionRecordItem>
            {
               new ApplicationPermissionRecordItem
               {
                   Effect=ApplicationPermissionRecordItem.effect.ALLOW,
                   TargetType=ApplicationPermissionRecordItem.targetType.USER,
                   TargetIdentifier=new List<string>{ "634fc0a6ebc13285a2ac8dd2" }
               }
            }
            });
            Assert.IsTrue(dto.Data.Success);
        }

        /// <summary>
        /// 2022-10-20 测试通过 
        /// 删除授权应用访问
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task RevokeApplicationAccessTest()
        {
            var dto = await managementClient.RevokeApplicationAccess(new DeleteApplicationPermissionRecord 
            {
                AppId= "634e5637ea7c7e0e817ddfc7",
                List=new List<DeleteApplicationPermissionRecordItem> 
                {
                    new DeleteApplicationPermissionRecordItem 
                    {
                        TargetIdentifier=new List<string> 
                        { "634fc0a6ebc13285a2ac8dd2" },
                        TargetType=DeleteApplicationPermissionRecordItem.targetType.USER 
                    }
                }
            });
            Assert.IsTrue(dto.Data.Success);
        }

        /// <summary>
        /// 2022-10-20 测试通过 
        /// 删除授权应用访问
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task CheckDomainAvailableTest()
        {
            var dto = await managementClient.CheckDomainAvailable(new CheckDomainAvailable 
            {
                Domain="qidongtest"
            });
            Assert.IsFalse(dto.Data.Available);
        }

    }
}
