using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Authing.CSharp.SDK.Models
{
    public class MobileSignInDto
    {
        /// <summary>
        /// 移动端社会化登录类型
        /// </summary>
        [JsonProperty("connection")]
        public MobileConnection Connection { get; set; }

        /// <summary>
        /// 外部身份源连接标志符
        /// </summary>
        [JsonProperty("extIdpConnidentifier")]
        public MobileConnection ExtIdpConnidentifier { get; set; }

        /// <summary>
        /// 微信移动端社会化登录数据，当 connection 为 wechat 的时候必填
        /// </summary>
        [JsonProperty("wechatPayload")]
        public PayLoad WechatPayload { get; set; }

        /// <summary>
        /// 支付宝移动端社会化登录数据，当 connection 为 alipay 的时候必填
        /// </summary>
        [JsonProperty("alipayPayload")]
        public PayLoad AlipayPayload { get; set; }

        /// <summary>
        /// 企业微信移动端社会化登录数据，当 connection 为 wechatwork 的时候必填
        /// </summary>
        [JsonProperty("wechatworkPayload")]
        public PayLoad WechatworkPayload { get; set; }

        /// <summary>
        /// 企业微信（代开发模式）移动端社会化登录数据，当 connection 为 wechatwork_agency 的时候必填
        /// </summary>
        [JsonProperty("wechatworkAgencyPayload")]
        public PayLoad WechatworkAgencyPayload { get; set; }

        /// <summary>
        /// 飞书应用商店应用移动端社会化登录数据，当 connection 为 lark_public 的时候必填
        /// </summary>
        [JsonProperty("larkPublicPayload")]
        public PayLoad LarkPublicPayload { get; set; }

        /// <summary>
        /// 飞书自建应用移动端社会化登录数据，当 connection 为 lark_public 的时候必填
        /// </summary>
        [JsonProperty("larkInternalPayload")]
        public PayLoad LarkInternalPayload { get; set; }

        /// <summary>
        /// 网易易盾移动端社会化登录数据，当 connection 为 yidun 的时候必填
        /// </summary>
        [JsonProperty("yidunPayload")]
        public YidunPayload YidunPayload { get; set; }

        /// <summary>
        /// 微信小程序使用 code 登录,当 connection 为 wechat_mini_program_code 的时候必填
        /// </summary>
        [JsonProperty("wechatMiniProgramCodePayload")]
        public WechatMiniPayload WechatMiniProgramCodePayload { get; set; }

        /// <summary>
        /// 微信小程序使用手机号登录,当 connection 为 wechat_mini_program_phone 的时候必填
        /// </summary>
        [JsonProperty("wechatMiniProgramPhonePayload")]
        public WechatMiniPayload WechatMiniProgramPhonePayload { get; set; }
    }

    public enum MobileConnection
    {
        /// <summary>
        /// 微信移动应用
        /// </summary>
        [EnumMember(Value = "wechat")]
        Wechat,
        /// <summary>
        /// 支付宝移动应用
        /// </summary>
        [EnumMember(Value = "alipay")]
        Alipay,
        /// <summary>
        /// 企业微信移动应用
        /// </summary>
        [EnumMember(Value = "wechatwork")]
        Wechatwork,
        /// <summary>
        /// 企业微信移动应用（代开发模式）
        /// </summary>
        [EnumMember(Value = "wechatwork_agency")]
        Wechatwork_agency,
        /// <summary>
        /// 飞书移动端企业自建应用
        /// </summary>
        [EnumMember(Value = "lark_internal")]
        Lark_internal,
        /// <summary>
        /// 飞书移动端应用商店应用
        /// </summary>
        [EnumMember(Value = "lark_public")]
        Lark_public,
        /// <summary>
        /// 网易易盾一键登录
        /// </summary>
        [EnumMember(Value = "yidun")]
        Yidun,
        /// <summary>
        /// 微信小程序使用 code 登录
        /// </summary>
        [EnumMember(Value = "wechat_mini_program_code")]
        Wechat_mini_program_code,
        /// <summary>
        /// 微信小程序使用手机号登录
        /// </summary>
        [EnumMember(Value = "wechat_mini_program_phone")]
        Wechat_mini_program_phone
    }

    /// <summary>
    /// 社会化登录数据
    /// </summary>
    public class PayLoad
    {
        /// <summary>
        /// 移动端社会化登录返回的一次性临时 code
        /// </summary>
        public string Code { get; set; }
    }

    public class YidunPayload
    {
        /// <summary>
        /// 网易易盾 token
        /// </summary>
        public string Token { get; set; }

        /// <summary>
        /// 网易易盾运营商授权码
        /// </summary>
        public string AccessToken { get; set; }
    }

    public class WechatMiniPayload
    {
        /// <summary>
        /// 获取微信开放数据返回的加密数据（encryptedData）
        /// </summary>
        [JsonProperty("encryptedData")]
        public string EncryptedData { get; set; }

        /// <summary>
        /// 对称解密算法初始向量，由微信返回
        /// </summary>
        [JsonProperty("iv")]
        public string Iv { get; set; }

        /// <summary>
        /// wx.login 接口返回的用户 code
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }
    }
}
