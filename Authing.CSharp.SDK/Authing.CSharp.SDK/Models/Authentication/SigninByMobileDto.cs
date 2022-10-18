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
    /// SigninByMobileDto 的模型
    /// </summary>
    public partial class SigninByMobileDto
    {
        /// <summary>
        ///  外部身份源连接标志符
        /// </summary>
        [JsonProperty("extIdpConnidentifier")]
        public string ExtIdpConnidentifier { get; set; }
        /// <summary>
        ///  移动端社会化登录类型：
        /// - `wechat`: 微信移动应用
        /// - `alipay`: 支付宝移动应用
        /// - `wechatwork`: 企业微信移动应用
        /// - `wechatwork_agency`: 企业微信移动应用（代开发模式）
        /// - `lark_internal`: 飞书移动端企业自建应用
        /// - `lark_public`: 飞书移动端应用商店应用
        /// - `yidun`: 网易易盾一键登录
        /// - `wechat_mini_program_code`: 微信小程序使用 code 登录
        /// - `wechat_mini_program_phone `: 微信小程序使用手机号登录
        /// - `google`: Google 移动端社会化登录
        ///
        /// </summary>
        [JsonProperty("connection")]
        public connection Connection { get; set; }
        /// <summary>
        ///  微信移动端社会化登录数据，当 `connection` 为 `wechat` 的时候必填
        /// </summary>
        [JsonProperty("wechatPayload")]
        public AuthenticateByWechatDto WechatPayload { get; set; }
        /// <summary>
        ///  支付宝移动端社会化登录数据，当 `connection` 为 `alipay` 的时候必填
        /// </summary>
        [JsonProperty("alipayPayload")]
        public AuthenticateByAlipayDto AlipayPayload { get; set; }
        /// <summary>
        ///  企业微信移动端社会化登录数据，当 `connection` 为 `wechatwork` 的时候必填
        /// </summary>
        [JsonProperty("wechatworkPayload")]
        public AuthenticateByWechatworkDto WechatworkPayload { get; set; }
        /// <summary>
        ///  企业微信（代开发模式）移动端社会化登录数据，当 `connection` 为 `wechatwork_agency` 的时候必填
        /// </summary>
        [JsonProperty("wechatworkAgencyPayload")]
        public AuthenticateByWechatworkAgencyDto WechatworkAgencyPayload { get; set; }
        /// <summary>
        ///  飞书应用商店应用移动端社会化登录数据，当 `connection` 为 `lark_public` 的时候必填
        /// </summary>
        [JsonProperty("larkPublicPayload")]
        public AuthenticateByLarkPublicDto LarkPublicPayload { get; set; }
        /// <summary>
        ///  飞书自建应用移动端社会化登录数据，当 `connection` 为 `lark_internal` 的时候必填
        /// </summary>
        [JsonProperty("larkInternalPayload")]
        public AuthenticateByLarkInternalDto LarkInternalPayload { get; set; }
        /// <summary>
        ///  网易易盾移动端社会化登录数据，当 `connection` 为 `yidun` 的时候必填
        /// </summary>
        [JsonProperty("yidunPayload")]
        public AuthenticateByYidunDto YidunPayload { get; set; }
        /// <summary>
        ///  网易易盾移动端社会化登录数据，当 `connection` 为 `wechat_mini_program_code` 的时候必填
        /// </summary>
        [JsonProperty("wechatMiniProgramCodePayload")]
        public AuthenticateByWechatMiniProgramCodeDto WechatMiniProgramCodePayload { get; set; }
        /// <summary>
        ///  网易易盾移动端社会化登录数据，当 `connection` 为 `wechat_mini_program_phone` 的时候必填
        /// </summary>
        [JsonProperty("wechatMiniProgramPhonePayload")]
        public AuthenticateByWechatMiniProgramPhoneDto WechatMiniProgramPhonePayload { get; set; }
        /// <summary>
        ///  Google 移动端社会化登录数据，当 `connection` 为 `google` 的时候必填
        /// </summary>
        [JsonProperty("googlePayload")]
        public AuthenticateByGoogleDto GooglePayload { get; set; }
        /// <summary>
        ///  可选参数
        /// </summary>
        [JsonProperty("options")]
        public SignInByMobileOptionsDto Options { get; set; }
        /// <summary>
        ///  应用 ID。当应用的「换取 token 身份验证方式」配置为 `client_secret_post` 需要传。
        /// </summary>
        [JsonProperty("client_id")]
        public string Client_id { get; set; }
        /// <summary>
        ///  应用密钥。当应用的「换取 token 身份验证方式」配置为 `client_secret_post` 需要传。
        /// </summary>
        [JsonProperty("client_secret")]
        public string Client_secret { get; set; }
    }
    public partial class SigninByMobileDto
    {
        /// <summary>
        ///  移动端社会化登录类型：
        /// - `wechat`: 微信移动应用
        /// - `alipay`: 支付宝移动应用
        /// - `wechatwork`: 企业微信移动应用
        /// - `wechatwork_agency`: 企业微信移动应用（代开发模式）
        /// - `lark_internal`: 飞书移动端企业自建应用
        /// - `lark_public`: 飞书移动端应用商店应用
        /// - `yidun`: 网易易盾一键登录
        /// - `wechat_mini_program_code`: 微信小程序使用 code 登录
        /// - `wechat_mini_program_phone `: 微信小程序使用手机号登录
        /// - `google`: Google 移动端社会化登录
        ///
        /// </summary>
        public enum connection
        {
            [EnumMember(Value = "wechat")]
            WECHAT,
            [EnumMember(Value = "alipay")]
            ALIPAY,
            [EnumMember(Value = "wechatwork")]
            WECHATWORK,
            [EnumMember(Value = "wechatwork_agency")]
            WECHATWORK_AGENCY,
            [EnumMember(Value = "lark_internal")]
            LARK_INTERNAL,
            [EnumMember(Value = "lark_public")]
            LARK_PUBLIC,
            [EnumMember(Value = "yidun")]
            YIDUN,
            [EnumMember(Value = "wechat_mini_program_code")]
            WECHAT_MINI_PROGRAM_CODE,
            [EnumMember(Value = "wechat_mini_program_phone")]
            WECHAT_MINI_PROGRAM_PHONE,
            [EnumMember(Value = "google")]
            GOOGLE,
        }
    }
}