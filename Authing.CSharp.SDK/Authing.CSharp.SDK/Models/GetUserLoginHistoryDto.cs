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
        ///  用户唯一标志，可以是用户 ID、用户名、邮箱、手机号、外部 ID、在外部身份源的 ID。
        /// </summary>
        [JsonProperty("userId")]
        public string  UserId {get;set;} 
        /// <summary>
        ///  用户 ID 类型，默认值为 `user_id`，可选值为：
/// - `user_id`: Authing 用户 ID，如 `6319a1504f3xxxxf214dd5b7`
/// - `phone`: 用户手机号
/// - `email`: 用户邮箱
/// - `username`: 用户名
/// - `external_id`: 用户在外部系统的 ID，对应 Authing 用户信息的 `externalId` 字段
/// - `identity`: 用户的外部身份源信息，格式为 `<extIdpId>:<userIdInIdp>`，其中 `<extIdpId>` 为 Authing 身份源的 ID，`<userIdInIdp>` 为用户在外部身份源的 ID。
/// 示例值：`62f20932716fbcc10d966ee5:ou_8bae746eac07cd2564654140d2a9ac61`。
/// 
        /// </summary>
        [JsonProperty("userIdType")]
        public string  UserIdType {get;set;} 
        /// <summary>
        ///  应用 ID
        /// </summary>
        [JsonProperty("appId")]
        public string  AppId {get;set;} 
        /// <summary>
        ///  客户端 IP
        /// </summary>
        [JsonProperty("clientIp")]
        public string  ClientIp {get;set;} 
        /// <summary>
        ///  开始时间戳（毫秒）
        /// </summary>
        [JsonProperty("start")]
        public long  Start {get;set;} 
        /// <summary>
        ///  结束时间戳（毫秒）
        /// </summary>
        [JsonProperty("end")]
        public long  End {get;set;} 
        /// <summary>
        ///  当前页数，从 1 开始
        /// </summary>
        [JsonProperty("page")]
        public long  Page {get;set;} =1;
        /// <summary>
        ///  每页数目，最大不能超过 50，默认为 10
        /// </summary>
        [JsonProperty("limit")]
        public long  Limit {get;set;} =10;
    }
}