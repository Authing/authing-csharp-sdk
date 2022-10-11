using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Authing.CSharp.SDK.Models.Management;

   namespace Authing.CSharp.SDK.Models.Management
{
/// <summary>
/// SelfUnlockAccountConfigDto 的模型
/// </summary>
public partial class SelfUnlockAccountConfigDto
{
    /// <summary>
    ///  是否允许用户自助解锁账号。
    /// </summary>
[JsonProperty("enabled")]
public    bool   Enabled    {get;set;}
    /// <summary>
    ///  自助解锁方式，目前支持原密码 + 验证码和验证码两种方式。
    /// </summary>
[JsonProperty("strategy")]
public    strategy   Strategy    {get;set;}
}
public partial class SelfUnlockAccountConfigDto
 {
    /// <summary>
    ///  自助解锁方式，目前支持原密码 + 验证码和验证码两种方式。
    /// </summary>
    public enum strategy
     {
         [EnumMember(Value="captcha")]
        CAPTCHA,
         [EnumMember(Value="password-captcha")]
        PASSWORD_CAPTCHA,
    }
}
}