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
/// SecuritySettingsDto 的模型
/// </summary>
public partial class SecuritySettingsDto
{
    /// <summary>
    ///  安全域（CORS）
    /// </summary>
    [JsonProperty("allowedOrigins")]
    public string  AllowedOrigins {get;set;}
    /// <summary>
    ///  Authing Token 有效时间（秒）
    /// </summary>
    [JsonProperty("authingTokenExpiresIn")]
    public long  AuthingTokenExpiresIn {get;set;}
    /// <summary>
    ///  验证码长度。包含短信验证码、邮件验证码和图形验证码。
    /// </summary>
    [JsonProperty("verifyCodeLength")]
    public long  VerifyCodeLength {get;set;}
    /// <summary>
    ///  验证码尝试次数。在一个验证码有效周期内（默认为 60 s），用户输入验证码错误次数超过此阈值之后，将会导致当前验证码失效，需要重新发送。
    /// </summary>
    [JsonProperty("verifyCodeMaxAttempts")]
    public long  VerifyCodeMaxAttempts {get;set;}
    /// <summary>
    ///  用户修改邮箱的安全策略
    /// </summary>
    [JsonProperty("changeEmailStrategy")]
    public ChangeEmailStrategyDto  ChangeEmailStrategy {get;set;}
    /// <summary>
    ///  用户修改手机号的安全策略
    /// </summary>
    [JsonProperty("changePhoneStrategy")]
    public ChangePhoneStrategyDto  ChangePhoneStrategy {get;set;}
    /// <summary>
    ///  Cookie 过期时间设置
    /// </summary>
    [JsonProperty("cookieSettings")]
    public CookieSettingsDto  CookieSettings {get;set;}
    /// <summary>
    ///  是否禁止用户注册，开启之后，用户将无法自主注册，只能管理员为其创建账号。针对 B2B 和 B2E 类型用户池，默认开启。
    /// </summary>
    [JsonProperty("registerDisabled")]
    public bool  RegisterDisabled {get;set;}
    /// <summary>
    ///  频繁注册检测配置
    /// </summary>
    [JsonProperty("registerAnomalyDetection")]
    public RegisterAnomalyDetectionConfigDto  RegisterAnomalyDetection {get;set;}
    /// <summary>
    ///  验证码注册后是否要求用户设置密码（仅针对 Authing 登录页和 Guard 有效，不针对 API 调用）。
    /// </summary>
    [JsonProperty("completePasswordAfterPassCodeLogin")]
    public bool  CompletePasswordAfterPassCodeLogin {get;set;}
    /// <summary>
    ///  登录防暴破配置
    /// </summary>
    [JsonProperty("loginAnomalyDetection")]
    public LoginAnomalyDetectionConfigDto  LoginAnomalyDetection {get;set;}
    /// <summary>
    ///  当使用邮箱登录时，未验证的邮箱登录时是否禁止登录并发送认证邮件。当用户收到邮件并完成验证之后，才能进行登录。
    /// </summary>
    [JsonProperty("loginRequireEmailVerified")]
    public bool  LoginRequireEmailVerified {get;set;}
    /// <summary>
    ///  用户自助解锁配置。注：只有绑定了手机号/邮箱的用户才可以自助解锁
    /// </summary>
    [JsonProperty("selfUnlockAccount")]
    public SelfUnlockAccountConfigDto  SelfUnlockAccount {get;set;}
    /// <summary>
    ///  Authing 登录页面是否开启登录账号选择
    /// </summary>
    [JsonProperty("enableLoginAccountSwitch")]
    public bool  EnableLoginAccountSwitch {get;set;}
    /// <summary>
    ///  APP 扫码登录安全配置
    /// </summary>
    [JsonProperty("qrcodeLoginStrategy")]
    public QrcodeLoginStrategyDto  QrcodeLoginStrategy {get;set;}
}
}