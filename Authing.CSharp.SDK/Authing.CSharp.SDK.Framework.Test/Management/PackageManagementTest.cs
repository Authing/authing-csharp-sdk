using Authing.CSharp.SDK.Models;
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
        /// <summary>
        /// 2022-10-20 测试成功
        /// 获取套餐详情
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetCurrentPackageInfoTest()
        {
            var res = await managementClient.GetCurrentPackageInfo();
            Assert.AreEqual(200, res.StatusCode);
        }

        /// <summary>
        /// 2022-10-20 测试成功
        /// 获取用量详情
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetUsageInfoTest()
        {
            var res = await managementClient.GetUsageInfo();
            Assert.AreEqual(200, res.StatusCode);
        }

        /// <summary>
        /// 2022-10-20 测试成功
        /// 获取 MAU 使用记录
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetMauPeriodUsageHistoryTest()
        {
            var res = await managementClient.GetMauPeriodUsageHistory(new GetMauPeriodUsageHistoryDto
            {
                StartTime = "20220101",
                EndTime = "20221030"
            });
            Assert.AreEqual(200, res.StatusCode);
        }

        /// <summary>
        /// 2022-10-20 测试成功
        /// 获取所有权益
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetAllRightsItemTest()
        {
            var res = await managementClient.GetAllRightsItem();
            Assert.AreEqual(200, res.StatusCode);
        }

        /// <summary>
        /// 2022-10-20 测试成功
        /// 获取订单列表
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetOrdersTest()
        {
            var res = await managementClient.GetOrders(new GetOrdersDto { });
            Assert.AreEqual(200, res.StatusCode);
        }

        /// <summary>
        /// 2022-10-20 测试成功
        /// 获取订单详情
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetOrderDetailTest()
        {
            var res = await managementClient.GetOrderDetail(new GetOrderDetailDto { OrderNo = "12345"});
            Assert.AreEqual(200, res.StatusCode);
        }

        /// <summary>
        /// 2022-10-20 测试成功
        /// 获取订单支付明细
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetOrderPayDetailTest()
        {
            var res = await managementClient.GetOrderPayDetail(new GetOrderPayDetailDto { OrderNo = "12345"}); 
            Assert.AreEqual(200, res.StatusCode);
        }
    }
}
