using Authing.CSharp.SDK.Models;
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
        /// <summary>
        /// 2022-10-19 测试成功
        /// 获取邮件模版列表
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetEmailTemplatesTest()
        {
            var res = await managementClient.GetEmailTemplates();
            Assert.AreEqual(200, res.StatusCode);
        }

        /// <summary>
        /// 2022-10-19 测试成功
        /// 修改邮件模版
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task UpdateEmailTemplateTest()
        {
            var res = await managementClient.UpdateEmailTemplate(new UpdateEmailTemplateDto
            {
                Type = UpdateEmailTemplateDto.type.WELCOME_EMAIL,
                Subject = "test",
                Name = "test2",
                Sender = "tmgg",
                Content = "123",
                CustomizeEnabled = true,
                ExpiresIn = 123456
            });
            Assert.AreEqual(200, res.StatusCode);
        }

        /// <summary>
        /// 2022-10-19 测试成功
        /// 预览邮件模版
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task PreviewEmailTemplateTest()
        {
            var res = await managementClient.PreviewEmailTemplate(new PreviewEmailTemplateDto { Type = PreviewEmailTemplateDto.type.WELCOME_EMAIL, ExpiresIn = 1 });
            Assert.NotNull(res.Data);
        }


        /// <summary>
        /// 2022-10-19 测试失败
        /// 获取第三方邮件服务配置
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetEmailProviderTest()
        {
            var res = await managementClient.GetEmailProvider();
            Assert.NotNull(res);
        }

        /// <summary>
        /// 2022-10-19 测试失败
        /// 配置第三方邮件服务
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task ConfigEmailProviderTest()
        {
            var res = await managementClient.ConfigEmailProvider(new ConfigEmailProviderDto
            {
                Type = ConfigEmailProviderDto.type.ALI,
                AliExmailConfig = new AliExmailEmailProviderConfigInput
                {
                    Sender = "574378328@qq.com",
                    SenderPass = "123456"
                }
            });
            Assert.NotNull(res.Data.AliExmailConfig);
        }
    }
}
