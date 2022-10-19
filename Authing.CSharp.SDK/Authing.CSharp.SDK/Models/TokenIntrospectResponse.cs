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
/// TokenIntrospectResponse 的模型
/// </summary>
public partial class TokenIntrospectResponse
{
    /// <summary>
    ///  Token 是否有效
    /// </summary>
    [JsonProperty("active")]
    public bool  Active {get;set;}
    /// <summary>
    ///  此 Token 对应的用户 ID，当 token 合法时返回。
    /// </summary>
    [JsonProperty("sub")]
    public string  Sub {get;set;}
    /// <summary>
    ///  签发此 Token 的应用 ID，当 token 合法时返回。
    /// </summary>
    [JsonProperty("client_id")]
    public string  Client_id {get;set;}
    /// <summary>
    ///  Token 的到期时间，为单位为秒的时间戳。当 token 合法时返回。
    /// </summary>
    [JsonProperty("exp")]
    public long  Exp {get;set;}
    /// <summary>
    ///  Token 的签发时间，为单位为秒的时间戳。当 token 合法时返回。
    /// </summary>
    [JsonProperty("iat")]
    public long  Iat {get;set;}
    /// <summary>
    ///  Issuer，当 token 合法时返回。
    /// </summary>
    [JsonProperty("iss")]
    public string  Iss {get;set;}
    /// <summary>
    ///  JTI，当 token 合法时返回。
    /// </summary>
    [JsonProperty("jti")]
    public string  Jti {get;set;}
    /// <summary>
    ///  使用逗号分割的 scope 数组，当 token 合法时返回。
    /// </summary>
    [JsonProperty("scope")]
    public string  Scope {get;set;}
    /// <summary>
    ///  Token Type，默认为 Bearer，当 token 合法时返回。
    /// </summary>
    [JsonProperty("token_type")]
    public string  Token_type {get;set;}
}
}