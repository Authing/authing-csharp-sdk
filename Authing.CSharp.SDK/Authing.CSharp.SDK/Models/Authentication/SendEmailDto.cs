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

    public enum EmailChannel
    {
        /// <summary>
        /// 登录
        /// </summary>
        CHANNEL_LOGIN, 
        /// <summary>
        /// 注册
        /// </summary>
        CHANNEL_REGISTER, 
        /// <summary>
        /// 重置密码
        /// </summary>
        CHANNEL_RESET_PASSWORD, 
        /// <summary>
        /// 验证邮箱
        /// </summary>
        CHANNEL_VERIFY_EMAIL_LINK, 
        /// <summary>
        /// 绑定邮箱
        /// </summary>
        CHANNEL_BIND_EMAIL, 
        /// <summary>
        /// 解绑邮箱
        /// </summary>
        CHANNEL_UNBIND_EMAIL,
        /// <summary>
        /// 验证 MFA
        /// </summary>
        CHANNEL_VERIFY_MFA,
        /// <summary>
        /// 解锁账户
        /// </summary>
        CHANNEL_UNLOCK_ACCOUNT, 
        /// <summary>
        /// 
        /// </summary>
        CHANNEL_COMPLETE_EMAIL 
    }

}
