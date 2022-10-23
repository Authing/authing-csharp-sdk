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
/// PreCheckEmailCodeDto 的模型
/// </summary>
public partial class PreCheckEmailCodeDto
{
    /// <summary>
    ///  邮箱，不区分大小写
    /// </summary>
    [JsonProperty("email")]
    public string  Email {get;set;}
    /// <summary>
    ///  邮箱验证码
    /// </summary>
    [JsonProperty("passCode")]
    public string  PassCode {get;set;}
    /// <summary>
    ///  短信通道，指定发送此短信的目的，如 CHANNEL_LOGIN 用于登录、CHANNEL_REGISTER 用于注册。
    /// </summary>
    [JsonProperty("channel")]
    public channel  Channel {get;set;}
}
public partial class PreCheckEmailCodeDto
 {
    /// <summary>
    ///  短信通道，指定发送此短信的目的，如 CHANNEL_LOGIN 用于登录、CHANNEL_REGISTER 用于注册。
    /// </summary>
    public enum channel
     {
         [EnumMember(Value="CHANNEL_LOGIN")]
        CHANNEL_LOGIN,
         [EnumMember(Value="CHANNEL_REGISTER")]
        CHANNEL_REGISTER,
         [EnumMember(Value="CHANNEL_RESET_PASSWORD")]
        CHANNEL_RESET_PASSWORD,
         [EnumMember(Value="CHANNEL_VERIFY_EMAIL_LINK")]
        CHANNEL_VERIFY_EMAIL_LINK,
         [EnumMember(Value="CHANNEL_UPDATE_EMAIL")]
        CHANNEL_UPDATE_EMAIL,
         [EnumMember(Value="CHANNEL_BIND_EMAIL")]
        CHANNEL_BIND_EMAIL,
         [EnumMember(Value="CHANNEL_UNBIND_EMAIL")]
        CHANNEL_UNBIND_EMAIL,
         [EnumMember(Value="CHANNEL_VERIFY_MFA")]
        CHANNEL_VERIFY_MFA,
         [EnumMember(Value="CHANNEL_UNLOCK_ACCOUNT")]
        CHANNEL_UNLOCK_ACCOUNT,
         [EnumMember(Value="CHANNEL_COMPLETE_EMAIL")]
        CHANNEL_COMPLETE_EMAIL,
         [EnumMember(Value="CHANNEL_DELETE_ACCOUNT")]
        CHANNEL_DELETE_ACCOUNT,
    }
}
}