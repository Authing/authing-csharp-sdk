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
    /// KickPublicAccountsOptionsDto 的模型
    /// </summary>
    public partial class KickPublicAccountsOptionsDto
    {
        /// <summary>
        ///  用户 ID 类型，默认值为 `user_id`，可选值为：
/// - `user_id`: Authing 用户 ID，如 `6319a1504f3xxxxf214dd5b7`
/// - `phone`: 用户手机号
/// - `email`: 用户邮箱
/// - `username`: 用户名
/// - `external_id`: 用户在外部系统的 ID，对应 Authing 用户信息的 `externalId` 字段
/// 
        /// </summary>
        [JsonProperty("userIdType")]
        public userIdType  UserIdType {get;set;}
    }
    public partial class KickPublicAccountsOptionsDto
    {
        /// <summary>
        ///  用户 ID 类型，默认值为 `user_id`，可选值为：
/// - `user_id`: Authing 用户 ID，如 `6319a1504f3xxxxf214dd5b7`
/// - `phone`: 用户手机号
/// - `email`: 用户邮箱
/// - `username`: 用户名
/// - `external_id`: 用户在外部系统的 ID，对应 Authing 用户信息的 `externalId` 字段
/// 
        /// </summary>
        public enum userIdType
        {
            [EnumMember(Value="user_id")]
            USER_ID,
            [EnumMember(Value="external_id")]
            EXTERNAL_ID,
            [EnumMember(Value="phone")]
            PHONE,
            [EnumMember(Value="email")]
            EMAIL,
            [EnumMember(Value="username")]
            USERNAME,
            [EnumMember(Value="identity")]
            IDENTITY,
            [EnumMember(Value="sync_relation")]
            SYNC_RELATION,
            [EnumMember(Value="custom_field")]
            CUSTOM_FIELD,
        }
    }
}