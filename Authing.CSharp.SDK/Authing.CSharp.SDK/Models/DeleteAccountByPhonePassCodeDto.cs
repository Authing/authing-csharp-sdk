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
/// DeleteAccountByPhonePassCodeDto 的模型
/// </summary>
public partial class DeleteAccountByPhonePassCodeDto
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
    ///  手机区号
    /// </summary>
    [JsonProperty("phoneCountryCode")]
    public string  PhoneCountryCode {get;set;}
}
}