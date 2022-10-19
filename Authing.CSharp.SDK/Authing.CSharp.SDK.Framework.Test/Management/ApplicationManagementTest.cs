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
        [Test]
        public async Task GetApplicationTest()
        {
            var dto = await managementClient.GetApplication(new GetApplicationDto { });
            Assert.NotNull(dto);
        }


        [Test]
        public async Task ListApplicationsTest()
        {
            var dto = await managementClient.ListApplications(new ListApplicationsDto { });
            Assert.NotNull(dto);
        }


        [Test]
        public async Task GetApplicationSimpleInfoTest()
        {
            var dto = await managementClient.GetApplicationSimpleInfo(new  GetApplicationSimpleInfoDto { });
            Assert.NotNull(dto);
        }


        [Test]
        public async Task ListApplicationSimpleInfoTest()
        {
            var dto = await managementClient.ListApplicationSimpleInfo(new  ListApplicationSimpleInfoDto { });
            Assert.NotNull(dto);
        }

        [Test]
        public async Task CreateApplicationTest()
        {
            var dto = await managementClient.CreateApplication(new  CreateApplicationDto { });
            Assert.NotNull(dto);
        }

        [Test]
        public async Task DeleteApplicationTest()
        {
            var dto = await managementClient.GetApplication(new  GetApplicationDto { });
            Assert.NotNull(dto);
        }

        [Test]
        public async Task GetApplicationSecretTest()
        {
            var dto = await managementClient.GetApplicationSecret(new  GetApplicationSecretDto { });
            Assert.NotNull(dto);
        }

        [Test]
        public async Task RefreshApplicationSecretTest()
        {
            var dto = await managementClient.RefreshApplicationSecret(new  RefreshApplicationSecretDto { });
            Assert.NotNull(dto);
        }

        [Test]
        public async Task ListApplicationActiveUsersTest()
        {
            var dto = await managementClient.ListApplicationActiveUsers(new  ListApplicationActiveUsersDto { });
            Assert.NotNull(dto);
        }

        [Test]
        public async Task GetApplicationPermissionStrategyTest()
        {
            var dto = await managementClient.GetApplicationPermissionStrategy(new  GetApplicationPermissionStrategyDto { });
            Assert.NotNull(dto);
        }

        [Test]
        public async Task UpdateApplicationPermissionStrategyTest()
        {
            var dto = await managementClient.UpdateApplicationPermissionStrategy(new  UpdateApplicationPermissionStrategyDataDto { });
            Assert.NotNull(dto);
        }

        [Test]
        public async Task AuthorizeApplicationAccessTest()
        {
            var dto = await managementClient.AuthorizeApplicationAccess(new  AddApplicationPermissionRecord { });
            Assert.NotNull(dto);
        }

        [Test]
        public async Task RevokeApplicationAccessTest()
        {
            var dto = await managementClient.RevokeApplicationAccess(new  DeleteApplicationPermissionRecord { });
            Assert.NotNull(dto);
        }

        [Test]
        public async Task CheckDomainAvailableTest()
        {
            var dto = await managementClient.CheckDomainAvailable(new  CheckDomainAvailable { });
            Assert.NotNull(dto);
        }

    }
}
