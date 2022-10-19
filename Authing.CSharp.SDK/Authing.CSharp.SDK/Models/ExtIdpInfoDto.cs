using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Authing.CSharp.SDK.Models;

   namespace Authing.CSharp.SDK.Models
{
/// <summary>
/// ExtIdpInfoDto 的模型
/// </summary>
public partial class ExtIdpInfoDto
{
    /// <summary>
    ///  身份源连接唯一标志
    /// </summary>
    [JsonProperty("identifier")]
    public string  Identifier {get;set;}
    /// <summary>
    ///  身份源 ID
    /// </summary>
    [JsonProperty("extIdpId")]
    public string  ExtIdpId {get;set;}
    /// <summary>
    ///  身份源类型
    /// </summary>
    [JsonProperty("type")]
    public type  Type {get;set;}
    /// <summary>
    ///  认证类型
    /// </summary>
    [JsonProperty("extIdpType")]
    public extIdpType  ExtIdpType {get;set;}
    /// <summary>
    ///  认证地址
    /// </summary>
    [JsonProperty("bindUrl")]
    public string  BindUrl {get;set;}
    /// <summary>
    ///  身份源显示名称
    /// </summary>
    [JsonProperty("name")]
    public string  Name {get;set;}
    /// <summary>
    ///  身份源显示名称（英文）
    /// </summary>
    [JsonProperty("name_en")]
    public string  Name_en {get;set;}
    /// <summary>
    ///  描述
    /// </summary>
    [JsonProperty("desc")]
    public string  Desc {get;set;}
    /// <summary>
    ///  描述英文
    /// </summary>
    [JsonProperty("desc_en")]
    public string  Desc_en {get;set;}
    /// <summary>
    ///  图标
    /// </summary>
    [JsonProperty("logo")]
    public string  Logo {get;set;}
}
public partial class ExtIdpInfoDto
 {
    /// <summary>
    ///  身份源类型
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
    /// <summary>
    ///  认证类型
    /// </summary>
    public enum extIdpType
     {
         [EnumMember(Value="social")]
        SOCIAL,
         [EnumMember(Value="enterprise")]
        ENTERPRISE,
    }
}
}