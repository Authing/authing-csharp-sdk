using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Authing.CSharp.SDK.Models.Authentication
{
    /// <summary>
    /// 获取可绑定的 MFA 认证要素返回结果类
    /// </summary>
    public class ListFactorsToEnrollRespDto
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
        ///  获取可绑定的 MFA 认证要素返回结果类
        /// </summary>
        [JsonProperty("data")]
        public IEnumerable<FactorToEnrollDto> Data { get; set; }
    }

    /// <summary>
    /// 获取可绑定的 MFA 认证要素返回结果类
    /// </summary>
    public class FactorToEnrollDto
    {
        /// <summary>
        /// MFA Factor 类型
        /// </summary>
        [JsonProperty("factorType")]
        public FactorType FactorType { get; set; }
    }
}
