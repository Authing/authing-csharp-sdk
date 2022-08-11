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
    /// CreateUserInfoDto 的模型
    /// </summary>
    public partial class CreateUserInfoDto
    {
        /// <summary>
        ///  账户当前状态
        /// </summary>
        [JsonProperty("status")]
        public status Status { get; set; }
        /// <summary>
        ///  邮箱
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }
        /// <summary>
        ///  密码加密类型，支持 sm2 和 rsa
        /// </summary>
        [JsonProperty("passwordEncryptType")]
        public passwordEncryptType PasswordEncryptType { get; set; }
        /// <summary>
        ///  手机号
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }
        /// <summary>
        ///  手机区号
        /// </summary>
        [JsonProperty("phoneCountryCode")]
        public string PhoneCountryCode { get; set; }
        /// <summary>
        ///  用户名，用户池内唯一
        /// </summary>
        [JsonProperty("username")]
        public string Username { get; set; }
        /// <summary>
        ///  用户真实名称，不具备唯一性
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        /// <summary>
        ///  昵称
        /// </summary>
        [JsonProperty("nickname")]
        public string Nickname { get; set; }
        /// <summary>
        ///  头像链接
        /// </summary>
        [JsonProperty("photo")]
        public string Photo { get; set; }
        /// <summary>
        ///  性别
        /// </summary>
        [JsonProperty("gender")]
        public gender Gender { get; set; }
        /// <summary>
        ///  邮箱是否验证
        /// </summary>
        [JsonProperty("emailVerified")]
        public bool EmailVerified { get; set; }
        /// <summary>
        ///  手机号是否验证
        /// </summary>
        [JsonProperty("phoneVerified")]
        public bool PhoneVerified { get; set; }
        /// <summary>
        ///  出生日期
        /// </summary>
        [JsonProperty("birthdate")]
        public string Birthdate { get; set; }
        /// <summary>
        ///  所在国家
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }
        /// <summary>
        ///  所在省份
        /// </summary>
        [JsonProperty("province")]
        public string Province { get; set; }
        /// <summary>
        ///  所在城市
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }
        /// <summary>
        ///  所处地址
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; }
        /// <summary>
        ///  所处街道地址
        /// </summary>
        [JsonProperty("streetAddress")]
        public string StreetAddress { get; set; }
        /// <summary>
        ///  邮政编码号
        /// </summary>
        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }
        /// <summary>
        ///  第三方外部 ID
        /// </summary>
        [JsonProperty("externalId")]
        public string ExternalId { get; set; }
        /// <summary>
        ///  用户所属部门 ID 列表
        /// </summary>
        [JsonProperty("departmentIds")]
        public List<string> DepartmentIds { get; set; }
        /// <summary>
        ///  自定义数据，传入的对象中的 key 必须先在用户池定义相关自定义字段
        /// </summary>
        [JsonProperty("customData")]
        public object CustomData { get; set; }
        /// <summary>
        ///  密码。可选加密方式进行加密，通过 passwordEncryptType 参数进行加密方法选择，默认为未加密
        /// </summary>
        [JsonProperty("password")]
        public string Password { get; set; }
        /// <summary>
        ///  租户 ID
        /// </summary>
        [JsonProperty("tenantIds")]
        public List<string> TenantIds { get; set; }
        /// <summary>
        ///  第三方身份源（建议调用绑定接口进行绑定）
        /// </summary>
        [JsonProperty("identities")]
        public List<CreateIdentityDto> Identities { get; set; }
    }
    public partial class CreateUserInfoDto
    {
        /// <summary>
        ///  账户当前状态
        /// </summary>
        public enum status
        {
            [EnumMember(Value = "Suspended")]
            SUSPENDED,
            [EnumMember(Value = "Resigned")]
            RESIGNED,
            [EnumMember(Value = "Activated")]
            ACTIVATED,
            [EnumMember(Value = "Archived")]
            ARCHIVED,
        }
        /// <summary>
        ///  密码加密类型，支持 sm2 和 rsa
        /// </summary>
        public enum passwordEncryptType
        {
            [EnumMember(Value = "sm2")]
            SM2,
            [EnumMember(Value = "rsa")]
            RSA,
            [EnumMember(Value = "none")]
            NONE,
        }
        /// <summary>
        ///  性别
        /// </summary>
        public enum gender
        {
            [EnumMember(Value = "M")]
            M,
            [EnumMember(Value = "W")]
            W,
            [EnumMember(Value = "U")]
            U,
        }
    }
}