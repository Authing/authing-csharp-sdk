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
    /// SignupOptionsDto 的模型
    /// </summary>
    public partial class SignupOptionsDto
    {
        /// <summary>
        ///  客户端 IP
        /// </summary>
        [JsonProperty("clientIp")]
        public    string   ClientIp    {get;set;}
        /// <summary>
        ///  用于注册时补全用户信息的短信验证码
        /// </summary>
        [JsonProperty("phonePassCodeForInformationCompletion")]
        public    string   PhonePassCodeForInformationCompletion    {get;set;}
        /// <summary>
        ///  用于注册时补全用户信息的短信验证码
        /// </summary>
        [JsonProperty("emailPassCodeForInformationCompletion")]
        public    string   EmailPassCodeForInformationCompletion    {get;set;}
        /// <summary>
        ///  登录/注册时传的额外参数，会存到用户自定义字段里面
        /// </summary>
        [JsonProperty("context")]
        public    object   Context    {get;set;}
        /// <summary>
        ///  密码加密类型，支持 sm2 和 rsa。默认可以不加密。
        /// </summary>
        [JsonProperty("passwordEncryptType")]
        public    passwordEncryptType   PasswordEncryptType    {get;set;}
    }
    public partial class SignupOptionsDto
    {
        /// <summary>
        ///  密码加密类型，支持 sm2 和 rsa。默认可以不加密。
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