using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Authing.CSharp.SDK.Models.Authentication
{
    /// <summary>
    /// 发起绑定 MFA 认证要素请求参数类的返回结果类
    /// </summary>
    public class SendEnrollFactorRequestRespDto
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
        ///  响应数据
        /// </summary>
        [JsonProperty("data")]
        public SendEnrollFactorRequest Data { get; set; }
    }

    public class SendEnrollFactorRequest
    {
        /// <summary>
        /// 临时凭证 enrollmentToken，有效时间为一分钟。在进行「绑定 MFA 认证要素」时，需要带上此参数
        /// </summary>
        [JsonProperty("enrollmentToken")]
        public string EnrollmentToken { get; set; }

        /// <summary>
        /// 发起绑定 OTP 类型认证要素时，接口会返回此数据
        /// </summary>
        [JsonProperty("otpData")]
        public object OtpData { get; set; }
    }
}
