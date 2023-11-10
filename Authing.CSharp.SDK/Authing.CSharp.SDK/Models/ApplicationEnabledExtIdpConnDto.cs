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
    /// ApplicationEnabledExtIdpConnDto 的模型
    /// </summary>
    public partial class ApplicationEnabledExtIdpConnDto
    {
        /// <summary>
        ///  是否为社会化登录身份源连接
        /// </summary>
        [JsonProperty("isSocial")]
        public bool  IsSocial {get;set;}
        /// <summary>
        ///  身份源 ID
        /// </summary>
        [JsonProperty("extIdpId")]
        public string  ExtIdpId {get;set;}
        /// <summary>
        ///  身份源类型
        /// </summary>
        [JsonProperty("extIdpType")]
        public extIdpType  ExtIdpType {get;set;}
        /// <summary>
        ///  身份源连接 ID
        /// </summary>
        [JsonProperty("extIdpConnId")]
        public string  ExtIdpConnId {get;set;}
        /// <summary>
        ///  身份源连接类型
        /// </summary>
        [JsonProperty("extIdpConnType")]
        public extIdpConnType  ExtIdpConnType {get;set;}
        /// <summary>
        ///  身份源连接可读唯一标志
        /// </summary>
        [JsonProperty("extIdpConnIdentifier")]
        public string  ExtIdpConnIdentifier {get;set;}
        /// <summary>
        ///  微信
        /// </summary>
        [JsonProperty("extIdpConnDisplayName")]
        public string  ExtIdpConnDisplayName {get;set;}
        /// <summary>
        ///  身份源连接 Logo
        /// </summary>
        [JsonProperty("extIdpConnLogo")]
        public string  ExtIdpConnLogo {get;set;}
        /// <summary>
        ///  是否允许身份源连接
        /// </summary>
        [JsonProperty("enabled")]
        public bool  Enabled {get;set;}
    }
    public partial class ApplicationEnabledExtIdpConnDto
    {
        /// <summary>
        ///  身份源类型
        /// </summary>
        public enum extIdpType
        {
            [EnumMember(Value="oidc")]
            OIDC,
            [EnumMember(Value="oauth2")]
            OAUTH2,
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
            [EnumMember(Value="wechat")]
            WECHAT,
            [EnumMember(Value="google")]
            GOOGLE,
            [EnumMember(Value="qq")]
            QQ,
            [EnumMember(Value="wechatwork")]
            WECHATWORK,
            [EnumMember(Value="dingtalk")]
            DINGTALK,
            [EnumMember(Value="weibo")]
            WEIBO,
            [EnumMember(Value="github")]
            GITHUB,
            [EnumMember(Value="alipay")]
            ALIPAY,
            [EnumMember(Value="apple")]
            APPLE,
            [EnumMember(Value="baidu")]
            BAIDU,
            [EnumMember(Value="lark")]
            LARK,
            [EnumMember(Value="gitlab")]
            GITLAB,
            [EnumMember(Value="twitter")]
            TWITTER,
            [EnumMember(Value="facebook")]
            FACEBOOK,
            [EnumMember(Value="slack")]
            SLACK,
            [EnumMember(Value="linkedin")]
            LINKEDIN,
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
            [EnumMember(Value="huawei")]
            HUAWEI,
            [EnumMember(Value="honor")]
            HONOR,
            [EnumMember(Value="xiaomi")]
            XIAOMI,
            [EnumMember(Value="oppo")]
            OPPO,
            [EnumMember(Value="aws")]
            AWS,
            [EnumMember(Value="amazon")]
            AMAZON,
            [EnumMember(Value="douyin")]
            DOUYIN,
            [EnumMember(Value="kuaishou")]
            KUAISHOU,
            [EnumMember(Value="line")]
            LINE,
            [EnumMember(Value="sdbz")]
            SDBZ,
        }
        /// <summary>
        ///  身份源连接类型
        /// </summary>
        public enum extIdpConnType
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
            [EnumMember(Value="github:mobile")]
            GITHUB_MOBILE,
            [EnumMember(Value="qq")]
            QQ,
            [EnumMember(Value="qq:mobile")]
            QQ_MOBILE,
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
            [EnumMember(Value="dingtalk:mobile")]
            DINGTALK_MOBILE,
            [EnumMember(Value="dingtalk:provider")]
            DINGTALK_PROVIDER,
            [EnumMember(Value="weibo")]
            WEIBO,
            [EnumMember(Value="weibo:mobile")]
            WEIBO_MOBILE,
            [EnumMember(Value="apple")]
            APPLE,
            [EnumMember(Value="apple:web")]
            APPLE_WEB,
            [EnumMember(Value="baidu")]
            BAIDU,
            [EnumMember(Value="baidu:mobile")]
            BAIDU_MOBILE,
            [EnumMember(Value="lark-internal")]
            LARK_INTERNAL,
            [EnumMember(Value="lark-public")]
            LARK_PUBLIC,
            [EnumMember(Value="lark-block")]
            LARK_BLOCK,
            [EnumMember(Value="gitlab")]
            GITLAB,
            [EnumMember(Value="gitlab:mobile")]
            GITLAB_MOBILE,
            [EnumMember(Value="linkedin")]
            LINKEDIN,
            [EnumMember(Value="linkedin:mobile")]
            LINKEDIN_MOBILE,
            [EnumMember(Value="slack")]
            SLACK,
            [EnumMember(Value="slack:mobile")]
            SLACK_MOBILE,
            [EnumMember(Value="yidun")]
            YIDUN,
            [EnumMember(Value="qingcloud")]
            QINGCLOUD,
            [EnumMember(Value="gitee")]
            GITEE,
            [EnumMember(Value="gitee:mobile")]
            GITEE_MOBILE,
            [EnumMember(Value="instagram")]
            INSTAGRAM,
            [EnumMember(Value="welink")]
            WELINK,
            [EnumMember(Value="ad-kerberos")]
            AD_KERBEROS,
            [EnumMember(Value="huawei")]
            HUAWEI,
            [EnumMember(Value="huawei:mobile")]
            HUAWEI_MOBILE,
            [EnumMember(Value="honor")]
            HONOR,
            [EnumMember(Value="xiaomi")]
            XIAOMI,
            [EnumMember(Value="xiaomi:mobile")]
            XIAOMI_MOBILE,
            [EnumMember(Value="aws")]
            AWS,
            [EnumMember(Value="amazon")]
            AMAZON,
            [EnumMember(Value="amazon:mobile")]
            AMAZON_MOBILE,
            [EnumMember(Value="douyin:mobile")]
            DOUYIN_MOBILE,
            [EnumMember(Value="kuaishou:mobile")]
            KUAISHOU_MOBILE,
            [EnumMember(Value="line:mobile")]
            LINE_MOBILE,
            [EnumMember(Value="oppo:mobile")]
            OPPO_MOBILE,
            [EnumMember(Value="wechatwork:qrconnect:of:authing:agency")]
            WECHATWORK_QRCONNECT_OF_AUTHING_AGENCY,
            [EnumMember(Value="sdbz")]
            SDBZ,
        }
    }
}