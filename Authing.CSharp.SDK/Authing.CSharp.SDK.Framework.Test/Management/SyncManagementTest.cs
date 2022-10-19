using Authing.CSharp.SDK.Models.Management;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authing.CSharp.SDK.Framework.Test.Management
{
    internal class SyncManagementTest : ManagementClientBaseTest
    {
        [Test]
        public async Task GetSyncTaskTest()
        {
            var dto = await managementClient.GetSyncTask(new GetSyncTaskDto { });
            Assert.NotNull(dto);
        }

        [Test]
        public async Task ListSyncTasksTest()
        {
            var dto = await managementClient.ListSyncTasks(new ListSyncTasksDto { });
            Assert.NotNull(dto);
        }

        [Test]
        public async Task CreateSyncTaskTest()
        {
            var dto = await managementClient.CreateSyncTask(new CreateSyncTaskDto { });
            Assert.NotNull(dto);
        }

        [Test]
        public async Task UpdateSyncTaskTest()
        {
            var dto = await managementClient.UpdateSyncTask(new UpdateSyncTaskDto { });
            Assert.NotNull(dto);
        }

        [Test]
        public async Task TriggerSyncTaskTest()
        {
            var dto = await managementClient.TriggerSyncTask(new TriggerSyncTaskDto { });
            Assert.NotNull(dto);
        }

        [Test]
        public async Task GetSyncJobTest()
        {
            var dto = await managementClient.GetSyncJob(new GetSyncJobDto { });
            Assert.NotNull(dto);
        }

        [Test]
        public async Task ListSyncJobsTest()
        {
            var dto = await managementClient.ListSyncJobs(new ListSyncJobsDto { });
            Assert.NotNull(dto);
        }

        [Test]
        public async Task ListSyncJobLogsTest()
        {
            var dto = await managementClient.ListSyncJobLogs(new ListSyncJobLogsDto { });
            Assert.NotNull(dto);
        }

        [Test]
        public async Task ListSyncRiskOperationsTest()
        {
            var dto = await managementClient.ListSyncRiskOperations(new ListSyncRiskOperationsDto { });
            Assert.NotNull(dto);
        }

        [Test]
        public async Task TriggerSyncRiskOperationsTest()
        {
            var dto = await managementClient.TriggerSyncRiskOperations(new TriggerSyncRiskOperationDto { });
            Assert.NotNull(dto);
        }

        [Test]
        public async Task CancelSyncRiskOperationTest()
        {
            var dto = await managementClient.CancelSyncRiskOperation(new  CancelSyncRiskOperationDto { });
            Assert.NotNull(dto);
        }
    }
}
