using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Authing.CSharp.SDK.Models
{
    public class ResetPasswordVerifyDto
    {
        /// <summary>
        /// 忘记密码请求使用的验证手段
        /// </summary>
        public VerifyMethod VerifyMethod { get; set; }

        /// <summary>
        /// 使用手机号验证码验证的数据
        /// </summary>
        [JsonProperty("phonePassCodePayload")]
        public ResetPasswordPhonePassCodePayload PhonePassCodePayload { get; set; }

        /// <summary>
        /// 使用邮箱验证码验证的数据
        /// </summary>
        [JsonProperty("emailPassCodePayload")]
        public ResetPasswordEmailPassCodePayload EmailPassCodePayload { get;set; }
    }

    public class ResetPasswordPhonePassCodePayload
    {
        /// <summary>
        /// 此账号绑定的手机号，不带区号。如果是国外手机号，请在 phoneCountryCode 参数中指定区号。
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// 短信验证码，一个短信验证码只能使用一次，有效时间为一分钟。你需要通过发送短信接口获取。
        /// </summary>
        public string PassCode { get; set; }
        /// <summary>
        /// 手机区号，中国大陆手机号可不填。Authing 短信服务暂不内置支持国际手机号，你需要在 Authing 控制台配置对应的国际短信服务。完整的手机区号列表可参阅 https://en.wikipedia.org/wiki/List_of_country_calling_codes。
        /// </summary>
        public string PhoneCountryCode { get; set; }
    }

    public class ResetPasswordEmailPassCodePayload 
    {
        /// <summary>
        /// 此账号绑定的邮箱，不区分大小写。
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 邮箱验证码，一个短信验证码只能使用一次，默认有效时间为无分钟。你需要通过发送邮件接口获取。
        /// </summary>
        public string PassCode { get; set; }
    }
}
