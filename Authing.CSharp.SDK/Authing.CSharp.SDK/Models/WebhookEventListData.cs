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
/// WebhookEventListData 的模型
/// </summary>
public partial class WebhookEventListData
{
    /// <summary>
    ///  分类列表
    /// </summary>
    [JsonProperty("categories")]
    public List<WebhookCategoryDto>  Categories {get;set;}
    /// <summary>
    ///  事件列表
    /// </summary>
    [JsonProperty("events")]
    public List<WebhookEventDto>  Events {get;set;}
}
}