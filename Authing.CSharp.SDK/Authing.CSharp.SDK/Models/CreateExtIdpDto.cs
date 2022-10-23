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
/// CreateExtIdpDto 的模型
/// </summary>
public partial class CreateExtIdpDto
{
    /// <summary>
    ///  身份源连接类型
    /// </summary>
    [JsonProperty("type")]
    public type  Type {get;set;}
    /// <summary>
    ///  身份源名称
    /// </summary>
    [JsonProperty("name")]
    public string  Name {get;set;}
    /// <summary>
    ///  租户 ID
    /// </summary>
    [JsonProperty("tenantId")]
    public string  TenantId {get;set;}
}
public partial class CreateExtIdpDto
 {
    /// <summary>
    ///  身份源连接类型
    /// </summary>
    public enum type
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