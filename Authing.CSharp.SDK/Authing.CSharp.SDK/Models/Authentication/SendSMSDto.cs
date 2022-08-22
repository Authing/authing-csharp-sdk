using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Authing.CSharp.SDK.Models
{
    /// <summary>
    /// 发送短信参数类
    /// </summary>
    public class SendSMSDto
    {
        /// <summary>
        /// 手机号，不带区号。如果是国外手机号，请在 phoneCountryCode 参数中指定区号
        /// </summary>
        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// 短信通道，指定发送此短信的目的，如 CHANNEL_LOGIN 用于登录、CHANNEL_REGISTER 用于注册
        /// </summary>
        [JsonProperty("channel")]
        [JsonConverter(typeof(StringEnumConverter))]
        public SmsChannel Channel { get; set; }

        /// <summary>
        /// 手机区号，中国大陆手机号可不填。Authing 短信服务暂不内置支持国际手机号，
        /// 你需要在 Authing 控制台配置对应的国际短信服务。
        /// 完整的手机区号列表可参阅 https://en.wikipedia.org/wiki/List_of_country_calling_codes
        /// </summary>
        [JsonProperty("phoneCountryCode")]
        public string PhoneCountryCode { get; set; }
    }

    public enum SmsChannel
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
        /// 绑定手机
        /// </summary>
        CHANNEL_BIND_PHONE, 
        /// <summary>
        /// 解绑手机
        /// </summary>
        CHANNEL_UNBIND_PHONE,
        /// <summary>
        /// 绑定 MFA
        /// </summary>
        CHANNEL_BIND_MFA,
        /// <summary>
        /// 验证 MFA-
        /// </summary>
        CHANNEL_VERIFY_MFA,
        /// <summary>
        /// 解绑 MFA
        /// </summary>
        CHANNEL_UNBIND_MFA, 
        /// <summary>
        /// 
        /// </summary>
        CHANNEL_COMPLETE_PHONE, 
        /// <summary>
        /// 
        /// </summary>
        CHANNEL_IDENTITY_VERIFICATION,
        /// <summary>
        /// 删除账户
        /// </summary>
        CHANNEL_DELETE_ACCOUNT 
    }

}
