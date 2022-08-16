using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Authing.CSharp.SDK.Models.Authentication
{
    /// <summary>
    /// 绑定 MFA 认证要素请求参数类
    /// </summary>
    public class EnrollFactorDto
    {
        /// <summary>
        /// MFA 认证要素类型，目前共支持短信、邮箱验证码、OTP、人脸四种类型的认证要素
        /// </summary>
        [JsonProperty("factorType")]
        public FactorType FactorType { get; set; }

        /// <summary>
        /// 「发起绑定 MFA 认证要素请求」接口返回的 enrollmentToken，此 token 有效时间为一分钟
        /// </summary>
        [JsonProperty("enrollmentToken")]
        public string EnrollmentToken { get; set; }

        /// <summary>
        /// 参数类
        /// </summary>
        [JsonProperty("enrollmentData")]
        public EnrollmentData EnrollmentData { get; set; }
    }

    /// <summary>
    /// 绑定 MFA 认证要素请求参数类
    /// </summary>
    public class EnrollmentData
    {
        /// <summary>
        /// 绑定短信、邮箱验证码、OTP 类型的认证要素时，需要传此参数。值为短信/邮箱/OTP 验证码
        /// </summary>
        [JsonProperty("passCode")]
        public string PassCode { get; set; }
    }

    /// <summary>
    /// 绑定 MFA 认证要素请求枚举
    /// </summary>
    public enum FactorType
    {
        OTP, 
        SMS,
        EMAIL, 
        FACE 
    }
}
