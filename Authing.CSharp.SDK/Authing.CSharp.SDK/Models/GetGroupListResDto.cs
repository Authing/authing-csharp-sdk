using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Authing.CSharp.SDK.Models
{
    public class GetGroupListResDto
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
        public List<GetGroupListRes> data { get; set; }
    }

    public class GetGroupListRes
    {
        /// <summary>
        /// 分组 Code
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 分组名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 分组描述
        /// </summary>
        public string Description { get; set; }
    }

}
