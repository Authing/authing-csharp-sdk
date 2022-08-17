using Authing.CSharp.SDK.Models.Authentication;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Authing.CSharp.SDK.Models
{
    public class SignupDto
    {
        public SignupDto()
        {
            Profile = new SignupProfile();
            Options = new SignupOptions();
            PasswordPayload = new SignupPasswordPayload();
            PassCodePayload = new SignupPassCodePayload();
        }

        /// <summary>
        /// 注册方式
        /// </summary>
        [JsonProperty("connection")]
        public SignupConnection Connection { get; set; }

        /// <summary>
        /// 当注册方式为 PASSWORD 时此参数必填
        /// </summary>
        [JsonProperty("passwordPayload")]
        public SignupPasswordPayload PasswordPayload { get; set; }

        /// <summary>
        /// 当认证方式为 PASSCODE 时此参数必填
        /// </summary>
        [JsonProperty("passCodePayload")]
        public SignupPassCodePayload PassCodePayload { get; set; }

        /// <summary>
        /// 用户资料
        /// </summary>
        [JsonProperty("profile")]
        public SignupProfile Profile { get; set; }

        /// <summary>
        /// 可选参数
        /// </summary>
        [JsonProperty("options")]
        public SignupOptions Options { get; set; }
    }

    public class SignupPasswordPayload
    {
        public SignupPasswordPayload()
        {
            Password = "";
            Email = "";
        }

        /// <summary>
        /// 用户密码，默认不加密。Authing 所有 API 均通过 HTTPS 协议对密码进行安全传输，可以在一定程度上保证安全性。 如果你还需要更高级别的安全性，我们还支持 RSA256 和国密 SM2 的密码加密方式。详情见可选参数 options.passwordEncryptType
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 邮箱，不区分大小写。
        /// </summary>
        public string Email { get; set; }
    }

    public class SignupPassCodePayload
    {
        public SignupPassCodePayload()
        {
            PassCode = "";
            Email = "";
            Phone = "";
            PhoneCountryCode = "";
        }

        /// <summary>
        /// 一次性临时验证码，你需要先调用发送短信或者发送邮件接口获取验证码。
        /// </summary>
        public string PassCode { get; set; }
        /// <summary>
        /// 邮箱，不区分大小写
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 手机号
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// 手机区号，中国大陆手机号可不填。Authing 短信服务暂不内置支持国际手机号，你需要在 Authing 控制台配置对应的国际短信服务。完整的手机区号列表可参阅 https://en.wikipedia.org/wiki/List_of_country_calling_codes。
        /// </summary>
        public string PhoneCountryCode { get; set; }
    }

    public class SignupProfile
    {
        /// <summary>
        /// 昵称
        /// </summary>
        public string Nickname { get; set; }
        /// <summary>
        /// 公司
        /// </summary>
        public string Company { get; set; }
        /// <summary>
        /// 头像
        /// </summary>
        public string Photo { get; set; }
        /// <summary>
        /// 设备
        /// </summary>
        public string Device { get; set; }
        /// <summary>
        /// 浏览器
        /// </summary>
        public string Browser { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 名
        /// </summary>
        public string GivenName { get; set; }
        /// <summary>
        /// 姓
        /// </summary>
        public string FamilyName { get; set; }
        /// <summary>
        /// 中间名
        /// </summary>
        public string MiddleName { get; set; }
        /// <summary>
        /// 资料
        /// </summary>
        public string Profile { get; set; }
        /// <summary>
        /// 希望称呼的用户名
        /// </summary>
        public string PreferredUsername { get; set; }
        /// <summary>
        /// 网站
        /// </summary>
        public string Website { get; set; }
        /// <summary>
        /// 性别 
        /// </summary>
        public Gender Gender { get; set; }
        /// <summary>
        /// 生日
        /// </summary>
        public string Birthdate { get; set; }
        /// <summary>
        /// 地区
        /// </summary>
        public string Zoneinfo { get; set; }
        /// <summary>
        /// 语言地区
        /// </summary>
        public string Locale { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// 格式
        /// </summary>
        public string Formatted { get; set; }
        /// <summary>
        /// 街道地址
        /// </summary>
        public string StreetAddress { get; set; }
        /// <summary>
        /// 位置
        /// </summary>
        public string Locality { get; set; }
        /// <summary>
        /// 地区
        /// </summary>
        public string Region { get; set; }
        /// <summary>
        /// 邮政编码
        /// </summary>
        public string PostalCode { get; set; }
        /// <summary>
        /// 国家
        /// </summary>
        public string Country { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 手机号
        /// </summary>
        public string Phone { get; set; }
        public object CustomData { get; set; }
    }

    public class SignupOptions
    {
        /// <summary>
        /// 客户端 IP
        /// </summary>
        public string ClientIp { get; set; }
        /// <summary>
        /// 登录/注册时传的额外参数，会存到用户自定义字段里面
        /// </summary>
        public object Context { get; set; }

        /// <summary>
        /// 密码加密类型，支持 sm2 和 rsa。默认可以不加密。
        /// </summary>
        [JsonProperty("passwordEncryptType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public PasswordEncryptType PasswordEncryptType { get; set; }
    }

    public enum SignupConnection
    {
        /// <summary>
        /// 邮箱密码方式
        /// </summary>
        PASSWORD,
        /// <summary>
        /// 邮箱/手机号验证码方式
        /// </summary>
        PASSCODE
    }
}
