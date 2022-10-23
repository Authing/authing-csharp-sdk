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
/// DeleteWebhookDto 的模型
/// </summary>
public partial class DeleteWebhookDto
{
    /// <summary>
    ///  webhookId 数组
    /// </summary>
    [JsonProperty("webhookIds")]
    public List<string>  WebhookIds {get;set;}
}
}