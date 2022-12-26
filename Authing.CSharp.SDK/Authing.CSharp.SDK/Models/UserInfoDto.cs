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
    /// UserInfoDto 的模型
    /// </summary>
    public partial class UserInfoDto
    {
        /// <summary>
        ///  用户名，用户池内唯一
        /// </summary>
        [JsonProperty("username")]
        public string  Username {get;set;}
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
        ///  用户真实名称，不具备唯一性
        /// </summary>
        [JsonProperty("name")]
        public string  Name {get;set;}
        /// <summary>
        ///  性别
        /// </summary>
        [JsonProperty("gender")]
        public gender  Gender {get;set;}
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
    }
    public partial class UserInfoDto
    {
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