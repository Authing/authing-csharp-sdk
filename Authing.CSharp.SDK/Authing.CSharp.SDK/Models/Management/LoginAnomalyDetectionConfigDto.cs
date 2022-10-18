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
    /// LoginAnomalyDetectionConfigDto 的模型
    /// </summary>
    public partial class LoginAnomalyDetectionConfigDto
    {
        /// <summary>
        ///  登录安全策略。当用户触发登录失败频率检测时，采用什么策略。目前支持验证码和锁定账号两种策略。当选择账号锁定策略的时候，只可以开启「登录密码错误限制」。
        /// </summary>
        [JsonProperty("loginFailStrategy")]
        public loginFailStrategy LoginFailStrategy { get; set; }
        /// <summary>
        ///  登录失败次数限制：当用户登录输入信息错误的时候会被按照「登录安全策略」规则触发相对应的策略。
        /// </summary>
        [JsonProperty("loginFailCheck")]
        public LoginFailCheckConfigDto LoginFailCheck { get; set; }
        /// <summary>
        ///  登录密码错误限制：当用户登录输入密码信息错误的时候会被按照「登录安全策略」规则触发相对应的策略。
        /// </summary>
        [JsonProperty("loginPasswordFailCheck")]
        public LoginPassowrdFailCheckConfigDto LoginPasswordFailCheck { get; set; }
    }
    public partial class LoginAnomalyDetectionConfigDto
    {
        /// <summary>
        ///  登录安全策略。当用户触发登录失败频率检测时，采用什么策略。目前支持验证码和锁定账号两种策略。当选择账号锁定策略的时候，只可以开启「登录密码错误限制」。
        /// </summary>
        public enum loginFailStrategy
        {
            [EnumMember(Value = "captcha")]
            CAPTCHA,
            [EnumMember(Value = "block-account")]
            BLOCK_ACCOUNT,
        }
    }
}