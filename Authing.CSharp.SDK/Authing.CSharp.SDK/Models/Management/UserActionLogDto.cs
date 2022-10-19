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
/// UserActionLogDto 的模型
/// </summary>
public partial class UserActionLogDto
{
    /// <summary>
    ///  用户 ID
    /// </summary>
    [JsonProperty("userId")]
    public string  UserId {get;set;}
    /// <summary>
    ///  用户头像
    /// </summary>
    [JsonProperty("userAvatar")]
    public string  UserAvatar {get;set;}
    /// <summary>
    ///  用户显示名称，按照以下用户字段顺序进行展示：nickname > username > name > givenName > familyName -> email -> phone -> id
    /// </summary>
    [JsonProperty("userDisplayName")]
    public string  UserDisplayName {get;set;}
    /// <summary>
    ///  用户登录次数
    /// </summary>
    [JsonProperty("userLoginsCount")]
    public long  UserLoginsCount {get;set;}
    /// <summary>
    ///  应用 ID
    /// </summary>
    [JsonProperty("appId")]
    public string  AppId {get;set;}
    /// <summary>
    ///  应用名称
    /// </summary>
    [JsonProperty("appName")]
    public string  AppName {get;set;}
    /// <summary>
    ///  客户端 IP，可根据登录时的客户端 IP 进行筛选。默认不传获取所有登录 IP 的登录历史。
    /// </summary>
    [JsonProperty("clientIp")]
    public string  ClientIp {get;set;}
    /// <summary>
    ///  事件类型：
/// - `login`: 登录
/// - `logout`: 登出
/// - `register`: 注册
/// - `verifyMfa`: 验证 MFA
/// - `updateUserProfile`: 修改用户信息
/// - `updateUserPassword`: 修改密码
/// - `updateUserEmail`: 修改邮箱
/// - `updateUserPhone`: 修改手机号
/// - `bindMfa`: 绑定 MFA
/// - `bindEmail`: 绑定邮箱
/// - `bindPhone`: 绑定手机号
/// - `unbindPhone`: 解绑手机号
/// - `unbindEmail`: 解绑邮箱
/// - `unbindMFA`: 解绑 MFA
/// - `deleteAccount`: 注销账号
/// - `verifyFirstLogin`: 首次登录验证
/// 
    /// </summary>
    [JsonProperty("eventType")]
    public eventType  EventType {get;set;}
    /// <summary>
    ///  事件详情
    /// </summary>
    [JsonProperty("eventDetail")]
    public string  EventDetail {get;set;}
    /// <summary>
    ///  是否成功
    /// </summary>
    [JsonProperty("success")]
    public bool  Success {get;set;}
    /// <summary>
    ///  应用登录地址
    /// </summary>
    [JsonProperty("appLoginUrl")]
    public string  AppLoginUrl {get;set;}
    /// <summary>
    ///  应用 Logo
    /// </summary>
    [JsonProperty("appLogo")]
    public string  AppLogo {get;set;}
    /// <summary>
    ///  User Agent
    /// </summary>
    [JsonProperty("userAgent")]
    public string  UserAgent {get;set;}
    /// <summary>
    ///  解析过后的 User Agent
    /// </summary>
    [JsonProperty("parsedUserAgent")]
    public ParsedUserAgent  ParsedUserAgent {get;set;}
    /// <summary>
    ///  地理位置
    /// </summary>
    [JsonProperty("geoip")]
    public GeoIp  Geoip {get;set;}
    /// <summary>
    ///  时间
    /// </summary>
    [JsonProperty("timestamp")]
    public string  Timestamp {get;set;}
    /// <summary>
    ///  请求 ID
    /// </summary>
    [JsonProperty("requestId")]
    public string  RequestId {get;set;}
}
public partial class UserActionLogDto
 {
    /// <summary>
    ///  事件类型：
/// - `login`: 登录
/// - `logout`: 登出
/// - `register`: 注册
/// - `verifyMfa`: 验证 MFA
/// - `updateUserProfile`: 修改用户信息
/// - `updateUserPassword`: 修改密码
/// - `updateUserEmail`: 修改邮箱
/// - `updateUserPhone`: 修改手机号
/// - `bindMfa`: 绑定 MFA
/// - `bindEmail`: 绑定邮箱
/// - `bindPhone`: 绑定手机号
/// - `unbindPhone`: 解绑手机号
/// - `unbindEmail`: 解绑邮箱
/// - `unbindMFA`: 解绑 MFA
/// - `deleteAccount`: 注销账号
/// - `verifyFirstLogin`: 首次登录验证
/// 
    /// </summary>
    public enum eventType
     {
         [EnumMember(Value="login")]
        LOGIN,
         [EnumMember(Value="logout")]
        LOGOUT,
         [EnumMember(Value="register")]
        REGISTER,
         [EnumMember(Value="verifyMfa")]
        VERIFY_MFA,
         [EnumMember(Value="updateUserPrefile")]
        UPDATE_USER_PREFILE,
         [EnumMember(Value="updateUserPassword")]
        UPDATE_USER_PASSWORD,
         [EnumMember(Value="updateUserEmail")]
        UPDATE_USER_EMAIL,
         [EnumMember(Value="updateUserPhone")]
        UPDATE_USER_PHONE,
         [EnumMember(Value="bindMfa")]
        BIND_MFA,
         [EnumMember(Value="bindEmail")]
        BIND_EMAIL,
         [EnumMember(Value="bindPhone")]
        BIND_PHONE,
         [EnumMember(Value="unbindPhone")]
        UNBIND_PHONE,
         [EnumMember(Value="unbindEmail")]
        UNBIND_EMAIL,
         [EnumMember(Value="unbindMFA")]
        UNBIND_MFA,
         [EnumMember(Value="refreshUserTokenBySelf")]
        REFRESH_USER_TOKEN_BY_SELF,
         [EnumMember(Value="deleteAccount")]
        DELETE_ACCOUNT,
         [EnumMember(Value="verifyFirstLogin")]
        VERIFY_FIRST_LOGIN,
    }
}
}