using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Authing.CSharp.SDK.Models
{
    public class OidcDiscoveryMetadata
    {
        /// <summary>
        /// OIDC Issuer
        /// </summary>
        public string Issuer { get; set; }
        /// <summary>
        /// OIDC 发起认证端点
        /// </summary>
        public string Authorization_endpoint { get; set; }
        /// <summary>
        /// OIDC 获取 Token 端点
        /// </summary>
        public string Token_endpoint { get; set; }
        /// <summary>
        /// OIDC 获取用户信息端点
        /// </summary>
        public string Userinfo_endpoint { get; set; }
        /// <summary>
        /// OIDC JWKS 端点
        /// </summary>
        public string Jwks_uri { get; set; }
        /// <summary>
        /// 此 OIDC IDP 支持的所有 Scope 列表
        /// </summary>
        public string Scopes_supported { get; set; }
        /// <summary>
        /// 此 OIDC IDP 支持的所有返回类型
        /// </summary>
        public List<ResponseTypesSupported> Response_types_supported { get; set; }
        /// <summary>
        /// 此 OIDC IDP 支持的所有 Response Mode
        /// </summary>
        public List<string> Response_modes_supported { get; set; }
        /// <summary>
        /// 此 OIDC IDP 支持的所有 Grant Types
        /// </summary>
        public List<string> Grant_types_supported { get; set; }
        /// <summary>
        /// 此 OIDC IDP 支持的所有 ID Token 签名方式
        /// </summary>
        public List<string> Id_token_signing_alg_values_supported { get; set; }
        /// <summary>
        /// 此 OIDC IDP 支持的所有 ID Token 加密方式
        /// </summary>
        public List<string> Id_token_encryption_alg_values_supported { get; set; }
        public List<string> Id_token_encryption_enc_values_supported { get; set; }
        /// <summary>
        /// 此 OIDC IDP 支持的所有用户信息签名方式
        /// </summary>
        public List<string> Userinfo_signing_alg_values_supported { get; set; }
        /// <summary>
        /// 此 OIDC IDP 支持的所有用户信息加密方式
        /// </summary>
        public List<string> Userinfo_encryption_alg_values_supported { get; set; }
        public List<string> Userinfo_encryption_enc_values_supported { get; set; }
        /// <summary>
        /// 此 OIDC IDP 支持的所有获取 Token 的认证方式
        /// </summary>
        public List<string> Token_endpoint_auth_methods_supported { get; set; }
        /// <summary>
        /// 此 OIDC IDP 支持的所有 Claim Type
        /// </summary>
        public List<string> Claim_types_supported { get; set; }
        /// <summary>
        /// 此 OIDC IDP 支持的所有 Claim
        /// </summary>
        public List<string> Claims_supported { get; set; }
        /// <summary>
        /// 此 OIDC IDP 支持的所有 Code Challenge 模式
        /// </summary>
        public List<string> Code_challenge_methods_supported { get; set; }
        /// <summary>
        /// 此 OIDC IDP 的前端登出端点
        /// </summary>
        public string End_session_endpoint { get; set; }
        /// <summary>
        /// 此 OIDC IDP 的检查 Token 状态端点
        /// </summary>
        public string Introspection_endpoint { get; set; }
        /// <summary>
        /// 此 OIDC IDP 检查 Token 状态端点支持的所有验证方式
        /// </summary>
        public List<string> Introspection_endpoint_auth_methods_supported { get; set; }
        /// <summary>
        /// 此 OIDC IDP 的撤销 Token 端点
        /// </summary>
        public string Revocation_endpoint { get; set; }
        /// <summary>
        /// 此 OIDC IDP 撤销 Token 端点支持的所有验证方式
        /// </summary>
        public List<string> Revocation_endpoint_auth_methods_supported { get; set; }

    }

    public enum ResponseTypesSupported
    {
        [EnumMember(Value ="none")]
        none,
        [EnumMember(Value ="code")]
        code, 
        [EnumMember(Value = "token")]
        token,
        [EnumMember(Value = "id_token token")]
        id_tokentoken,        
        [EnumMember(Value ="id_token")]
        id_token, 
        [EnumMember(Value = " code token")]
        codetoken,
        [EnumMember(Value = "code id_token token")]
        codeid_tokentoken,
        [EnumMember(Value = "code id_token")]
        codeid_token
    }
}
