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
    /// VerifyUpdateEmailRequestDto 的模型
    /// </summary>
    public partial class VerifyUpdateEmailRequestDto
    {
        /// <summary>
        ///  使用邮箱验证码方式验证的数据
        /// </summary>
        [JsonProperty("emailPasscodePayload")]
        public    UpdateEmailByEmailPassCodeDto   EmailPasscodePayload    {get;set;}
        /// <summary>
        ///  修改当前邮箱使用的验证手段：
        /// - `EMAIL_PASSCODE`: 通过邮箱验证码进行验证，当前只支持这种验证方式。
        ///
        /// </summary>
        [JsonProperty("verifyMethod")]
        public    verifyMethod   VerifyMethod    {get;set;}
    }
    public partial class VerifyUpdateEmailRequestDto
    {
        /// <summary>
        ///  修改当前邮箱使用的验证手段：
        /// - `EMAIL_PASSCODE`: 通过邮箱验证码进行验证，当前只支持这种验证方式。
        ///
        /// </summary>
        public enum verifyMethod
        {
            [EnumMember(Value="EMAIL_PASSCODE")]
            EMAIL_PASSCODE,
        }
    }
}