using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Authing.CSharp.SDK.Models.Management;

   namespace Authing.CSharp.SDK.Models.Management
{
/// <summary>
/// ApplicationDto 的模型
/// </summary>
public partial class ApplicationDto
{
    /// <summary>
    ///  应用 ID
    /// </summary>
[JsonProperty("appId")]
public    string   AppId    {get;set;}
    /// <summary>
    ///  应用唯一标志
    /// </summary>
[JsonProperty("appIdentifier")]
public    string   AppIdentifier    {get;set;}
    /// <summary>
    ///  应用名称
    /// </summary>
[JsonProperty("appName")]
public    string   AppName    {get;set;}
    /// <summary>
    ///  应用 Logo 链接
    /// </summary>
[JsonProperty("appLogo")]
public    string   AppLogo    {get;set;}
    /// <summary>
    ///  应用描述信息
    /// </summary>
[JsonProperty("appDescription")]
public    string   AppDescription    {get;set;}
    /// <summary>
    ///  应用类型
    /// </summary>
[JsonProperty("appType")]
public    appType   AppType    {get;set;}
    /// <summary>
    ///  用户池 ID
    /// </summary>
[JsonProperty("userPoolId")]
public    string   UserPoolId    {get;set;}
    /// <summary>
    ///  是否为集成应用
    /// </summary>
[JsonProperty("isIntegrateApp")]
public    bool   IsIntegrateApp    {get;set;}
    /// <summary>
    ///  默认应用协议类型
    /// </summary>
[JsonProperty("defaultProtocol")]
public    defaultProtocol   DefaultProtocol    {get;set;}
    /// <summary>
    ///  应用登录回调地址
    /// </summary>
[JsonProperty("redirectUris")]
public    List<string>   RedirectUris    {get;set;}
    /// <summary>
    ///  应用退出登录回调地址
    /// </summary>
[JsonProperty("logoutRedirectUris")]
public    List<string>   LogoutRedirectUris    {get;set;}
    /// <summary>
    ///  发起登录地址：在 Authing 应用详情点击「体验登录」或在应用面板点击该应用图标时，会跳转到此 URL，默认为 Authing 登录页。
    /// </summary>
[JsonProperty("initLoginUri")]
public    string   InitLoginUri    {get;set;}
    /// <summary>
    ///  是否开启 SSO 单点登录
    /// </summary>
[JsonProperty("ssoEnabled")]
public    bool   SsoEnabled    {get;set;}
    /// <summary>
    ///  开启 SSO 单点登录的时间
    /// </summary>
[JsonProperty("ssoEnabledAt")]
public    string   SsoEnabledAt    {get;set;}
    /// <summary>
    ///  登录配置
    /// </summary>
[JsonProperty("loginConfig")]
public    ApplicationLoginConfigDto   LoginConfig    {get;set;}
    /// <summary>
    ///  注册配置
    /// </summary>
[JsonProperty("registerConfig")]
public    ApplicationRegisterConfig   RegisterConfig    {get;set;}
    /// <summary>
    ///  品牌化配置
    /// </summary>
[JsonProperty("brandingConfig")]
public    ApplicationBrandingConfig   BrandingConfig    {get;set;}
    /// <summary>
    ///  OIDC 协议配置
    /// </summary>
[JsonProperty("oidcConfig")]
public    OIDCConfig   OidcConfig    {get;set;}
    /// <summary>
    ///  是否开启 SAML 身份提供商
    /// </summary>
[JsonProperty("samlProviderEnabled")]
public    bool   SamlProviderEnabled    {get;set;}
    /// <summary>
    ///  SAML 协议配置
    /// </summary>
[JsonProperty("samlConfig")]
public    SamlIdpConfig   SamlConfig    {get;set;}
    /// <summary>
    ///  是否开启 OAuth 身份提供商
    /// </summary>
[JsonProperty("oauthProviderEnabled")]
public    bool   OauthProviderEnabled    {get;set;}
    /// <summary>
    ///  OAuth2.0 协议配置
    /// </summary>
[JsonProperty("oauthConfig")]
public    OauthIdpConfig   OauthConfig    {get;set;}
    /// <summary>
    ///  是否开启 CAS 身份提供商
    /// </summary>
[JsonProperty("casProviderEnabled")]
public    bool   CasProviderEnabled    {get;set;}
    /// <summary>
    ///  CAS 协议配置
    /// </summary>
[JsonProperty("casConfig")]
public    CasIdPConfig   CasConfig    {get;set;}
    /// <summary>
    ///  是否自定义本应用的登录框，默认走全局的登录框配置。
    /// </summary>
[JsonProperty("customBrandingEnabled")]
public    bool   CustomBrandingEnabled    {get;set;}
    /// <summary>
    ///  是否自定义本应用的安全规则，默认走全局的安全配置。
    /// </summary>
[JsonProperty("customSecurityEnabled")]
public    bool   CustomSecurityEnabled    {get;set;}
    /// <summary>
    ///  集成应用的模版类型
    /// </summary>
[JsonProperty("template")]
public    string   Template    {get;set;}
}
public partial class ApplicationDto
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