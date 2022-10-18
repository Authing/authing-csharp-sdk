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
    /// SigninByCredentialsDto 的模型
    /// </summary>
    public partial class SigninByCredentialsDto
    {
        /// <summary>
        ///  认证方式：
        /// - `PASSWORD`: 使用密码方式进行认证。
        /// - `PASSCODE`: 使用一次性临时验证码进行认证。
        /// - `LDAP`: 基于 LDAP 用户目录进行认证。
        /// - `AD`: 基于 Windows AD 用户目录进行认证。
        ///
        /// </summary>
        [JsonProperty("connection")]
        public connection Connection { get; set; }
        /// <summary>
        ///  当认证方式为 `PASSWORD` 时此参数必填。
        /// </summary>
        [JsonProperty("passwordPayload")]
        public AuthenticateByPasswordDto PasswordPayload { get; set; }
        /// <summary>
        ///  当认证方式为 `PASSCODE` 时此参数必填
        /// </summary>
        [JsonProperty("passCodePayload")]
        public AuthenticateByPassCodeDto PassCodePayload { get; set; }
        /// <summary>
        ///  当认证方式为 `AD` 时此参数必填
        /// </summary>
        [JsonProperty("adPayload")]
        public AuthenticateByADDto AdPayload { get; set; }
        /// <summary>
        ///  当认证方式为 `LDAP` 时此参数必填
        /// </summary>
        [JsonProperty("ldapPayload")]
        public AuthenticateByLDAPDto LdapPayload { get; set; }
        /// <summary>
        ///  可选参数
        /// </summary>
        [JsonProperty("options")]
        public SignInOptionsDto Options { get; set; }
        /// <summary>
        ///  应用 ID。当应用的「换取 token 身份验证方式」配置为 `client_secret_post` 需要传。
        /// </summary>
        [JsonProperty("client_id")]
        public string Client_id { get; set; }
        /// <summary>
        ///  应用密钥。当应用的「换取 token 身份验证方式」配置为 `client_secret_post` 需要传。
        /// </summary>
        [JsonProperty("client_secret")]
        public string Client_secret { get; set; }
    }
    public partial class SigninByCredentialsDto
    {
        /// <summary>
        ///  认证方式：
        /// - `PASSWORD`: 使用密码方式进行认证。
        /// - `PASSCODE`: 使用一次性临时验证码进行认证。
        /// - `LDAP`: 基于 LDAP 用户目录进行认证。
        /// - `AD`: 基于 Windows AD 用户目录进行认证。
        ///
        /// </summary>
        public enum connection
        {
            [EnumMember(Value = "PASSWORD")]
            PASSWORD,
            [EnumMember(Value = "PASSCODE")]
            PASSCODE,
            [EnumMember(Value = "LDAP")]
            LDAP,
            [EnumMember(Value = "AD")]
            AD,
        }
    }
}