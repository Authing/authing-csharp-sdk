using Authing.CSharp.SDK.Models;
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
        /// <summary>
        /// 2022-10-20 测试成功
        /// 获取同步任务详情
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetSyncTaskTest()
        {
            var res1 = await managementClient.ListSyncTasks(new ListSyncTasksDto { });
            Assert.AreEqual(200, res1.StatusCode);
            var target = res1.Data.List.First();
            var res2 = await managementClient.GetSyncTask(new GetSyncTaskDto { SyncTaskId = target.SyncTaskId });
            Assert.AreEqual(200, res2.StatusCode);
        }

        /// <summary>
        /// 2022-10-20 测试成功
        /// 获取同步任务列表
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task ListSyncTasksTest()
        {
            var res = await managementClient.ListSyncTasks(new ListSyncTasksDto { });
            Assert.AreEqual(200, res.StatusCode);
        }

        /// <summary>
        /// 2022-10-20 测试失败
        /// 创建同步任务
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task CreateSyncTaskTest()
        {
            var res = await managementClient.CreateSyncTask(new CreateSyncTaskDto
            {
                SyncTaskName = "SDK",
                SyncTaskType = CreateSyncTaskDto.syncTaskType.ACTIVE_DIRECTORY,
                ClientConfig = new SyncTaskClientConfig()
                {
                    ActiveDirectoryConfig = new SyncTaskActiveDirectoryClientConfig
                    {
                        SyncIdentityProviderCode = "SDKTEST",
                        Ticket_url = "https://whoami.com/whocare"
                    }
                },
                SyncTaskFlow = CreateSyncTaskDto.syncTaskFlow.UPSTREAM,
                SyncTaskTrigger = CreateSyncTaskDto.syncTaskTrigger.MANUALLY,
                FieldMapping = new List<SyncTaskFieldMapping>()
                {
                    new SyncTaskFieldMapping
                    {
                        Expression = "mobile",
                        TargetKey = "phone"
                    }
                }
            });
            Assert.AreEqual(200, res.StatusCode);
        }

        /// <summary>
        /// 2022-10-20 测试失败
        /// 修改同步任务
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task UpdateSyncTaskTest()
        {
            var res1 = await managementClient.ListSyncTasks(new ListSyncTasksDto { });
            Assert.AreEqual(200, res1.StatusCode);
            var target = res1.Data.List.Last();
            var res2 = await managementClient.UpdateSyncTask(new UpdateSyncTaskDto
            {
                SyncTaskId = target.SyncTaskId,
                SyncTaskType = UpdateSyncTaskDto.syncTaskType.ACTIVE_DIRECTORY,
                SyncTaskName = "SDKMODIFIY"
            });
            Assert.AreEqual(200, res2.StatusCode);
        }

        /// <summary>
        /// 2022-10-20 测试失败
        /// 执行同步任务
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task TriggerSyncTaskTest()
        {
            var res1 = await managementClient.ListSyncTasks(new ListSyncTasksDto { });
            Assert.AreEqual(200, res1.StatusCode);
            var target = res1.Data.List.Last();
            var res2 = await managementClient.TriggerSyncTask(new TriggerSyncTaskDto { SyncTaskId = target.SyncTaskId });
            Assert.AreEqual(200, res2.StatusCode);
        }

        /// <summary>
        /// 2022-10-20 测试失败
        /// 通过同步作业 ID 获取同步作业详情
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetSyncJobTest()
        {
            var res1 = await managementClient.ListSyncTasks(new ListSyncTasksDto { });
            Assert.AreEqual(200, res1.StatusCode);
            var target = res1.Data.List.Last();
            var res2 = await managementClient.ListSyncJobs(new ListSyncJobsDto { SyncTaskId = target.SyncTaskId });
            Assert.AreEqual(200, res2.StatusCode);
            var target2 = res2.Data.List.First();
            var res3 = await managementClient.GetSyncJob(new GetSyncJobDto { SyncJobId = target2.SyncJobId });
            Assert.AreEqual(200, res3.StatusCode);
        }

        /// <summary>
        /// 2022-10-20 测试失败
        /// 通过同步任务 ID 获取所有同步作业详情
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task ListSyncJobsTest()
        {
            var res1 = await managementClient.ListSyncTasks(new ListSyncTasksDto { });
            Assert.AreEqual(200, res1.StatusCode);
            var target = res1.Data.List.Last();
            var res2 = await managementClient.ListSyncJobs(new ListSyncJobsDto { SyncTaskId = target.SyncTaskId });
            Assert.AreEqual(200, res2.StatusCode);
        }

        /// <summary>
        /// 2022-10-20 测试失败
        /// 通过同步作业 ID 获取同步作业详情与日志
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task ListSyncJobLogsTest()
        {
            var res1 = await managementClient.ListSyncTasks(new ListSyncTasksDto { });
            Assert.AreEqual(200, res1.StatusCode);
            var target = res1.Data.List.Last();
            var res2 = await managementClient.ListSyncJobs(new ListSyncJobsDto { SyncTaskId = target.SyncTaskId });
            Assert.AreEqual(200, res2.StatusCode);
            var target2 = res2.Data.List.First();
            var res3 = await managementClient.GetSyncJob(new GetSyncJobDto { SyncJobId = target2.SyncJobId });
            Assert.AreEqual(200, res3.StatusCode);
            var dto = await managementClient.ListSyncJobLogs(new ListSyncJobLogsDto
            {
                SyncJobId = target2.SyncJobId,
                Action = "CreateUser"

            });
            Assert.NotNull(dto);
        }

        /// <summary>
        /// 2022-10-20 测试失败
        /// 获取同步风险操作列表
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task ListSyncRiskOperationsTest()
        {
            var res1 = await managementClient.ListSyncTasks(new ListSyncTasksDto { });
            Assert.AreEqual(200, res1.StatusCode);
            var target = res1.Data.List.Last();
            var res = await managementClient.ListSyncRiskOperations(new ListSyncRiskOperationsDto { SyncTaskId = target.SyncTaskId });
            Assert.AreEqual(200, res.StatusCode);
        }

        /// <summary>
        /// 2022-10-20 测试失败
        /// 通过同步作业 ID 获取同步作业详情与日志
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task TriggerSyncRiskOperationsTest()
        {
            var res1 = await managementClient.ListSyncTasks(new ListSyncTasksDto { });
            Assert.AreEqual(200, res1.StatusCode);
            var target = res1.Data.List.Last();
            var res2 = await managementClient.ListSyncRiskOperations(new ListSyncRiskOperationsDto { SyncTaskId = target.SyncTaskId });
            Assert.AreEqual(200, res2.StatusCode);
            var target2 = res2.Data.List.Last();
            var res3 = await managementClient.TriggerSyncRiskOperations(new TriggerSyncRiskOperationDto
            {
                SyncRiskOperationIds = new List<long>() { target2.SyncRiskOperationId }
            });
            Assert.AreEqual(200, res3.StatusCode);
        }

        /// <summary>
        /// 2022-10-20 测试失败
        /// 取消同步风险操作
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task CancelSyncRiskOperationTest()
        {
            var res1 = await managementClient.ListSyncTasks(new ListSyncTasksDto { });
            Assert.AreEqual(200, res1.StatusCode);
            var target = res1.Data.List.Last();
            var res2 = await managementClient.ListSyncRiskOperations(new ListSyncRiskOperationsDto { SyncTaskId = target.SyncTaskId });
            Assert.AreEqual(200, res2.StatusCode);
            var target2 = res2.Data.List.Last();
            var res3 = await managementClient.CancelSyncRiskOperation(new CancelSyncRiskOperationDto
            {
                SyncRiskOperationIds = new List<long>() { target2.SyncRiskOperationId }
            });
            Assert.AreEqual(200, res3.StatusCode);
        }
    }
}
