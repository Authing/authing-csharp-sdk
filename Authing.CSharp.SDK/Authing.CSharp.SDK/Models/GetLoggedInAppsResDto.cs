using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Authing.CSharp.SDK.Models
{
    public class GetLoggedInAppsResDto
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
        public List<LoggedInAppsRes> Data { get; set; }
    }

    public class LoggedInAppsRes
    {
        /// <summary>
        /// 应用 ID
        /// </summary>
        public string AppId { get; set; }
        /// <summary>
        /// 应用名称
        /// </summary>
        public string AppName { get; set; }
        /// <summary>
        /// 应用登录地址
        /// </summary>
        public string AppLoginUrl { get; set; }
        /// <summary>
        /// 应用 Logo
        /// </summary>
        public string AppLogo { get; set; }
        /// <summary>
        /// 当前是否处于登录态
        /// </summary>
        public bool Active { get; set; }
    }

}
