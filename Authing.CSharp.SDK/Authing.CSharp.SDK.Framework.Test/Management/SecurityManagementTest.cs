using Authing.CSharp.SDK.Models;
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
        /// <summary>
        /// 2022-10-20 测试成功
        /// 获取安全配置
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetSecuritySettingsTest()
        {
            var res = await managementClient.GetSecuritySettings();
            Assert.AreEqual(200, res.StatusCode);
        }

        /// <summary>
        /// 2022-10-20 测试成功
        /// 修改安全配置
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task UpdateSecuritySettingsTest()
        {
            var res = await managementClient.UpdateSecuritySettings(new UpdateSecuritySettingsDto
            {
                AllowedOrigins = new List<string>() { "https://www.baidu.com" }
            });
            Assert.AreEqual(200, res.StatusCode);
        }



        /// <summary>
        /// 2022-10-20 测试失败
        /// 获取全局多因素认证配置
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetGlobalMfaSettingsTest()
        {
            var res = await managementClient.GetGlobalMfaSettings();
            Assert.AreEqual(200, res.StatusCode);
        }

        /// <summary>
        /// 2022-10-20 测试失败
        /// 修改全局多因素认证配置
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task UpdateGlobalMfaSettingsTest()
        {
            var res = await managementClient.UpdateGlobalMfaSettings(new MFASettingsDto
            {
                EnabledFactors = new List<string>(){"OTP","SMS","EMAIL","FACE"}
            });
            Assert.AreEqual(200,res.StatusCode);
        }
    }
}
