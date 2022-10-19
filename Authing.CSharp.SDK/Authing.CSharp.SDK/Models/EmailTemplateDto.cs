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
/// EmailTemplateDto 的模型
/// </summary>
public partial class EmailTemplateDto
{
    /// <summary>
    ///  是否启用自定义模版
    /// </summary>
    [JsonProperty("customizeEnabled")]
    public bool  CustomizeEnabled {get;set;}
    /// <summary>
    ///  模版类型:
/// - `WELCOME_EMAIL`: 欢迎邮件
/// - `FIRST_CREATED_USER`: 首次创建用户通知
/// - `REGISTER_VERIFY_CODE`: 注册验证码
/// - `LOGIN_VERIFY_CODE`: 登录验证码
/// - `MFA_VERIFY_CODE`: MFA 验证码
/// - `INFORMATION_COMPLETION_VERIFY_CODE`: 注册信息补全验证码
/// - `FIRST_EMAIL_LOGIN_VERIFY`: 首次邮箱登录验证
/// - `CONSOLE_CONDUCTED_VERIFY`: 在控制台发起邮件验证
/// - `USER_PASSWORD_UPDATE_REMIND`: 用户到期提醒
/// - `ADMIN_RESET_USER_PASSWORD_NOTIFICATION`: 管理员重置用户密码成功通知
/// - `USER_PASSWORD_RESET_NOTIFICATION`: 用户密码重置成功通知
/// - `RESET_PASSWORD_VERIFY_CODE`: 重置密码验证码
/// - `SELF_UNLOCKING_VERIFY_CODE`: 自助解锁验证码
/// - `EMAIL_BIND_VERIFY_CODE`: 绑定邮箱验证码
/// - `EMAIL_UNBIND_VERIFY_CODE`: 解绑邮箱验证码
/// 
    /// </summary>
    [JsonProperty("type")]
    public type  Type {get;set;}
    /// <summary>
    ///  邮件模版名称
    /// </summary>
    [JsonProperty("name")]
    public string  Name {get;set;}
    /// <summary>
    ///  邮件主题
    /// </summary>
    [JsonProperty("subject")]
    public string  Subject {get;set;}
    /// <summary>
    ///  邮件发件人名称
    /// </summary>
    [JsonProperty("sender")]
    public string  Sender {get;set;}
    /// <summary>
    ///  邮件内容模版
    /// </summary>
    [JsonProperty("content")]
    public string  Content {get;set;}
    /// <summary>
    ///  验证码/邮件有效时间，只有验证类邮件才有有效时间。
    /// </summary>
    [JsonProperty("expiresIn")]
    public long  ExpiresIn {get;set;}
    /// <summary>
    ///  完成邮件验证之后跳转到的地址，只针对 `FIRST_EMAIL_LOGIN_VERIFY` 和 `CONSOLE_CONDUCTED_VERIFY` 类型的模版有效。
    /// </summary>
    [JsonProperty("redirectTo")]
    public string  RedirectTo {get;set;}
    /// <summary>
    ///  模版渲染引擎。Authing 邮件模版目前支持两种渲染引擎：
/// - `handlebar`: 详细使用方法请见：[handlebars 官方文档](https://handlebarsjs.com/)
/// - `ejs`: 详细使用方法请见：[ejs 官方文档](https://ejs.co/)
///
/// 默认将使用 `handlerbar` 作为膜拜渲染引擎。
/// 
    /// </summary>
    [JsonProperty("tplEngine")]
    public tplEngine  TplEngine {get;set;}
}
public partial class EmailTemplateDto
 {
    /// <summary>
    ///  模版类型:
/// - `WELCOME_EMAIL`: 欢迎邮件
/// - `FIRST_CREATED_USER`: 首次创建用户通知
/// - `REGISTER_VERIFY_CODE`: 注册验证码
/// - `LOGIN_VERIFY_CODE`: 登录验证码
/// - `MFA_VERIFY_CODE`: MFA 验证码
/// - `INFORMATION_COMPLETION_VERIFY_CODE`: 注册信息补全验证码
/// - `FIRST_EMAIL_LOGIN_VERIFY`: 首次邮箱登录验证
/// - `CONSOLE_CONDUCTED_VERIFY`: 在控制台发起邮件验证
/// - `USER_PASSWORD_UPDATE_REMIND`: 用户到期提醒
/// - `ADMIN_RESET_USER_PASSWORD_NOTIFICATION`: 管理员重置用户密码成功通知
/// - `USER_PASSWORD_RESET_NOTIFICATION`: 用户密码重置成功通知
/// - `RESET_PASSWORD_VERIFY_CODE`: 重置密码验证码
/// - `SELF_UNLOCKING_VERIFY_CODE`: 自助解锁验证码
/// - `EMAIL_BIND_VERIFY_CODE`: 绑定邮箱验证码
/// - `EMAIL_UNBIND_VERIFY_CODE`: 解绑邮箱验证码
/// 
    /// </summary>
    public enum type
     {
         [EnumMember(Value="WELCOME_EMAIL")]
        WELCOME_EMAIL,
         [EnumMember(Value="FIRST_CREATED_USER")]
        FIRST_CREATED_USER,
         [EnumMember(Value="REGISTER_VERIFY_CODE")]
        REGISTER_VERIFY_CODE,
         [EnumMember(Value="LOGIN_VERIFY_CODE")]
        LOGIN_VERIFY_CODE,
         [EnumMember(Value="MFA_VERIFY_CODE")]
        MFA_VERIFY_CODE,
         [EnumMember(Value="INFORMATION_COMPLETION_VERIFY_CODE")]
        INFORMATION_COMPLETION_VERIFY_CODE,
         [EnumMember(Value="FIRST_EMAIL_LOGIN_VERIFY")]
        FIRST_EMAIL_LOGIN_VERIFY,
         [EnumMember(Value="CONSOLE_CONDUCTED_VERIFY")]
        CONSOLE_CONDUCTED_VERIFY,
         [EnumMember(Value="USER_PASSWORD_UPDATE_REMIND")]
        USER_PASSWORD_UPDATE_REMIND,
         [EnumMember(Value="ADMIN_RESET_USER_PASSWORD_NOTIFICATION")]
        ADMIN_RESET_USER_PASSWORD_NOTIFICATION,
         [EnumMember(Value="USER_PASSWORD_RESET_NOTIFICATION")]
        USER_PASSWORD_RESET_NOTIFICATION,
         [EnumMember(Value="RESET_PASSWORD_VERIFY_CODE")]
        RESET_PASSWORD_VERIFY_CODE,
         [EnumMember(Value="SELF_UNLOCKING_VERIFY_CODE")]
        SELF_UNLOCKING_VERIFY_CODE,
         [EnumMember(Value="EMAIL_BIND_VERIFY_CODE")]
        EMAIL_BIND_VERIFY_CODE,
         [EnumMember(Value="EMAIL_UNBIND_VERIFY_CODE")]
        EMAIL_UNBIND_VERIFY_CODE,
    }
    /// <summary>
    ///  模版渲染引擎。Authing 邮件模版目前支持两种渲染引擎：
/// - `handlebar`: 详细使用方法请见：[handlebars 官方文档](https://handlebarsjs.com/)
/// - `ejs`: 详细使用方法请见：[ejs 官方文档](https://ejs.co/)
///
/// 默认将使用 `handlerbar` 作为膜拜渲染引擎。
/// 
    /// </summary>
    public enum tplEngine
     {
         [EnumMember(Value="handlebar")]
        HANDLEBAR,
         [EnumMember(Value="ejs")]
        EJS,
    }
}
}