using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Authing.CSharp.SDK.Models;
using NUnit.Framework;

namespace Authing.CSharp.SDK.Framework.Test
{
    public partial class AuthenticationClientAuthTest
    {
        /// <summary>
        /// 2022-10-17 测试通过
        /// 使用邮箱密码注册
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task RegisterByEmailAndPassword()
        {
            var res = await client.SignUpByEmailPassword("574378328@qq.com", "88886666");
            Assert.AreEqual(200, res.StatusCode);
        }

        /// <summary>
        /// 2022-10-17 测试失败
        /// 使用邮箱验证码注册
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task RegisterByEmailAndCode()
        {
            var res1 = await client.SendEmail(new SendEmailDto()
            {
                Email = "574378328@qq.com",
                Channel = SendEmailDto.channel.CHANNEL_REGISTER
            });
            Assert.AreEqual(200,res1.StatusCode);
            var res2 = await client.SignUpByEmailCode("574378328@qq.com", "6002");
            Assert.AreEqual(200,res2.StatusCode);
        }
    }
}
