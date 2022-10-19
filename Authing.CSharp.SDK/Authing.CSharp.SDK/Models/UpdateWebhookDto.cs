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
/// UpdateWebhookDto 的模型
/// </summary>
public partial class UpdateWebhookDto
{
    /// <summary>
    ///  Webhook ID
    /// </summary>
    [JsonProperty("webhookId")]
    public string  WebhookId {get;set;}
    /// <summary>
    ///  Webhook 名称
    /// </summary>
    [JsonProperty("name")]
    public string  Name {get;set;}
    /// <summary>
    ///  Webhook 回调地址
    /// </summary>
    [JsonProperty("url")]
    public string  Url {get;set;}
    /// <summary>
    ///  用户真实名称，不具备唯一性。 示例值: 张三
    /// </summary>
    [JsonProperty("events")]
    public List<string>  Events {get;set;}
    /// <summary>
    ///  请求数据格式
    /// </summary>
    [JsonProperty("contentType")]
    public contentType  ContentType {get;set;}
    /// <summary>
    ///  是否启用
    /// </summary>
    [JsonProperty("enabled")]
    public bool  Enabled {get;set;}
    /// <summary>
    ///  请求密钥
    /// </summary>
    [JsonProperty("secret")]
    public string  Secret {get;set;}
}
public partial class UpdateWebhookDto
 {
    /// <summary>
    ///  请求数据格式
    /// </summary>
    public enum contentType
     {
         [EnumMember(Value="application/json")]
        APPLICATION_JSON,
         [EnumMember(Value="application/x-www-form-urlencoded")]
        APPLICATION_X_WWW_FORM_URLENCODED,
    }
}
}