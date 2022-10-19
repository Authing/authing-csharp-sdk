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
/// EnrollFactorEnrollmentDataDto 的模型
/// </summary>
public partial class EnrollFactorEnrollmentDataDto
{
    /// <summary>
    ///  绑定短信、邮箱验证码、OTP 类型的认证要素时，需要传此参数。值为短信/邮箱/OTP 验证码。
    /// </summary>
    [JsonProperty("passCode")]
    public string  PassCode {get;set;}
}
}