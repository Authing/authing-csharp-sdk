using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Authing.CSharp.SDK.Models
{
    /// <summary>
    /// FactorProfile 的模型
    /// </summary>
    public partial class FactorProfile
    {
        /// <summary>
        ///  当发起绑定手机短信认证要素时，此参数必传。需要传递用户希望绑定的手机号。Authing 服务器会向此手机号发送短信验证码，要求用户在绑定 MFA 阶段提供验证码。一个手机号在一分钟内只能请求一次。
        /// </summary>
        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }
        /// <summary>
        ///  当发起绑定手机短信认证要素且需要绑定国际手机号时可以设置，默认为 +86，中国大陆手机区号。Authing 短信服务暂不内置支持国际手机号，你需要在 Authing 控制台配置对应的国际短信服务。完整的手机区号列表可参阅 https://en.wikipedia.org/wiki/List_of_country_calling_codes。
        /// </summary>
        [JsonProperty("phoneCountryCode")]
        public string PhoneCountryCode { get; set; }
        /// <summary>
        ///  当发起绑定邮箱验证码认证要素时，此参数必传。需要传递用户希望绑定的邮箱。Authing 服务器会向此邮箱发送邮箱验证码，要求用户在绑定 MFA 阶段提供验证码。一个邮箱在一分钟内只能请求一次。
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }
    }
}