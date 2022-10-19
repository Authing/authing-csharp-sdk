using Authing.CSharp.SDK.Models.Management;
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
        [Test]
        public async Task GetUserActionLogsTest()
        {
            var dto = await managementClient.GetUserActionLogs(new GetUserActionLogsDto { });
            Assert.NotNull(dto);
        }

        [Test]
        public async Task GetAdminAuditLogsTest()
        {
            var dto = await managementClient.GetAdminAuditLogs(new  GetAdminAuditLogsDto { });
            Assert.NotNull(dto);
        }
    }
}
