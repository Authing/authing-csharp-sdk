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
/// TokenRevocationEndpointParams 的模型
/// </summary>
public partial class TokenRevocationEndpointParams
{
    /// <summary>
    ///  Authing 应用 ID。当在控制台配置撤回 token 身份验证方式为 client_secret_post 和 none 时必填。
    /// </summary>
    [JsonProperty("client_id")]
    public string  Client_id {get;set;}
    /// <summary>
    ///  Authing 应用密钥。在控制台配置撤回 token 身份验证方式为 client_secret_post 时必填。
    /// </summary>
    [JsonProperty("client_secret")]
    public string  Client_secret {get;set;}
    /// <summary>
    ///  `access_token` 或者 `refresh_token` 的值
    /// </summary>
    [JsonProperty("token")]
    public string  Token {get;set;}
}
}