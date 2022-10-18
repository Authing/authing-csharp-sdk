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
    /// VerifyUpdatePhoneRequestDto 的模型
    /// </summary>
    public partial class VerifyUpdatePhoneRequestDto
    {
        /// <summary>
        ///  使用手机号验证码方式验证的数据
        /// </summary>
        [JsonProperty("phonePassCodePayload")]
        public UpdatePhoneByPhonePassCodeDto PhonePassCodePayload { get; set; }
        /// <summary>
        ///  修改手机号的验证方式：
        /// - `PHONE_PASSCODE`: 使用短信验证码的方式进行验证，当前仅支持这一种方式。
        ///
        /// </summary>
        [JsonProperty("verifyMethod")]
        public verifyMethod VerifyMethod { get; set; }
    }
    public partial class VerifyUpdatePhoneRequestDto
    {
        /// <summary>
        ///  修改手机号的验证方式：
        /// - `PHONE_PASSCODE`: 使用短信验证码的方式进行验证，当前仅支持这一种方式。
        ///
        /// </summary>
        public enum verifyMethod
        {
            [EnumMember(Value = "PHONE_PASSCODE")]
            PHONE_PASSCODE,
        }
    }
}