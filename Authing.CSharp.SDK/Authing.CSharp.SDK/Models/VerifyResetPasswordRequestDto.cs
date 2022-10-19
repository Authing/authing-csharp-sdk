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
/// VerifyResetPasswordRequestDto 的模型
/// </summary>
public partial class VerifyResetPasswordRequestDto
{
    /// <summary>
    ///  忘记密码请求使用的验证手段：
/// - `EMAIL_PASSCODE`: 通过邮箱验证码进行验证，当前只支持这种验证方式。
/// 
    /// </summary>
    [JsonProperty("verifyMethod")]
    public verifyMethod  VerifyMethod {get;set;}
    /// <summary>
    ///  使用手机号验证码验证的数据
    /// </summary>
    [JsonProperty("phonePassCodePayload")]
    public ResetPasswordByPhonePassCodeDto  PhonePassCodePayload {get;set;}
    /// <summary>
    ///  使用邮箱验证码验证的数据
    /// </summary>
    [JsonProperty("emailPassCodePayload")]
    public ResetPasswordByEmailPassCodeDto  EmailPassCodePayload {get;set;}
}
public partial class VerifyResetPasswordRequestDto
 {
    /// <summary>
    ///  忘记密码请求使用的验证手段：
/// - `EMAIL_PASSCODE`: 通过邮箱验证码进行验证，当前只支持这种验证方式。
/// 
    /// </summary>
    public enum verifyMethod
     {
         [EnumMember(Value="EMAIL_PASSCODE")]
        EMAIL_PASSCODE,
         [EnumMember(Value="PHONE_PASSCODE")]
        PHONE_PASSCODE,
    }
}
}