using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Authing.CSharp.SDK.Models.Authentication
{
    /// <summary>
    /// 获取绑定的某个 MFA 认证要素返回结果类
    /// </summary>
    public class GetFactorRespDto
    {
        /// <summary>
        /// 业务状态码，可以通过此状态码判断操作是否成功，200 表示成功
        /// </summary>
        [JsonProperty("statusCode")]
        public string statusCode { get; set; }

        /// <summary>
        /// 描述信息
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        /// 细分错误码，可通过此错误码得到具体的错误类型
        /// </summary>
        [JsonProperty("apiCode")]
        public string ApiCode { get; set; }

        /// <summary>
        ///  MFA Factor 详情
        /// </summary>
        [JsonProperty("data")]
        public IEnumerable<GetFactorDto> Data { get; set; }
    }

    /// <summary>
    /// MFA Factor 详情
    /// </summary>
    public class GetFactorDto
    {
        /// <summary>
        /// MFA 认证要素ID
        /// </summary>
        [JsonProperty("factorId")]
        public string FactorId { get; set; }

        /// <summary>
        /// MFA 认证要素类型
        /// </summary>
        [JsonProperty("factorType")]
        public FactorType FactorType { get; set; }

        /// <summary>
        /// MFA 认证要素信息
        /// </summary>
        [JsonProperty("profile")]
        public FactorProfileDto Profile { get; set; }
    }

    public class FactorProfileDto
    {
        /// <summary>
        /// 绑定的手机号
        /// </summary>
        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// 绑定的手机号国家代码，默认为 +86，中国大陆手机区号。Authing 短信服务暂不内置支持国际手机号
        /// 你需要在 Authing 控制台配置对应的国际短信服务。完整的手机区号列表可参阅 https://en.wikipedia.org/wiki/List_of_country_calling_codes
        /// </summary>
        [JsonProperty("phoneCountryCode")]
        public string PhoneCountryCode { get; set; } = "+86";

        /// <summary>
        /// 绑定的邮箱
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }
    }
}
