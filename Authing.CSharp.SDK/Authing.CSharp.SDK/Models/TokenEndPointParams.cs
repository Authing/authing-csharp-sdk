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
/// TokenEndPointParams 的模型
/// </summary>
public partial class TokenEndPointParams
{
    /// <summary>
    ///  Authing 应用 ID，当换取 token 身份验证方式为 `client_secret_post` 或 `none` 时必填。
    /// </summary>
    [JsonProperty("client_id")]
    public string  Client_id {get;set;}
    /// <summary>
    ///  Authing 应用密钥，当换取 token 身份验证方式为 `client_secret_post` 时必填。
    /// </summary>
    [JsonProperty("client_secret")]
    public string  Client_secret {get;set;}
    /// <summary>
    ///  授权模式：
/// - `authorization_code`: 使用一次性授权码 `code` 换取。
/// - `refresh_token`: 使用 Refresh Token 获取。
/// - `client_credentials`: M2M 无用户交互场景使用。
/// - `password`: 密码模式，使用用户的账号密码获取，不推荐使用。
/// - `http://authing.cn/oidc/grant_type/authing_token`: 使用 Authing 历史版本签发的 Token 换取，不推荐使用。
/// 
    /// </summary>
    [JsonProperty("grant_type")]
    public grant_type  Grant_type {get;set;}
    /// <summary>
    ///  发起 OIDC 授权登录时的 redirect_uri 值，必须与发起登录请求时的参数一致
    /// </summary>
    [JsonProperty("redirect_uri")]
    public string  Redirect_uri {get;set;}
    /// <summary>
    ///  获取到的一次性授权码，**一个 code 仅限一次性使用**，用后作废。有效期为 10 分钟。当 `grant_type` 为 `authorization_code` 时必填。
    /// </summary>
    [JsonProperty("code")]
    public string  Code {get;set;}
    /// <summary>
    ///  拼接 OIDC 授权登录连接时生成的随机字符串值，也就是 code_challenge 原始值，不是其摘要值。当使用**授权码 + PKCE 模式**时需要填写此参数。当 `grant_type` 为 `authorization_code` 并且使用 PKCE 模式时必填。
    /// </summary>
    [JsonProperty("code_verifier")]
    public string  Code_verifier {get;set;}
    /// <summary>
    ///  用户的 Refresh Token。当 `grant_type` 为 `refresh_token` 时必填。
    /// </summary>
    [JsonProperty("refresh_token")]
    public string  Refresh_token {get;set;}
}
public partial class TokenEndPointParams
 {
    /// <summary>
    ///  授权模式：
/// - `authorization_code`: 使用一次性授权码 `code` 换取。
/// - `refresh_token`: 使用 Refresh Token 获取。
/// - `client_credentials`: M2M 无用户交互场景使用。
/// - `password`: 密码模式，使用用户的账号密码获取，不推荐使用。
/// - `http://authing.cn/oidc/grant_type/authing_token`: 使用 Authing 历史版本签发的 Token 换取，不推荐使用。
/// 
    /// </summary>
    public enum grant_type
     {
         [EnumMember(Value="authorization_code")]
        AUTHORIZATION_CODE,
         [EnumMember(Value="refresh_token")]
        REFRESH_TOKEN,
         [EnumMember(Value="client_credentials")]
        CLIENT_CREDENTIALS,
         [EnumMember(Value="password")]
        PASSWORD,
         [EnumMember(Value="http://authing.cn/oidc/grant_type/authing_token")]
        HTTP_AUTHING_CN_OIDC_GRANT_TYPE_AUTHING_TOKEN,
    }
}
}