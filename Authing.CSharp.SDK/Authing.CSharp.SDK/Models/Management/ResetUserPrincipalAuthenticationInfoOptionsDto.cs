using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Authing.CSharp.SDK.Models.Management;

   namespace Authing.CSharp.SDK.Models.Management
{
/// <summary>
/// ResetUserPrincipalAuthenticationInfoOptionsDto 的模型
/// </summary>
public partial class ResetUserPrincipalAuthenticationInfoOptionsDto
{
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
public    userIdType   UserIdType    {get;set;}
}
public partial class ResetUserPrincipalAuthenticationInfoOptionsDto
 {
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
    }
}
}