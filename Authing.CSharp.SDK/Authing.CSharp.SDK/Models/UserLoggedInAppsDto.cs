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
/// UserLoggedInAppsDto 的模型
/// </summary>
public partial class UserLoggedInAppsDto
{
    /// <summary>
    ///  App ID
    /// </summary>
    [JsonProperty("appId")]
    public string  AppId {get;set;}
    /// <summary>
    ///  App 名称
    /// </summary>
    [JsonProperty("appName")]
    public string  AppName {get;set;}
    /// <summary>
    ///  App Logo
    /// </summary>
    [JsonProperty("appLogo")]
    public string  AppLogo {get;set;}
    /// <summary>
    ///  App 登录地址
    /// </summary>
    [JsonProperty("appLoginUrl")]
    public string  AppLoginUrl {get;set;}
}
}