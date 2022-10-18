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
    /// ApplicationRegisterConfigInputDto 的模型
    /// </summary>
    public partial class ApplicationRegisterConfigInputDto
    {
        /// <summary>
        ///  开启的注册方式
        /// </summary>
        [JsonProperty("enabledBasicRegisterMethods")]
        public List<string> EnabledBasicRegisterMethods { get; set; }
        /// <summary>
        ///  默认的注册类型
        /// - `PASSWORD`: 密码类型，支持邮箱 + 密码进行登录
        /// - `PASSCODE`: 验证码类型，取决于你开启的注册方式，支持手机号/邮箱 + 验证码进行登录
        /// 
        /// </summary>
        [JsonProperty("defaultRegisterMethod")]
        public defaultRegisterMethod DefaultRegisterMethod { get; set; }
    }
    public partial class ApplicationRegisterConfigInputDto
    {
        /// <summary>
        ///  默认的注册类型
        /// - `PASSWORD`: 密码类型，支持邮箱 + 密码进行登录
        /// - `PASSCODE`: 验证码类型，取决于你开启的注册方式，支持手机号/邮箱 + 验证码进行登录
        /// 
        /// </summary>
        public enum defaultRegisterMethod
        {
            [EnumMember(Value = "PASSCODE")]
            PASSCODE,
            [EnumMember(Value = "PASSWORD")]
            PASSWORD,
        }
    }
}