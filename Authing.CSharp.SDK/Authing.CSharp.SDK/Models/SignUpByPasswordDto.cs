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
/// SignUpByPasswordDto 的模型
/// </summary>
public partial class SignUpByPasswordDto
{
    /// <summary>
    ///  用户密码，默认不加密。Authing 所有 API 均通过 HTTPS 协议对密码进行安全传输，可以在一定程度上保证安全性。
/// 如果你还需要更高级别的安全性，我们还支持 `RSA256` 和国密 `SM2` 的密码加密方式。详情见可选参数 `options.passwordEncryptType`。
/// 
    /// </summary>
    [JsonProperty("password")]
    public string  Password {get;set;}
    /// <summary>
    ///  用户名
    /// </summary>
    [JsonProperty("username")]
    public string  Username {get;set;}
    /// <summary>
    ///  邮箱，不区分大小写。
    /// </summary>
    [JsonProperty("email")]
    public string  Email {get;set;}
}
}