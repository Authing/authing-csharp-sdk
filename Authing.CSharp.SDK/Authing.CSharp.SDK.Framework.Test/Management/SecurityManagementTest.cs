using Authing.CSharp.SDK.Models.Management;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authing.CSharp.SDK.Framework.Test.Management
{
    internal class SecurityManagementTest : ManagementClientBaseTest
    {
        [Test]
        public async Task UpdateSecuritySettingsTest()
        {
            var dto = await managementClient.UpdateSecuritySettings(new UpdateSecuritySettingsDto { });
            Assert.NotNull(dto);
        }
        [Test]
        public async Task GetSecuritySettingsTest()
        {
            var dto = await managementClient.GetSecuritySettings();
            Assert.NotNull(dto);
        }
        [Test]
        public async Task GetGlobalMfaSettingsTest()
        {
            var dto = await managementClient.GetGlobalMfaSettings();
            Assert.NotNull(dto);
        }
        [Test]
        public async Task UpdateGlobalMfaSettingsTest()
        {
            var dto = await managementClient.UpdateGlobalMfaSettings(new  MFASettingsDto { });
            Assert.NotNull(dto);
        }
    }
}
