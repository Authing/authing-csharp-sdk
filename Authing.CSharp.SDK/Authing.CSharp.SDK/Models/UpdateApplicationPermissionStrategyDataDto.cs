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
/// UpdateApplicationPermissionStrategyDataDto 的模型
/// </summary>
public partial class UpdateApplicationPermissionStrategyDataDto
{
    /// <summary>
    ///  应用访问授权策略
    /// </summary>
    [JsonProperty("permissionStrategy")]
    public permissionStrategy  PermissionStrategy {get;set;}
    /// <summary>
    ///  应用 ID
    /// </summary>
    [JsonProperty("appId")]
    public string  AppId {get;set;}
}
public partial class UpdateApplicationPermissionStrategyDataDto
 {
    /// <summary>
    ///  应用访问授权策略
    /// </summary>
    public enum permissionStrategy
     {
         [EnumMember(Value="ALLOW_ALL")]
        ALLOW_ALL,
         [EnumMember(Value="DENY_ALL")]
        DENY_ALL,
    }
}
}