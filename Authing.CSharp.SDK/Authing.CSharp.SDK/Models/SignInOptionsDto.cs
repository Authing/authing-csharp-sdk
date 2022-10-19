using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Authing.CSharp.SDK.Models;

   namespace Authing.CSharp.SDK.Models
{
/// <summary>
/// SignInOptionsDto 的模型
/// </summary>
public partial class SignInOptionsDto
{
    /// <summary>
    ///  需要请求的权限，必须包含 openid。如果需要获取手机号和 email 需要包含 phone email；如果需要 refresh_token 需要包含 offline_access。多个 scope 请用空格分隔。id_token 解码后的内容中会包含这些 scope 对应的用户信息相关的字段。
/// - `openid`: 必须包含。
/// - `profile`: 返回 birthdate，family_name，gender，given_name，locale，middle_name，name，nickname，picture，preferred_username，profile，updated_at，website，zoneinfo 字段。
/// - `username`: 返回 username。
/// - `email`: 返回 email，email_verified。
/// - `phone`: 返回 phone_number, phone_number_verified。
/// - `offline_access`: 如果存在此参数，token 接口会返回 refresh_token 字段。
/// - `roles`: 返回用户的角色列表。
/// - `external_id`: 用户在原有系统的用户 ID。
/// - `extended_fields`: 返回用户的扩展字段信息，内容为一个对象，key 为扩展字段名，value 为扩展字段值。
/// - `tenant_id`: 返回用户的租户 ID。
/// 
    /// </summary>
    [JsonProperty("scope")]
    public string  Scope {get;set;}
    /// <summary>
    ///  客户端真实 IP 地址。默认情况下，Authing 会将请求来源的 IP 识别为用户登录的 IP 地址，如果你在后端服务器中调用此接口，需要将此 IP 设置为用户的真实请求 IP。
    /// </summary>
    [JsonProperty("clientIp")]
    public string  ClientIp {get;set;}
    /// <summary>
    ///  额外请求上下文，将会传递到认证前和认证后的 [Pipeline](https://docs.authing.cn/v2/guides/pipeline/) 的 `context` 对象中。了解[如何在 Pipeline 的 `context` 参数中获取传入的额外 context](https://docs.authing.cn/v2/guides/pipeline/context-object.html)。
    /// </summary>
    [JsonProperty("context")]
    public string  Context {get;set;}
    /// <summary>
    ///  租户 ID
    /// </summary>
    [JsonProperty("tenantId")]
    public string  TenantId {get;set;}
    /// <summary>
    ///  设置额外的用户自定义数据，你需要先在 Authing 控制台[配置自定义数据](https://docs.authing.cn/v2/guides/users/user-defined-field/)。
    /// </summary>
    [JsonProperty("customData")]
    public object  CustomData {get;set;}
    /// <summary>
    ///  是否开启自动注册。如果设置为 true，当用户不存在的时候，会先自动为其创建一个账号。
    /// </summary>
    [JsonProperty("autoRegister")]
    public bool  AutoRegister {get;set;}
    /// <summary>
    ///  Captcha 图形验证码，不区分大小写。当**安全策略**设置为**验证码**且触发**登录失败次数限制**时，下次登录需要填写图形验证码。
    /// </summary>
    [JsonProperty("captchaCode")]
    public string  CaptchaCode {get;set;}
    /// <summary>
    ///  密码加密类型，支持 sm2 和 rsa。默认可以不加密。
/// - `none`: 不对密码进行加密，使用明文进行传输。
/// - `rsa`: 使用 RSA256 算法对密码进行加密，需要使用 Authing 服务的 RSA 公钥进行加密，请阅读**介绍**部分了解如何获取 Authing 服务的 RSA256 公钥。
/// - `sm2`: 使用 [国密 SM2 算法](https://baike.baidu.com/item/SM2/15081831) 对密码进行加密，需要使用 Authing 服务的 SM2 公钥进行加密，请阅读**介绍**部分了解如何获取 Authing 服务的 SM2 公钥。
/// 
    /// </summary>
    [JsonProperty("passwordEncryptType")]
    public passwordEncryptType  PasswordEncryptType {get;set;}
}
public partial class SignInOptionsDto
 {
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