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
    /// GetUserLoginHistoryDto 的模型
    /// </summary>
    public partial class GetUserLoginHistoryDto
    {
        /// <summary>
        ///  用户 ID
        /// </summary>
        [JsonProperty("userId")]
        public    object   UserId    {get;set;}
        /// <summary>
        ///  应用 ID
        /// </summary>
        [JsonProperty("appId")]
        public    object   AppId    {get;set;}
        /// <summary>
        ///  客户端 IP
        /// </summary>
        [JsonProperty("clientIp")]
        public    object   ClientIp    {get;set;}
        /// <summary>
        ///  开始时间戳（毫秒）
        /// </summary>
        [JsonProperty("start")]
        public    object   Start    {get;set;}
        /// <summary>
        ///  结束时间戳（毫秒）
        /// </summary>
        [JsonProperty("end")]
        public    object   End    {get;set;}
        /// <summary>
        ///  当前页数，从 1 开始
        /// </summary>
        [JsonProperty("page")]
        public    object   Page    {get;set;}
        /// <summary>
        ///  每页数目，最大不能超过 50，默认为 10
        /// </summary>
        [JsonProperty("limit")]
        public    object   Limit    {get;set;}
    }
}