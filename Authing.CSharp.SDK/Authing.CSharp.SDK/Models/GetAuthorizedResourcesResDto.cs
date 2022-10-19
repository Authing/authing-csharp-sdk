using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Authing.CSharp.SDK.Models.Authentication
{
    public class GetAuthorizedResourcesResDto
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
        public AuthorizedResources data { get; set; }
    }

    public class AuthorizedResources
    {
        public int TotalCount { get; set; }
        public List<Resources> List { get; set; }
    }

    public class Resources
    {
        public string ResourceCode { get; set; }
        public string Description { get; set; }
        public List<Condition> ondition { get; set; }
        /// <summary>
        /// 资源类型
        /// </summary>
        public string ResourceType { get; set; }
        /// <summary>
        /// API URL
        /// </summary>
        public string ApiIdentifier { get; set; }
        /// <summary>
        /// 授权的操作列表
        /// </summary>
        public List<string> actions { get; set; }
        /// <summary>
        /// 允许还是拒绝
        /// </summary>
        public string Effect { get; set; }
    }

    /// <summary>
    /// 策略 Condition
    /// </summary>
    public class Condition
    {
        public string Param { get; set; }

        [JsonProperty("operator")]
        public string Operator { get; set; }
        public string Value { get; set; }
    }

}
