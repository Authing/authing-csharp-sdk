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
    /// SignInByWechatMiniProgramCodeAndPhonePayloadDto 的模型
    /// </summary>
    public partial class SignInByWechatMiniProgramCodeAndPhonePayloadDto
    {
        /// <summary>
        ///  微信小程序使用 code 登录相关数据，必填
        /// </summary>
        [JsonProperty("wxLoginInfo")]
        public SignInByWechatMiniProgramCodePayloadDto  WxLoginInfo  {get;set;}
        /// <summary>
        ///  必填，微信小程序用户授权使用手机号登录相关数据。如果是新用户注册到用户池，手机号将会同步更新到用户信息；如果用户池用户已存在，若用户没有绑定过手机号且从小程序授权的手机号未被绑定过，将会把手机号更新到用户信息上。
        /// </summary>
        [JsonProperty("wxPhoneInfo")]
        public SignInByWechatMiniProgramPhoneInfoPayloadDto  WxPhoneInfo  {get;set;}
    }
}