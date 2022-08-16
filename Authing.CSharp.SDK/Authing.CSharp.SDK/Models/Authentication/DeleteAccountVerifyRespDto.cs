using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Authing.CSharp.SDK.Models
{
    public class DeleteAccountVerifyRespDto
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
        public DeleteAccountVerifyResp Data { get; set; }
    }

    public class DeleteAccountVerifyResp
    {
        /// <summary>
        /// 用于删除账户 token
        /// </summary>
        public string deleteAccountToken { get; set; }
        /// <summary>
        /// 过期时间
        /// </summary>
        public int tokenExpiresIn { get; set; }
    }
}
