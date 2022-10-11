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
    /// VerifyDeleteAccountRequestDto 的模型
    /// </summary>
    public partial class VerifyDeleteAccountRequestDto
    {
        /// <summary>
        ///  注销账号的验证手段：
        /// - `PHONE_PASSCODE`: 使用手机号验证码方式进行验证。
        /// - `EMAIL_PASSCODE`: 使用邮箱验证码方式进行验证。
        /// - `PASSWORD`: 如果用户既没有绑定手机号又没有绑定邮箱，可以使用密码作为验证手段。
        ///
        /// </summary>
        [JsonProperty("verifyMethod")]
        public    verifyMethod   VerifyMethod    {get;set;}
        /// <summary>
        ///  使用手机号验证码验证的数据
        /// </summary>
        [JsonProperty("phonePassCodePayload")]
        public    DeleteAccountByPhonePassCodeDto   PhonePassCodePayload    {get;set;}
        /// <summary>
        ///  使用邮箱验证码验证的数据
        /// </summary>
        [JsonProperty("emailPassCodePayload")]
        public    DeleteAccountByEmailPassCodeDto   EmailPassCodePayload    {get;set;}
        /// <summary>
        ///  使用密码验证的数据
        /// </summary>
        [JsonProperty("passwordPayload")]
        public    DeleteAccountByPasswordDto   PasswordPayload    {get;set;}
    }
    public partial class VerifyDeleteAccountRequestDto
    {
        /// <summary>
        ///  注销账号的验证手段：
        /// - `PHONE_PASSCODE`: 使用手机号验证码方式进行验证。
        /// - `EMAIL_PASSCODE`: 使用邮箱验证码方式进行验证。
        /// - `PASSWORD`: 如果用户既没有绑定手机号又没有绑定邮箱，可以使用密码作为验证手段。
        ///
        /// </summary>
        public enum verifyMethod
        {
            [EnumMember(Value="PHONE_PASSCODE")]
            PHONE_PASSCODE,
            [EnumMember(Value="EMAIL_PASSCODE")]
            EMAIL_PASSCODE,
            [EnumMember(Value="PASSWORD")]
            PASSWORD,
        }
    }
}