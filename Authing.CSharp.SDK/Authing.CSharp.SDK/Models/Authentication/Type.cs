using System.Runtime.Serialization;

namespace Authing.CSharp.SDK.Models.Authentication
{
    public enum Type
    {
        [EnumMember(Value = "oidc")]
        OIDC,
        [EnumMember(Value = "oauth")]
        OAUTH,
        [EnumMember(Value = "saml")]
        SAML,
        [EnumMember(Value = "ldap")]
        LDAP,
        [EnumMember(Value = "ad")]
        AD,
        [EnumMember(Value = "cas")]
        CAS,
        [EnumMember(Value = "azure-ad")]
        AZURE_AD,
        [EnumMember(Value = "alipay")]
        ALIPAY,
        [EnumMember(Value = "facebook")]
        FACEBOOK,
        [EnumMember(Value = "twitter")]
        TWITTER,
        [EnumMember(Value = "google")]
        GOOGLE,
        [EnumMember(Value = "wechat:pc")]
        WECHAT_PC,
        [EnumMember(Value = "wechat:mobile")]
        WECHAT_MOBILE,
        [EnumMember(Value = "wechat:webpage-authorization")]
        WECHAT_WEBPAGE_AUTHORIZATION,
        [EnumMember(Value = "wechatmp-qrcode")]
        WECHATMP_QRCODE,
        [EnumMember(Value = "wechat:miniprogram:default")]
        WECHAT_MINIPROGRAM_DEFAULT,
        [EnumMember(Value = "wechat:miniprogram:qrconnect")]
        WECHAT_MINIPROGRAM_QRCONNECT,
        [EnumMember(Value = "wechat:miniprogram:app-launch")]
        WECHAT_MINIPROGRAM_APP_LAUNCH,
        [EnumMember(Value = "github")]
        GITHUB,
        [EnumMember(Value = "qq")]
        QQ,
        [EnumMember(Value = "wechatwork:corp:qrconnect")]
        WECHATWORK_CORP_QRCONNECT,
        [EnumMember(Value = "wechatwork:agency:qrconnect")]
        WECHATWORK_AGENCY_QRCONNECT,
        [EnumMember(Value = "wechatwork:service-provider:qrconnect")]
        WECHATWORK_SERVICE_PROVIDER_QRCONNECT,
        [EnumMember(Value = "wechatwork:mobile")]
        WECHATWORK_MOBILE,
        [EnumMember(Value = "wechatwork:agency:mobile")]
        WECHATWORK_AGENCY_MOBILE,
        [EnumMember(Value = "dingtalk")]
        DINGTALK,
        [EnumMember(Value = "dingtalk:provider")]
        DINGTALK_PROVIDER,
        [EnumMember(Value = "weibo")]
        WEIBO,
        [EnumMember(Value = "apple")]
        APPLE,
        [EnumMember(Value = "apple:web")]
        APPLE_WEB,
        [EnumMember(Value = "baidu")]
        BAIDU,
        [EnumMember(Value = "lark-internal")]
        LARK_INTERNAL,
        [EnumMember(Value = "lark-public")]
        LARK_PUBLIC,
        [EnumMember(Value = "gitlab")]
        GITLAB,
        [EnumMember(Value = "linkedin")]
        LINKEDIN,
        [EnumMember(Value = "slack")]
        SLACK,
        [EnumMember(Value = "yidun")]
        YIDUN,
        [EnumMember(Value = "qingcloud")]
        QINGCLOUD,
        [EnumMember(Value = "gitee")]
        GITEE,
        [EnumMember(Value = "instagram")]
        INSTAGRAM,
        [EnumMember(Value = "welink")]
        WELINK,
    }
}