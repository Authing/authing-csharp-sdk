using Authing.CSharp.SDK.Models.Management;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authing.CSharp.SDK.Framework.Test.Management
{
    internal class WebHookManagementTest : ManagementClientBaseTest
    {
        [Test]
        public async Task CreateWebHooKTest()
        {
            var dto = await managementClient.CreateWebhook(new CreateWebhookDto { });
        }

        [Test]
        public async Task ListWebhooksTest()
        {
            var dto = await managementClient.ListWebhooks(new ListWebhooksDto { });
        }

        [Test]
        public async Task UpdateWebhookTest()
        {
            var dto = await managementClient.UpdateWebhook(new UpdateWebhookDto { });
        }

        [Test]
        public async Task DeleteWebhookTest()
        {
            var dto = await managementClient.DeleteWebhook(new DeleteWebhookDto { });
        }

        [Test]
        public async Task GetWebhookLogsTest()
        {
            var dto = await managementClient.GetWebhookLogs(new ListWebhookLogs { });
        }

        [Test]
        public async Task TriggerWebhookTest()
        {
            var dto = await managementClient.TriggerWebhook(new TriggerWebhookDto { });
        }

        [Test]
        public async Task GetWebhookTest()
        {
            var dto = await managementClient.GetWebhook(new GetWebhookDto { });
        }

        [Test]
        public async Task GetWebhookEventListTest()
        {
            var dto = await managementClient.GetWebhookEventList();
        }
    }
}
