using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Authing.CSharp.SDK.Models;

   namespace Authing.CSharp.SDK.Models
{
/// <summary>
/// ResetPasswordByPhonePassCodeDto 的模型
/// </summary>
public partial class ResetPasswordByPhonePassCodeDto
{
    /// <summary>
    ///  此账号绑定的手机号，不带区号。如果是国外手机号，请在 phoneCountryCode 参数中指定区号。
    /// </summary>
    [JsonProperty("phoneNumber")]
    public string  PhoneNumber {get;set;}
    /// <summary>
    ///  短信验证码，一个短信验证码只能使用一次，有效时间为一分钟。你需要通过**发送短信**接口获取。
    /// </summary>
    [JsonProperty("passCode")]
    public string  PassCode {get;set;}
    /// <summary>
    ///  手机区号，中国大陆手机号可不填。Authing 短信服务暂不内置支持国际手机号，你需要在 Authing 控制台配置对应的国际短信服务。完整的手机区号列表可参阅 https://en.wikipedia.org/wiki/List_of_country_calling_codes。
    /// </summary>
    [JsonProperty("phoneCountryCode")]
    public string  PhoneCountryCode {get;set;}
}
}