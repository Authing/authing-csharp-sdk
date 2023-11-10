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
    /// GetMfaInfoDataDto 的模型
    /// </summary>
    public partial class GetMfaInfoDataDto
    {
        /// <summary>
        ///  MFA Token
        /// </summary>
        [JsonProperty("mfaToken")]
        public string  MfaToken {get;set;}
        /// <summary>
        ///  MFA 绑定的手机号
        /// </summary>
        [JsonProperty("mfaPhone")]
        public string  MfaPhone {get;set;}
        /// <summary>
        ///  MFA 绑定的手机区号
        /// </summary>
        [JsonProperty("mfaPhoneCountryCode")]
        public string  MfaPhoneCountryCode {get;set;}
        /// <summary>
        ///  MFA 绑定的邮箱
        /// </summary>
        [JsonProperty("mfaEmail")]
        public string  MfaEmail {get;set;}
        /// <summary>
        ///  用户昵称
        /// </summary>
        [JsonProperty("nickname")]
        public string  Nickname {get;set;}
        /// <summary>
        ///  用户名
        /// </summary>
        [JsonProperty("username")]
        public string  Username {get;set;}
        /// <summary>
        ///  用户手机号
        /// </summary>
        [JsonProperty("phone")]
        public string  Phone {get;set;}
        /// <summary>
        ///  用户手机区号
        /// </summary>
        [JsonProperty("phoneCountryCode")]
        public string  PhoneCountryCode {get;set;}
        /// <summary>
        ///  人脸校验是否开启
        /// </summary>
        [JsonProperty("faceMfaEnabled")]
        public bool  FaceMfaEnabled {get;set;}
        /// <summary>
        ///  OTP 校验是否开启
        /// </summary>
        [JsonProperty("totpMfaEnabled")]
        public bool  TotpMfaEnabled {get;set;}
        /// <summary>
        ///  MFA Factor 列表
        /// </summary>
        [JsonProperty("applicationMfa")]
        public List<ApplicationMfaDto>  ApplicationMfa {get;set;}
    }
}