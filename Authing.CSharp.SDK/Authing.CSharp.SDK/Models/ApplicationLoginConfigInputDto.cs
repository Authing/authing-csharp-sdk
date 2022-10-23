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
/// ApplicationLoginConfigInputDto 的模型
/// </summary>
public partial class ApplicationLoginConfigInputDto
{
    /// <summary>
    ///  是否开启登录注册合并
    /// </summary>
    [JsonProperty("mergeLoginAndRegisterPage")]
    public bool  MergeLoginAndRegisterPage {get;set;}
    /// <summary>
    ///  开启的基础登录方式
    /// </summary>
    [JsonProperty("enabledBasicLoginMethods")]
    public List<string>  EnabledBasicLoginMethods {get;set;}
    /// <summary>
    ///  应用默认登录方式（不包含社会化登录和企业身份源登录）
    /// </summary>
    [JsonProperty("defaultLoginMethod")]
    public ApplicationDefaultLoginMethodInput  DefaultLoginMethod {get;set;}
    /// <summary>
    ///  开启的外部身份源连接
    /// </summary>
    [JsonProperty("enabledExtIdpConnIds")]
    public List<ApplicationEnabledExtIdpConnInputDto>  EnabledExtIdpConnIds {get;set;}
    /// <summary>
    ///  开启所有的外部身份源连接
    /// </summary>
    [JsonProperty("enabledAllExtIdpConns")]
    public bool  EnabledAllExtIdpConns {get;set;}
    /// <summary>
    ///  是否展示用户授权页面
    /// </summary>
    [JsonProperty("showAuthorizationPage")]
    public bool  ShowAuthorizationPage {get;set;}
}
}