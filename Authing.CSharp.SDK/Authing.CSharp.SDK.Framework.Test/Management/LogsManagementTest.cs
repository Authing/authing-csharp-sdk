using Authing.CSharp.SDK.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authing.CSharp.SDK.Framework.Test.Management
{
    internal class LogsManagementTest: ManagementClientBaseTest
    {
        /// <summary>
        /// 2022-10-20 测试成功
        /// 获取用户行为日志
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetUserActionLogsTest()
        {
            var res = await managementClient.GetUserActionLogs(new GetUserActionLogsDto { });
            Assert.AreEqual(200,res.StatusCode);
        }

        /// <summary>
        /// 2022-10-20 测试成功
        /// 获取管理员操作日志
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetAdminAuditLogsTest()
        {
            var res = await managementClient.GetAdminAuditLogs(new  GetAdminAuditLogsDto { });
            Assert.AreEqual(200,res.StatusCode);
        }
    }
}
