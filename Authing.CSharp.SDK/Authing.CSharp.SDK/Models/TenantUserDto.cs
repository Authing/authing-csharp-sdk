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
    /// TenantUserDto 的模型
    /// </summary>
    public partial class TenantUserDto
    {
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
        [JsonProperty("preferredUsername")]
        public string  PreferredUsername {get;set;}
        /// <summary>
        ///  用户上次登录的应用 ID
        /// </summary>
        [JsonProperty("lastLoginApp")]
        public string  LastLoginApp {get;set;}
        /// <summary>
        ///  用户池 ID
        /// </summary>
        [JsonProperty("userPoolId")]
        public string  UserPoolId {get;set;}
        /// <summary>
        ///  租户 ID
        /// </summary>
        [JsonProperty("tenantId")]
        public string  TenantId {get;set;}
        /// <summary>
        ///  租户成员 ID
        /// </summary>
        [JsonProperty("memberId")]
        public string  MemberId {get;set;}
        /// <summary>
        ///  关联的用户池级别的用户 ID
        /// </summary>
        [JsonProperty("linkUserId")]
        public string  LinkUserId {get;set;}
        /// <summary>
        ///  是否为租户管理员
        /// </summary>
        [JsonProperty("isTenantAdmin")]
        public bool  IsTenantAdmin {get;set;}
        /// <summary>
        ///  用户密码，默认为明文。我们使用 HTTPS 协议对密码进行安全传输，可以在一定程度上保证安全性。如果你还需要更高级别的安全性，我们还支持 RSA256 和国密 SM2 两种方式对密码进行加密。详情见 `passwordEncryptType` 参数。
        /// </summary>
        [JsonProperty("password")]
        public string  Password {get;set;}
        /// <summary>
        ///  加密用户密码的盐
        /// </summary>
        [JsonProperty("salt")]
        public string  Salt {get;set;}
    }
    public partial class TenantUserDto
    {
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
    }
}