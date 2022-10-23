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
/// ApplicationSimpleInfoDto 的模型
/// </summary>
public partial class ApplicationSimpleInfoDto
{
    /// <summary>
    ///  应用 ID
    /// </summary>
    [JsonProperty("appId")]
    public string  AppId {get;set;}
    /// <summary>
    ///  应用唯一标志
    /// </summary>
    [JsonProperty("appIdentifier")]
    public string  AppIdentifier {get;set;}
    /// <summary>
    ///  应用名称
    /// </summary>
    [JsonProperty("appName")]
    public string  AppName {get;set;}
    /// <summary>
    ///  应用 Logo 链接
    /// </summary>
    [JsonProperty("appLogo")]
    public string  AppLogo {get;set;}
    /// <summary>
    ///  应用描述信息
    /// </summary>
    [JsonProperty("appDescription")]
    public string  AppDescription {get;set;}
    /// <summary>
    ///  应用类型
    /// </summary>
    [JsonProperty("appType")]
    public appType  AppType {get;set;}
    /// <summary>
    ///  是否为集成应用
    /// </summary>
    [JsonProperty("isIntegrateApp")]
    public bool  IsIntegrateApp {get;set;}
}
public partial class ApplicationSimpleInfoDto
 {
    /// <summary>
    ///  应用类型
    /// </summary>
    public enum appType
     {
         [EnumMember(Value="web")]
        WEB,
         [EnumMember(Value="spa")]
        SPA,
         [EnumMember(Value="native")]
        NATIVE,
         [EnumMember(Value="api")]
        API,
    }
}
}