using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Authing.CSharp.SDK.Models.Authentication
{
    public class GetRoleListResDto
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
        public List<GetRoleListRes> Data { get; set; }
    }

    public class GetRoleListRes
    {
        /// <summary>
        /// 权限分组内角色的唯一标识符
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 角色描述
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 所属权限分组的 code
        /// </summary>
        [JsonProperty("namespace")]
        public string Namespace { get; set; }
    }

}
