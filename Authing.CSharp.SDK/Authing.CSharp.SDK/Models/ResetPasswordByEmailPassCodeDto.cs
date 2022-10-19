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
/// ResetPasswordByEmailPassCodeDto 的模型
/// </summary>
public partial class ResetPasswordByEmailPassCodeDto
{
    /// <summary>
    ///  此账号绑定的邮箱，不区分大小写。
    /// </summary>
    [JsonProperty("email")]
    public string  Email {get;set;}
    /// <summary>
    ///  邮箱验证码，一个短信验证码只能使用一次，默认有效时间为 5 分钟。你需要通过**发送邮件**接口获取。
    /// </summary>
    [JsonProperty("passCode")]
    public string  PassCode {get;set;}
}
}