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
/// UpdateUserBatchOptionsDto 的模型
/// </summary>
public partial class UpdateUserBatchOptionsDto
{
    /// <summary>
    ///  下次登录要求重置密码
    /// </summary>
    [JsonProperty("resetPasswordOnNextLogin")]
    public bool  ResetPasswordOnNextLogin {get;set;}
    /// <summary>
    ///  密码加密类型，支持 sm2 和 rsa
    /// </summary>
    [JsonProperty("passwordEncryptType")]
    public passwordEncryptType  PasswordEncryptType {get;set;}
    /// <summary>
    ///  是否自动生成密码
    /// </summary>
    [JsonProperty("autoGeneratePassword")]
    public bool  AutoGeneratePassword {get;set;}
    /// <summary>
    ///  重置密码发送邮件和手机号选项
    /// </summary>
    [JsonProperty("sendPasswordResetedNotification")]
    public SendResetPasswordNotificationDto  SendPasswordResetedNotification {get;set;}
}
public partial class UpdateUserBatchOptionsDto
 {
    /// <summary>
    ///  密码加密类型，支持 sm2 和 rsa
    /// </summary>
    public enum passwordEncryptType
     {
         [EnumMember(Value="sm2")]
        SM2,
         [EnumMember(Value="rsa")]
        RSA,
         [EnumMember(Value="none")]
        NONE,
    }
}
}