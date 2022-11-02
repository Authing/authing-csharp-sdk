using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Authing.CSharp.SDK.Models
{
    /// <summary>
    /// GroupPaginatedRespDto 的模型
    /// </summary>
    public partial class GroupPaginatedRespDto
    {
        /// <summary>
        ///  业务状态码，可以通过此状态码判断操作是否成功，200 表示成功。
        /// </summary>
        [JsonProperty("statusCode")]
        public long  StatusCode {get;set;}
        /// <summary>
        ///  描述信息
        /// </summary>
        [JsonProperty("message")]
        public string  Message {get;set;}
        /// <summary>
        ///  细分错误码，可通过此错误码得到具体的错误类型。
        /// </summary>
        [JsonProperty("apiCode")]
        public long  ApiCode {get;set;}
        /// <summary>
        ///  请求 ID。当请求失败时会返回。
        /// </summary>
        [JsonProperty("requestId")]
        public string  RequestId {get;set;}
        /// <summary>
        ///  响应数据
        /// </summary>
        [JsonProperty("data")]
        public GroupPagingDto  Data {get;set;}
    }
}