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
/// SyncTaskItalentClientConfig 的模型
/// </summary>
public partial class SyncTaskItalentClientConfig
{
    /// <summary>
    ///  Tenant Id
    /// </summary>
    [JsonProperty("tenant_id")]
    public string  Tenant_id {get;set;}
    /// <summary>
    ///  App Key
    /// </summary>
    [JsonProperty("app_key")]
    public string  App_key {get;set;}
    /// <summary>
    ///  App Secret
    /// </summary>
    [JsonProperty("app_secret")]
    public string  App_secret {get;set;}
}
}