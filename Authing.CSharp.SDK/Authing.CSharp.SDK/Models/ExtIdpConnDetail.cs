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
    /// ExtIdpConnDetail 的模型
    /// </summary>
    public partial class ExtIdpConnDetail
    {
        /// <summary>
        ///  身份源连接 id
        /// </summary>
        [JsonProperty("id")]
        public string  Id  {get;set;}
        /// <summary>
        ///  身份源连接类型
        /// </summary>
        [JsonProperty("type")]
        public type  Type  {get;set;}
        /// <summary>
        ///  身份源 ID
        /// </summary>
        [JsonProperty("extIdpId")]
        public string  ExtIdpId  {get;set;}
        /// <summary>
        ///  身份源连接图标
        /// </summary>
        [JsonProperty("logo")]
        public string  Logo  {get;set;}
        /// <summary>
        ///  身份源连接标识
        /// </summary>
        [JsonProperty("identifier")]
        public string  Identifier  {get;set;}
        /// <summary>
        ///  身份源连接在登录页的显示名称
        /// </summary>
        [JsonProperty("displayName")]
        public string  DisplayName  {get;set;}
        /// <summary>
        ///  是否只支持登录
        /// </summary>
        [JsonProperty("loginOnly")]
        public bool  LoginOnly  {get;set;}
        /// <summary>
        ///  账号关联模式
        /// </summary>
        [JsonProperty("associationMode")]
        public associationMode  AssociationMode  {get;set;}
        /// <summary>
        ///  账号绑定方式
        /// </summary>
        [JsonProperty("challengeBindingMethods")]
        public List<string>  ChallengeBindingMethods  {get;set;}
    }
    public partial class ExtIdpConnDetail
    {
        /// <summary>
        ///  身份源连接类型
        /// </summary>
        public enum type
        {
            [EnumMember(Value="oidc")]
            OIDC,
            [EnumMember(Value="oauth")]
            OAUTH,
            [EnumMember(Value="saml")]
            SAML,
            [EnumMember(Value="ldap")]
            LDAP,
            [EnumMember(Value="ad")]
            AD,
            [EnumMember(Value="cas")]
            CAS,
            [EnumMember(Value="azure-ad")]
            AZURE_AD,
            [EnumMember(Value="alipay")]
            ALIPAY,
            [EnumMember(Value="facebook")]
            FACEBOOK,
            [EnumMember(Value="facebook:mobile")]
            FACEBOOK_MOBILE,
            [EnumMember(Value="twitter")]
            TWITTER,
            [EnumMember(Value="google:mobile")]
            GOOGLE_MOBILE,
            [EnumMember(Value="google")]
            GOOGLE,
            [EnumMember(Value="wechat:pc")]
            WECHAT_PC,
            [EnumMember(Value="wechat:mobile")]
            WECHAT_MOBILE,
            [EnumMember(Value="wechat:webpage-authorization")]
            WECHAT_WEBPAGE_AUTHORIZATION,
            [EnumMember(Value="wechatmp-qrcode")]
            WECHATMP_QRCODE,
            [EnumMember(Value="wechat:miniprogram:default")]
            WECHAT_MINIPROGRAM_DEFAULT,
            [EnumMember(Value="wechat:miniprogram:qrconnect")]
            WECHAT_MINIPROGRAM_QRCONNECT,
            [EnumMember(Value="wechat:miniprogram:app-launch")]
            WECHAT_MINIPROGRAM_APP_LAUNCH,
            [EnumMember(Value="github")]
            GITHUB,
            [EnumMember(Value="qq")]
            QQ,
            [EnumMember(Value="wechatwork:corp:qrconnect")]
            WECHATWORK_CORP_QRCONNECT,
            [EnumMember(Value="wechatwork:agency:qrconnect")]
            WECHATWORK_AGENCY_QRCONNECT,
            [EnumMember(Value="wechatwork:service-provider:qrconnect")]
            WECHATWORK_SERVICE_PROVIDER_QRCONNECT,
            [EnumMember(Value="wechatwork:mobile")]
            WECHATWORK_MOBILE,
            [EnumMember(Value="wechatwork:agency:mobile")]
            WECHATWORK_AGENCY_MOBILE,
            [EnumMember(Value="dingtalk")]
            DINGTALK,
            [EnumMember(Value="dingtalk:provider")]
            DINGTALK_PROVIDER,
            [EnumMember(Value="weibo")]
            WEIBO,
            [EnumMember(Value="apple")]
            APPLE,
            [EnumMember(Value="apple:web")]
            APPLE_WEB,
            [EnumMember(Value="baidu")]
            BAIDU,
            [EnumMember(Value="lark-internal")]
            LARK_INTERNAL,
            [EnumMember(Value="lark-public")]
            LARK_PUBLIC,
            [EnumMember(Value="gitlab")]
            GITLAB,
            [EnumMember(Value="linkedin")]
            LINKEDIN,
            [EnumMember(Value="slack")]
            SLACK,
            [EnumMember(Value="yidun")]
            YIDUN,
            [EnumMember(Value="qingcloud")]
            QINGCLOUD,
            [EnumMember(Value="gitee")]
            GITEE,
            [EnumMember(Value="instagram")]
            INSTAGRAM,
            [EnumMember(Value="welink")]
            WELINK,
            [EnumMember(Value="ad-kerberos")]
            AD_KERBEROS,
            [EnumMember(Value="huawei")]
            HUAWEI,
            [EnumMember(Value="honor")]
            HONOR,
            [EnumMember(Value="xiaomi")]
            XIAOMI,
        }
        /// <summary>
        ///  账号关联模式
        /// </summary>
        public enum associationMode
        {
            [EnumMember(Value="none")]
            NONE,
            [EnumMember(Value="field")]
            FIELD,
            [EnumMember(Value="challenge")]
            CHALLENGE,
        }
    }
}