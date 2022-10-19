using Authing.CSharp.SDK.Models.Management;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authing.CSharp.SDK.Framework.Test.Management
{
    internal class PackageManagementTest: ManagementClientBaseTest
    {
        [Test]
        public async Task GetCurrentPackageInfoTest()
        {
            var dto = await managementClient.GetCurrentPackageInfo();
            Assert.NotNull(dto);
        }

        [Test]
        public async Task GetUsageInfoTest()
        {
            var dto = await managementClient.GetUsageInfo();
            Assert.NotNull(dto);
        }

        [Test]
        public async Task GetMauPeriodUsageHistoryTest()
        {
            var dto = await managementClient.GetMauPeriodUsageHistory(new GetMauPeriodUsageHistoryDto { });
            Assert.NotNull(dto);
        }

        [Test]
        public async Task GetAllRightsItemTest()
        {
            var dto = await managementClient.GetAllRightsItem();
            Assert.NotNull(dto);
        }

        [Test]
        public async Task GetOrdersTest()
        {
            var dto = await managementClient.GetOrders(new GetOrdersDto { });
            Assert.NotNull(dto);
        }

        [Test]
        public async Task GetOrderDetailTest()
        {
            var dto = await managementClient.GetOrderDetail(new GetOrderDetailDto { });
            Assert.NotNull(dto);
        }

        [Test]
        public async Task GetOrderPayDetailTest()
        {
            var dto = await managementClient.GetOrderPayDetail(new GetOrderPayDetailDto { });
            Assert.NotNull(dto);
        }
    }
}
