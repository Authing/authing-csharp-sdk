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
/// LoggedInAppsDto 的模型
/// </summary>
public partial class LoggedInAppsDto
{
    /// <summary>
    ///  应用 ID
    /// </summary>
    [JsonProperty("appId")]
    public string  AppId {get;set;}
    /// <summary>
    ///  应用名称
    /// </summary>
    [JsonProperty("appName")]
    public string  AppName {get;set;}
    /// <summary>
    ///  应用登录地址
    /// </summary>
    [JsonProperty("appLoginUrl")]
    public string  AppLoginUrl {get;set;}
    /// <summary>
    ///  应用 Logo
    /// </summary>
    [JsonProperty("appLogo")]
    public string  AppLogo {get;set;}
    /// <summary>
    ///  当前是否处于登录态
    /// </summary>
    [JsonProperty("active")]
    public bool  Active {get;set;}
}
}