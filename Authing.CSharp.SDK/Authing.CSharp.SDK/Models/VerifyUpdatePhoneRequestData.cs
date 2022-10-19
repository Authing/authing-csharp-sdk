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
/// VerifyUpdatePhoneRequestData 的模型
/// </summary>
public partial class VerifyUpdatePhoneRequestData
{
    /// <summary>
    ///  用于修改当前手机号 token，你需要使用此 token 请求**修改手机号**的接口。
    /// </summary>
    [JsonProperty("updatePhoneToken")]
    public string  UpdatePhoneToken {get;set;}
    /// <summary>
    ///  过期时间
    /// </summary>
    [JsonProperty("tokenExpiresIn")]
    public long  TokenExpiresIn {get;set;}
}
}