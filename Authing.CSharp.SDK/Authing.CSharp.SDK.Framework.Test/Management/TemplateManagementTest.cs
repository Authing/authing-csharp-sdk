using Authing.CSharp.SDK.Models.Management;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Authing.CSharp.SDK.Framework.Test.Management
{
    internal class TemplateManagementTest : ManagementClientBaseTest
    {
        [Test]
        public async Task GetEmailTemplatesTest()
        {
            var dto = await managementClient.GetEmailTemplates();
            Assert.NotNull(dto);
        }

        [Test]
        public async Task UpdateEmailTemplateTest()
        {
            var dto = await managementClient.UpdateEmailTemplate(new UpdateEmailTemplateDto { });
            Assert.NotNull(dto);
        }

        [Test]
        public async Task PreviewEmailTemplateTest()
        {
            var dto = await managementClient.PreviewEmailTemplate(new PreviewEmailTemplateDto { });
            Assert.NotNull(dto);
        }

        [Test]
        public async Task GetEmailProviderTest()
        {
            var dto = await managementClient.GetEmailProvider();
            Assert.NotNull(dto);
        }

        [Test]
        public async Task ConfigEmailProviderTest()
        {
            var dto = await managementClient.ConfigEmailProvider(new ConfigEmailProviderDto { });
            Assert.NotNull(dto);
        }
    }
}
