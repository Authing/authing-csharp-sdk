using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Authing.CSharp.SDK.Models
{

    public class GetTenantListResDto
    {
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
        [JsonProperty("apiCode")]
        public string ApiCode { get; set; }
        public List<GetTenantListRes> data { get; set; }
    }


    public class GetTenantListRes
    {
        /// <summary>
        /// 租户 ID
        /// </summary>
        public string TenantId { get; set; }
        /// <summary>
        /// 租户名称
        /// </summary>
        public string TenantName { get; set; }
        /// <summary>
        /// 加入租户的事件
        /// </summary>
        public string JoinAt { get; set; }
    }
}
