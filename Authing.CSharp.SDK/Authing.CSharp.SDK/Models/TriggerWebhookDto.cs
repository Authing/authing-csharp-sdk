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
/// TriggerWebhookDto 的模型
/// </summary>
public partial class TriggerWebhookDto
{
    /// <summary>
    ///  Webhook ID
    /// </summary>
    [JsonProperty("webhookId")]
    public string  WebhookId {get;set;}
    /// <summary>
    ///  请求头
    /// </summary>
    [JsonProperty("requestHeaders")]
    public object  RequestHeaders {get;set;}
    /// <summary>
    ///  请求体
    /// </summary>
    [JsonProperty("requestBody")]
    public object  RequestBody {get;set;}
}
}