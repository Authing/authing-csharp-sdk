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
    /// LoginAnomalyDetectionConfigDto 的模型
    /// </summary>
    public partial class LoginAnomalyDetectionConfigDto
    {
        /// <summary>
        ///  登录安全策略。当用户触发登录失败频率检测时，采用什么策略。目前支持验证码和锁定账号两种策略。当选择账号锁定策略的时候，只可以开启「登录密码错误限制」。此字段标志为过时，但是此字段还是必传的，如果使用新版本逻辑可以默认写一个。新版本账号锁定使用 accountLock，验证码使用 robotVerify
        /// </summary>
        [JsonProperty("loginFailStrategy")]
        public loginFailStrategy  LoginFailStrategy {get;set;}
        /// <summary>
        ///  人机验证（验证码）策略。可选值，disable（不开启）/condition_set（条件开启）/always_enable （始终开启）
        /// </summary>
        [JsonProperty("robotVerify")]
        public string  RobotVerify {get;set;}
        /// <summary>
        ///  账号锁定策略。可选值，disable（不开启）/condition_set（条件开启）
        /// </summary>
        [JsonProperty("accountLock")]
        public string  AccountLock {get;set;}
        /// <summary>
        ///  登录失败次数限制：当用户登录输入信息错误的时候会被按照「登录安全策略」规则触发相对应的策略。
        /// </summary>
        [JsonProperty("loginFailCheck")]
        public LoginFailCheckConfigDto  LoginFailCheck {get;set;}
        /// <summary>
        ///  登录密码错误限制：当用户登录输入密码信息错误的时候会被按照「登录安全策略」规则触发相对应的策略。此字段被标志为过时，见 accountLockLoginPasswordFailCheck/ robotVerifyLoginPasswordFailCheck
        /// </summary>
        [JsonProperty("loginPasswordFailCheck")]
        public LoginPassowrdFailCheckConfigDto  LoginPasswordFailCheck {get;set;}
        /// <summary>
        ///  账号锁定-登录密码错误限制：当用户登录输入密码信息错误的时候会被按照「登录安全策略」规则触发相对应的策略。
        /// </summary>
        [JsonProperty("accountLockLoginPasswordFailCheck")]
        public LoginPassowrdFailCheckConfigDto  AccountLockLoginPasswordFailCheck {get;set;}
        /// <summary>
        ///  人机验证（验证码）-登录密码错误限制：当用户登录输入密码信息错误的时候会被按照「登录安全策略」规则触发相对应的策略。
        /// </summary>
        [JsonProperty("robotVerifyLoginPasswordFailCheck")]
        public LoginPassowrdFailCheckConfigDto  RobotVerifyLoginPasswordFailCheck {get;set;}
        /// <summary>
        ///  人机验证（验证码）- ip 白名单：当登录者 ip 不在白名单会触发人机验证。
        /// </summary>
        [JsonProperty("robotVerifyLoginIpWhitelistCheck")]
        public LoginIpWhitelistCheckConfigDto  RobotVerifyLoginIpWhitelistCheck {get;set;}
        /// <summary>
        ///  是否开启登录时间限制
        /// </summary>
        [JsonProperty("robotVerifyLoginTimeCheckEnable")]
        public bool  RobotVerifyLoginTimeCheckEnable {get;set;}
        /// <summary>
        ///  登录时间限制周几+起始时间数组
        /// </summary>
        [JsonProperty("robotVerifyloginWeekStartEndTime")]
        public List<string>  RobotVerifyloginWeekStartEndTime {get;set;}
    }
    public partial class LoginAnomalyDetectionConfigDto
    {
        /// <summary>
        ///  登录安全策略。当用户触发登录失败频率检测时，采用什么策略。目前支持验证码和锁定账号两种策略。当选择账号锁定策略的时候，只可以开启「登录密码错误限制」。此字段标志为过时，但是此字段还是必传的，如果使用新版本逻辑可以默认写一个。新版本账号锁定使用 accountLock，验证码使用 robotVerify
        /// </summary>
        public enum loginFailStrategy
        {
            [EnumMember(Value="captcha")]
            CAPTCHA,
            [EnumMember(Value="block-account")]
            BLOCK_ACCOUNT,
        }
    }
}