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
/// VerifyDeleteAccountRequestDataDto 的模型
/// </summary>
public partial class VerifyDeleteAccountRequestDataDto
{
    /// <summary>
    ///  用于注销账号的临时 Token，你需要调用**注销账号**接口执行实际注销账号操作。
    /// </summary>
    [JsonProperty("deleteAccountToken")]
    public string  DeleteAccountToken {get;set;}
    /// <summary>
    ///  Token 有效时间，默认为 60 秒。
    /// </summary>
    [JsonProperty("tokenExpiresIn")]
    public long  TokenExpiresIn {get;set;}
}
}