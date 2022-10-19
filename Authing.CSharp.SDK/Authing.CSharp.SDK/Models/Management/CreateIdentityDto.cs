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
/// CreateIdentityDto 的模型
/// </summary>
public partial class CreateIdentityDto
{
    /// <summary>
    ///  身份源连接 ID
    /// </summary>
    [JsonProperty("extIdpId")]
    public string  ExtIdpId {get;set;}
    /// <summary>
    ///  外部身份源类型：
/// - `wechat`: 微信
/// - `qq`: QQ
/// - `wechatwork`: 企业微信
/// - `dingtalk`: 钉钉
/// - `weibo`: 微博
/// - `github`: GitHub
/// - `alipay`: 支付宝
/// - `baidu`: 百度
/// - `lark`: 飞书
/// - `welink`: Welink
/// - `yidun`: 网易易盾
/// - `qingcloud`: 青云
/// - `google`: Google
/// - `gitlab`: GitLab
/// - `gitee`: Gitee
/// - `twitter`: Twitter
/// - `facebook`: Facebook
/// - `slack`: Slack
/// - `linkedin`: Linkedin
/// - `instagram`: Instagram
/// - `oidc`: OIDC 型企业身份源
/// - `oauth2`: OAuth2 型企业身份源
/// - `saml`: SAML 型企业身份源
/// - `ldap`: LDAP 型企业身份源
/// - `ad`: AD 型企业身份源
/// - `cas`: CAS 型企业身份源
/// - `azure-ad`: Azure AD 型企业身份源
/// 
    /// </summary>
    [JsonProperty("provider")]
    public provider  Provider {get;set;}
    /// <summary>
    ///  Identity 类型，如 unionid, openid, primary
    /// </summary>
    [JsonProperty("type")]
    public string  Type {get;set;}
    /// <summary>
    ///  在外部身份源中的 ID
    /// </summary>
    [JsonProperty("userIdInIdp")]
    public string  UserIdInIdp {get;set;}
    /// <summary>
    ///  身份来自的身份源连接 ID 列表
    /// </summary>
    [JsonProperty("originConnIds")]
    public List<string>  OriginConnIds {get;set;}
}
public partial class CreateIdentityDto
 {
    /// <summary>
    ///  外部身份源类型：
/// - `wechat`: 微信
/// - `qq`: QQ
/// - `wechatwork`: 企业微信
/// - `dingtalk`: 钉钉
/// - `weibo`: 微博
/// - `github`: GitHub
/// - `alipay`: 支付宝
/// - `baidu`: 百度
/// - `lark`: 飞书
/// - `welink`: Welink
/// - `yidun`: 网易易盾
/// - `qingcloud`: 青云
/// - `google`: Google
/// - `gitlab`: GitLab
/// - `gitee`: Gitee
/// - `twitter`: Twitter
/// - `facebook`: Facebook
/// - `slack`: Slack
/// - `linkedin`: Linkedin
/// - `instagram`: Instagram
/// - `oidc`: OIDC 型企业身份源
/// - `oauth2`: OAuth2 型企业身份源
/// - `saml`: SAML 型企业身份源
/// - `ldap`: LDAP 型企业身份源
/// - `ad`: AD 型企业身份源
/// - `cas`: CAS 型企业身份源
/// - `azure-ad`: Azure AD 型企业身份源
/// 
    /// </summary>
    public enum provider
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
    }
}
}