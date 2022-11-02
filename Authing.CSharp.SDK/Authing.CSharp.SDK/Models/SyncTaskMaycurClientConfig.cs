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
/// SyncTaskMaycurClientConfig 的模型
/// </summary>
public partial class SyncTaskMaycurClientConfig
{
    /// <summary>
    ///  App Code
    /// </summary>
    [JsonProperty("app_code")]
    public string  App_code {get;set;}
    /// <summary>
    ///  App Secret
    /// </summary>
    [JsonProperty("app_secret")]
    public string  App_secret {get;set;}
    /// <summary>
    ///  登录域名
    /// </summary>
    [JsonProperty("endpoint")]
    public string  Endpoint {get;set;}
}
}