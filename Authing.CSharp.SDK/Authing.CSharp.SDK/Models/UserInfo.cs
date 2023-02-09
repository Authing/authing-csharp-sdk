using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authing.CSharp.SDK.Models.Authentication
{
    /// <summary>
    /// 用户信息模型
    /// </summary>
    public class UserInfo
    {
        /// <summary>
        /// subject 的缩写，唯一标识，一般为用户 ID
        /// </summary>
        [JsonProperty("sub")]
        public string Sub { get; set; }

        /// <summary>
        /// 用户池 ID
        /// </summary>
        [JsonProperty("userPoolId")]
        public string UserPoolId { get; set; }

        /// <summary>
        /// 用户名，用户池内唯一
        /// </summary>
        [JsonProperty("username")]
        public string Username { get; set; }

        /// <summary>
        /// 邮箱，用户池内唯一
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// 邮箱是否已验证
        /// </summary>
        [JsonProperty("email_verified")]
        public bool? EmailVerified { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 中间名
        /// </summary>
        [JsonProperty("middle_name")]
        public string MiddleName { get; set; }

        /// <summary>
        /// 手机号，用户池内唯一
        /// </summary>
        [JsonProperty("phone_number")]
        public string Phone { get; set; }

        /// <summary>
        /// 手机号是否已验证
        /// </summary>
        [JsonProperty("phone_number_verified")]
        public bool? PhoneVerified { get; set; }

        /// <summary>
        /// 名字
        /// </summary>
        [JsonProperty("given_name")]
        public string GivenName { get; set; }

        [JsonProperty("unionid")] public string Unionid { get; set; }

        /// <summary>
        /// 头像链接，默认为 https://usercontents.authing.cn/authing-avatar.png
        /// </summary>
        [JsonProperty("picture")]
        public string Photo { get; set; }

        [JsonProperty("device")] public string Device { get; set; }

        [JsonProperty("browser")] public string Browser { get; set; }

        [JsonProperty("company")] public string Company { get; set; }

        /// <summary>
        /// 姓氏
        /// </summary>
        [JsonProperty("family_name")]
        public string FamilyName { get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        [JsonProperty("nickname")]
        public string NickName { get; set; }

        /// <summary>
        /// 希望被称呼的名字
        /// </summary>
        [JsonProperty("preferred_username")]
        public string PreferredUsername { get; set; }

        /// <summary>
        /// 基础资料
        /// </summary>
        [JsonProperty("profile")]
        private object Profile { get; set; }

        /// <summary>
        /// 头像
        /// </summary>
        [JsonProperty("picture")]
        public string Picture { get; set; }

        /// <summary>
        /// 网站链接
        /// </summary>
        [JsonProperty("website")]
        public string Website { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [JsonProperty("gender")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Gender Gender { get; set; }

        /// <summary>
        /// 生日
        /// </summary>
        [JsonProperty("birthdate")]
        public string Birthdate { get; set; }

        [JsonProperty("zoneinfo")] 
        public string Zoneinfo { get; set; }

        /// <summary>
        /// 时区
        /// </summary>
        [JsonProperty("zoneinfo")]
        public string ZoneInfo { get; set; }

        /// <summary>
        /// 区域
        /// </summary>
        [JsonProperty("locale")]
        public string Locale { get; set; }

        /// <summary>
        /// 信息更新时间
        /// </summary>
        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("address")] 
        public Address Address { get; set; }

        [JsonProperty("formatted")] 
        public string Formatted { get; set; }

        [JsonProperty("streetAddress")] 
        public string StreetAddress { get; set; }

        [JsonProperty("locality")] 
        public string Locality { get; set; }

        [JsonProperty("region")] 
        public string Region { get; set; }

        [JsonProperty("postalCode")] 
        public string PostalCode { get; set; }

        [JsonProperty("city")] 
        public string City { get; set; }

        [JsonProperty("province")] 
        public string Province { get; set; }

        [JsonProperty("country")] 
        public string Country { get; set; }

        [JsonProperty("createdAt")] 
        public string CreatedAt { get; set; }

        /// 用户外部 ID
        /// </summary>
        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        [JsonProperty("token")] public string Token { get; set; }
    }

    public class Address
    {
        [JsonProperty("country")]
        public string Country { get; set; }
        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }
        [JsonProperty("region")]
        public string Region { get; set; }
        [JsonProperty("formatted")]
        public string Formatted { get; set; }
    }

    /// <summary>
    /// 性别枚举
    /// </summary>
    public enum Gender
    {
        /// <summary>
        /// 男性
        /// </summary>
        M,
        /// <summary>
        /// 女性
        /// </summary>
        F,
        /// <summary>
        /// 未选择性别
        /// </summary>
        U
    }
}
