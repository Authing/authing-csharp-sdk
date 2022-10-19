using Authing.CSharp.SDK.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Interfaces;

namespace Authing.CSharp.SDK.Framework.Test.Management
{
    internal class WebHookManagementTest : ManagementClientBaseTest
    {
        /// <summary>
        /// 2022-10-19 测试成功
        /// 创建 Webhook
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task CreateWebHooKTest()
        {
            var res = await managementClient.CreateWebhook(new CreateWebhookDto
            {
                Name = "test",
                Url = "https://www.baidu.com/callback",
                Events = new List<string>() { "user:created" },
                ContentType = CreateWebhookDto.contentType.APPLICATION_JSON
            });
            Assert.AreEqual(200, res.StatusCode);
        }

        /// <summary>
        /// 2022-10-19 测试成功
        /// 获取 Webhook 列表
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task ListWebhooksTest()
        {
            var res = await managementClient.ListWebhooks(new ListWebhooksDto { });
            Assert.AreEqual(200, res.StatusCode);
        }

        /// <summary>
        /// 2022-10-19 测试成功
        /// 修改 Webhook 配置
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task UpdateWebhookTest()
        {
            var res = await managementClient.ListWebhooks(new ListWebhooksDto { });
            var item = res.Data.List.First();
            var res2 = await managementClient.UpdateWebhook(new UpdateWebhookDto { WebhookId = item.WebhookId, Enabled = false });
            Assert.AreEqual(false, res2.Data.Enabled);
        }

        /// <summary>
        /// 2022-10-19 测试成功
        /// 删除 Webhook
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task DeleteWebhookTest()
        {
            var res = await managementClient.ListWebhooks(new ListWebhooksDto { });
            var item = res.Data.List.First();
            var res2 = await managementClient.DeleteWebhook(new DeleteWebhookDto { WebhookIds = new List<string>() { $"{item.WebhookId}" } });
            Assert.AreEqual(200, res2.StatusCode);
        }

        /// <summary>
        /// 2022-10-19 测试成功
        /// 获取 Webhook 日志
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetWebhookLogsTest()
        {
            var res = await managementClient.ListWebhooks(new ListWebhooksDto { });
            var item = res.Data.List.First();
            var res2 = await managementClient.GetWebhookLogs(new ListWebhookLogs { Page = 1, Limit = 10, WebhookId = item.WebhookId });
            Assert.AreEqual(200, res2.StatusCode);
        }

        /// <summary>
        /// 2022-10-19 测试成功
        /// 手动触发 Webhook 执行
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task TriggerWebhookTest()
        {
            var res = await managementClient.ListWebhooks(new ListWebhooksDto { });
            var item = res.Data.List.First();
            var res2 = await managementClient.TriggerWebhook(new TriggerWebhookDto { WebhookId = item.WebhookId });
            Assert.AreEqual(200, res2.StatusCode);
        }

        /// <summary>
        /// 2022-10-19 测试成功
        /// 获取 Webhook 详情
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetWebhookTest()
        {
            var res = await managementClient.ListWebhooks(new ListWebhooksDto { });
            var item = res.Data.List.First();
            var res2 = await managementClient.GetWebhook(new GetWebhookDto() { WebhookId = item.WebhookId });
            Assert.AreEqual(200, res2.StatusCode);
        }

        /// <summary>
        /// 2022-10-19 测试成功
        /// 获取 Webhook 事件列表
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetWebhookEventListTest()
        {
            var res = await managementClient.GetWebhookEventList();
            Assert.AreEqual(200, res.StatusCode);
        }
    }
}
