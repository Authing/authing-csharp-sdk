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
    /// SignUpByPassCodeDto 的模型
    /// </summary>
    public partial class SignUpByPassCodeDto
    {
        /// <summary>
        ///  一次性临时验证码，你需要先调用发送短信或者发送邮件接口获取验证码。
        /// </summary>
        [JsonProperty("passCode")]
        public    string   PassCode    {get;set;}
        /// <summary>
        ///  邮箱，不区分大小写。
        /// </summary>
        [JsonProperty("email")]
        public    string   Email    {get;set;}
        /// <summary>
        ///  手机号
        /// </summary>
        [JsonProperty("phone")]
        public    string   Phone    {get;set;}
        /// <summary>
        ///  手机区号，中国大陆手机号可不填。Authing 短信服务暂不内置支持国际手机号，你需要在 Authing 控制台配置对应的国际短信服务。完整的手机区号列表可参阅 https://en.wikipedia.org/wiki/List_of_country_calling_codes。
        /// </summary>
        [JsonProperty("phoneCountryCode")]
        public    string   PhoneCountryCode    {get;set;}
    }
}