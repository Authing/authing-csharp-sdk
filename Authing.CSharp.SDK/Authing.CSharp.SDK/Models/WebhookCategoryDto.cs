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
/// WebhookCategoryDto 的模型
/// </summary>
public partial class WebhookCategoryDto
{
    /// <summary>
    ///  Webhook 类型名称
    /// </summary>
    [JsonProperty("name")]
    public string  Name {get;set;}
    /// <summary>
    ///  Webhook 类型英文名称
    /// </summary>
    [JsonProperty("nameEn")]
    public string  NameEn {get;set;}
    /// <summary>
    ///  Webhook 类型
    /// </summary>
    [JsonProperty("value")]
    public string  Value {get;set;}
}
}