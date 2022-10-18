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
    /// EnrollFactorDto 的模型
    /// </summary>
    public partial class EnrollFactorDto
    {
        /// <summary>
        ///  绑定 MFA 认证要素时，对应认证要素要求的验证信息。
        /// </summary>
        [JsonProperty("enrollmentData")]
        public EnrollFactorEnrollmentDataDto EnrollmentData { get; set; }
        /// <summary>
        ///  「发起绑定 MFA 认证要素请求」接口返回的 enrollmentToken，此 token 有效时间为一分钟。
        /// </summary>
        [JsonProperty("enrollmentToken")]
        public string EnrollmentToken { get; set; }
        /// <summary>
        ///  MFA 认证要素类型，目前共支持短信、邮箱验证码、OTP、人脸四种类型的认证要素。
        /// </summary>
        [JsonProperty("factorType")]
        public factorType FactorType { get; set; }
    }
    public partial class EnrollFactorDto
    {
        /// <summary>
        ///  MFA 认证要素类型，目前共支持短信、邮箱验证码、OTP、人脸四种类型的认证要素。
        /// </summary>
        public enum factorType
        {
            [EnumMember(Value = "OTP")]
            OTP,
            [EnumMember(Value = "SMS")]
            SMS,
            [EnumMember(Value = "EMAIL")]
            EMAIL,
            [EnumMember(Value = "FACE")]
            FACE,
        }
    }
}