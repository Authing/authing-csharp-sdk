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
    /// UserDto 的模型
    /// </summary>
    public partial class UserDto
    {
        /// <summary>
        ///  用户唯一标志，可以是用户 ID、用户名、邮箱、手机号、外部 ID、在外部身份源的 ID。
        /// </summary>
        [JsonProperty("userId")]
        public string  UserId {get;set;}
        /// <summary>
        ///  创建时间
        /// </summary>
        [JsonProperty("createdAt")]
        public string  CreatedAt {get;set;}
        /// <summary>
        ///  更新时间
        /// </summary>
        [JsonProperty("updatedAt")]
        public string  UpdatedAt {get;set;}
        /// <summary>
        ///  账户当前状态
        /// </summary>
        [JsonProperty("status")]
        public status  Status {get;set;}
        /// <summary>
        ///  账户当前工作状态
        /// </summary>
        [JsonProperty("workStatus")]
        public workStatus  WorkStatus {get;set;}
        /// <summary>
        ///  第三方外部 ID
        /// </summary>
        [JsonProperty("externalId")]
        public string  ExternalId {get;set;}
        /// <summary>
        ///  邮箱，不区分大小写
        /// </summary>
        [JsonProperty("email")]
        public string  Email {get;set;}
        /// <summary>
        ///  手机号，不带区号。如果是国外手机号，请在 phoneCountryCode 参数中指定区号。
        /// </summary>
        [JsonProperty("phone")]
        public string  Phone {get;set;}
        /// <summary>
        ///  手机区号，中国大陆手机号可不填。Authing 短信服务暂不内置支持国际手机号，你需要在 Authing 控制台配置对应的国际短信服务。完整的手机区号列表可参阅 https://en.wikipedia.org/wiki/List_of_country_calling_codes。
        /// </summary>
        [JsonProperty("phoneCountryCode")]
        public string  PhoneCountryCode {get;set;}
        /// <summary>
        ///  用户名，用户池内唯一
        /// </summary>
        [JsonProperty("username")]
        public string  Username {get;set;}
        /// <summary>
        ///  用户真实名称，不具备唯一性
        /// </summary>
        [JsonProperty("name")]
        public string  Name {get;set;}
        /// <summary>
        ///  昵称
        /// </summary>
        [JsonProperty("nickname")]
        public string  Nickname {get;set;}
        /// <summary>
        ///  头像链接
        /// </summary>
        [JsonProperty("photo")]
        public string  Photo {get;set;}
        /// <summary>
        ///  历史总登录次数
        /// </summary>
        [JsonProperty("loginsCount")]
        public long  LoginsCount {get;set;}
        /// <summary>
        ///  上次登录时间
        /// </summary>
        [JsonProperty("lastLogin")]
        public string  LastLogin {get;set;}
        /// <summary>
        ///  上次登录 IP
        /// </summary>
        [JsonProperty("lastIp")]
        public string  LastIp {get;set;}
        /// <summary>
        ///  性别:
/// - `M`: 男性，`male`
/// - `F`: 女性，`female`
/// - `U`: 未知，`unknown`
/// 
        /// </summary>
        [JsonProperty("gender")]
        public gender  Gender {get;set;}
        /// <summary>
        ///  邮箱是否验证
        /// </summary>
        [JsonProperty("emailVerified")]
        public bool  EmailVerified {get;set;}
        /// <summary>
        ///  手机号是否验证
        /// </summary>
        [JsonProperty("phoneVerified")]
        public bool  PhoneVerified {get;set;}
        /// <summary>
        ///  用户上次密码修改时间
        /// </summary>
        [JsonProperty("passwordLastSetAt")]
        public string  PasswordLastSetAt {get;set;}
        /// <summary>
        ///  出生日期
        /// </summary>
        [JsonProperty("birthdate")]
        public string  Birthdate {get;set;}
        /// <summary>
        ///  所在国家
        /// </summary>
        [JsonProperty("country")]
        public string  Country {get;set;}
        /// <summary>
        ///  所在省份
        /// </summary>
        [JsonProperty("province")]
        public string  Province {get;set;}
        /// <summary>
        ///  所在城市
        /// </summary>
        [JsonProperty("city")]
        public string  City {get;set;}
        /// <summary>
        ///  所处地址
        /// </summary>
        [JsonProperty("address")]
        public string  Address {get;set;}
        /// <summary>
        ///  所处街道地址
        /// </summary>
        [JsonProperty("streetAddress")]
        public string  StreetAddress {get;set;}
        /// <summary>
        ///  邮政编码号
        /// </summary>
        [JsonProperty("postalCode")]
        public string  PostalCode {get;set;}
        /// <summary>
        ///  所在公司
        /// </summary>
        [JsonProperty("company")]
        public string  Company {get;set;}
        /// <summary>
        ///  最近一次登录时使用的浏览器 UA
        /// </summary>
        [JsonProperty("browser")]
        public string  Browser {get;set;}
        /// <summary>
        ///  最近一次登录时使用的设备
        /// </summary>
        [JsonProperty("device")]
        public string  Device {get;set;}
        /// <summary>
        ///  名
        /// </summary>
        [JsonProperty("givenName")]
        public string  GivenName {get;set;}
        /// <summary>
        ///  姓
        /// </summary>
        [JsonProperty("familyName")]
        public string  FamilyName {get;set;}
        /// <summary>
        ///  中间名
        /// </summary>
        [JsonProperty("middleName")]
        public string  MiddleName {get;set;}
        /// <summary>
        ///  Preferred Username
        /// </summary>
        [JsonProperty("profile")]
        public string  Profile {get;set;}
        /// <summary>
        ///  Preferred Username
        /// </summary>
        [JsonProperty("preferredUsername")]
        public string  PreferredUsername {get;set;}
        /// <summary>
        ///  用户个人网页
        /// </summary>
        [JsonProperty("website")]
        public string  Website {get;set;}
        /// <summary>
        ///  用户时区信息
        /// </summary>
        [JsonProperty("zoneinfo")]
        public string  Zoneinfo {get;set;}
        /// <summary>
        ///  Locale
        /// </summary>
        [JsonProperty("locale")]
        public string  Locale {get;set;}
        /// <summary>
        ///  标准的完整地址
        /// </summary>
        [JsonProperty("formatted")]
        public string  Formatted {get;set;}
        /// <summary>
        ///  用户所在区域
        /// </summary>
        [JsonProperty("region")]
        public string  Region {get;set;}
        /// <summary>
        ///  来源类型:
/// - `excel`: 通过 excel 导入
/// - `register`: 用户自主注册
/// - `adminCreated`: 管理员后台手动创建（包含使用管理 API 创建用户 ）
/// - `syncTask`: 同步中心的同步任务
/// 
        /// </summary>
        [JsonProperty("userSourceType")]
        public userSourceType  UserSourceType {get;set;}
        /// <summary>
        ///  应用 ID 或者同步任务 ID
        /// </summary>
        [JsonProperty("userSourceId")]
        public string  UserSourceId {get;set;}
        /// <summary>
        ///  用户上次登录的应用 ID
        /// </summary>
        [JsonProperty("lastLoginApp")]
        public string  LastLoginApp {get;set;}
        /// <summary>
        ///  用户主部门 ID
        /// </summary>
        [JsonProperty("mainDepartmentId")]
        public string  MainDepartmentId {get;set;}
        /// <summary>
        ///  用户上次进行 MFA 认证的时间
        /// </summary>
        [JsonProperty("lastMfaTime")]
        public string  LastMfaTime {get;set;}
        /// <summary>
        ///  用户密码安全强度等级
        /// </summary>
        [JsonProperty("passwordSecurityLevel")]
        public long  PasswordSecurityLevel {get;set;}
        /// <summary>
        ///  下次登录要求重置密码
        /// </summary>
        [JsonProperty("resetPasswordOnNextLogin")]
        public bool  ResetPasswordOnNextLogin {get;set;}
        /// <summary>
        ///  用户所属部门 ID 列表
        /// </summary>
        [JsonProperty("departmentIds")]
        public List<string>  DepartmentIds {get;set;}
        /// <summary>
        ///  外部身份源
        /// </summary>
        [JsonProperty("identities")]
        public List<IdentityDto>  Identities {get;set;}
        /// <summary>
        ///  用户的扩展字段数据
        /// </summary>
        [JsonProperty("customData")]
        public object  CustomData {get;set;}
        /// <summary>
        ///  用户状态上次修改时间
        /// </summary>
        [JsonProperty("statusChangedAt")]
        public string  StatusChangedAt {get;set;}
    }
    public partial class UserDto
    {
        /// <summary>
        ///  账户当前状态
        /// </summary>
        public enum status
        {
            [EnumMember(Value="Suspended")]
            SUSPENDED,
            [EnumMember(Value="Resigned")]
            RESIGNED,
            [EnumMember(Value="Activated")]
            ACTIVATED,
            [EnumMember(Value="Archived")]
            ARCHIVED,
            [EnumMember(Value="Deactivated")]
            DEACTIVATED,
        }
        /// <summary>
        ///  账户当前工作状态
        /// </summary>
        public enum workStatus
        {
            [EnumMember(Value="Closed")]
            CLOSED,
            [EnumMember(Value="Active")]
            ACTIVE,
        }
        /// <summary>
        ///  性别:
/// - `M`: 男性，`male`
/// - `F`: 女性，`female`
/// - `U`: 未知，`unknown`
/// 
        /// </summary>
        public enum gender
        {
            [EnumMember(Value="M")]
            M,
            [EnumMember(Value="F")]
            F,
            [EnumMember(Value="U")]
            U,
        }
        /// <summary>
        ///  来源类型:
/// - `excel`: 通过 excel 导入
/// - `register`: 用户自主注册
/// - `adminCreated`: 管理员后台手动创建（包含使用管理 API 创建用户 ）
/// - `syncTask`: 同步中心的同步任务
/// 
        /// </summary>
        public enum userSourceType
        {
            [EnumMember(Value="excel")]
            EXCEL,
            [EnumMember(Value="register")]
            REGISTER,
            [EnumMember(Value="adminCreated")]
            ADMIN_CREATED,
            [EnumMember(Value="syncTask")]
            SYNC_TASK,
        }
    }
}