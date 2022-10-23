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
/// SignUpDto 的模型
/// </summary>
public partial class SignUpDto
{
    /// <summary>
    ///  注册方式：
/// - `PASSWORD`: 邮箱密码方式
/// - `PASSCODE`: 邮箱/手机号验证码方式
/// 
    /// </summary>
    [JsonProperty("connection")]
    public connection  Connection {get;set;}
    /// <summary>
    ///  当注册方式为 `PASSWORD` 时此参数必填。
    /// </summary>
    [JsonProperty("passwordPayload")]
    public SignUpByPasswordDto  PasswordPayload {get;set;}
    /// <summary>
    ///  当认证方式为 `PASSCODE` 时此参数必填
    /// </summary>
    [JsonProperty("passCodePayload")]
    public SignUpByPassCodeDto  PassCodePayload {get;set;}
    /// <summary>
    ///  用户资料
    /// </summary>
    [JsonProperty("profile")]
    public SignUpProfileDto  Profile {get;set;}
    /// <summary>
    ///  可选参数
    /// </summary>
    [JsonProperty("options")]
    public SignUpOptionsDto  Options {get;set;}
}
public partial class SignUpDto
 {
    /// <summary>
    ///  注册方式：
/// - `PASSWORD`: 邮箱密码方式
/// - `PASSCODE`: 邮箱/手机号验证码方式
/// 
    /// </summary>
    public enum connection
     {
         [EnumMember(Value="PASSWORD")]
        PASSWORD,
         [EnumMember(Value="PASSCODE")]
        PASSCODE,
    }
}
}