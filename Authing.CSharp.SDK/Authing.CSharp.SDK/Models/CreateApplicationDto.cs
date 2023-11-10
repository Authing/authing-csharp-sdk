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
    /// CreateApplicationDto 的模型
    /// </summary>
    public partial class CreateApplicationDto
    {
        /// <summary>
        ///  应用名称
        /// </summary>
        [JsonProperty("appName")]
        public string  AppName {get;set;}
        /// <summary>
        ///  集成应用模版类型，**集成应用必填**。集成应用只需要填 `template` 和 `templateData` 两个字段，其他的字段将被忽略。
        /// </summary>
        [JsonProperty("template")]
        public string  Template {get;set;}
        /// <summary>
        ///  集成应用配置信息，**集成应用必填**。
        /// </summary>
        [JsonProperty("templateData")]
        public string  TemplateData {get;set;}
        /// <summary>
        ///  应用唯一标志，**自建应用必填**。
        /// </summary>
        [JsonProperty("appIdentifier")]
        public string  AppIdentifier {get;set;}
        /// <summary>
        ///  应用 Logo 链接
        /// </summary>
        [JsonProperty("appLogo")]
        public string  AppLogo {get;set;}
        /// <summary>
        ///  应用描述信息
        /// </summary>
        [JsonProperty("appDescription")]
        public string  AppDescription {get;set;}
        /// <summary>
        ///  应用类型
        /// </summary>
        [JsonProperty("appType")]
        public appType  AppType {get;set;}
        /// <summary>
        ///  默认应用协议类型
        /// </summary>
        [JsonProperty("defaultProtocol")]
        public defaultProtocol  DefaultProtocol {get;set;}
        /// <summary>
        ///  应用登录回调地址
        /// </summary>
        [JsonProperty("redirectUris")]
        public List<string>  RedirectUris {get;set;}
        /// <summary>
        ///  应用退出登录回调地址
        /// </summary>
        [JsonProperty("logoutRedirectUris")]
        public List<string>  LogoutRedirectUris {get;set;}
        /// <summary>
        ///  发起登录地址：在 Authing 应用详情点击「体验登录」或在应用面板点击该应用图标时，会跳转到此 URL，默认为 Authing 登录页。
        /// </summary>
        [JsonProperty("initLoginUri")]
        public string  InitLoginUri {get;set;}
        /// <summary>
        ///  是否开启 SSO 单点登录
        /// </summary>
        [JsonProperty("ssoEnabled")]
        public bool  SsoEnabled {get;set;}
        /// <summary>
        ///  OIDC 协议配置
        /// </summary>
        [JsonProperty("oidcConfig")]
        public OIDCConfig  OidcConfig {get;set;}
        /// <summary>
        ///  是否开启 SAML 身份提供商
        /// </summary>
        [JsonProperty("samlProviderEnabled")]
        public bool  SamlProviderEnabled {get;set;}
        /// <summary>
        ///  SAML 协议配置
        /// </summary>
        [JsonProperty("samlConfig")]
        public SamlIdpConfig  SamlConfig {get;set;}
        /// <summary>
        ///  是否开启 OAuth 身份提供商
        /// </summary>
        [JsonProperty("oauthProviderEnabled")]
        public bool  OauthProviderEnabled {get;set;}
        /// <summary>
        ///  OAuth2.0 协议配置。【重要提示】不再推荐使用 OAuth2.0，建议切换到 OIDC。
        /// </summary>
        [JsonProperty("oauthConfig")]
        public OauthIdpConfig  OauthConfig {get;set;}
        /// <summary>
        ///  是否开启 CAS 身份提供商
        /// </summary>
        [JsonProperty("casProviderEnabled")]
        public bool  CasProviderEnabled {get;set;}
        /// <summary>
        ///  CAS 协议配置
        /// </summary>
        [JsonProperty("casConfig")]
        public CasIdPConfig  CasConfig {get;set;}
        /// <summary>
        ///  登录配置
        /// </summary>
        [JsonProperty("loginConfig")]
        public ApplicationLoginConfigInputDto  LoginConfig {get;set;}
        /// <summary>
        ///  注册配置
        /// </summary>
        [JsonProperty("registerConfig")]
        public ApplicationRegisterConfigInputDto  RegisterConfig {get;set;}
        /// <summary>
        ///  品牌化配置
        /// </summary>
        [JsonProperty("brandingConfig")]
        public ApplicationBrandingConfigInputDto  BrandingConfig {get;set;}
    }
    public partial class CreateApplicationDto
    {
        /// <summary>
        ///  应用类型
        /// </summary>
        public enum appType
        {
            [EnumMember(Value="web")]
            WEB,
            [EnumMember(Value="spa")]
            SPA,
            [EnumMember(Value="native")]
            NATIVE,
            [EnumMember(Value="api")]
            API,
            [EnumMember(Value="mfa")]
            MFA,
            [EnumMember(Value="mini-program")]
            MINI_PROGRAM,
        }
        /// <summary>
        ///  默认应用协议类型
        /// </summary>
        public enum defaultProtocol
        {
            [EnumMember(Value="oidc")]
            OIDC,
            [EnumMember(Value="oauth")]
            OAUTH,
            [EnumMember(Value="saml")]
            SAML,
            [EnumMember(Value="cas")]
            CAS,
            [EnumMember(Value="asa")]
            ASA,
        }
    }
}