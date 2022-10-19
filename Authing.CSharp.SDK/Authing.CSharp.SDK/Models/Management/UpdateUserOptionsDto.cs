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
/// UpdateUserOptionsDto 的模型
/// </summary>
public partial class UpdateUserOptionsDto
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
    public userIdType  UserIdType {get;set;}
    /// <summary>
    ///  下次登录要求重置密码
    /// </summary>
    [JsonProperty("resetPasswordOnNextLogin")]
    public bool  ResetPasswordOnNextLogin {get;set;}
    /// <summary>
    ///  密码加密类型，支持 sm2 和 rsa。默认可以不加密。
/// - `none`: 不对密码进行加密，使用明文进行传输。
/// - `rsa`: 使用 RSA256 算法对密码进行加密，需要使用 Authing 服务的 RSA 公钥进行加密，请阅读**介绍**部分了解如何获取 Authing 服务的 RSA256 公钥。
/// - `sm2`: 使用 [国密 SM2 算法](https://baike.baidu.com/item/SM2/15081831) 对密码进行加密，需要使用 Authing 服务的 SM2 公钥进行加密，请阅读**介绍**部分了解如何获取 Authing 服务的 SM2 公钥。
/// 
    /// </summary>
    [JsonProperty("passwordEncryptType")]
    public passwordEncryptType  PasswordEncryptType {get;set;}
    /// <summary>
    ///  是否自动生成密码
    /// </summary>
    [JsonProperty("autoGeneratePassword")]
    public bool  AutoGeneratePassword {get;set;}
    /// <summary>
    ///  重置密码发送邮件和手机号选项
    /// </summary>
    [JsonProperty("sendPasswordResetedNotification")]
    public SendResetPasswordNotificationDto  SendPasswordResetedNotification {get;set;}
}
public partial class UpdateUserOptionsDto
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
    /// <summary>
    ///  密码加密类型，支持 sm2 和 rsa。默认可以不加密。
/// - `none`: 不对密码进行加密，使用明文进行传输。
/// - `rsa`: 使用 RSA256 算法对密码进行加密，需要使用 Authing 服务的 RSA 公钥进行加密，请阅读**介绍**部分了解如何获取 Authing 服务的 RSA256 公钥。
/// - `sm2`: 使用 [国密 SM2 算法](https://baike.baidu.com/item/SM2/15081831) 对密码进行加密，需要使用 Authing 服务的 SM2 公钥进行加密，请阅读**介绍**部分了解如何获取 Authing 服务的 SM2 公钥。
/// 
    /// </summary>
    public enum passwordEncryptType
     {
         [EnumMember(Value="sm2")]
        SM2,
         [EnumMember(Value="rsa")]
        RSA,
         [EnumMember(Value="none")]
        NONE,
    }
}
}