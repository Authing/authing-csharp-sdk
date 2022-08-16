using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Authing.CSharp.SDK.Models.Authentication
{
    /// <summary>
    /// 发送邮件参数类
    /// </summary>
    public class SendEmailDto
    {
        /// <summary>
        /// 邮箱，不区分大小写
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// 短信通道，指定发送此短信的目的，如 CHANNEL_LOGIN 用于登录、CHANNEL_REGISTER 用于注册
        /// </summary>
        [JsonProperty("channel")]
        public EmailChannel Channel { get; set; }
    }
}
