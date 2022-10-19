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
/// OidcDiscoveryMetadata 的模型
/// </summary>
public partial class OidcDiscoveryMetadata
{
    /// <summary>
    ///  OIDC Issuer
    /// </summary>
    [JsonProperty("issuer")]
    public string  Issuer {get;set;}
    /// <summary>
    ///  OIDC 发起认证端点
    /// </summary>
    [JsonProperty("authorization_endpoint")]
    public string  Authorization_endpoint {get;set;}
    /// <summary>
    ///  OIDC 获取 Token 端点
    /// </summary>
    [JsonProperty("token_endpoint")]
    public string  Token_endpoint {get;set;}
    /// <summary>
    ///  OIDC 获取用户信息端点
    /// </summary>
    [JsonProperty("userinfo_endpoint")]
    public string  Userinfo_endpoint {get;set;}
    /// <summary>
    ///  OIDC JWKS 端点
    /// </summary>
    [JsonProperty("jwks_uri")]
    public string  Jwks_uri {get;set;}
    /// <summary>
    ///  此 OIDC IDP 支持的所有 Scope 列表
    /// </summary>
    [JsonProperty("scopes_supported")]
    public List<string>  Scopes_supported {get;set;}
    /// <summary>
    ///  此 OIDC IDP 支持的所有返回类型
    /// </summary>
    [JsonProperty("response_types_supported")]
    public List<string>  Response_types_supported {get;set;}
    /// <summary>
    ///  此 OIDC IDP 支持的所有 Response Mode
    /// </summary>
    [JsonProperty("response_modes_supported")]
    public List<string>  Response_modes_supported {get;set;}
    /// <summary>
    ///  此 OIDC IDP 支持的所有 Grant Types
    /// </summary>
    [JsonProperty("grant_types_supported")]
    public List<string>  Grant_types_supported {get;set;}
    /// <summary>
    ///  此 OIDC IDP 支持的所有 ID Token 签名方式
    /// </summary>
    [JsonProperty("id_token_signing_alg_values_supported")]
    public List<string>  Id_token_signing_alg_values_supported {get;set;}
    /// <summary>
    ///  此 OIDC IDP 支持的所有 ID Token 加密方式
    /// </summary>
    [JsonProperty("id_token_encryption_alg_values_supported")]
    public List<string>  Id_token_encryption_alg_values_supported {get;set;}
    [JsonProperty("id_token_encryption_enc_values_supported")]
    public List<string>  Id_token_encryption_enc_values_supported {get;set;}
    /// <summary>
    ///  此 OIDC IDP 支持的所有用户信息签名方式
    /// </summary>
    [JsonProperty("userinfo_signing_alg_values_supported")]
    public List<string>  Userinfo_signing_alg_values_supported {get;set;}
    /// <summary>
    ///  此 OIDC IDP 支持的所有用户信息加密方式
    /// </summary>
    [JsonProperty("userinfo_encryption_alg_values_supported")]
    public List<string>  Userinfo_encryption_alg_values_supported {get;set;}
    [JsonProperty("userinfo_encryption_enc_values_supported")]
    public List<string>  Userinfo_encryption_enc_values_supported {get;set;}
    /// <summary>
    ///  此 OIDC IDP 支持的所有获取 Token 的认证方式
    /// </summary>
    [JsonProperty("token_endpoint_auth_methods_supported")]
    public List<string>  Token_endpoint_auth_methods_supported {get;set;}
    /// <summary>
    ///  此 OIDC IDP 支持的所有 Claim Type
    /// </summary>
    [JsonProperty("claim_types_supported")]
    public List<string>  Claim_types_supported {get;set;}
    /// <summary>
    ///  此 OIDC IDP 支持的所有 Claim
    /// </summary>
    [JsonProperty("claims_supported")]
    public List<string>  Claims_supported {get;set;}
    /// <summary>
    ///  此 OIDC IDP 支持的所有 Code Challenge 模式
    /// </summary>
    [JsonProperty("code_challenge_methods_supported")]
    public List<string>  Code_challenge_methods_supported {get;set;}
    /// <summary>
    ///  此 OIDC IDP 的前端登出端点
    /// </summary>
    [JsonProperty("end_session_endpoint")]
    public string  End_session_endpoint {get;set;}
    /// <summary>
    ///  此 OIDC IDP 的检查 Token 状态端点
    /// </summary>
    [JsonProperty("introspection_endpoint")]
    public string  Introspection_endpoint {get;set;}
    /// <summary>
    ///  此 OIDC IDP 检查 Token 状态端点支持的所有验证方式
    /// </summary>
    [JsonProperty("introspection_endpoint_auth_methods_supported")]
    public List<string>  Introspection_endpoint_auth_methods_supported {get;set;}
    /// <summary>
    ///  此 OIDC IDP 的撤销 Token 端点
    /// </summary>
    [JsonProperty("revocation_endpoint")]
    public string  Revocation_endpoint {get;set;}
    /// <summary>
    ///  此 OIDC IDP 撤销 Token 端点支持的所有验证方式
    /// </summary>
    [JsonProperty("revocation_endpoint_auth_methods_supported")]
    public List<string>  Revocation_endpoint_auth_methods_supported {get;set;}
}
}