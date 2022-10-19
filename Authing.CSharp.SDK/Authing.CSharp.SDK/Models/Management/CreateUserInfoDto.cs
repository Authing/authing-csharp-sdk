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
/// CreateUserInfoDto 的模型
/// </summary>
public partial class CreateUserInfoDto
{
    /// <summary>
    ///  账户当前状态
    /// </summary>
    [JsonProperty("status")]
    public status  Status {get;set;}
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
    ///  第三方外部 ID
    /// </summary>
    [JsonProperty("externalId")]
    public string  ExternalId {get;set;}
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
    ///  性别
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
    ///  用户密码。我们使用 HTTPS 协议对密码进行安全传输，可以在一定程度上保证安全性。如果你还需要更高级别的安全性，我们还支持 RSA256 和国密 SM2 两种方式对密码进行加密。详情见 `passwordEncryptType` 参数。
    /// </summary>
    [JsonProperty("password")]
    public string  Password {get;set;}
    /// <summary>
    ///  加密用户密码的盐
    /// </summary>
    [JsonProperty("salt")]
    public string  Salt {get;set;}
    /// <summary>
    ///  租户 ID
    /// </summary>
    [JsonProperty("tenantIds")]
    public List<string>  TenantIds {get;set;}
    /// <summary>
    ///  用户的 OTP 验证器
    /// </summary>
    [JsonProperty("otp")]
    public CreateUserOtpDto  Otp {get;set;}
    /// <summary>
    ///  用户所属部门 ID 列表
    /// </summary>
    [JsonProperty("departmentIds")]
    public List<string>  DepartmentIds {get;set;}
    /// <summary>
    ///  自定义数据，传入的对象中的 key 必须先在用户池定义相关自定义字段
    /// </summary>
    [JsonProperty("customData")]
    public object  CustomData {get;set;}
    /// <summary>
    ///  第三方身份源（建议调用绑定接口进行绑定）
    /// </summary>
    [JsonProperty("identities")]
    public List<CreateIdentityDto>  Identities {get;set;}
}
public partial class CreateUserInfoDto
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
    ///  性别
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
}
}