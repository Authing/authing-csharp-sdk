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
/// LoginTokenResponseDataDto 的模型
/// </summary>
public partial class LoginTokenResponseDataDto
{
    /// <summary>
    ///  接口调用凭据，在限制时间内被授权访问资源 API
    /// </summary>
    [JsonProperty("access_token")]
    public string  Access_token {get;set;}
    /// <summary>
    ///  用户的身份凭证，解析后会包含用户信息
    /// </summary>
    [JsonProperty("id_token")]
    public string  Id_token {get;set;}
    /// <summary>
    ///  refresh_token 用于获取新的 AccessToken
    /// </summary>
    [JsonProperty("refresh_token")]
    public string  Refresh_token {get;set;}
    /// <summary>
    ///  token 类型
    /// </summary>
    [JsonProperty("token_type")]
    public string  Token_type {get;set;}
    /// <summary>
    ///  过期时间 单位是秒
    /// </summary>
    [JsonProperty("expire_in")]
    public long  Expire_in {get;set;}
}
}