using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Authing.CSharp.SDK.Models
{
    public class GetSecurityInfoRespDto
    {
        /// <summary>
        /// 业务状态码，可以通过此状态码判断操作是否成功，200 表示成功
        /// </summary>
        [JsonProperty("statusCode")]
        public long StatusCode { get; set; }

        /// <summary>
        /// 描述信息
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        /// 细分错误码，可通过此错误码得到具体的错误类型
        /// </summary>
        [JsonProperty("apicode")]
        public long ApiCode { get; set; }

        [JsonProperty("data")]
        public GetSecurityInfoDto Data { get; set; }
    }

    public class GetSecurityInfoDto
    {
        /// <summary>
        /// 密码强度等级
        /// </summary>
        public int PasswordSecurityLevel { get; set; }
        /// <summary>
        /// 是否绑定了 MFA
        /// </summary>
        public bool MfaEnrolled { get; set; }
        /// <summary>
        /// 是否设置了密码
        /// </summary>
        public bool PasswordSet { get; set; }
        /// <summary>
        /// 是否绑定了邮箱
        /// </summary>
        public bool EmailBinded { get; set; }
        /// <summary>
        /// 是否绑定了手机号
        /// </summary>
        public bool PhoneBinded { get; set; }
        /// <summary>
        /// 账号等级评分
        /// </summary>
        public int SecurityScore { get; set; }
    }
}
