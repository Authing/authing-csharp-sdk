using Authing.CSharp.SDK.Models.Authentication;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Authing.CSharp.SDK.Models
{
    public class LoginByCredentialsDto
    {
        [JsonProperty("connection")]
        public Connection Connection { get; set; }

        /// <summary>
        /// 当认证方式为 PASSWORD 时此参数必填
        /// </summary>
       [JsonProperty("passwordPayload")]
        public PasswordPayLoad PasswordPayLoad { get; set; }

        /// <summary>
        /// 当认证方式为 PASSCODE 时此参数必填
        /// </summary>
        [JsonProperty("passCodePayload")]
        public PassCodePayLoad PassCodePayLoad { get; set; }

        /// <summary>
        /// 当认证方式为 AD 时此参数必填
        /// </summary>
        [JsonProperty("adPayload")]
        public ADPayLoad ADPayLoad { get; set; }

        /// <summary>
        /// 当认证方式为 LDAP 时此参数必填
        /// </summary>
        [JsonProperty("ldapPayload")]
        public LDAPPayLoad LDAPPayLoad { get; set; }

        /// <summary>
        /// 可选参数
        /// </summary>
        [JsonProperty("options")]
        public Options Options { get; set; }
    }

    public class PasswordPayLoad
    {
        /// <summary>
        /// 用户密码，默认不加密。Authing 所有 API 均通过 HTTPS 协议对密码进行安全传输，可以在一定程度上保证安全性。 如果你还需要更高级别的安全性，我们还支持 RSA256 和国密 SM2 的密码加密方式。详情见可选参数 options.passwordEncryptType
        /// </summary>
        [JsonProperty("password")]
        public string Password { get; set; }

        /// <summary>
        /// 用户账号（用户名/手机号/邮箱）
        /// </summary>
        [JsonProperty("account")]
        public string Account { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// 用户名字
        /// </summary>
        [JsonProperty("username")]
        public string UserName { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }
    }

    public class PassCodePayLoad
    {
        /// <summary>
        /// 一次性临时验证码，你需要先调用发送短信或者发送邮件接口获取验证码
        /// </summary>
        [JsonProperty("passCode")]
        public string PassCode { get; set; }

        /// <summary>
        /// 邮箱，不区分大小写
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 手机区号，中国大陆手机号可不填。Authing 短信服务暂不内置支持国际手机号，你需要在 Authing 控制台配置对应的国际短信服务。完整的手机区号列表可参阅 https://en.wikipedia.org/wiki/List_of_country_calling_codes
        /// </summary>
        [JsonProperty("phoneCountryCode")]
        public string PhoneCountryCode { get; set; }
    }

    public class ADPayLoad
    {
        /// <summary>
        /// 一次性临时验证码，你需要先调用发送短信或者发送邮件接口获取验证码
        /// </summary>
        [JsonProperty("passCode")]
        public string PassCode { get; set; }

        /// <summary>
        /// 邮箱，不区分大小写
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 手机区号，中国大陆手机号可不填。Authing 短信服务暂不内置支持国际手机号，你需要在 Authing 控制台配置对应的国际短信服务。完整的手机区号列表可参阅 https://en.wikipedia.org/wiki/List_of_country_calling_codes
        /// </summary>
        [JsonProperty("phoneCountryCode")]
        public string PhoneCountryCode { get; set; }
    }

    public class LDAPPayLoad
    {
        /// <summary>
        /// 用户密码，默认不加密。Authing 所有 API 均通过 HTTPS 协议对密码进行安全传输，可以在一定程度上保证安全性。 如果你还需要更高级别的安全性，我们还支持 RSA256 和国密 SM2 的密码加密方式。详情见可选参数 options.passwordEncryptType
        /// </summary>
        [JsonProperty("password")]
        public string Password { get; set; }

        /// <summary>
        /// LDAP AD 用户目录中账号的 sAMAccountName
        /// </summary>
        [JsonProperty("sAMAccountName")]
        public string sAMAccountName { get; set; }
    }

    public class Profile
    {
        public string NickName { get; set; }
        public string Company { get; set; }
        public string Photo { get; set; }
        public string Device { get; set; }
        public string Browser { get; set; }
        public string Name { get; set; }
        public string GivenName { get; set; }
        public string FamilyName { get; set; }
        public string MidleName { get; set; }
        public string MiddleName { get; set; }
        public string PreferredUsername { get; set; }
        public string Website { get; set; }
        public Gender Gender { get; set; }
        public string Birthdate { get; set; }
        public string Zoneinfo { get; set; }
        public string Locale { get; set; }
        public string Address { get; set; }
    }

    public class Options
    {
        /// <summary>
        /// 获取的资源类型，以空格分割
        /// </summary>
        [JsonProperty("scopes")]
        public string Scopes { get; set; }

        /// <summary>
        /// 客户端真实 IP 地址。默认情况下，Authing 会将请求来源的 IP 识别为用户登录的 IP 地址，如果你在后端服务器中调用此接口，需要将此 IP 设置为用户的真实请求 IP
        /// </summary>
        [JsonProperty("clientIp")]
        public string ClientId { get; set; }

        /// <summary>
        /// 额外请求上下文，将会传递到认证前和认证后的 Pipeline 的 context 对象中。了解如何在 Pipeline 的 context 参数中获取传入的额外 context https://docs.authing.cn/v2/guides/pipeline/context-object.html
        /// </summary>
        [JsonProperty("context")]
        public string Context { get; set; }

        /// <summary>
        /// 租户 
        /// </summary>
        [JsonProperty("tenantId")]
        public string TenanId { get; set; }

        [JsonProperty("customData")]
        public object CustomData { get; set; }

        /// <summary>
        /// 是否开启自动注册。如果设置为 true，当用户不存在的时候，会先自动为其创建一个账号
        /// </summary>
        [JsonProperty("autoRegister")]
        public bool AutoRegister { get; set; }

        /// <summary>
        /// Captcha 图形验证码，不区分大小写。当安全策略设置为验证码且触发登录失败次数限制时，下次登录需要填写图形验证码
        /// </summary>
        [JsonProperty("")]
        public bool CaptchaCode { get; set; }

        /// <summary>
        /// 密码加密类型，支持 sm2 和 rsa。默认可以不加密
        /// </summary>
        [JsonProperty("passwordEncryptType")]
        public PasswordEncryptType PasswordEncryptType { get; set; }
    }

    public enum PasswordEncryptType
    {
        /// <summary>
        /// 不对密码进行加密，使用明文进行传输
        /// </summary>
        None,
        /// <summary>
        /// 使用 RSA256 算法对密码进行加密，需要使用 Authing 服务的 RSA 公钥进行加密
        /// </summary>
        RSA,
        /// <summary>
        /// 使用 国密 SM2 算法 对密码进行加密，需要使用 Authing 服务的 SM2 公钥进行加密
        /// </summary>
        SM2,
    }
}
