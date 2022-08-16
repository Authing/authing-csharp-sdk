﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Authing.CSharp.SDK.Models.Authentication
{
    /// <summary>
    /// 获取绑定的所有 MFA 认证要素返回结果类
    /// </summary>
    public class ListEnrolledFactorsRespDto
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
        ///  MFA Factor 列表
        /// </summary>
        [JsonProperty("data")]
        public IEnumerable<FactorDto> Data { get; set; }
    }

    public class FactorDto
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
        public object Profile { get; set; }
    }
}